namespace Palindrom_Checker
{
    partial class PalindromeChecker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) ) {
                components.Dispose( );
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PalindromeChecker));
            this.wordTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.attemptBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.ansTxtLbl = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wordTextBox
            // 
            this.wordTextBox.AccessibleDescription = "A text box to attempt a palindrome";
            this.wordTextBox.AccessibleName = "wordTextBox";
            this.wordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(160)))), ((int)(((byte)(164)))));
            this.wordTextBox.Font = new System.Drawing.Font("Hack", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.wordTextBox.Location = new System.Drawing.Point(199, 140);
            this.wordTextBox.Multiline = true;
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(621, 82);
            this.wordTextBox.TabIndex = 1;
            this.wordTextBox.Text = "Enter Text Here...";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar});
            this.statusStrip1.Location = new System.Drawing.Point(10, 456);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1023, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusBar
            // 
            this.statusBar.AccessibleDescription = "Status bar";
            this.statusBar.AccessibleName = "statusBar";
            this.statusBar.ActiveLinkColor = System.Drawing.Color.Yellow;
            this.statusBar.BackColor = System.Drawing.Color.White;
            this.statusBar.Font = new System.Drawing.Font("Hack", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBar.ForeColor = System.Drawing.Color.Black;
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(109, 20);
            this.statusBar.Text = "Loading...";
            // 
            // titleLabel
            // 
            this.titleLabel.AccessibleDescription = "The title header";
            this.titleLabel.AccessibleName = "titleLabel";
            this.titleLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(62)))), ((int)(((byte)(75)))));
            this.titleLabel.Font = new System.Drawing.Font("PRIMETIME", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(74)))), ((int)(((byte)(73)))));
            this.titleLabel.Location = new System.Drawing.Point(268, 47);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(498, 54);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Palindrome Checker";
            // 
            // attemptBtn
            // 
            this.attemptBtn.Font = new System.Drawing.Font("Midday Champy", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attemptBtn.Location = new System.Drawing.Point(689, 248);
            this.attemptBtn.Name = "attemptBtn";
            this.attemptBtn.Size = new System.Drawing.Size(130, 35);
            this.attemptBtn.TabIndex = 4;
            this.attemptBtn.Text = "Attempt";
            this.attemptBtn.UseVisualStyleBackColor = true;
            this.attemptBtn.Click += new System.EventHandler(this.attemptBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.AccessibleDescription = "A button to reset the text to original form";
            this.resetBtn.AccessibleName = "Reset Button";
            this.resetBtn.Font = new System.Drawing.Font("Midday Champy", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(553, 248);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(130, 35);
            this.resetBtn.TabIndex = 5;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // ansTxtLbl
            // 
            this.ansTxtLbl.AccessibleDescription = "text to let user no word is not a palindrome";
            this.ansTxtLbl.AccessibleName = "ansTxtLbl";
            this.ansTxtLbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ansTxtLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.ansTxtLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ansTxtLbl.Font = new System.Drawing.Font("Midday Champy", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ansTxtLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(160)))), ((int)(((byte)(164)))));
            this.ansTxtLbl.Location = new System.Drawing.Point(199, 248);
            this.ansTxtLbl.Name = "ansTxtLbl";
            this.ansTxtLbl.Size = new System.Drawing.Size(249, 35);
            this.ansTxtLbl.TabIndex = 6;
            this.ansTxtLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PalindromeChecker
            // 
            this.AcceptButton = this.attemptBtn;
            this.AccessibleDescription = "A GUI that checks wrods to see if they are palindromes";
            this.AccessibleName = "Palindrome Checker";
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(62)))), ((int)(((byte)(75)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1043, 492);
            this.Controls.Add(this.ansTxtLbl);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.attemptBtn);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.wordTextBox);
            this.Font = new System.Drawing.Font("LW Title", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(160)))), ((int)(((byte)(164)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(256, 256);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PalindromeChecker";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Palindrome Checker";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wordTextBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusBar;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button attemptBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label ansTxtLbl;
    }
}

