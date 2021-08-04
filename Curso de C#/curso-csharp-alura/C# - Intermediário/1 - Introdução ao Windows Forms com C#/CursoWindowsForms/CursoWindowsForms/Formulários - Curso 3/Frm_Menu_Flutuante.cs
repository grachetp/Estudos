using System;
using System.Drawing;
using System.Windows.Forms;

namespace CursoWindowsForms {
  public partial class Frm_Menu_Flutuante : Form {
    public Frm_Menu_Flutuante() {
      InitializeComponent();
    }

    private void Frm_Menu_Flutuante_MouseDown(object sender, MouseEventArgs e) {
      //string str1 = e.Button.ToString();
      //comparação qual botão do mouse foi clicado
      if (e.Button == System.Windows.Forms.MouseButtons.Right) {
        //var posX = e.X;
        //var posY = e.Y;
        //MessageBox.Show($"Clique com o botão direito do mouse!.\nA posição relativa foi:\nX: {posX}\nY:{posY}");

        //Fazer menu com opcoes cascata
        //ToolStripDropDownItem menu;
        //menu = new ToolStripMenuItem("Ajuda");
        //menu.DropDownItems.Add("Teste1");
        //menu.DropDownItems.Add("Teste2");

        var contextMenu = new ContextMenuStrip();
        var vToolTip001 = desenhaMenuItem("Item 1", "key");
        var vToolTip002 = desenhaMenuItem("Item 2", "question1");
        contextMenu.Items.Add(vToolTip001);
        contextMenu.Items.Add(vToolTip002);
        contextMenu.Show(this, new Point(e.X, e.Y));

        //adicionando evento no item do menu
        vToolTip001.Click += new System.EventHandler(vToolTip001_Click);
        vToolTip002.Click += new System.EventHandler(vToolTip002_Click);

      }

      //Funçao pra dar acão
      void vToolTip001_Click(object sender1, EventArgs e1) {
        MessageBox.Show("Item 1");
      }

      void vToolTip002_Click(object sender1, EventArgs e1) {
        MessageBox.Show("Item 2");
      }


      ToolStripMenuItem desenhaMenuItem(string text, string nomeImagem) {
        var itemMenu = new ToolStripMenuItem();
        itemMenu.Text = text;

        var myImage = (Image)global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(nomeImagem);
        itemMenu.Image = myImage;

        return itemMenu;
      }



    }
  }
}
