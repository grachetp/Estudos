using System;
using System.Windows.Forms;

namespace CursoWindowsForms {
  public partial class Frm_PrincipalMenu : Form {
    public Frm_PrincipalMenu() {
      InitializeComponent();
    }

    private void DemonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e) {
      var f = new Frm_DemonstracaoKey();
      f.ShowDialog();
    }

    private void HelloWorldToolStripMenuItem_Click(object sender, EventArgs e) {
      var f = new Frm_HelloWorld();
      f.ShowDialog();

      //string resultado = f.DialogResult.ToString();
      //MessageBox.Show(resultado);

      //f.Show();
    }

    private void MáscaraToolStripMenuItem_Click(object sender, EventArgs e) {
      var f = new Frm_Mascara();
      f.ShowDialog();
    }

    private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e) {
      var f = new Frm_ValidaCPF();
      f.ShowDialog();
    }

    private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e) {
      var f = new Frm_ValidaCPF2();
      f.ShowDialog();
    }

    private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e) {
      var f = new Frm_ValidaSenha();
      f.ShowDialog();
    }

    private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
      Application.Exit();
    }
  }
}
