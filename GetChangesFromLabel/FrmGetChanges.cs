using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.TeamFoundation.VersionControl.Client;
using Microsoft.TeamFoundation.Client;
using Microsoft.VisualStudio.Services.Client;
using Microsoft.VisualStudio.Services.Common;

namespace GetChangesFromLabel
{
    public partial class FrmGetChanges : Form
    {
        public FrmGetChanges()
        {
            InitializeComponent();

            FillLabelsCombo();
            FillEncodingsCombo();
        }

        void FillLabelsCombo()
        {
            VersionControlServer tfsClient = GetTfsClient();
            var items = tfsClient.QueryLabels(null, null, null, false, "$/GREDOS/MAIN", VersionSpec.Latest);
            List<TFSLabel> labelsList = new List<TFSLabel>();
            foreach (var i in items)
            {
                labelsList.Add(new TFSLabel()
                {
                    Label = i.Name,
                    Owner = i.OwnerDisplayName,
                    Date = i.LastModifiedDate
                });
            }
            labelsList.Sort((a, b) => { return DateTime.Compare(b.Date, a.Date); });
            searchLookUpEditLabels.Properties.DataSource = labelsList;
            searchLookUpEditLabels.EditValue = labelsList[0].Label;
        }
        VersionControlServer tfsClient = null;
        VersionControlServer GetTfsClient()
        {
            string TFS_COLLECTION = "http://tfs.corpme.es:8080/tfs/tradis";
            if (tfsClient == null)
            {
                Microsoft.VisualStudio.Services.Common.WindowsCredential winCred = 
                    new Microsoft.VisualStudio.Services.Common.WindowsCredential(System.Net.CredentialCache.DefaultCredentials);
                VssCredentials vssCred = new VssClientCredentials(winCred);
                vssCred.PromptType = CredentialPromptType.PromptIfNeeded;

                // Now you can connect to TFS passing Uri and VssCredentials instances as parameters
                Uri tfsUri = new Uri(TFS_COLLECTION);
                var tfsTeamProjectCollection = new TfsTeamProjectCollection(tfsUri);
                // Finally, to make sure you are authenticated...
                tfsTeamProjectCollection.EnsureAuthenticated();

                tfsClient = tfsTeamProjectCollection.GetService<VersionControlServer>();

            }
            return tfsClient;
        }

        void FillEncodingsCombo()
        {
            List<string> listado = new List<string>();
            listado.Add("UTF-8");
            listado.Add("ANSI");

            searchLookUpEditEncoding.Properties.DataSource = listado;
            searchLookUpEditEncoding.EditValue = listado[1];
        }

        GridHitInfo downHitInfo = null;

        #region Controls events
        private void btnGetChangesAfterLabel_Click(object sender, EventArgs e)
        {
            List <TFSFile> l = TFSFile.GetLabelChanges(searchLookUpEditLabels.EditValue.ToString());
            gridControlChangesAfterLabel.DataSource = l;
            OrdenarPaquetes();
            gridViewChangesAfterLabel.SelectAll();

            gridViewChangesAfterLabel.Columns[0].Width = 120;
            gridViewChangesAfterLabel.Columns[1].Width = 120;
            gridViewChangesAfterLabel.Columns[1].DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss";
            gridViewChangesAfterLabel.Columns[1].DisplayFormat.FormatType = FormatType.DateTime;
        }

