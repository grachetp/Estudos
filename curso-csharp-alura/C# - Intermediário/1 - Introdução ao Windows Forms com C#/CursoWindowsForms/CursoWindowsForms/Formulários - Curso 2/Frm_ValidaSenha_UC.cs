using CursoWindowsFormsBiblioteca;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CursoWindowsForms.Formuláris___Curso_2 {
  public partial class Frm_ValidaSenha_UC : UserControl {
    public Frm_ValidaSenha_UC() {
      InitializeComponent();
    }

    private void Btn_Reset_Click(object sender, EventArgs e) {
      Lbl_Resultado.Text = "";
      Txt_Senha.Text = "";
    }

    private void Btn_VerSenha_Click(object sender, EventArgs e) {

    }

    private void Txt_Senha_KeyDown(object sender, KeyEventArgs e) {
      var verifica = new Cls_Uteis.ChecaForcaSenha();
      Cls_Uteis.ChecaForcaSenha.ForcaDaSenha forca;
      forca = verifica.GetForcaDaSenha(Txt_Senha.Text);
      Lbl_Resultado.Text = forca.ToString();
      if (Lbl_Resultado.Text == "Inaceitavel" || Lbl_Resultado.Text == "Fraca") {
        Lbl_Resultado.ForeColor = Color.Red;
      }
      if (Lbl_Resultado.Text == "Aceitavel") {
        Lbl_Resultado.ForeColor = Color.Blue;
      }
      if (Lbl_Resultado.Text == "Forte" || Lbl_Resultado.Text == "Segura") {
        Lbl_Resultado.ForeColor = Color.Green;
      }
    }
  }
}
