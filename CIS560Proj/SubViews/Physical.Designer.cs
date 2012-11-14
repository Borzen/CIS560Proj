namespace CIS560Proj
{
    partial class Physical
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mediaDB = new CIS560Proj.MediaDB();
            this.physicalMediaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.physicalMediaTableAdapter = new CIS560Proj.MediaDBTableAdapters.PhysicalMediaTableAdapter();
            this.mediaTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pKtitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pKcreatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.physicalMediaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mediaTypeDataGridViewTextBoxColumn,
            this.pKtitleDataGridViewTextBoxColumn,
            this.pKcreatorDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.physicalMediaBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(666, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // mediaDB
            // 
            this.mediaDB.DataSetName = "MediaDB";
            this.mediaDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // physicalMediaBindingSource
            // 
            this.physicalMediaBindingSource.DataMember = "PhysicalMedia";
            this.physicalMediaBindingSource.DataSource = this.mediaDB;
            // 
            // physicalMediaTableAdapter
            // 
            this.physicalMediaTableAdapter.ClearBeforeFill = true;
            // 
            // mediaTypeDataGridViewTextBoxColumn
            // 
            this.mediaTypeDataGridViewTextBoxColumn.DataPropertyName = "mediaType";
            this.mediaTypeDataGridViewTextBoxColumn.HeaderText = "mediaType";
            this.mediaTypeDataGridViewTextBoxColumn.Name = "mediaTypeDataGridViewTextBoxColumn";
            this.mediaTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pKtitleDataGridViewTextBoxColumn
            // 
            this.pKtitleDataGridViewTextBoxColumn.DataPropertyName = "PK_title";
            this.pKtitleDataGridViewTextBoxColumn.HeaderText = "PK_title";
            this.pKtitleDataGridViewTextBoxColumn.Name = "pKtitleDataGridViewTextBoxColumn";
            this.pKtitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pKcreatorDataGridViewTextBoxColumn
            // 
            this.pKcreatorDataGridViewTextBoxColumn.DataPropertyName = "PK_creator";
            this.pKcreatorDataGridViewTextBoxColumn.HeaderText = "PK_creator";
            this.pKcreatorDataGridViewTextBoxColumn.Name = "pKcreatorDataGridViewTextBoxColumn";
            this.pKcreatorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Physical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 285);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Physical";
            this.Text = "Physical";
            this.Load += new System.EventHandler(this.Physical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.physicalMediaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MediaDB mediaDB;
        private System.Windows.Forms.BindingSource physicalMediaBindingSource;
        private MediaDBTableAdapters.PhysicalMediaTableAdapter physicalMediaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pKtitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pKcreatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
    }
}