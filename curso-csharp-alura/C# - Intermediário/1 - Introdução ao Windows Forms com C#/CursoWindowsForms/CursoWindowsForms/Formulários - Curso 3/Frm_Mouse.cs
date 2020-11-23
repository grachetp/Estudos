using System;
using System.Windows.Forms;

namespace CursoWindowsForms {
  public partial class Frm_Mouse : Form {
    public Frm_Mouse() {
      InitializeComponent();
    }

    private void btnMouse_MouseEnter(object sender, EventArgs e) {
      btnMouse.Text = "Mouse enter!";
    }

    private void btnMouse_MouseLeave(object sender, EventArgs e) {
      btnMouse.Text = "Mouse Leave";
    }

    private void btnMouse_MouseHover(object sender, EventArgs e) {
      btnMouse.Text = "Mouse Hover";
    }

    private void btnMouse_MouseDown(object sender, MouseEventArgs e) {
      btnMouse.Text = "Mouse Down!";
    }

    private void btnMouse_MouseUp(object sender, MouseEventArgs e) {
      btnMouse.Text = "Mouse Up";
    }
  }
}
