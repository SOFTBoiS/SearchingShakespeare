using System;
using System.Linq;
using System.Windows.Forms;
using Searching_Shakespeare.Logic;

namespace Searching_Shakespeare
{
    public partial class Form1 : Form
    {
        private readonly SuffixTree _suffixTree;
        private readonly int _maxResultAmount;

        public Form1(SuffixTree suffixTree, int maxResultAmount = 50)
        {
            _suffixTree = suffixTree;
            _maxResultAmount = maxResultAmount;
            InitializeComponent();
        }

        // Dont Delete
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        //Make search each time text changes in textBox1 and print result in textBox2
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var searchStr = textBox1.Text;
            textBox2.Lines = searchStr.Length > 0
                ? _suffixTree.Search(searchStr, _maxResultAmount).ToArray()
                : new string[] {"Search Results will show here"};
        }
    }
}