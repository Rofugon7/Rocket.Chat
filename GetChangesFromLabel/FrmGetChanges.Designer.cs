namespace GetChangesFromLabel
{
    partial class FrmGetChanges
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGetChanges));
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnGetChangesAfterLabel = new DevExpress.XtraEditors.SimpleButton();
            this.searchLookUpEditLabels = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.tFSLabelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlChangesAfterLabel = new DevExpress.XtraGrid.GridControl();
            this.gridViewChangesAfterLabel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnJoinFiles = new DevExpress.XtraEditors.SimpleButton();
            this.memoEditInstrucciones = new DevExpress.XtraEditors.MemoEdit();
            this.searchLookUpEditEncoding = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditLabels.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFSLabelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlChangesAfterLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChangesAfterLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditInstrucciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditEncoding.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem1)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "barCheckItem1";
            this.barCheckItem1.Id = 1;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barCheckItem1});
            this.barManager1.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1176, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 385);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1176, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 385);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1176, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 385);
            // 
            // btnGetChangesAfterLabel
            // 
            this.btnGetChangesAfterLabel.Location = new System.Drawing.Point(9, 35);
            this.btnGetChangesAfterLabel.Name = "btnGetChangesAfterLabel";
            this.btnGetChangesAfterLabel.Size = new System.Drawing.Size(75, 23);
            this.btnGetChangesAfterLabel.TabIndex = 70;
            this.btnGetChangesAfterLabel.Text = "Get changes";
            this.btnGetChangesAfterLabel.Click += new System.EventHandler(this.btnGetChangesAfterLabel_Click);
            // 
            // searchLookUpEditLabels
            // 
            this.searchLookUpEditLabels.Location = new System.Drawing.Point(74, 9);
            this.searchLookUpEditLabels.MenuManager = this.barManager1;
            this.searchLookUpEditLabels.Name = "searchLookUpEditLabels";
            this.searchLookUpEditLabels.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEditLabels.Properties.DataSource = this.tFSLabelBindingSource;
            this.searchLookUpEditLabels.Properties.DisplayMember = "Label";
            this.searchLookUpEditLabels.Properties.PopupView = this.searchLookUpEdit1View;
            this.searchLookUpEditLabels.Properties.ValueMember = "Label";
            this.searchLookUpEditLabels.Size = new System.Drawing.Size(166, 20);
            this.searchLookUpEditLabels.TabIndex = 75;
            this.searchLookUpEditLabels.Popup += new System.EventHandler(this.searchLookUpEditLabels_Popup);
            // 
            // tFSLabelBindingSource
            // 
            this.tFSLabelBindingSource.DataSource = typeof(GetChangesFromLabel.TFSLabel);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 80;
            this.labelControl1.Text = "List of labels";
            // 
            // gridControlChangesAfterLabel
            // 
            this.gridControlChangesAfterLabel.AllowDrop = true;
            this.gridControlChangesAfterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridControlChangesAfterLabel.Location = new System.Drawing.Point(9, 64);
            this.gridControlChangesAfterLabel.MainView = this.gridViewChangesAfterLabel;
            this.gridControlChangesAfterLabel.MenuManager = this.barManager1;
            this.gridControlChangesAfterLabel.Name = "gridControlChangesAfterLabel";
            this.gridControlChangesAfterLabel.Size = new System.Drawing.Size(1152, 284);
            this.gridControlChangesAfterLabel.TabIndex = 81;
            this.gridControlChangesAfterLabel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewChangesAfterLabel});
            this.gridControlChangesAfterLabel.DragDrop += new System.Windows.Forms.DragEventHandler(this.gridControl1_DragDrop);
            this.gridControlChangesAfterLabel.DragOver += new System.Windows.Forms.DragEventHandler(this.gridControl1_DragOver);
            // 
            // gridViewChangesAfterLabel
            // 
            this.gridViewChangesAfterLabel.GridControl = this.gridControlChangesAfterLabel;
            this.gridViewChangesAfterLabel.Name = "gridViewChangesAfterLabel";
            this.gridViewChangesAfterLabel.OptionsBehavior.Editable = false;
            this.gridViewChangesAfterLabel.OptionsCustomization.AllowSort = false;
            this.gridViewChangesAfterLabel.OptionsSelection.MultiSelect = true;
            this.gridViewChangesAfterLabel.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewChangesAfterLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseDown);
            this.gridViewChangesAfterLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseMove);
            // 
            // btnJoinFiles
            // 
            this.btnJoinFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnJoinFiles.Location = new System.Drawing.Point(9, 354);
            this.btnJoinFiles.Name = "btnJoinFiles";
            this.btnJoinFiles.Size = new System.Drawing.Size(75, 23);
            this.btnJoinFiles.TabIndex = 86;
            this.btnJoinFiles.Text = "Join";
            this.btnJoinFiles.Click += new System.EventHandler(this.btnJoinFiles_Click);
            // 
            // memoEditInstrucciones
            // 
            this.memoEditInstrucciones.EditValue = resources.GetString("memoEditInstrucciones.EditValue");
            this.memoEditInstrucciones.Location = new System.Drawing.Point(341, 12);
            this.memoEditInstrucciones.MenuManager = this.barManager1;
            this.memoEditInstrucciones.Name = "memoEditInstrucciones";
            this.memoEditInstrucciones.Properties.ReadOnly = true;
            this.memoEditInstrucciones.Size = new System.Drawing.Size(820, 46);
            this.memoEditInstrucciones.TabIndex = 91;
            // 
            // searchLookUpEditEncoding
            // 
            this.searchLookUpEditEncoding.Location = new System.Drawing.Point(246, 9);
            this.searchLookUpEditEncoding.MenuManager = this.barManager1;
            this.searchLookUpEditEncoding.Name = "searchLookUpEditEncoding";
            this.searchLookUpEditEncoding.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEditEncoding.Properties.PopupView = this.gridView1;
            this.searchLookUpEditEncoding.Size = new System.Drawing.Size(89, 20);
            this.searchLookUpEditEncoding.TabIndex = 101;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // FrmGetChanges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 385);
            this.Controls.Add(this.searchLookUpEditEncoding);
            this.Controls.Add(this.memoEditInstrucciones);
            this.Controls.Add(this.btnJoinFiles);
            this.Controls.Add(this.gridControlChangesAfterLabel);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.searchLookUpEditLabels);
            this.Controls.Add(this.btnGetChangesAfterLabel);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmGetChanges";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditLabels.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFSLabelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlChangesAfterLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChangesAfterLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditInstrucciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditEncoding.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraEditors.SimpleButton btnGetChangesAfterLabel;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEditLabels;
        private System.Windows.Forms.BindingSource tFSLabelBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControlChangesAfterLabel;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewChangesAfterLabel;
        private DevExpress.XtraEditors.SimpleButton btnJoinFiles;
        private DevExpress.XtraEditors.MemoEdit memoEditInstrucciones;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEditEncoding;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}

