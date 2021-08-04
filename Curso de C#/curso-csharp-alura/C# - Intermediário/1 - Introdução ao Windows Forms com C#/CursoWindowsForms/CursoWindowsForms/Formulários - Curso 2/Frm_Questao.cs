using System;
using System.Drawing;
using System.Windows.Forms;

namespace CursoWindowsForms {
  public partial class Frm_Questao : Form {
    public Frm_Questao(string imagem, string mensagem) {
      InitializeComponent();
      var myImage = (Image)global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(imagem);
      Pic_Imagem.Image = myImage;
      Lbl_Questao.Text = mensagem;

    }

    private void Btn_OK_Click(object sender, EventArgs e) {
      DialogResult = DialogResult.Yes;
      this.Close();
    }

    private void Btn_Cancel_Click(object sender, EventArgs e) {
      DialogResult = DialogResult.Cancel;
      this.Close();
    }
  }
}
