﻿namespace AnimalShelterManagementSystem.WinForm.AdminForms
{
    partial class FindingManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.cbxSpecies = new System.Windows.Forms.ComboBox();
            this.btnFindingReport = new DevExpress.XtraEditors.SimpleButton();
            this.txbPlace = new System.Windows.Forms.TextBox();
            this.dteFoundDateFrom = new DevExpress.XtraEditors.DateEdit();
            this.dteFoundDateTo = new DevExpress.XtraEditors.DateEdit();
            this.grvAdoptionList = new System.Windows.Forms.DataGridView();
            this.speciesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isInShelterDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.findingReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.list = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteFoundDateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFoundDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFoundDateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFoundDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvAdoptionList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findingReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.toolStrip1);
            this.layoutControl1.Controls.Add(this.cbxSpecies);
            this.layoutControl1.Controls.Add(this.btnFindingReport);
            this.layoutControl1.Controls.Add(this.txbPlace);
            this.layoutControl1.Controls.Add(this.dteFoundDateFrom);
            this.layoutControl1.Controls.Add(this.dteFoundDateTo);
            this.layoutControl1.Controls.Add(this.grvAdoptionList);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(869, 123, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1000, 660);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbDelete,
            this.tsbEdit,
            this.tsbRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(14, 115);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(972, 33);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = global::AnimalShelterManagementSystem.WinForm.Properties.Resources.Insert;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(34, 28);
            this.tsbAdd.Text = "추가";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = global::AnimalShelterManagementSystem.WinForm.Properties.Resources.Delete;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(34, 28);
            this.tsbDelete.Text = "삭제";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEdit.Image = global::AnimalShelterManagementSystem.WinForm.Properties.Resources.Edit;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(34, 28);
            this.tsbEdit.Text = "수정";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.Image = global::AnimalShelterManagementSystem.WinForm.Properties.Resources.Update;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(34, 28);
            this.tsbRefresh.Text = "새로고침";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // cbxSpecies
            // 
            this.cbxSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSpecies.FormattingEnabled = true;
            this.cbxSpecies.Location = new System.Drawing.Point(112, 14);
            this.cbxSpecies.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cbxSpecies.Name = "cbxSpecies";
            this.cbxSpecies.Size = new System.Drawing.Size(874, 30);
            this.cbxSpecies.TabIndex = 16;
            this.cbxSpecies.SelectedIndexChanged += new System.EventHandler(this.cbxSpecies_SelectedIndexChanged);
            // 
            // btnFindingReport
            // 
            this.btnFindingReport.Location = new System.Drawing.Point(620, 614);
            this.btnFindingReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFindingReport.Name = "btnFindingReport";
            this.btnFindingReport.Size = new System.Drawing.Size(366, 32);
            this.btnFindingReport.StyleController = this.layoutControl1;
            this.btnFindingReport.TabIndex = 9;
            this.btnFindingReport.Text = "확인";
            this.btnFindingReport.Click += new System.EventHandler(this.btnFindingReport_Click);
            // 
            // txbPlace
            // 
            this.txbPlace.Location = new System.Drawing.Point(112, 81);
            this.txbPlace.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txbPlace.Name = "txbPlace";
            this.txbPlace.Size = new System.Drawing.Size(874, 30);
            this.txbPlace.TabIndex = 6;
            this.txbPlace.TextChanged += new System.EventHandler(this.txbPlace_TextChanged);
            // 
            // dteFoundDateFrom
            // 
            this.dteFoundDateFrom.EditValue = null;
            this.dteFoundDateFrom.Location = new System.Drawing.Point(112, 49);
            this.dteFoundDateFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dteFoundDateFrom.Name = "dteFoundDateFrom";
            this.dteFoundDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFoundDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFoundDateFrom.Size = new System.Drawing.Size(302, 28);
            this.dteFoundDateFrom.StyleController = this.layoutControl1;
            this.dteFoundDateFrom.TabIndex = 9;
            this.dteFoundDateFrom.EditValueChanged += new System.EventHandler(this.dteFoundDateFrom_EditValueChanged);
            // 
            // dteFoundDateTo
            // 
            this.dteFoundDateTo.EditValue = "";
            this.dteFoundDateTo.Location = new System.Drawing.Point(516, 49);
            this.dteFoundDateTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dteFoundDateTo.Name = "dteFoundDateTo";
            this.dteFoundDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFoundDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFoundDateTo.Size = new System.Drawing.Size(470, 28);
            this.dteFoundDateTo.StyleController = this.layoutControl1;
            this.dteFoundDateTo.TabIndex = 10;
            this.dteFoundDateTo.EditValueChanged += new System.EventHandler(this.dteFoundDateTo_EditValueChanged);
            // 
            // grvAdoptionList
            // 
            this.grvAdoptionList.AllowUserToAddRows = false;
            this.grvAdoptionList.AllowUserToDeleteRows = false;
            this.grvAdoptionList.AllowUserToOrderColumns = true;
            this.grvAdoptionList.AutoGenerateColumns = false;
            this.grvAdoptionList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvAdoptionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvAdoptionList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.speciesDataGridViewTextBoxColumn,
            this.placeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.isInShelterDataGridViewCheckBoxColumn});
            this.grvAdoptionList.DataSource = this.findingReportBindingSource;
            this.grvAdoptionList.Location = new System.Drawing.Point(112, 152);
            this.grvAdoptionList.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grvAdoptionList.Name = "grvAdoptionList";
            this.grvAdoptionList.ReadOnly = true;
            this.grvAdoptionList.RowHeadersVisible = false;
            this.grvAdoptionList.RowHeadersWidth = 51;
            this.grvAdoptionList.RowTemplate.Height = 27;
            this.grvAdoptionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvAdoptionList.Size = new System.Drawing.Size(874, 430);
            this.grvAdoptionList.TabIndex = 5;
            // 
            // speciesDataGridViewTextBoxColumn
            // 
            this.speciesDataGridViewTextBoxColumn.DataPropertyName = "SpeciesName";
            this.speciesDataGridViewTextBoxColumn.HeaderText = "종";
            this.speciesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.speciesDataGridViewTextBoxColumn.Name = "speciesDataGridViewTextBoxColumn";
            this.speciesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placeDataGridViewTextBoxColumn
            // 
            this.placeDataGridViewTextBoxColumn.DataPropertyName = "Place";
            this.placeDataGridViewTextBoxColumn.HeaderText = "장소";
            this.placeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
            this.placeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "날짜";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isInShelterDataGridViewCheckBoxColumn
            // 
            this.isInShelterDataGridViewCheckBoxColumn.DataPropertyName = "IsInShelter";
            this.isInShelterDataGridViewCheckBoxColumn.HeaderText = "보호 여부";
            this.isInShelterDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isInShelterDataGridViewCheckBoxColumn.Name = "isInShelterDataGridViewCheckBoxColumn";
            this.isInShelterDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // findingReportBindingSource
            // 
            this.findingReportBindingSource.DataSource = typeof(AnimalShelterManagementSystem.FindingReport);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem9,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem2,
            this.layoutControlItem4,
            this.list,
            this.emptySpaceItem1,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1000, 660);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.cbxSpecies;
            this.layoutControlItem9.CustomizationFormText = " 종 :";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(976, 35);
            this.layoutControlItem9.Text = " 종 :";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(94, 22);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dteFoundDateFrom;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem1.CustomizationFormText = "신고일(부터)";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 35);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(404, 32);
            this.layoutControlItem1.Text = " 찾는 기간 :";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(94, 22);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dteFoundDateTo;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem2.CustomizationFormText = "신고일(까지)";
            this.layoutControlItem2.Location = new System.Drawing.Point(404, 35);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(572, 32);
            this.layoutControlItem2.Text = " ~";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(94, 22);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txbPlace;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 67);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(976, 34);
            this.layoutControlItem3.Text = " 발견 장소 :   ";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(94, 22);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 600);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(606, 36);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnFindingReport;
            this.layoutControlItem4.Location = new System.Drawing.Point(606, 600);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(370, 36);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // list
            // 
            this.list.Control = this.grvAdoptionList;
            this.list.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.list.CustomizationFormText = "리스트";
            this.list.Location = new System.Drawing.Point(0, 138);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(976, 434);
            this.list.Text = "리스트";
            this.list.TextSize = new System.Drawing.Size(94, 22);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 572);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(976, 28);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.toolStrip1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 101);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(976, 37);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // FindingManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 660);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.Image = global::AnimalShelterManagementSystem.WinForm.Properties.Resources.BlackPuppy;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FindingManagementForm";
            this.Text = "발견신고리스트";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteFoundDateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFoundDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFoundDateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFoundDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvAdoptionList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findingReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.ComboBox cbxSpecies;
        private DevExpress.XtraEditors.SimpleButton btnFindingReport;
        private System.Windows.Forms.TextBox txbPlace;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.DateEdit dteFoundDateFrom;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.DateEdit dteFoundDateTo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private System.Windows.Forms.DataGridView grvAdoptionList;
        private DevExpress.XtraLayout.LayoutControlItem list;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.BindingSource findingReportBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isInShelterDataGridViewCheckBoxColumn;
    }
}