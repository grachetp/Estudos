﻿namespace CursoWindowsForms {
  partial class Frm_PrincipalMenu {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PrincipalMenu));
      this.Mnu_Principal = new System.Windows.Forms.MenuStrip();
      this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.demonstracaoKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helloWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mascaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.validaCPFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.validaCPF2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.validaSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.Mnu_Principal.SuspendLayout();
      this.SuspendLayout();
      // 
      // Mnu_Principal
      // 
      this.Mnu_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.windowsToolStripMenuItem});
      this.Mnu_Principal.Location = new System.Drawing.Point(0, 0);
      this.Mnu_Principal.Name = "Mnu_Principal";
      this.Mnu_Principal.Size = new System.Drawing.Size(410, 24);
      this.Mnu_Principal.TabIndex = 0;
      this.Mnu_Principal.Text = "menuStrip1";
      // 
      // arquivoToolStripMenuItem
      // 
      this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.sairToolStripMenuItem});
      this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
      this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
      this.arquivoToolStripMenuItem.Text = "Arquivo";
      // 
      // novoToolStripMenuItem
      // 
      this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.demonstracaoKeyToolStripMenuItem,
            this.helloWorldToolStripMenuItem,
            this.mascaraToolStripMenuItem,
            this.validaCPFToolStripMenuItem,
            this.validaCPF2ToolStripMenuItem,
            this.validaSenhaToolStripMenuItem});
      this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
      this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.novoToolStripMenuItem.Text = "Novo";
      // 
      // demonstracaoKeyToolStripMenuItem
      // 
      this.demonstracaoKeyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("demonstracaoKeyToolStripMenuItem.Image")));
      this.demonstracaoKeyToolStripMenuItem.Name = "demonstracaoKeyToolStripMenuItem";
      this.demonstracaoKeyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.K)));
      this.demonstracaoKeyToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
      this.demonstracaoKeyToolStripMenuItem.Text = "Demonstração &Key";
      this.demonstracaoKeyToolStripMenuItem.Click += new System.EventHandler(this.DemonstraçãoKeyToolStripMenuItem_Click);
      // 
      // helloWorldToolStripMenuItem
      // 
      this.helloWorldToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_HelloWorld;
      this.helloWorldToolStripMenuItem.Name = "helloWorldToolStripMenuItem";
      this.helloWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
      this.helloWorldToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
      this.helloWorldToolStripMenuItem.Text = "Hello &World";
      this.helloWorldToolStripMenuItem.Click += new System.EventHandler(this.HelloWorldToolStripMenuItem_Click);
      // 
      // mascaraToolStripMenuItem
      // 
      this.mascaraToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_Mascara;
      this.mascaraToolStripMenuItem.Name = "mascaraToolStripMenuItem";
      this.mascaraToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
      this.mascaraToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
      this.mascaraToolStripMenuItem.Text = "&Máscara";
      this.mascaraToolStripMenuItem.Click += new System.EventHandler(this.MáscaraToolStripMenuItem_Click);
      // 
      // validaCPFToolStripMenuItem
      // 
      this.validaCPFToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_ValidaCPF;
      this.validaCPFToolStripMenuItem.Name = "validaCPFToolStripMenuItem";
      this.validaCPFToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
      this.validaCPFToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
      this.validaCPFToolStripMenuItem.Text = "Valída &CPF";
      this.validaCPFToolStripMenuItem.Click += new System.EventHandler(this.validaCPFToolStripMenuItem_Click);
      // 
      // validaCPF2ToolStripMenuItem
      // 
      this.validaCPF2ToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_ValidaCPF2;
      this.validaCPF2ToolStripMenuItem.Name = "validaCPF2ToolStripMenuItem";
      this.validaCPF2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
      this.validaCPF2ToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
      this.validaCPF2ToolStripMenuItem.Text = "Valída C&PF 2";
      this.validaCPF2ToolStripMenuItem.Click += new System.EventHandler(this.validaCPF2ToolStripMenuItem_Click);
      // 
      // validaSenhaToolStripMenuItem
      // 
      this.validaSenhaToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_ValidaSenha;
      this.validaSenhaToolStripMenuItem.Name = "validaSenhaToolStripMenuItem";
      this.validaSenhaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
      this.validaSenhaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
      this.validaSenhaToolStripMenuItem.Text = "Valída &Senha";
      this.validaSenhaToolStripMenuItem.Click += new System.EventHandler(this.validaSenhaToolStripMenuItem_Click);
      // 
      // sairToolStripMenuItem
      // 
      this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
      this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.sairToolStripMenuItem.Text = "Sair";
      this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
      // 
      // windowsToolStripMenuItem
      // 
      this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
      this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
      this.windowsToolStripMenuItem.Text = "Windows";
      // 
      // Frm_PrincipalMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(410, 318);
      this.Controls.Add(this.Mnu_Principal);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Frm_PrincipalMenu";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Principal";
      this.Mnu_Principal.ResumeLayout(false);
      this.Mnu_Principal.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip Mnu_Principal;
    private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem demonstracaoKeyToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helloWorldToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem mascaraToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem validaCPFToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem validaCPF2ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem validaSenhaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
  }
}