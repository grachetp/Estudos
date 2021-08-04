namespace CursoWindowsForms.Formulários___Curso_2 {
  partial class Frm_Login {
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
      this.Pic_Login = new System.Windows.Forms.PictureBox();
      this.lblLogin = new System.Windows.Forms.Label();
      this.lblPass = new System.Windows.Forms.Label();
      this.txtLogin = new System.Windows.Forms.TextBox();
      this.txtSenha = new System.Windows.Forms.TextBox();
      this.btnOK = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      ((System.ComponentModel.ISupportInitialize)(this.Pic_Login)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // Pic_Login
      // 
      this.Pic_Login.Image = global::CursoWindowsForms.Properties.Resources.key;
      this.Pic_Login.Location = new System.Drawing.Point(39, 70);
      this.Pic_Login.Name = "Pic_Login";
      this.Pic_Login.Size = new System.Drawing.Size(100, 93);
      this.Pic_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.Pic_Login.TabIndex = 0;
      this.Pic_Login.TabStop = false;
      // 
      // lblLogin
      // 
      this.lblLogin.AutoSize = true;
      this.lblLogin.Location = new System.Drawing.Point(146, 79);
      this.lblLogin.Name = "lblLogin";
      this.lblLogin.Size = new System.Drawing.Size(35, 13);
      this.lblLogin.TabIndex = 1;
      this.lblLogin.Text = "label1";
      // 
      // lblPass
      // 
      this.lblPass.AutoSize = true;
      this.lblPass.Location = new System.Drawing.Point(146, 127);
      this.lblPass.Name = "lblPass";
      this.lblPass.Size = new System.Drawing.Size(35, 13);
      this.lblPass.TabIndex = 2;
      this.lblPass.Text = "label2";
      // 
      // txtLogin
      // 
      this.txtLogin.Location = new System.Drawing.Point(149, 95);
      this.txtLogin.Name = "txtLogin";
      this.txtLogin.Size = new System.Drawing.Size(153, 20);
      this.txtLogin.TabIndex = 3;
      this.txtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
      // 
      // txtSenha
      // 
      this.txtSenha.Location = new System.Drawing.Point(149, 143);
      this.txtSenha.Name = "txtSenha";
      this.txtSenha.Size = new System.Drawing.Size(153, 20);
      this.txtSenha.TabIndex = 4;
      this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
      // 
      // btnOK
      // 
      this.btnOK.Location = new System.Drawing.Point(39, 181);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(75, 23);
      this.btnOK.TabIndex = 5;
      this.btnOK.Text = "button1";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(224, 181);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 6;
      this.btnCancel.Text = "button2";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Fira Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(130, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(80, 33);
      this.label1.TabIndex = 7;
      this.label1.Text = "Login";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.panel1.Controls.Add(this.label1);
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(348, 64);
      this.panel1.TabIndex = 8;
      // 
      // Frm_Login
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(347, 238);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.txtSenha);
      this.Controls.Add(this.txtLogin);
      this.Controls.Add(this.lblPass);
      this.Controls.Add(this.lblLogin);
      this.Controls.Add(this.Pic_Login);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.KeyPreview = true;
      this.Name = "Frm_Login";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Frm_Login";
      ((System.ComponentModel.ISupportInitialize)(this.Pic_Login)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox Pic_Login;
    private System.Windows.Forms.Label lblLogin;
    private System.Windows.Forms.Label lblPass;
    private System.Windows.Forms.TextBox txtLogin;
    private System.Windows.Forms.TextBox txtSenha;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel1;
  }
}