        private void searchLookUpEditLabels_Popup(object sender, EventArgs e)
        {
            searchLookUpEditLabels.Properties.View.Columns["Date"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
        }
        /// <summary>
        /// Obtener el encoding real del fichero con UDE.CSHARP (nuget)
        /// </summary>
        static string GetFileEncoding(string filename)
        {
            using (FileStream fs = File.OpenRead(filename))
            {
                Ude.CharsetDetector cdet = new Ude.CharsetDetector();
                cdet.Feed(fs);
                cdet.DataEnd();
                return cdet.Charset;
            }
        }
        private void btnJoinFiles_Click(object sender, EventArgs e)
        {
            if (searchLookUpEditEncoding.EditValue.ToString() == "UTF-8")
                JoinFiles(Encoding.UTF8);
            else
                JoinFiles(Encoding.Default);
        }
        void WriteTrace(string strTrace)
        {
            string logFile = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "logfile.txt");
            using (StreamWriter s = new StreamWriter(logFile, true))
                s.WriteLine($"{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")} {strTrace}");
        }
        void JoinFiles(Encoding destEncoding)
        {
            string fileName = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "Vistas_y_Paquetes-3.sql");
            int[] selRows = gridViewChangesAfterLabel.GetSelectedRows();
            WriteTrace("Inicio merge ficheros sql");
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(fileName, false))
            {
                for (int i = 0; i < selRows.Length; i++)
                {
                    TFSFile file = gridViewChangesAfterLabel.GetRow(selRows[i]) as TFSFile;
                    if (File.Exists(file.File))
                    {
                        FileInfo fInf = new FileInfo(file.File);
                        if (fInf.LastWriteTime < file.Date)
                        {
                            if (MessageBox.Show($"El fichero {file.File} no está actualizado con la misma versión del TFS, habría que descargarlo del TFS, ¿continuar?",
                                 "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                                return;
                        }
                        WriteTrace($"Mergeando fichero: {file.File}, LastWriteTime: {fInf.LastWriteTime}");
                        var fileEncoding = GetFileEncoding(file.File);
                        Encoding curEncoding = fileEncoding != null ? Encoding.GetEncoding(fileEncoding) : Encoding.GetEncoding(1252);
                        byte[] bytes = File.ReadAllBytes(file.File);
                        if (curEncoding.CodePage != destEncoding.CodePage) // si no es destEncoding convertir a destEncoding
                        {
                            MessageBox.Show($"El fichero {file.File} no está en {destEncoding.HeaderName.ToUpper()}, pruebo a convertirlo!!!");
                            bytes = Encoding.Convert(curEncoding, destEncoding, bytes);
                        }

                        string sqlText = destEncoding.GetString(bytes);

                        writer.Write(sqlText);
                        if (!sqlText.EndsWith("/"))
                        {
                            if (i < selRows.Length - 1)
                            {
                                writer.Write(Environment.NewLine);
                                writer.Write("/");
                                writer.Write(Environment.NewLine);
                            }
                        }
                        else
                            writer.Write(Environment.NewLine);
                    }
                    else
                    {
                        WriteTrace($"EL ARCHIVO NO EXISTE: {file.File}");
                        XtraMessageBox.Show($"EL ARCHIVO NO EXISTE: {file.File}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            WriteTrace("Fin merge ficheros sql");

            System.Diagnostics.Process.Start("notepad.exe", fileName);

        }

        private void gridControl1_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(GridHitInfo)))
            {
                GridHitInfo downHitInfo = e.Data.GetData(typeof(GridHitInfo)) as GridHitInfo;
                if (downHitInfo == null)
                    return;

                GridControl grid = sender as GridControl;
                GridView view = grid.MainView as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(grid.PointToClient(new Point(e.X, e.Y)));
                if (hitInfo.InRow && hitInfo.RowHandle != downHitInfo.RowHandle && hitInfo.RowHandle != GridControl.NewItemRowHandle)
                    e.Effect = DragDropEffects.Move;
                else
                    e.Effect = DragDropEffects.None;
            }
        }

        private void gridControl1_DragDrop(object sender, DragEventArgs e)
        {
            GridControl grid = sender as GridControl;
            GridView view = grid.MainView as GridView;
            GridHitInfo srcHitInfo = e.Data.GetData(typeof(GridHitInfo)) as GridHitInfo;
            GridHitInfo hitInfo = view.CalcHitInfo(grid.PointToClient(new Point(e.X, e.Y)));
            int sourceRow = srcHitInfo.RowHandle;
            int targetRow = hitInfo.RowHandle;
            MoveRow(sourceRow, targetRow, true);
        }

        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            downHitInfo = null;

            GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            if (Control.ModifierKeys != Keys.None)
                return;
            if (e.Button == MouseButtons.Left && hitInfo.InRow && hitInfo.RowHandle != GridControl.NewItemRowHandle)
                downHitInfo = hitInfo;

        }

        private void gridView1_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Button == MouseButtons.Left && downHitInfo != null)
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(downHitInfo.HitPoint.X - dragSize.Width / 2,
                    downHitInfo.HitPoint.Y - dragSize.Height / 2), dragSize);

                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    view.GridControl.DoDragDrop(downHitInfo, DragDropEffects.All);
                    downHitInfo = null;
                }
            }
        }
        #endregion

        #region Private methods

        /// <summary>
        /// Ordenar los paquetes; siempre va el header antes del body
        /// </summary>
        void OrdenarPaquetes()
        {
            List<TFSFile> l = gridViewChangesAfterLabel.DataSource as List<TFSFile>;
            int headerIndex = -1;
            int bodyIndex = -1;
            //int newHeaderIndex = -1;
            int newBodyIndex = -1;
            foreach (TFSFile file in l)
            {
                if (file.IsBody())
                {
                    TFSFile header = l.FirstOrDefault(x => x.File == file.File.Replace(".BODY", ""));
                    if (header != null)
                    {
                        headerIndex = l.IndexOf(header);
                        bodyIndex = l.IndexOf(file);
                        if (headerIndex != bodyIndex - 1)
                        {
                            newBodyIndex = headerIndex;
                            break;
                        }
                    }
                }
            }
            if (newBodyIndex >= 0)
            {
                MoveRow(bodyIndex, newBodyIndex, false);
                OrdenarPaquetes();
            }
        }
        /// <summary>
        /// Mover filas; por drag and drop o al OrdenarPaquetes
        /// </summary>
        private void MoveRow(int sourceRow, int targetRow, bool manual)
        {
            List<TFSFile> l = gridViewChangesAfterLabel.DataSource as List<TFSFile>;
            TFSFile source = l[sourceRow];
            l.Remove(source);
            l.Insert(targetRow, source);
            gridViewChangesAfterLabel.RefreshData();
            if (manual)
                OrdenarPaquetes();
        }
        #endregion
    }
}
