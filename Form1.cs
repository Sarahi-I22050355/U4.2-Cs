using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4._2_Cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static T InlineAssignHelper<T>(ref T target, T value)
        {
            target = value;
            return value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvInventory.View = View.Details;
            lvInventory.FullRowSelect = true;
            lvInventory.Clear();
            string rutaArchivo = @"C:\Users\Sarah\OneDrive\Escritorio\inventario.txt";
            StreamReader SR = new StreamReader(rutaArchivo, Encoding.UTF8);
            string Columnas = SR.ReadLine();
            string[] Separador = Columnas.Split(',');
            for (int i = 0; i < Separador.Length; i++)
            {
                lvInventory.Columns.Add(Separador[i], 100);
            }

            string renglon;
            while ((renglon = SR.ReadLine()) != null)
            {
                string[] datos = renglon.Split(',');
                ListViewItem item = new ListViewItem(datos[0]);
                for (int i = 1; i < datos.Length; i++)
                {
                    item.SubItems.Add(datos[i]);
                }
                lvInventory.Items.Add(item);
            }
            SR.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtModel.Text) || string.IsNullOrEmpty(cbBrand.Text) || string.IsNullOrEmpty(cbOS.Text) || string.IsNullOrEmpty(cbProcessor.Text))
            {
                MessageBox.Show("Please enter the complete data.");
                return;
            }

            Computadora electronicos = new Computadora(double.Parse(txtPrice.Text), cbBrand.Text, txtModel.Text, cbOS.Text, cbProcessor.Text);
            ListViewItem item = new ListViewItem(new string[] { electronicos.Price.ToString(), electronicos.IVA, electronicos.Brand, electronicos.Model, electronicos.Processor, electronicos.Os });
            lvInventory.Items.Add(item);

            txtPrice.Clear();
            txtModel.Clear();
            cbBrand.Focus();
            cbOS.Focus();
            cbProcessor.Focus();
        }

        private void lvInventory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (ListViewItem seleccion in lvInventory.SelectedItems)
                {
                    seleccion.Remove();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string rutaArchivo = @"C:\Users\Sarah\OneDrive\Escritorio\inventario.txt";
            StreamWriter sw = new StreamWriter(rutaArchivo);
            string Header = "";
            for (int i = 0; i <= lvInventory.Columns.Count - 2; i++)
            {
                Header += lvInventory.Columns[i].Text + ",";
            }
            Header += lvInventory.Columns[lvInventory.Columns.Count - 1].Text;
            sw.WriteLine(Header);
            foreach (ListViewItem renglon in lvInventory.Items)
            {
                string r = "";
                for (int i = 0; i <= renglon.SubItems.Count - 2; i++)
                {
                    r += renglon.SubItems[i].Text + ",";
                }
                r += renglon.SubItems[renglon.SubItems.Count - 1].Text;
                sw.WriteLine(r);
            }
            sw.Close();
        }
    }
}
