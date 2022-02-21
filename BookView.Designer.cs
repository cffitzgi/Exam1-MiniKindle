
namespace Exam1_MiniKindle
{
    partial class BookView
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
            this.PageDisplay = new System.Windows.Forms.TextBox();
            this.buttonNextPage = new System.Windows.Forms.Button();
            this.buttonPreviousPage = new System.Windows.Forms.Button();
            this.buttonBookmark = new System.Windows.Forms.Button();
            this.labelBookTitle = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.buttonLibrary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PageDisplay
            // 
            this.PageDisplay.Location = new System.Drawing.Point(12, 39);
            this.PageDisplay.Multiline = true;
            this.PageDisplay.Name = "PageDisplay";
            this.PageDisplay.ReadOnly = true;
            this.PageDisplay.Size = new System.Drawing.Size(476, 424);
            this.PageDisplay.TabIndex = 0;
            // 
            // buttonNextPage
            // 
            this.buttonNextPage.Location = new System.Drawing.Point(323, 474);
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.Size = new System.Drawing.Size(165, 41);
            this.buttonNextPage.TabIndex = 1;
            this.buttonNextPage.Text = ">>";
            this.buttonNextPage.UseVisualStyleBackColor = true;
            this.buttonNextPage.Click += new System.EventHandler(this.buttonNextPage_Click);
            // 
            // buttonPreviousPage
            // 
            this.buttonPreviousPage.Location = new System.Drawing.Point(12, 474);
            this.buttonPreviousPage.Name = "buttonPreviousPage";
            this.buttonPreviousPage.Size = new System.Drawing.Size(165, 41);
            this.buttonPreviousPage.TabIndex = 2;
            this.buttonPreviousPage.Text = "<<";
            this.buttonPreviousPage.UseVisualStyleBackColor = true;
            // 
            // buttonBookmark
            // 
            this.buttonBookmark.Location = new System.Drawing.Point(217, 474);
            this.buttonBookmark.Name = "buttonBookmark";
            this.buttonBookmark.Size = new System.Drawing.Size(68, 41);
            this.buttonBookmark.TabIndex = 3;
            this.buttonBookmark.Text = "Bookmark";
            this.buttonBookmark.UseVisualStyleBackColor = true;
            // 
            // labelBookTitle
            // 
            this.labelBookTitle.AutoSize = true;
            this.labelBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookTitle.Location = new System.Drawing.Point(12, 9);
            this.labelBookTitle.Name = "labelBookTitle";
            this.labelBookTitle.Size = new System.Drawing.Size(118, 26);
            this.labelBookTitle.TabIndex = 5;
            this.labelBookTitle.Text = "Book Title";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthor.Location = new System.Drawing.Point(331, 16);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(99, 17);
            this.labelAuthor.TabIndex = 6;
            this.labelAuthor.Text = "Author Person";
            // 
            // buttonLibrary
            // 
            this.buttonLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLibrary.Location = new System.Drawing.Point(436, 7);
            this.buttonLibrary.Name = "buttonLibrary";
            this.buttonLibrary.Size = new System.Drawing.Size(52, 29);
            this.buttonLibrary.TabIndex = 7;
            this.buttonLibrary.Text = "🏠";
            this.buttonLibrary.UseVisualStyleBackColor = true;
            // 
            // BookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 521);
            this.Controls.Add(this.buttonLibrary);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelBookTitle);
            this.Controls.Add(this.buttonBookmark);
            this.Controls.Add(this.buttonPreviousPage);
            this.Controls.Add(this.buttonNextPage);
            this.Controls.Add(this.PageDisplay);
            this.Name = "BookView";
            this.Text = "Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PageDisplay;
        private System.Windows.Forms.Button buttonNextPage;
        private System.Windows.Forms.Button buttonPreviousPage;
        private System.Windows.Forms.Button buttonBookmark;
        private System.Windows.Forms.Label labelBookTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Button buttonLibrary;
    }
}

