﻿using CursoWindowsFormsBiblioteca;
using System;
using System.Windows.Forms;

namespace CursoWindowsForms {
  public partial class Frm_ValidaCPF2 : Form {
    public Frm_ValidaCPF2() {
      InitializeComponent();
    }

    private void Btn_Reset_Click(object sender, EventArgs e) {
      Msk_CPF.Text = "";
    }

    private void Btn_Valida_Click(object sender, EventArgs e) {
      string vConteudo;
      vConteudo = Msk_CPF.Text;
      vConteudo = vConteudo.Replace(".", "").Replace("-", "").Replace(" ", "");
      vConteudo = vConteudo.Trim();
      if (vConteudo == "" || vConteudo.Length < 11) {
        MessageBox.Show("Você deve digitar um CPF com 11 dígitos", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
      } else {
        if (MessageBox.Show("Você deseja realmente validar o CPF?", "Mensagem de Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
          var validaCPF = false;
          validaCPF = Cls_Uteis.Valida(Msk_CPF.Text);
          if (validaCPF == true) {
            MessageBox.Show("CPF Válido", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
          } else {
            MessageBox.Show("CPF Inválido", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }
      }
    }

    private void Msk_CPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {

    }
  }
}
