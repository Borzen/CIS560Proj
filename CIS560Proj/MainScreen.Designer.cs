namespace CIS560Proj
{
    partial class MainScreen
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
            this.SongB = new System.Windows.Forms.Button();
            this.BookB = new System.Windows.Forms.Button();
            this.MoviesB = new System.Windows.Forms.Button();
            this.GamesB = new System.Windows.Forms.Button();
            this.PhysicalB = new System.Windows.Forms.Button();
            this.DigitalB = new System.Windows.Forms.Button();
            this.checkoutB = new System.Windows.Forms.Button();
            this.checkinB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mediaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mediaDB = new CIS560Proj.MediaDB();
            this.mediaTableAdapter = new CIS560Proj.MediaDBTableAdapters.MediaTableAdapter();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madeByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDigitalDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaDB)).BeginInit();
            this.SuspendLayout();
            // 
            // SongB
            // 
            this.SongB.Location = new System.Drawing.Point(13, 251);
            this.SongB.Name = "SongB";
            this.SongB.Size = new System.Drawing.Size(75, 23);
            this.SongB.TabIndex = 3;
            this.SongB.Text = "Songs";
            this.SongB.UseVisualStyleBackColor = true;
            this.SongB.Click += new System.EventHandler(this.SongB_Click);
            // 
            // BookB
            // 
            this.BookB.Location = new System.Drawing.Point(146, 250);
            this.BookB.Name = "BookB";
            this.BookB.Size = new System.Drawing.Size(75, 23);
            this.BookB.TabIndex = 4;
            this.BookB.Text = "Books";
            this.BookB.UseVisualStyleBackColor = true;
            this.BookB.Click += new System.EventHandler(this.BookB_Click);
            // 
            // MoviesB
            // 
            this.MoviesB.Location = new System.Drawing.Point(279, 250);
            this.MoviesB.Name = "MoviesB";
            this.MoviesB.Size = new System.Drawing.Size(75, 23);
            this.MoviesB.TabIndex = 5;
            this.MoviesB.Text = "Movies";
            this.MoviesB.UseVisualStyleBackColor = true;
            this.MoviesB.Click += new System.EventHandler(this.MoviesB_Click);
            // 
            // GamesB
            // 
            this.GamesB.Location = new System.Drawing.Point(412, 250);
            this.GamesB.Name = "GamesB";
            this.GamesB.Size = new System.Drawing.Size(75, 23);
            this.GamesB.TabIndex = 6;
            this.GamesB.Text = "Games";
            this.GamesB.UseVisualStyleBackColor = true;
            this.GamesB.Click += new System.EventHandler(this.GamesB_Click);
            // 
            // PhysicalB
            // 
            this.PhysicalB.Location = new System.Drawing.Point(545, 250);
            this.PhysicalB.Name = "PhysicalB";
            this.PhysicalB.Size = new System.Drawing.Size(75, 23);
            this.PhysicalB.TabIndex = 7;
            this.PhysicalB.Text = "Physical";
            this.PhysicalB.UseVisualStyleBackColor = true;
            this.PhysicalB.Click += new System.EventHandler(this.PhysicalB_Click);
            // 
            // DigitalB
            // 
            this.DigitalB.Location = new System.Drawing.Point(678, 251);
            this.DigitalB.Name = "DigitalB";
            this.DigitalB.Size = new System.Drawing.Size(75, 23);
            this.DigitalB.TabIndex = 8;
            this.DigitalB.Text = "Digital";
            this.DigitalB.UseVisualStyleBackColor = true;
            this.DigitalB.Click += new System.EventHandler(this.DigitalB_Click);
            // 
            // checkoutB
            // 
            this.checkoutB.Location = new System.Drawing.Point(13, 13);
            this.checkoutB.Name = "checkoutB";
            this.checkoutB.Size = new System.Drawing.Size(75, 23);
            this.checkoutB.TabIndex = 9;
            this.checkoutB.Text = "Check Out";
            this.checkoutB.UseVisualStyleBackColor = true;
            // 
            // checkinB
            // 
            this.checkinB.Location = new System.Drawing.Point(682, 12);
            this.checkinB.Name = "checkinB";
            this.checkinB.Size = new System.Drawing.Size(75, 23);
            this.checkinB.TabIndex = 10;
            this.checkinB.Text = "Check In";
            this.checkinB.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.titleDataGridViewTextBoxColumn,
            this.madeByDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.isDigitalDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.mediaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 202);
            this.dataGridView1.TabIndex = 11;
            // 
            // mediaBindingSource
            // 
            this.mediaBindingSource.DataMember = "Media";
            this.mediaBindingSource.DataSource = this.mediaDB;
            // 
            // mediaDB
            // 
            this.mediaDB.DataSetName = "MediaDB";
            this.mediaDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mediaTableAdapter
            // 
            this.mediaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "mediaType";
            this.dataGridViewTextBoxColumn7.HeaderText = "mediaType";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // madeByDataGridViewTextBoxColumn
            // 
            this.madeByDataGridViewTextBoxColumn.DataPropertyName = "Made By";
            this.madeByDataGridViewTextBoxColumn.HeaderText = "Made By";
            this.madeByDataGridViewTextBoxColumn.Name = "madeByDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "length";
            this.dataGridViewTextBoxColumn8.HeaderText = "length";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "genre";
            this.dataGridViewTextBoxColumn9.HeaderText = "genre";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "count";
            this.dataGridViewTextBoxColumn10.HeaderText = "count";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // isDigitalDataGridViewCheckBoxColumn
            // 
            this.isDigitalDataGridViewCheckBoxColumn.DataPropertyName = "isDigital";
            this.isDigitalDataGridViewCheckBoxColumn.HeaderText = "isDigital";
            this.isDigitalDataGridViewCheckBoxColumn.Name = "isDigitalDataGridViewCheckBoxColumn";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 285);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkinB);
            this.Controls.Add(this.checkoutB);
            this.Controls.Add(this.DigitalB);
            this.Controls.Add(this.PhysicalB);
            this.Controls.Add(this.GamesB);
            this.Controls.Add(this.MoviesB);
            this.Controls.Add(this.BookB);
            this.Controls.Add(this.SongB);
            this.Name = "MainScreen";
            this.Text = "Main DB";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SongB;
        private System.Windows.Forms.Button BookB;
        private System.Windows.Forms.Button MoviesB;
        private System.Windows.Forms.Button GamesB;
        private System.Windows.Forms.Button PhysicalB;
        private System.Windows.Forms.Button DigitalB;
        private System.Windows.Forms.Button checkoutB;
        private System.Windows.Forms.Button checkinB;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pKtitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pKcreatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MediaDB mediaDB;
        private System.Windows.Forms.BindingSource mediaBindingSource;
        private MediaDBTableAdapters.MediaTableAdapter mediaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn madeByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDigitalDataGridViewCheckBoxColumn;
    }
}

