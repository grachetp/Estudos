using System;
using System.Windows.Forms;

namespace CursoWindowsForms.Formulários___Curso_2 {
  public partial class Frm_Login : Form {

    public string senha;
    public string login;

    public Frm_Login() {
      InitializeComponent();
      lblLogin.Text = "Login";
      lblPass.Text = "Senha";
      btnCancel.Text = "Cancel";
      btnOK.Text = "OK";
      txtSenha.PasswordChar = '*';
    }

    private void btnOK_Click(object sender, EventArgs e) {
      DialogResult = DialogResult.OK;
      login = txtLogin.Text;
      senha = txtSenha.Text;
      this.Close();
    }

    private void btnCancel_Click(object sender, EventArgs e) {
      DialogResult = DialogResult.Cancel;
      this.Close();
    }

    private void txtLogin_KeyPress(object sender, KeyPressEventArgs e) {
      if (e.KeyChar == (char)13) {
        this.ProcessTabKey(true);
        e.Handled = true;
      }
    }

    private void txtSenha_KeyPress(object sender, KeyPressEventArgs e) {
      if (e.KeyChar == (char)13) {
        this.ProcessTabKey(true);
        e.Handled = true;
      }
    }

    private void label1_Click(object sender, EventArgs e) {

    }

    private void label2_Click(object sender, EventArgs e) {

    }
  }
}
