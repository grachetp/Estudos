namespace CursoWindowsForms
{
  partial class Frm_HelloWorld
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HelloWorld));
      this.lblTitulo = new System.Windows.Forms.Label();
      this.btnSair = new System.Windows.Forms.Button();
      this.btnModificaLabel = new System.Windows.Forms.Button();
      this.txtConteudoLabel = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // lblTitulo
      // 
      this.lblTitulo.AutoSize = true;
      this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitulo.Location = new System.Drawing.Point(53, 29);
      this.lblTitulo.Name = "lblTitulo";
      this.lblTitulo.Size = new System.Drawing.Size(259, 24);
      this.lblTitulo.TabIndex = 0;
      this.lblTitulo.Text = "Visual Studio .NET Version";
      this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
      // 
      // btnSair
      // 
      this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSair.Location = new System.Drawing.Point(210, 263);
      this.btnSair.Name = "btnSair";
      this.btnSair.Size = new System.Drawing.Size(152, 22);
      this.btnSair.TabIndex = 1;
      this.btnSair.Text = "Fechar a Aplicação";
      this.btnSair.UseVisualStyleBackColor = true;
      this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
      // 
      // btnModificaLabel
      // 
      this.btnModificaLabel.Location = new System.Drawing.Point(57, 58);
      this.btnModificaLabel.Name = "btnModificaLabel";
      this.btnModificaLabel.Size = new System.Drawing.Size(177, 25);
      this.btnModificaLabel.TabIndex = 2;
      this.btnModificaLabel.Text = "Modifica Texto do Label";
      this.btnModificaLabel.UseVisualStyleBackColor = true;
      this.btnModificaLabel.Click += new System.EventHandler(this.btnModificaLabel_Click);
      // 
      // txtConteudoLabel
      // 
      this.txtConteudoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtConteudoLabel.Location = new System.Drawing.Point(57, 89);
      this.txtConteudoLabel.Name = "txtConteudoLabel";
      this.txtConteudoLabel.Size = new System.Drawing.Size(255, 20);
      this.txtConteudoLabel.TabIndex = 3;
      this.txtConteudoLabel.TextChanged += new System.EventHandler(this.txtConteudoLabel_TextChanged);
      // 
      // Frm_HelloWorld
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(374, 297);
      this.Controls.Add(this.txtConteudoLabel);
      this.Controls.Add(this.btnModificaLabel);
      this.Controls.Add(this.btnSair);
      this.Controls.Add(this.lblTitulo);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Frm_HelloWorld";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Hello World";
      this.Load += new System.EventHandler(this.HelloWorld_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblTitulo;
    private System.Windows.Forms.Button btnSair;
    private System.Windows.Forms.Button btnModificaLabel;
    private System.Windows.Forms.TextBox txtConteudoLabel;
  }
}