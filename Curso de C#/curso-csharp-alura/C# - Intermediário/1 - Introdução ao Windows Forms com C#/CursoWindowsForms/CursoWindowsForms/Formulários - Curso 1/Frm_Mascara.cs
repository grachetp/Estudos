﻿using System;
using System.Windows.Forms;

//FormBorderStyle -> resposável por alterar a  janela

namespace CursoWindowsForms {
  public partial class Frm_Mascara : Form {
    public Frm_Mascara() {
      InitializeComponent();
    }

    private void Frm_Mascara_Load(object sender, EventArgs e) {

    }

    private void Btn_Hora_Click(object sender, EventArgs e) {
      Msk_TextBox.UseSystemPasswordChar = false; //Máscara do sistema para senhas
      Lbl_Conteudo.Text = "";
      Msk_TextBox.Mask = "00:00"; //Definir o formato da máscara
      Lbl_MascaraAtiva.Text = Msk_TextBox.Mask; //Definir a propriedade da Máscara
      Msk_TextBox.Text = "";
      Msk_TextBox.Focus(); //Focar o cursor no Msk
    }

    private void button5_Click(object sender, EventArgs e) {
      Lbl_Conteudo.Text = Msk_TextBox.Text;
    }

    private void Btn_CEP_Click(object sender, EventArgs e) {
      Msk_TextBox.UseSystemPasswordChar = false;
      Lbl_Conteudo.Text = "";
      Msk_TextBox.Mask = "00000-000"; //Definir o formato da máscara
      Lbl_MascaraAtiva.Text = Msk_TextBox.Mask; //Definir a propriedade da Máscara
      Msk_TextBox.Text = "";
      Msk_TextBox.Focus(); //Focar o cursor no Msk
    }

    private void Btn_Moeda_Click(object sender, EventArgs e) {
      Msk_TextBox.UseSystemPasswordChar = false;
      Lbl_Conteudo.Text = "";
      Msk_TextBox.Mask = "$ 000,000,000.00"; //Definir o formato da máscara
      Lbl_MascaraAtiva.Text = Msk_TextBox.Mask; //Definir a propriedade da Máscara
      Msk_TextBox.Text = "";
      Msk_TextBox.Focus(); //Focar o cursor no Msk
    }

    private void Btn_Data_Click(object sender, EventArgs e) {
      Msk_TextBox.UseSystemPasswordChar = false;
      Lbl_Conteudo.Text = "";
      Msk_TextBox.Mask = "00/00/0000"; //Definir o formato da máscara
      Lbl_MascaraAtiva.Text = Msk_TextBox.Mask; //Definir a propriedade da Máscara
      Msk_TextBox.Text = "";
      Msk_TextBox.Focus(); //Focar o cursor no Msk
    }

    private void Btn_Telefone_Click(object sender, EventArgs e) {
      Msk_TextBox.UseSystemPasswordChar = false;
      Lbl_Conteudo.Text = "";
      Msk_TextBox.Mask = "(00) 0 0000-0000"; //Definir o formato da máscara
      Lbl_MascaraAtiva.Text = Msk_TextBox.Mask; //Definir a propriedade da Máscara
      Msk_TextBox.Text = "";
      Msk_TextBox.Focus(); //Focar o cursor no Msk
    }

    private void Btn_Senha_Click(object sender, EventArgs e) {
      Msk_TextBox.UseSystemPasswordChar = true;
      Lbl_Conteudo.Text = "";
      Msk_TextBox.Mask = "000000"; //Definir o formato da máscara
      Lbl_MascaraAtiva.Text = Msk_TextBox.Mask; //Definir a propriedade da Máscara
      Msk_TextBox.Text = "";
      Msk_TextBox.Focus(); //Focar o cursor no Msk
    }
  }
}
