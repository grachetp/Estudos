using CursoWindowsForms.Formulários___Curso_2;
using CursoWindowsForms.Formuláris___Curso_2;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CursoWindowsForms {
  public partial class Frm_Principal_Menu_UC : Form {
    int controleCAD = 0;
    int controleHW = 0;
    int controleDK = 0;
    int controleM = 0;
    int controleCPF = 0;
    int controleCPF2 = 0;
    int validaSenha = 0;
    int controleImagem = 0;

    public Frm_Principal_Menu_UC() {
      InitializeComponent();
      Desconectado();
      conectarToolStripMenuItem_Click();

    }

    private void Conectado() {
      conectarToolStripMenuItem.Enabled = false;
      novoToolStripMenuItem.Enabled = true;
      apagarAbaToolStripMenuItem.Enabled = true;
      abrirImagemToolStripMenuItem.Enabled = true;
      desconectarToolStripMenuItem.Enabled = true;
      byteBankToolStripMenuItem.Enabled = true;
    }

    private void Desconectado() {
      novoToolStripMenuItem.Enabled = false;
      apagarAbaToolStripMenuItem.Enabled = false;
      abrirImagemToolStripMenuItem.Enabled = false;
      desconectarToolStripMenuItem.Enabled = false;
      byteBankToolStripMenuItem.Enabled = false;
      conectarToolStripMenuItem.Enabled = true;
    }


    private void DemonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e) {
      controleDK++;
      var u = new Frm_DemonstracaoKey_UC();
      u.Dock = DockStyle.Fill;
      var tb = new TabPage();
      tb.Name = "Demonstração Key " + controleDK;
      tb.Text = "Demonstração Key " + controleDK;
      tb.ImageIndex = 0;
      tb.Controls.Add(u);
      Tbc_Aplicacoes.TabPages.Add(tb);
    }

    private void HelloWorldToolStripMenuItem_Click(object sender, EventArgs e) {
      controleHW++;
      var u = new Frm_HelloWorld_UC();
      u.Dock = DockStyle.Fill;
      var tb = new TabPage();
      tb.Name = "Hello World " + controleHW;
      tb.Text = "Hello World " + controleHW;
      tb.ImageIndex = 1;
      tb.Controls.Add(u);
      Tbc_Aplicacoes.TabPages.Add(tb);
    }

    private void MáscaraToolStripMenuItem_Click(object sender, EventArgs e) {
      controleM++;
      var u = new Frm_Mascara_UC();
      u.Dock = DockStyle.Fill;
      var tb = new TabPage();
      tb.Name = "Máscara " + controleM;
      tb.Text = "Máscara " + controleM;
      tb.ImageIndex = 2;
      tb.Controls.Add(u);
      Tbc_Aplicacoes.TabPages.Add(tb);
    }

    private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e) {
      controleCPF++;
      var u = new Frm_ValidaCPF_UC();
      u.Dock = DockStyle.Fill;
      var tb = new TabPage();
      tb.Name = "Valída CFP" + controleCPF;
      tb.Text = "Valída CFP" + controleCPF;
      tb.ImageIndex = 3;
      tb.Controls.Add(u);
      Tbc_Aplicacoes.TabPages.Add(tb);
    }

    private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e) {
      var u = new Frm_ValidaCPF2_UC();
      u.Dock = DockStyle.Fill;
      var tb = new TabPage();
      tb.Name = "Valída CPF 2" + controleCPF2;
      tb.Text = "Valída CPF 2" + controleCPF2;
      tb.ImageIndex = 4;
      tb.Controls.Add(u);
      Tbc_Aplicacoes.TabPages.Add(tb);
      controleCPF2++;
    }

    private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e) {
      validaSenha++;
      var u = new Frm_ValidaSenha_UC();
      u.Dock = DockStyle.Fill;
      var tb = new TabPage();
      tb.Name = "Valída Senha" + validaSenha;
      tb.Text = "Valída Senha" + validaSenha;
      tb.ImageIndex = 5;
      tb.Controls.Add(u);
      Tbc_Aplicacoes.TabPages.Add(tb);
    }

    private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
      Application.Exit();
    }

    private void apagarAbaToolStripMenuItem_Click(object sender, EventArgs e) {
      if (!(Tbc_Aplicacoes.SelectedTab == null)) {
        apagaAba(Tbc_Aplicacoes.SelectedTab);
      }
    }


    private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e) {
      var db = new OpenFileDialog();
      db.InitialDirectory = "C:\\Users\\pedro\\Documents\\GitHub\\Curso C# - Alura\\C# - Intermediário\\1 - Introdução ao Windows Forms com C#\\CursoWindowsForms\\CursoWindowsForms\\Imagens";
      db.Filter = "png|*.png";
      db.Title = "Escolha a imagem";

      if (db.ShowDialog() == DialogResult.OK) {
        string nomeArquivo = db.FileName;

        controleImagem++;
        var u = new Frm_ArquivoImagem_UC(nomeArquivo);
        u.Dock = DockStyle.Fill;
        var tb = new TabPage();
        tb.Name = "Imagem " + controleImagem;
        tb.Text = "Imagem " + controleImagem;
        tb.ImageIndex = 6;
        tb.Controls.Add(u);
        Tbc_Aplicacoes.TabPages.Add(tb);
      }
    }

    private void conectarToolStripMenuItem_Click(object sender, EventArgs e) {
      var Flogin = new Frm_Login();
      Flogin.ShowDialog();

      if (Flogin.DialogResult == DialogResult.OK) {

        string login = Flogin.login;
        string senha = Flogin.senha;

        if (CursoWindowsFormsBiblioteca.Cls_Uteis.validaSenhaLogin(senha) == true) {
          //substitutir conectado = true; 
          Conectado();
          //Descrição: Caixa de mensagem(textoDaMensagem, tituloJanela, BotãoDentro, iconeDentro)
          MessageBox.Show("Bem vindo: " + login, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } else {
          MessageBox.Show("Senha Inválida", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


      }
    }

    private void conectarToolStripMenuItem_Click() {
      //var Flogin = new Frm_Login();
      //Flogin.ShowDialog();

      //if (Flogin.DialogResult == DialogResult.OK) {

      //  string login = Flogin.login;
      //  string senha = Flogin.senha;

      //  if (CursoWindowsFormsBiblioteca.Cls_Uteis.validaSenhaLogin(senha) == true) {
      //    Conectado();
      //    //Descrição: Caixa de mensagem(textoDaMensagem, tituloJanela, BotãoDentro, iconeDentro)
      //    MessageBox.Show("Bem vindo: " + login, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
      //  } else {
      //    MessageBox.Show("Senha Inválida", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
      //  }
      //}
      Conectado();
    }

    private void desconectarToolStripMenuItem_Click(object sender, EventArgs e) {
      var Db = new Frm_Questao("question1", "Você deseja se descontar?");
      Db.ShowDialog();

      if (Db.DialogResult == DialogResult.Yes) {
        foreach (TabPage page in Tbc_Aplicacoes.TabPages) {
          apagaAba(page);
        }
        Desconectado();
      }
    }

    private void Tbc_Aplicacoes_MouseDown(object sender, MouseEventArgs e) {
      if (e.Button == System.Windows.Forms.MouseButtons.Right) {
        //var posX = e.X;
        //var posY = e.Y;
        //MessageBox.Show($"Clique com o botão direito do mouse!.\nA posição relativa foi:\nX: {posX}\nY:{posY}");

        //Fazer menu com opcoes cascata
        //ToolStripDropDownItem menu;
        //menu = new ToolStripMenuItem("Ajuda");
        //menu.DropDownItems.Add("Teste1");
        //menu.DropDownItems.Add("Teste2");

        var contextMenu = new ContextMenuStrip();
        var vToolTip001 = desenhaMenuItem("Apagar Aba", "DeleteTab");
        var vToolTip002 = desenhaMenuItem("Apagar todas a esquerda", "DeleteLeft");
        var vToolTip003 = desenhaMenuItem("Apagar todas a direita", "DeleteRight");
        var vToolTip004 = desenhaMenuItem("Apagar todas menos esta", "DeleteAll");
        var vToolTip005 = desenhaMenuItem("Apagar todas as abas", "DeleteAll");
        contextMenu.Items.Add(vToolTip001);
        contextMenu.Items.Add(vToolTip002);
        contextMenu.Items.Add(vToolTip003);
        contextMenu.Items.Add(vToolTip004);
        contextMenu.Items.Add(vToolTip005);
        contextMenu.Show(this, new Point(e.X, e.Y));

        //adicionando evento no item do menu
        vToolTip001.Click += new System.EventHandler(vToolTip001_Click);
        vToolTip002.Click += new System.EventHandler(vToolTip002_Click);
        vToolTip003.Click += new System.EventHandler(vToolTip003_Click);
        vToolTip004.Click += new System.EventHandler(vToolTip004_Click);
        vToolTip005.Click += new System.EventHandler(vToolTip005_Click);

      }
    }

    //Funçao pra dar acão
    void vToolTip001_Click(object sender1, EventArgs e1) {
      if (!(Tbc_Aplicacoes.SelectedTab == null)) {
        apagaAba(Tbc_Aplicacoes.SelectedTab);
      }
    }

    void vToolTip002_Click(object sender1, EventArgs e1) {
      if (!(Tbc_Aplicacoes.SelectedTab == null)) {
        apagaEsqueda(Tbc_Aplicacoes.SelectedIndex);
      }
    }

    void vToolTip003_Click(object sender1, EventArgs e1) {
      if (!(Tbc_Aplicacoes.SelectedTab == null)) {
        apagaDireita(Tbc_Aplicacoes.SelectedIndex);
      }
    }

    void vToolTip004_Click(object sender1, EventArgs e1) {
      if (!(Tbc_Aplicacoes.SelectedTab == null)) {
        apagaDireita(Tbc_Aplicacoes.SelectedIndex);
        apagaEsqueda(Tbc_Aplicacoes.SelectedIndex);
      }
    }


    void apagaDireita(int itemSelecionado) {
      for (int i = Tbc_Aplicacoes.TabCount - 1; i > itemSelecionado; i--) {
        apagaAba(Tbc_Aplicacoes.TabPages[i]);
      }
    }

    void apagaEsqueda(int itemSelecionado) {
      for (int i = itemSelecionado - 1; i >= 0; i--) {
        apagaAba(Tbc_Aplicacoes.TabPages[i]);
      }
    }

    void vToolTip005_Click(object sender1, EventArgs e1) {
      for (int i = Tbc_Aplicacoes.TabCount - 1; i >= 0; i--) {
        apagaAba(Tbc_Aplicacoes.TabPages[i]);
      }
    }


    ToolStripMenuItem desenhaMenuItem(string text, string nomeImagem) {
      var itemMenu = new ToolStripMenuItem();
      itemMenu.Text = text;

      var myImage = (Image)global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(nomeImagem);
      itemMenu.Image = myImage;

      return itemMenu;
    }

    private void clientesToolStripMenuItem_Click(object sender, EventArgs e) {
      if (controleCAD == 0) {
        controleCAD++;
        var u = new Frm_Cadastro_Cliente_UC();
        u.Dock = DockStyle.Fill;
        var tb = new TabPage();
        tb.Name = "Cadastro Usuário";
        tb.Text = "Cadastro Usuário";
        tb.ImageIndex = 7;
        tb.Controls.Add(u);
        Tbc_Aplicacoes.TabPages.Add(tb);
      } else {
        //MessageBox.Show(Texto, Titulo, Botão, Icone)
        MessageBox.Show("Não posso abrir o cadastro de clientes. Já está aberto", "Banco ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }

    }

    void apagaAba(TabPage TB) {

      if (TB.Name == "Cadastro Usuário") {
        controleCAD = 0;
      }

      Tbc_Aplicacoes.TabPages.Remove(TB);
    }
  }
}
