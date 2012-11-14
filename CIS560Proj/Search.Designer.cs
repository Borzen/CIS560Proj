namespace CIS560Proj
{
    partial class Search
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
            this.btn_Search_By_Creator = new System.Windows.Forms.Button();
            this.btn_Search_By_Title = new System.Windows.Forms.Button();
            this.btn_Search_by_Media = new System.Windows.Forms.Button();
            this.tB_Search_By_Creator = new System.Windows.Forms.TextBox();
            this.tb_Search_by_Meida = new System.Windows.Forms.TextBox();
            this.tb_Search_By_Title = new System.Windows.Forms.TextBox();
            this.Search_By_Creator = new System.Windows.Forms.Label();
            this.lb_Search_By_Title = new System.Windows.Forms.Label();
            this.lb_media_type = new System.Windows.Forms.Label();
            this.lb_Results = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Search_By_Creator
            // 
            this.btn_Search_By_Creator.Location = new System.Drawing.Point(508, 35);
            this.btn_Search_By_Creator.Name = "btn_Search_By_Creator";
            this.btn_Search_By_Creator.Size = new System.Drawing.Size(117, 21);
            this.btn_Search_By_Creator.TabIndex = 0;
            this.btn_Search_By_Creator.Text = "Search By Creator";
            this.btn_Search_By_Creator.UseVisualStyleBackColor = true;
            this.btn_Search_By_Creator.Click += new System.EventHandler(this.btn_Search_By_Creator_Click);
            // 
            // btn_Search_By_Title
            // 
            this.btn_Search_By_Title.Location = new System.Drawing.Point(508, 12);
            this.btn_Search_By_Title.Name = "btn_Search_By_Title";
            this.btn_Search_By_Title.Size = new System.Drawing.Size(117, 21);
            this.btn_Search_By_Title.TabIndex = 1;
            this.btn_Search_By_Title.Text = "Search By Title";
            this.btn_Search_By_Title.UseVisualStyleBackColor = true;
            this.btn_Search_By_Title.Click += new System.EventHandler(this.btn_Search_By_Title_Click);
            // 
            // btn_Search_by_Media
            // 
            this.btn_Search_by_Media.Location = new System.Drawing.Point(508, 62);
            this.btn_Search_by_Media.Name = "btn_Search_by_Media";
            this.btn_Search_by_Media.Size = new System.Drawing.Size(117, 21);
            this.btn_Search_by_Media.TabIndex = 2;
            this.btn_Search_by_Media.Text = "Search by Media";
            this.btn_Search_by_Media.UseVisualStyleBackColor = true;
            this.btn_Search_by_Media.Click += new System.EventHandler(this.btn_Search_by_Media_Click);
            // 
            // tB_Search_By_Creator
            // 
            this.tB_Search_By_Creator.Location = new System.Drawing.Point(117, 36);
            this.tB_Search_By_Creator.Name = "tB_Search_By_Creator";
            this.tB_Search_By_Creator.Size = new System.Drawing.Size(385, 20);
            this.tB_Search_By_Creator.TabIndex = 3;
            // 
            // tb_Search_by_Meida
            // 
            this.tb_Search_by_Meida.Location = new System.Drawing.Point(117, 61);
            this.tb_Search_by_Meida.Name = "tb_Search_by_Meida";
            this.tb_Search_by_Meida.Size = new System.Drawing.Size(385, 20);
            this.tb_Search_by_Meida.TabIndex = 4;
            // 
            // tb_Search_By_Title
            // 
            this.tb_Search_By_Title.Location = new System.Drawing.Point(117, 12);
            this.tb_Search_By_Title.Name = "tb_Search_By_Title";
            this.tb_Search_By_Title.Size = new System.Drawing.Size(385, 20);
            this.tb_Search_By_Title.TabIndex = 5;
            // 
            // Search_By_Creator
            // 
            this.Search_By_Creator.AutoSize = true;
            this.Search_By_Creator.Location = new System.Drawing.Point(12, 39);
            this.Search_By_Creator.Name = "Search_By_Creator";
            this.Search_By_Creator.Size = new System.Drawing.Size(93, 13);
            this.Search_By_Creator.TabIndex = 6;
            this.Search_By_Creator.Text = "Search By Creator";
            // 
            // lb_Search_By_Title
            // 
            this.lb_Search_By_Title.AutoSize = true;
            this.lb_Search_By_Title.Location = new System.Drawing.Point(12, 16);
            this.lb_Search_By_Title.Name = "lb_Search_By_Title";
            this.lb_Search_By_Title.Size = new System.Drawing.Size(79, 13);
            this.lb_Search_By_Title.TabIndex = 7;
            this.lb_Search_By_Title.Text = "Search By Title";
            // 
            // lb_media_type
            // 
            this.lb_media_type.AutoSize = true;
            this.lb_media_type.Location = new System.Drawing.Point(12, 64);
            this.lb_media_type.Name = "lb_media_type";
            this.lb_media_type.Size = new System.Drawing.Size(88, 13);
            this.lb_media_type.TabIndex = 8;
            this.lb_media_type.Text = "Search By Media";
            // 
            // lb_Results
            // 
            this.lb_Results.FormattingEnabled = true;
            this.lb_Results.Location = new System.Drawing.Point(15, 100);
            this.lb_Results.Name = "lb_Results";
            this.lb_Results.Size = new System.Drawing.Size(605, 173);
            this.lb_Results.TabIndex = 9;
            this.lb_Results.SelectedIndexChanged += new System.EventHandler(this.lb_Results_SelectedIndexChanged);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 278);
            this.Controls.Add(this.lb_Results);
            this.Controls.Add(this.lb_media_type);
            this.Controls.Add(this.lb_Search_By_Title);
            this.Controls.Add(this.Search_By_Creator);
            this.Controls.Add(this.tb_Search_By_Title);
            this.Controls.Add(this.tb_Search_by_Meida);
            this.Controls.Add(this.tB_Search_By_Creator);
            this.Controls.Add(this.btn_Search_by_Media);
            this.Controls.Add(this.btn_Search_By_Title);
            this.Controls.Add(this.btn_Search_By_Creator);
            this.Name = "Search";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search_By_Creator;
        private System.Windows.Forms.Button btn_Search_By_Title;
        private System.Windows.Forms.Button btn_Search_by_Media;
        private System.Windows.Forms.TextBox tB_Search_By_Creator;
        private System.Windows.Forms.TextBox tb_Search_by_Meida;
        private System.Windows.Forms.TextBox tb_Search_By_Title;
        private System.Windows.Forms.Label Search_By_Creator;
        private System.Windows.Forms.Label lb_Search_By_Title;
        private System.Windows.Forms.Label lb_media_type;
        private System.Windows.Forms.ListBox lb_Results;
    }
}