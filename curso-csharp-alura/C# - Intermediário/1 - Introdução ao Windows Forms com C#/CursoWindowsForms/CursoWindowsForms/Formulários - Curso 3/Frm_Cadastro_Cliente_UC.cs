using CursoWindowsFormsBiblioteca.Classes;
using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using CursoWindowsFormsBiblioteca;

namespace CursoWindowsForms {
  public partial class Frm_Cadastro_Cliente_UC : UserControl {
    public Frm_Cadastro_Cliente_UC() {
      InitializeComponent();
      grpCodigo.Text = "Código";
      grpGenero.Text = "Gênero";
      grpDadosPessoais.Text = "Dados Pessoais";
      grpEndereco.Text = "Endereço";
      grpOutros.Text = "Outros";
      lblBairro.Text = "Bairro";
      lblCEP.Text = "CEP";
      lblComplemento.Text = "Complemento";
      lblCPF.Text = "CPF";
      lblEstado.Text = "Estado";
      lblLogradouro.Text = "Logradouro";
      lblNomeCliente.Text = "Nome";
      lblNomeMae.Text = "Nome da Mãe";
      lblNomePai.Text = "Nome do Pai";
      lblProfissao.Text = "Profissão";
      lblRendaFamiliar.Text = "Renda Familiar";
      lblTelefone.Text = "Telefone";
      lblCidade.Text = "Cidade";
      chkTemPai.Text = "Pai Desconhecido";
      rdbFem.Text = "Feminino";
      rdbMasc.Text = "Masculino";
      rdbInde.Text = "Indefinido";

      cbbEstados.Items.Clear();
      cbbEstados.Items.Add("Acre (AC)");
      cbbEstados.Items.Add("Alagoas (AL)");
      cbbEstados.Items.Add("Amapá (AP)");
      cbbEstados.Items.Add("Amazonas (AM)");
      cbbEstados.Items.Add("Bahia (BA)");
      cbbEstados.Items.Add("Ceará (CE)");
      cbbEstados.Items.Add("Distrito Federal (DF)");
      cbbEstados.Items.Add("Espírito Santo (ES)");
      cbbEstados.Items.Add("Goiás (GO)");
      cbbEstados.Items.Add("Maranhão (MA)");
      cbbEstados.Items.Add("Mato Grosso (MT)");
      cbbEstados.Items.Add("Mato Grosso do Sul (MS)");
      cbbEstados.Items.Add("Minas Gerais (MG)");
      cbbEstados.Items.Add("Pará (PA)");
      cbbEstados.Items.Add("Paraíba (PB)");
      cbbEstados.Items.Add("Paraná (PR)");
      cbbEstados.Items.Add("Pernambuco (PE)");
      cbbEstados.Items.Add("Piauí (PI)");
      cbbEstados.Items.Add("Rio de Janeiro (RJ)");
      cbbEstados.Items.Add("Rio Grande do Norte (RN)");
      cbbEstados.Items.Add("Rio Grande do Sul (RS)");
      cbbEstados.Items.Add("Rondônia (RO)");
      cbbEstados.Items.Add("Roraima (RR)");
      cbbEstados.Items.Add("Santa Catarina (SC)");
      cbbEstados.Items.Add("São Paulo (SP)");
      cbbEstados.Items.Add("Sergipe (SE)");
      cbbEstados.Items.Add("Tocantins (TO)");

      tslPrincipal.Items[0].ToolTipText = "Novo Cliente";
      tslPrincipal.Items[1].ToolTipText = "Buscar Cliente";
      tslPrincipal.Items[2].ToolTipText = "Salver Cliente";
      tslPrincipal.Items[3].ToolTipText = "Apagar Cliente";
      tslPrincipal.Items[4].ToolTipText = "Limpar Tela";

    }

    private void txtCPF_TextChanged(object sender, System.EventArgs e) {

    }

    private void lblCPF_Click(object sender, System.EventArgs e) {

    }

    private void txtNumeroCliente_TextChanged(object sender, System.EventArgs e) {

    }

    private void txtNomeMae_TextChanged(object sender, System.EventArgs e) {

    }

