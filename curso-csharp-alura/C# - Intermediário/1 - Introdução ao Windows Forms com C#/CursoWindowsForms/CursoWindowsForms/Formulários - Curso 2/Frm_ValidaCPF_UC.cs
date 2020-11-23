using CursoWindowsFormsBiblioteca;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CursoWindowsForms.Formuláris___Curso_2 {
  public partial class Frm_ValidaCPF_UC : UserControl {
    public Frm_ValidaCPF_UC() {
      InitializeComponent();
    }

    private void Btn_Reset_Click(object sender, EventArgs e) {
      Lbl_Resultado.Text = "";
      Msk_CPF.Text = "";
    }

    private void Btn_Valida_Click(object sender, EventArgs e) {
      var validaCPF = false;
      validaCPF = Cls_Uteis.Valida(Msk_CPF.Text);
      if (validaCPF == true) {
        Lbl_Resultado.Text = "CPF Válido";
        Lbl_Resultado.ForeColor = Color.Green;
      } else {
        Lbl_Resultado.Text = "CPF Inválido";
        Lbl_Resultado.ForeColor = Color.Red;
      }
    }
  }
}
