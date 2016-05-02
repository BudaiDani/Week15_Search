namespace RegexSearcher
{
    partial class Form1
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.lblMatches = new System.Windows.Forms.Label();
            this.lblPattern = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.RichTextBox();
            this.lstMatches = new System.Windows.Forms.ListBox();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(76, 310);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(517, 242);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(37, 19);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(28, 13);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "Text";
            // 
            // lblMatches
            // 
            this.lblMatches.AutoSize = true;
            this.lblMatches.Location = new System.Drawing.Point(389, 19);
            this.lblMatches.Name = "lblMatches";
            this.lblMatches.Size = new System.Drawing.Size(48, 13);
            this.lblMatches.TabIndex = 3;
            this.lblMatches.Text = "Matches";
            // 
            // lblPattern
            // 
            this.lblPattern.AutoSize = true;
            this.lblPattern.Location = new System.Drawing.Point(37, 277);
            this.lblPattern.Name = "lblPattern";
            this.lblPattern.Size = new System.Drawing.Size(41, 13);
            this.lblPattern.TabIndex = 4;
            this.lblPattern.Text = "Pattern";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(40, 44);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(307, 194);
            this.txtText.TabIndex = 5;
            this.txtText.Text = "";
            // 
            // lstMatches
            // 
            this.lstMatches.FormattingEnabled = true;
            this.lstMatches.Location = new System.Drawing.Point(392, 44);
            this.lstMatches.Name = "lstMatches";
            this.lstMatches.Size = new System.Drawing.Size(200, 186);
            this.lstMatches.TabIndex = 6;
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(85, 277);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(390, 20);
            this.txtPattern.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 358);
            this.Controls.Add(this.txtPattern);
            this.Controls.Add(this.lstMatches);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.lblPattern);
            this.Controls.Add(this.lblMatches);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblMatches;
        private System.Windows.Forms.Label lblPattern;
        private System.Windows.Forms.RichTextBox txtText;
        private System.Windows.Forms.ListBox lstMatches;
        private System.Windows.Forms.TextBox txtPattern;
    }
}

