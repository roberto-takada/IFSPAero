using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IFSPAero.App.FormBase;
using IFSPAero.App.Models;
using IFSPAero.Domain.Base;
using IFSPAero.Domain.Entities;
using IFSPAero.Services.Validators;

namespace IFSPAero.App.Forms
{
    public partial class CadastraFuncionario : CadastroBase
    {
        private IBaseService<Funcionario> _funcionarioService;
        private IBaseService<Companhia> _companhiaService;
        private IBaseService<Funcao> _funcaoService;
        private List<FuncionarioModel>? funcionarios;
        public CadastraFuncionario(IBaseService<Funcionario> funcionarioService, IBaseService<Companhia> companhiaService, IBaseService<Funcao> funcaoService)
        {
            _funcionarioService = funcionarioService;
            _companhiaService = companhiaService;
            _funcaoService = funcaoService;
            InitializeComponent();
            CarregaCombo();
        }

        private void CarregaCombo()
        {
            cboCompanhia.ValueMember = "Id";
            cboCompanhia.DisplayMember = "Nome";
            cboCompanhia.DataSource = _companhiaService.Get<CompanhiaModel>().ToList();

            cboFuncao.ValueMember = "Id";
            cboFuncao.DisplayMember = "NomeFuncao";
            cboFuncao.DataSource = _funcaoService.Get<FuncaoModel>().ToList();

        }

        private void PreencheObjeto(Funcionario funcionario)
        {
            funcionario.Nome = txtBoxNome.Text;
            funcionario.Documento = txtBoxDocumento.Text;
            if (int.TryParse(cboCompanhia.SelectedValue.ToString(), out var idCompanhia))
            {
                var companhia = _companhiaService.GetById<Companhia>(idCompanhia);
                funcionario.Companhia = companhia;
            }
            if(int.TryParse(cboFuncao.SelectedValue.ToString(), out var idFuncao))
            {
                var funcao = _funcaoService.GetById<Funcao>(idFuncao);
                funcionario.Funcao = funcao;
            }
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtBoxId.Text, out var id))
                    {
                        var funcionario = _funcionarioService.GetById<Funcionario>(id);
                        PreencheObjeto(funcionario);
                        _funcionarioService.Update<Funcionario, Funcionario, FuncionarioValidator>(funcionario);
                    }
                }
                else
                {
                    var funcionario = new Funcionario();
                    PreencheObjeto(funcionario);
                    _funcionarioService.Add<Funcionario, Funcionario, FuncionarioValidator>(funcionario);
                }
                tabControlCadastro.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSPAERO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _funcionarioService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSPAERO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            funcionarios = _funcionarioService.Get<FuncionarioModel>().ToList();
            dataGridViewConsulta.DataSource = funcionarios;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["IdFuncao"]!.Visible = false;
            dataGridViewConsulta.Columns["IdCompanhia"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtBoxNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtBoxDocumento.Text = linha?.Cells["Documento"].Value.ToString();
            txtBoxId.Text = linha?.Cells["Id"].Value.ToString();
            cboCompanhia.SelectedValue = linha?.Cells["IdCompanhia"].Value;
            cboFuncao.SelectedValue = linha?.Cells["IdFuncao"].Value;
        }
    }
}
