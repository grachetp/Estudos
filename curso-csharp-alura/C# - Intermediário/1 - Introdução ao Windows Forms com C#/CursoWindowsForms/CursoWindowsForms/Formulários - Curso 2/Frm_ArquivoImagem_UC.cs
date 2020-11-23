using System;
using System.Drawing;
using System.Windows.Forms;

namespace CursoWindowsForms {
  public partial class Frm_ArquivoImagem_UC : UserControl {
    public Frm_ArquivoImagem_UC(string imagem) {
      InitializeComponent();
      label1.Text = imagem;
      Pic_ArquivoImagem.Image = Image.FromFile(imagem);
    }

    private void pictureBox1_Click(object sender, EventArgs e) {

    }

    private void Btn_Cor_Click(object sender, EventArgs e) {
      var cDB = new ColorDialog();
      if (cDB.ShowDialog() == DialogResult.OK) {
        label1.ForeColor = cDB.Color;
      }
    }

    private void Btn_Fonte_Click(object sender, EventArgs e) {
      var fDB = new FontDialog();
      if (fDB.ShowDialog() == DialogResult.OK) {
        label1.Font = fDB.Font;
      }
    }
  }
}
