using System;
using System.Windows.Forms;

namespace CursoWindowsForms {
  public partial class Frm_HelloWorld_UC : UserControl {
    public Frm_HelloWorld_UC() {
      InitializeComponent();
    }

    private void btnModificaLabel_Click(object sender, EventArgs e) {
      this.lblTitulo.Text = txtConteudoLabel.Text;
    }
  }
}
