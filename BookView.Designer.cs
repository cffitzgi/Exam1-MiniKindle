
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
            this.buttonNextPage = new System.Windows.Forms.Button();
            this.buttonPreviousPage = new System.Windows.Forms.Button();
            this.buttonBookmark = new System.Windows.Forms.Button();
            this.labelPageDisplay = new System.Windows.Forms.Label();
            this.labelPageNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.buttonPreviousPage.Click += new System.EventHandler(this.buttonPreviousPage_Click);
            // 
            // buttonBookmark
            // 
            this.buttonBookmark.Location = new System.Drawing.Point(183, 474);
            this.buttonBookmark.Name = "buttonBookmark";
            this.buttonBookmark.Size = new System.Drawing.Size(76, 41);
            this.buttonBookmark.TabIndex = 3;
            this.buttonBookmark.Text = "Bookmark";
            this.buttonBookmark.UseVisualStyleBackColor = true;
            this.buttonBookmark.Click += new System.EventHandler(this.buttonBookmark_Click);
            // 
            // labelPageDisplay
            // 
            this.labelPageDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPageDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPageDisplay.Location = new System.Drawing.Point(12, 9);
            this.labelPageDisplay.Name = "labelPageDisplay";
            this.labelPageDisplay.Size = new System.Drawing.Size(476, 462);
            this.labelPageDisplay.TabIndex = 4;
            this.labelPageDisplay.Text = "Text";
            // 
            // labelPageNumber
            // 
            this.labelPageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPageNumber.Location = new System.Drawing.Point(265, 474);
            this.labelPageNumber.Name = "labelPageNumber";
            this.labelPageNumber.Size = new System.Drawing.Size(52, 41);
            this.labelPageNumber.TabIndex = 5;
            this.labelPageNumber.Text = "Page ##";
            this.labelPageNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 521);
            this.Controls.Add(this.labelPageNumber);
            this.Controls.Add(this.labelPageDisplay);
            this.Controls.Add(this.buttonBookmark);
            this.Controls.Add(this.buttonPreviousPage);
            this.Controls.Add(this.buttonNextPage);
            this.Name = "BookView";
            this.Text = "Reader";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonNextPage;
        private System.Windows.Forms.Button buttonPreviousPage;
        private System.Windows.Forms.Button buttonBookmark;
        private System.Windows.Forms.Label labelPageDisplay;
        private System.Windows.Forms.Label labelPageNumber;
    }
}

