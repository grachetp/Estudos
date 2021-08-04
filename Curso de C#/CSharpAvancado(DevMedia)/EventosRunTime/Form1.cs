using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventosRunTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var bt = new Button();
            bt.Parent = this;
            this.Controls.Add(bt);
            bt.Text = "Clique Aqui";
            bt.Location = new System.Drawing.Point(26, 60);
            bt.Click += new EventHandler(Bt_Click); //Apontando o evento para um método
            bt.Click += delegate (object s, EventArgs ea)
            {
                //Método Anonimo
                MessageBox.Show("Olá Mundo");
            };
            bt.Click += (s, ea) => MessageBox.Show("Hello World");
        }

        private void Bt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá Mundo");
        }
    }
}
