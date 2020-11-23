using System.Windows.Forms;

namespace CursoWindowsForms {
  public partial class Frm_Caputura_Mouse : Form {
    public Frm_Caputura_Mouse() {
      InitializeComponent();
    }

    private void btnMouse_MouseDown(object sender, MouseEventArgs e) {
      string str1 = e.Button.ToString();
      MessageBox.Show("Foi pressionado o butão da(o) " + str1);
    }
  }
}