    private void lblNomeMae_Click(object sender, System.EventArgs e) {

    }

    private void chkTemPai_Click(object sender, System.EventArgs e) {
      if (chkTemPai.Checked == true) {
        txtNomePai.Enabled = false;
        txtNomePai.Text = "";
      } else {
        txtNomePai.Enabled = true;
      }
    }

    private void radioButton2_CheckedChanged(object sender, System.EventArgs e) {

    }

    private void radioButton3_CheckedChanged(object sender, System.EventArgs e) {

    }

    private void radioButton1_CheckedChanged(object sender, System.EventArgs e) {

    }

    private void novoToolStripButton_Click(object sender, System.EventArgs e) {
      try {

        var cliente = new Cliente.Unit();
        cliente = LeituraFuncionario();
        cliente.ValidaClasse();
        cliente.ValidaComplemento();
        MessageBox.Show("Classe foi inicializada sem erros!", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
      } catch (ValidationException ex) {
        MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
      } catch (Exception ex) {
        MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void abrirToolStripButton_Click(object sender, System.EventArgs e) {
      MessageBox.Show("Abrir");
    }

    private void salvarToolStripButton_Click(object sender, System.EventArgs e) {
      MessageBox.Show("Salvar");
    }

    private void ApagaStripButton1_Click(object sender, System.EventArgs e) {
      MessageBox.Show("Excluir");
    }

    private void LimparStripButton1_Click(object sender, System.EventArgs e) {
      MessageBox.Show("Limpar");
    }

    Cliente.Unit LeituraFuncionario() {
      var c = new Cliente.Unit();

      c.ID = txtCodigo.Text;
      c.Nome = txtNomeCliente.Text;
      c.NomeMae = txtNomeMae.Text;
      c.NomePai = txtNomePai.Text;
      if (chkTemPai.Checked) {
        c.NaoTemPai = true;
      } else {
        c.NaoTemPai = false;
      }
      if (rdbMasc.Checked) {
        c.Genero = "M";
      }
      if (rdbFem.Checked) {
        c.Genero = "F";
      }
      if (rdbInde.Checked) {
        c.Genero = "I";
      }
      c.CPF = txtCPF.Text;
      c.CEP = txtCEP.Text;
      c.Logradouro = txtLogradouro.Text;
      c.Complemento = txtComplemento.Text;
      c.Cidade = txtCidade.Text;
      c.Bairro = txtBairro.Text;
      if(cbbEstados.SelectedIndex < 0) {
        c.Estado = "";
      } else {
        c.Estado = cbbEstados.Items[cbbEstados.SelectedIndex].ToString();
      }
      c.Telefone = txtTelefone.Text;
      c.Profissao = txtProfissao.Text;

      if (Information.IsNumeric(txtRendaFamiliar.Text)) {
        double vRenda = Convert.ToDouble(txtRendaFamiliar.Text);
        if(vRenda < 0) {
          c.RendaFamiliar = 0;
        } else {
          c.RendaFamiliar = vRenda;
        }
      }

      return c;
    }

    private void chkTemPai_CheckedChanged(object sender, EventArgs e) {

    }

    private void txtCEP_Leave(object sender, EventArgs e) {


      if(txtCEP.Text != "") {
        if(txtCEP.Text.Length == 8) {
          if (Information.IsNumeric(txtCEP.Text)) {
            var vJson = Cls_Uteis.GeraJSONCEP(txtCEP.Text);
            var CEP = new Cep.Unit();
            CEP = Cep.DesSerializedClassUnit(vJson);
            txtLogradouro.Text = CEP.logradouro;
            txtCidade.Text = CEP.localidade;
            txtComplemento.Text = CEP.complemento;
            txtBairro.Text = CEP.bairro;
            cbbEstados.SelectedIndex = -1;
            for(int i=0; i<= cbbEstados.Items.Count - 1; i++) {
              var vPos = Strings.InStr(cbbEstados.Items[i].ToString(), $"({CEP.uf})");
              if(vPos > 0) {
                cbbEstados.SelectedIndex = i;
                break;
              }
            }

          }
        }
      }
    }
  }
}
