using System;
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

        private void button1_click( object sender , EventArgs e )
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
                {
                    if ( character[ startchar ] == character[ lastchar ] ) {
                        startchar++;
                        lastchar--;
                    } else {
                        // Display message if not a palindrome
                        label1.Visible = true;
                        label1.Text = "It is not a palindrome\n Try again?";
                        resetBtn.Focus( );

                    }
                }
            }
        }
