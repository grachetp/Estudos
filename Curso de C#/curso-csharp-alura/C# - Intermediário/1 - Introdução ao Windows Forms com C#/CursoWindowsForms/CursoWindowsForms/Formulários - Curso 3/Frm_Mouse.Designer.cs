namespace CursoWindowsForms {
  partial class Frm_Mouse {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.btnMouse = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnMouse
      // 
      this.btnMouse.Location = new System.Drawing.Point(140, 136);
      this.btnMouse.Name = "btnMouse";
      this.btnMouse.Size = new System.Drawing.Size(251, 105);
      this.btnMouse.TabIndex = 0;
      this.btnMouse.UseVisualStyleBackColor = true;
      this.btnMouse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMouse_MouseDown);
      this.btnMouse.MouseEnter += new System.EventHandler(this.btnMouse_MouseEnter);
      this.btnMouse.MouseLeave += new System.EventHandler(this.btnMouse_MouseLeave);
      this.btnMouse.MouseHover += new System.EventHandler(this.btnMouse_MouseHover);
      this.btnMouse.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMouse_MouseUp);
      // 
      // Frm_Mouse
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(538, 403);
      this.Controls.Add(this.btnMouse);
      this.Name = "Frm_Mouse";
      this.Text = "Frm_Mouse";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnMouse;
  }
}