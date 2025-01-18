using System;
using System.Windows.Forms;

namespace Palindrom_Checker
{
    public partial class PalindromeChecker : Form
    {
        int i, startchar, lastchar;
        //private TextBox textBox1;


        public PalindromeChecker( )
        {
            InitializeComponent( );
        }

        //public void InitializeComponent( )
        //{
        //    this.textBox1 = new System.Windows.Forms.TextBox();
        //    this.SuspendLayout( );
        //    // 
        //    // textBox1
        //    // 
        //    this.textBox1.AcceptsReturn = true;
        //    this.textBox1.AcceptsTab = true;
        //    this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        //    this.textBox1.Multiline = true;
        //    this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        //    // 
        //    // Form1
        //    // 
        //    this.ClientSize = new System.Drawing.Size(284 , 264);
        //    this.Controls.Add(this.textBox1);
        //    this.Text = "TextBox Example";
        //    this.ResumeLayout(false);
        //    this.PerformLayout( );


        //}

        private void attemptBtn_Click( object sender , EventArgs e )
        {
            // Convert all input into lower case. Avoiding case sensitivity
            string low = wordTextBox.Text.ToLower( );

            // Remove spaces from input sentences to check palindrome
            low = low.Replace(" " , "");

            char[ ] character = new char[ 100 ];
            character = low.ToCharArray( );
            startchar = 0;
            lastchar = character.Length - 1;

            while ( startchar < lastchar ) {

                if ( character[ startchar ] == character[ lastchar ] ) {
                    startchar++;
                    lastchar--;
                } else {
                    // Display message if not a palindrome
                    ansTxtLbl.Visible = true;
                    ansTxtLbl.Text = "Not palindrome";
                    wordTextBox.Focus( );

                    // Set a Flag to prevent closing the app after breaking loop
                    // Allows user to try again
                    i = 2;
                    break;
                }
            }

            if ( i < 2 ) {
                // Display message if input is a Palindrome
                ansTxtLbl.Visible = true;
                ansTxtLbl.Text = "IT is a PALINDROME!!!";
                wordTextBox.Focus( );
            } else {
                {
                    // Reset the flag back to 0 to stop infinite loop
                    i = 0;
                }
            }
        }



        private void wordTextBox_click( object sender , EventArgs e )
        {
            wordTextBox.Focus( );
            wordTextBox.Clear( );

        }



        private void resetBtn_Click( object sender , EventArgs e )
        {
            wordTextBox.Text = string.Empty;
            wordTextBox.Focus( );
            ansTxtLbl.Visible = false;
        }
    }
}
