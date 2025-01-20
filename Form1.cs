using System;
using System.Drawing;
using System.Windows.Forms;

namespace Palindrom_Checker
{
    public partial class PalindromeChecker : Form
    {
        int i, startchar, lastchar;



        public PalindromeChecker( )
        {
            InitializeComponent( );
        }




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
                    ansTxtLbl.BackColor = System.Drawing.Color.DarkRed;
                    wordTextBox.Focus( );
                    wordTextBox.ResetText( );

                    // Set a Flag to prevent closing the app after breaking loop
                    // Allows user to try again
                    i = 2;
                    break;
                }
            }

            if ( i < 2 ) {
                // Display message if input is a Palindrome
                ansTxtLbl.Visible = true;
                ansTxtLbl.Text = "IT is a PALINDROME";
                ansTxtLbl.BackColor = System.Drawing.Color.DarkGreen;
                wordTextBox.Focus( );
                wordTextBox.ResetText( );
            } else {
                {
                    // Reset the flag back to 0 to stop infinite loop
                    i = 0;
                }
            }
        }



        private void resetBtn_Click( object sender , EventArgs e )
        {
            Color whiteColor = Color.FromArgb(234 , 234 , 234);
            Color randColor = Color.FromArgb(49 , 121 , 98);

            wordTextBox.Text = string.Empty;
            wordTextBox.Focus( );
            ansTxtLbl.Visible = true;
            ansTxtLbl.ResetText( );
            ansTxtLbl.BackColor = whiteColor;
        }


    }
}
