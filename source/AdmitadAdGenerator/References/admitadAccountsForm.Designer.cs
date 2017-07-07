namespace AdmitadAdGenerator.References
{
    partial class admitadAccountsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admitadAccountsForm));
            this.accountsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.accountsDataGridView = new System.Windows.Forms.DataGridView();
            this.accountNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admitadAccountsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.admitadAdsDBDataSet = new AdmitadAdGenerator.AdmitadAdsDBDataSet();
            this.admitadAccountsTableTableAdapter = new AdmitadAdGenerator.AdmitadAdsDBDataSetTableAdapters.AdmitadAccountsTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingNavigator)).BeginInit();
            this.accountsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admitadAccountsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admitadAdsDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // accountsBindingNavigator
            // 
            this.accountsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.accountsBindingNavigator.BindingSource = this.admitadAccountsTableBindingSource;
            this.accountsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.accountsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.accountsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.accountsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.accountsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.accountsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.accountsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.accountsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.accountsBindingNavigator.Name = "accountsBindingNavigator";
            this.accountsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.accountsBindingNavigator.Size = new System.Drawing.Size(394, 25);
            this.accountsBindingNavigator.TabIndex = 1;
            this.accountsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // accountsDataGridView
            // 
            this.accountsDataGridView.AutoGenerateColumns = false;
            this.accountsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountNameDataGridViewTextBoxColumn});
            this.accountsDataGridView.DataSource = this.admitadAccountsTableBindingSource;
            this.accountsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountsDataGridView.Location = new System.Drawing.Point(0, 25);
            this.accountsDataGridView.Name = "accountsDataGridView";
            this.accountsDataGridView.Size = new System.Drawing.Size(394, 236);
            this.accountsDataGridView.TabIndex = 2;
            // 
            // accountNameDataGridViewTextBoxColumn
            // 
            this.accountNameDataGridViewTextBoxColumn.DataPropertyName = "AccountName";
            this.accountNameDataGridViewTextBoxColumn.HeaderText = "Наименование площадки";
            this.accountNameDataGridViewTextBoxColumn.Name = "accountNameDataGridViewTextBoxColumn";
            this.accountNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // admitadAccountsTableBindingSource
            // 
            this.admitadAccountsTableBindingSource.DataMember = "AdmitadAccountsTable";
            this.admitadAccountsTableBindingSource.DataSource = this.admitadAdsDBDataSet;
            // 
            // admitadAdsDBDataSet
            // 
            this.admitadAdsDBDataSet.DataSetName = "AdmitadAdsDBDataSet";
            this.admitadAdsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // admitadAccountsTableTableAdapter
            // 
            this.admitadAccountsTableTableAdapter.ClearBeforeFill = true;
            // 
            // admitadAccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 261);
            this.Controls.Add(this.accountsDataGridView);
            this.Controls.Add(this.accountsBindingNavigator);
            this.Name = "admitadAccountsForm";
            this.Text = "Рекламные площадки в Admitad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.admitadAccountsForm_FormClosing);
            this.Load += new System.EventHandler(this.admitadAccountsForm_Load);
            this.Leave += new System.EventHandler(this.admitadAccountsForm_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingNavigator)).EndInit();
            this.accountsBindingNavigator.ResumeLayout(false);
            this.accountsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admitadAccountsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admitadAdsDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AdmitadAdsDBDataSet admitadAdsDBDataSet;
        private System.Windows.Forms.BindingSource admitadAccountsTableBindingSource;
        private AdmitadAdsDBDataSetTableAdapters.AdmitadAccountsTableTableAdapter admitadAccountsTableTableAdapter;
        private System.Windows.Forms.BindingNavigator accountsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView accountsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNameDataGridViewTextBoxColumn;
    }
}