using System;
using System.Windows.Forms;
using Searching_Shakespeare.Logic;

namespace Searching_Shakespeare
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // // Reading the complete text from file to a string (TAKES OVER A MINUTE TO LOAD)
            // // (Change default path in TextProcessor Class to your own location of the file if this does not work)
            var text = TextProcessor.ReadText(); 
            
            // // For testing a smaller file (Change this path to your own location of the file if this does not work)
            // var text = TextProcessor.ReadText(@"..\..\..\test-text.txt"); 

            // //Build SuffixTree from shakespeare text, and max amount of results to find.
            var suffixTree = new SuffixTree(text);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //Run the form with the created suffixTree and the max amount of results to find (for performance)
            Application.Run(new Form1(suffixTree, 50));
        }
    }
}