using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraductorInglesEspannol
{
    public partial class UserControl1: UserControl
    {
        Dictionary<string, string> diccionario = new Dictionary<string, string>();

       
        public UserControl1()
        {
            InitializeComponent();
        
            diccionario.Add("dog", "perro");
            diccionario.Add("flower", "flor");
            diccionario.Add("car", "carro");
            diccionario.Add("fish", "pescado");
            diccionario.Add("nature", "naturaleza");
            diccionario.Add("ocean", "océano");
            diccionario.Add("song", "canción");
            diccionario.Add("beach", "playa");
            diccionario.Add("moon", "luna");
            diccionario.Add("poetry", "poesía");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string palabraATraducir = textBox1.Text.ToLower();
            DialogResult result;
            if (palabraATraducir.Equals(""))
            {
                result = MessageBox.Show("Debe escribir una palabra");
            }
            else
            {
                if (diccionario.ContainsKey(palabraATraducir))
                {                    
                    label3.Text = diccionario[palabraATraducir];
                }
                else
                {
                    result = MessageBox.Show("El diccionario no contiene una traducción a esa palabra");

                }
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
