namespace JsonApp
{
    partial class DisneyForm
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.ascBtn = new System.Windows.Forms.Button();
            this.descBtn = new System.Windows.Forms.Button();
            this.YearView = new System.Windows.Forms.ListView();
            this.SortByYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ascBtn
            // 
            this.ascBtn.Location = new System.Drawing.Point(45, 31);
            this.ascBtn.Name = "ascBtn";
            this.ascBtn.Size = new System.Drawing.Size(39, 23);
            this.ascBtn.TabIndex = 0;
            this.ascBtn.Text = "Asc";
            this.ascBtn.UseVisualStyleBackColor = true;
            this.ascBtn.Click += new System.EventHandler(this.ascBtn_Click);
            // 
            // descBtn
            // 
            this.descBtn.Location = new System.Drawing.Point(90, 31);
            this.descBtn.Name = "descBtn";
            this.descBtn.Size = new System.Drawing.Size(42, 23);
            this.descBtn.TabIndex = 1;
            this.descBtn.Text = "Desc";
            this.descBtn.UseVisualStyleBackColor = true;
            this.descBtn.Click += new System.EventHandler(this.descBtn_Click);
            // 
            // YearView
            // 
            this.YearView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SortByYear});
            this.YearView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.YearView.Location = new System.Drawing.Point(45, 58);
            this.YearView.Margin = new System.Windows.Forms.Padding(1);
            this.YearView.Name = "YearView";
            this.YearView.Size = new System.Drawing.Size(244, 183);
            this.YearView.TabIndex = 2;
            this.YearView.UseCompatibleStateImageBehavior = false;
            this.YearView.View = System.Windows.Forms.View.Details;
            // 
            // SortByYear
            // 
            this.SortByYear.Text = "Sort By Year";
            this.SortByYear.Width = 262;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.YearView);
            this.Controls.Add(this.descBtn);
            this.Controls.Add(this.ascBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ascBtn;
        private System.Windows.Forms.Button descBtn;
        private System.Windows.Forms.ListView YearView;
        private System.Windows.Forms.ColumnHeader SortByYear;
    }
}