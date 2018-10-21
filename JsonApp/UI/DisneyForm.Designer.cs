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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.ascBtn = new System.Windows.Forms.Button();
            this.descBtn = new System.Windows.Forms.Button();
            this.YearView = new System.Windows.Forms.ListView();
            this.SortByYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.radioYear = new System.Windows.Forms.RadioButton();
            this.radioLength = new System.Windows.Forms.RadioButton();
            this.radioRating = new System.Windows.Forms.RadioButton();
            this.radioTitle = new System.Windows.Forms.RadioButton();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.listViewSearch = new System.Windows.Forms.ListView();
            this.groupOptions = new System.Windows.Forms.GroupBox();
            this.groupOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // ascBtn
            // 
            this.ascBtn.Location = new System.Drawing.Point(45, 55);
            this.ascBtn.Name = "ascBtn";
            this.ascBtn.Size = new System.Drawing.Size(39, 23);
            this.ascBtn.TabIndex = 0;
            this.ascBtn.Text = "Asc";
            this.ascBtn.UseVisualStyleBackColor = true;
            this.ascBtn.Click += new System.EventHandler(this.ascBtn_Click);
            // 
            // descBtn
            // 
            this.descBtn.Location = new System.Drawing.Point(90, 55);
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
            listViewItem1});
            this.YearView.Location = new System.Drawing.Point(45, 99);
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
            // radioYear
            // 
            this.radioYear.AutoSize = true;
            this.radioYear.Location = new System.Drawing.Point(78, 42);
            this.radioYear.Name = "radioYear";
            this.radioYear.Size = new System.Drawing.Size(47, 17);
            this.radioYear.TabIndex = 3;
            this.radioYear.TabStop = true;
            this.radioYear.Text = "Year";
            this.radioYear.UseVisualStyleBackColor = true;
            // 
            // radioLength
            // 
            this.radioLength.AutoSize = true;
            this.radioLength.Location = new System.Drawing.Point(78, 19);
            this.radioLength.Name = "radioLength";
            this.radioLength.Size = new System.Drawing.Size(58, 17);
            this.radioLength.TabIndex = 4;
            this.radioLength.TabStop = true;
            this.radioLength.Text = "Length";
            this.radioLength.UseVisualStyleBackColor = true;
            // 
            // radioRating
            // 
            this.radioRating.AutoSize = true;
            this.radioRating.Location = new System.Drawing.Point(16, 42);
            this.radioRating.Name = "radioRating";
            this.radioRating.Size = new System.Drawing.Size(56, 17);
            this.radioRating.TabIndex = 5;
            this.radioRating.TabStop = true;
            this.radioRating.Text = "Rating";
            this.radioRating.UseVisualStyleBackColor = true;
            // 
            // radioTitle
            // 
            this.radioTitle.AutoSize = true;
            this.radioTitle.Location = new System.Drawing.Point(16, 19);
            this.radioTitle.Name = "radioTitle";
            this.radioTitle.Size = new System.Drawing.Size(45, 17);
            this.radioTitle.TabIndex = 6;
            this.radioTitle.TabStop = true;
            this.radioTitle.Text = "Title";
            this.radioTitle.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(326, 31);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(192, 20);
            this.textBoxSearch.TabIndex = 7;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(670, 25);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(100, 23);
            this.Search.TabIndex = 8;
            this.Search.Text = "btnSearch";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // listViewSearch
            // 
            this.listViewSearch.Location = new System.Drawing.Point(326, 99);
            this.listViewSearch.Name = "listViewSearch";
            this.listViewSearch.Size = new System.Drawing.Size(434, 183);
            this.listViewSearch.TabIndex = 9;
            this.listViewSearch.UseCompatibleStateImageBehavior = false;
            // 
            // groupOptions
            // 
            this.groupOptions.Controls.Add(this.radioTitle);
            this.groupOptions.Controls.Add(this.radioLength);
            this.groupOptions.Controls.Add(this.radioRating);
            this.groupOptions.Controls.Add(this.radioYear);
            this.groupOptions.Location = new System.Drawing.Point(524, 12);
            this.groupOptions.Name = "groupOptions";
            this.groupOptions.Size = new System.Drawing.Size(140, 66);
            this.groupOptions.TabIndex = 10;
            this.groupOptions.TabStop = false;
            this.groupOptions.Text = "Options";
            // 
            // DisneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupOptions);
            this.Controls.Add(this.listViewSearch);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.YearView);
            this.Controls.Add(this.descBtn);
            this.Controls.Add(this.ascBtn);
            this.Name = "DisneyForm";
            this.Text = "Form1";
            this.groupOptions.ResumeLayout(false);
            this.groupOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ascBtn;
        private System.Windows.Forms.Button descBtn;
        private System.Windows.Forms.ListView YearView;
        private System.Windows.Forms.ColumnHeader SortByYear;
        private System.Windows.Forms.RadioButton radioYear;
        private System.Windows.Forms.RadioButton radioLength;
        private System.Windows.Forms.RadioButton radioRating;
        private System.Windows.Forms.RadioButton radioTitle;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ListView listViewSearch;
        private System.Windows.Forms.GroupBox groupOptions;
    }
}