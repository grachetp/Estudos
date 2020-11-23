using System;
using System.Windows.Forms;

//MDI - Multiple Document Interface
//Criar varias janelas dentro da janela pai.
//Formulário > Propriedades > isMdiContainer = true

//var f = new Frm_DemonstracaoKey(); -> Instancia o formulario
//f.MdiParent = this; -> diz que ele é filho do formulario atual
//f.Show(); -> mostra formulário dentro como MDI

namespace CursoWindowsForms {
  public partial class Frm_PrincipalMenu_MDI : Form {
    public Frm_PrincipalMenu_MDI() {
      InitializeComponent();
    }

    private void DemonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e) {
      var f = new Frm_DemonstracaoKey();
      f.MdiParent = this;
      f.Show();
    }

    private void HelloWorldToolStripMenuItem_Click(object sender, EventArgs e) {
      var f = new Frm_HelloWorld();
      f.MdiParent = this;
      f.Show();
    }

    private void MáscaraToolStripMenuItem_Click(object sender, EventArgs e) {
      var f = new Frm_Mascara();
      f.MdiParent = this;
      f.Show();
    }

    private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e) {
      var f = new Frm_ValidaCPF();
      f.MdiParent = this;
      f.Show();
    }

    private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e) {
      var f = new Frm_ValidaCPF2();
      f.MdiParent = this;
      f.Show();
    }

    private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e) {
      var f = new Frm_ValidaSenha();
      f.MdiParent = this;
      f.Show();
    }

    private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
      Application.Exit();
    }

    private void cascataToolStripMenuItem_Click(object sender, EventArgs e) {
      this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
    }

    private void horizontalToolStripMenuItem_Click(object sender, EventArgs e) {
      this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
    }

    private void verticalToolStripMenuItem_Click(object sender, EventArgs e) {
      this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
    }
  }
}
