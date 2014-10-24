using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Between0to100MaxMinAndAvarage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int min1 = 0;
        public int max1 = 0;
        public int avar = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            int[] arr = { 5, 14, 3, 65, 22, 87, 23, 33, 65, 1 };
            MinandMax(arr);
            avarage(arr, ref avar);
            MessageBox.Show("Min Value : " + min1.ToString() + "\nMax Value : " + max1.ToString() + "\nAvarage : " + avar.ToString());
        }
        public void MinandMax(int[] arr )
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        int temp = 0;
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            MessageBox.Show("içerde min : " + arr[0].ToString());
           min1 = arr[0];
           max1 = arr[9];
           MessageBox.Show("içerde min : " + arr[9].ToString());
        
        }
        public void avarage(int[] arr , ref int avarage)
        {
            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
            }
            avarage = total / arr.Length;
        }
    }
}
