using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Evaluare
{
    public partial class PrimNumber : Form
    {
        private double shift = 1;
        
        public PrimNumber()
        {
            InitializeComponent();
        }

        private void textBox_A_TextChanged(object sender, EventArgs e)
        {
            refreshList();
        }
        
        
        private void refreshList()
        {
            int num;
            bool isNumber = int.TryParse(textBox_A.Text, out num);

            listBox1.Items.Clear();
            if (isNumber)
            {
                progressBar1.Visible = true;
                progressBar1.Value = 0;

                addAllPrimeNumbersToList(num);
            }
        }

        private void addAllPrimeNumbersToList(int number)
        {
            for (int i = 0; i < number; i++)
            {

                int percent = 100 * i / number;
                progressBar1.Value = percent;
                
                if (isPrimeNum(i))
                {
                    listBox1.Items.Add(i);
                }
            }

            progressBar1.Value = 100;
        }
        
        
        private bool isPrimeNum(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));
          
            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;
    
            return true;   
        }
    }
}