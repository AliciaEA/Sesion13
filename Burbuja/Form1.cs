using Burbuja.operaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burbuja
{
    public partial class Form1 : Form
    {
        int[] numeros = new int[10];
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(tbNumber.Text);
            numeros[i++] = number;
            showNumbers();

        }

        private void showNumbers()
        {
            if (numeros.Length > 0)
            {
                lbNumber.Items.Clear();
            }
            for (int j = 0; j < numeros.Length; j++)
            {
                lbNumber.Items.Add(numeros[j]);
            }
            
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            MetBurbuja burbuja = new MetBurbuja();
            burbuja.OrdenarBurbuja(numeros);
            showNumbers();
        }
    }
}
