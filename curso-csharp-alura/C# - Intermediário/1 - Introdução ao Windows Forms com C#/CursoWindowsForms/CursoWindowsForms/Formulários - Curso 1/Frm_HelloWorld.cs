using System;
using System.Windows.Forms;

namespace CursoWindowsForms {
  public partial class Frm_HelloWorld : Form {
    public Frm_HelloWorld() {
      InitializeComponent();
    }

    private void HelloWorld_Load(object sender, EventArgs e) {

    }

    private void lbl_Titulo_Click(object sender, EventArgs e) {

    }

    private void btnSair_Click(object sender, EventArgs e) {
      this.Close();
    }

    private void btnModificaLabel_Click(object sender, EventArgs e) {
      this.lblTitulo.Text = txtConteudoLabel.Text;
    }

    private void txtConteudoLabel_TextChanged(object sender, EventArgs e) {

    }

    private void lblTitulo_Click(object sender, EventArgs e) {

    }
  }
}
