using CursoWindowsFormsBiblioteca;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CursoWindowsForms {
  public partial class Frm_ValidaSenha : Form {
    bool VerSenhaTxt = false;
    public Frm_ValidaSenha() {
      InitializeComponent();
    }

    private void Btn_Reset_Click(object sender, EventArgs e) {
      Lbl_Resultado.Text = "";
      Txt_Senha.Text = "";
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

    private void Btn_VerSenha_Click(object sender, EventArgs e) {
      if (VerSenhaTxt == false) {
        //Representa o caractere vazio \0
        Txt_Senha.PasswordChar = '\0';
        VerSenhaTxt = true;
        Btn_VerSenha.Text = "Esconder Senha";
      } else {
        Txt_Senha.PasswordChar = '*';
        VerSenhaTxt = false;
        Btn_VerSenha.Text = "Mostrar Senha";
      }

    }

    private void Lbl_Resultado_Click(object sender, EventArgs e) {

    }
  }
}
