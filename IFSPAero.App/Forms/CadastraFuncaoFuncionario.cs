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
    public partial class CadastraFuncaoFuncionario : CadastroBase
    {
        private IBaseService<Funcao> _FuncaoService;
        private List<FuncaoModel> funcoes;
        public CadastraFuncaoFuncionario(IBaseService<Funcao> funcaoFuncionario)
        {
            _FuncaoService = funcaoFuncionario;
            InitializeComponent();
        }

        private void PreencheObjeto(Funcao funcao)
        {
            funcao.NomeFuncao = txtBoxFuncao.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtBoxId.Text, out var id))
                    {
                        var funcao = _FuncaoService.GetById<Funcao>(id);
                        PreencheObjeto(funcao);
                        _FuncaoService.Update<Funcao, Funcao, FuncaoValidator>(funcao);
                    }
                }
                else
                {
                    var funcao = new Funcao();
                    PreencheObjeto(funcao);
                    _FuncaoService.Add<Funcao, Funcao, FuncaoValidator>(funcao);
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
                _FuncaoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSPAERO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            funcoes = _FuncaoService.Get<FuncaoModel>().ToList();
            dataGridViewConsulta.DataSource = funcoes;
            dataGridViewConsulta.Columns["NomeFuncao"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtBoxId.Text = linha?.Cells["Id"].Value.ToString();
            txtBoxFuncao.Text = linha?.Cells["NomeFuncao"].Value.ToString();
        }
    }
}
