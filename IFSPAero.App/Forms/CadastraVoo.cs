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
    public partial class CadastraVoo : CadastroBase
    {
        private IBaseService<Voo> _vooService;
        private IBaseService<TipoVoo> _tipoVooService;
        private IBaseService<Aeroporto> _aeroportoService;
        private IBaseService<Aviao> _aviaoService;
        private IBaseService<Funcionario> _funcionarioService;
        private List<VooModel>? voos;
        public CadastraVoo(IBaseService<Voo> vooService, IBaseService<TipoVoo> tipoVooService, IBaseService<Aeroporto> aeroportoService, IBaseService<Aviao> aviaoService, IBaseService<Funcionario> funcionarioService)
        {
            _vooService = vooService;
            _tipoVooService = tipoVooService;
            _aviaoService = aviaoService;
            _aeroportoService = aeroportoService;
            _funcionarioService = funcionarioService;
            InitializeComponent();
            CarregaCombo();
        }

        private void CarregaCombo()
        {
            cboAviao.ValueMember = "Id";
            cboAviao.DisplayMember = "Codigo";
            cboAviao.DataSource = _aviaoService.Get<AviaoModel>().ToList();

            cboCapitao.ValueMember = "Id";
            cboCapitao.DisplayMember = "Nome";
            cboCapitao.DataSource = _funcionarioService.Get<FuncionarioModel>().ToList();

            cboVoo.ValueMember = "Id";
            cboVoo.DisplayMember = "TipoVoo";
            cboVoo.DataSource = _tipoVooService.Get<TipoVoo>().ToList();

            cboAeroportoChegada.ValueMember = "Id";
            cboAeroportoChegada.DisplayMember = "Nome";
            cboAeroportoChegada.DataSource = _aeroportoService.Get<AeroportoModel>().ToList();

            cboAeroportoSaida.ValueMember = "Id";
            cboAeroportoSaida.DisplayMember = "Nome";
            cboAeroportoSaida.DataSource = _aeroportoService.Get<AeroportoModel>().ToList();

        }

        private void PreencheObjeto(AviaoEstacionado aviaoEstacionado)
        {
            aviaoEstacionado.DuracaoEstacionamento = txtBoxDuracao.Text;
            aviaoEstacionado.ComecoEstacionamento = dateTimeComeco.Value;
            aviaoEstacionado.FimEstacionamento = dateTimeFim.Value;
            if (int.TryParse(cboAviao.SelectedValue.ToString(), out var idAviao))
            {
                var aviao = _aviaoService.GetById<Aviao>(idAviao);
                aviaoEstacionado.Aviao = aviao;
            }
            if (int.TryParse(cboHangar.SelectedValue.ToString(), out var idHangar))
            {
                var hangar = _hangarService.GetById<Hangar>(idHangar);
                aviaoEstacionado.Hangar = hangar;
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
                        var aviaoEstacionado = _aviaoEstacionadoService.GetById<AviaoEstacionado>(id);
                        PreencheObjeto(aviaoEstacionado);
                        _aviaoEstacionadoService.Update<AviaoEstacionado, AviaoEstacionado, AviaoEstacionadoValidator>(aviaoEstacionado);
                    }
                }
                else
                {
                    var aviaoEstacionado = new AviaoEstacionado();
                    PreencheObjeto(aviaoEstacionado);
                    _aviaoEstacionadoService.Add<AviaoEstacionado, AviaoEstacionado, AviaoEstacionadoValidator>(aviaoEstacionado);
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
                _aviaoEstacionadoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSPAERO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            aviaoEstacionados = _aviaoEstacionadoService.Get<AviaoEstacionadoModel>().ToList();
            dataGridViewConsulta.DataSource = aviaoEstacionados;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["IdAviao"]!.Visible = false;
            dataGridViewConsulta.Columns["IdHangar"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtBoxDuracao.Text = linha?.Cells["Nome"].Value.ToString();
            dateTimeComeco.Value = (DateTime)(linha?.Cells["ComecoEstacionamento"].Value);
            dateTimeFim.Value = (DateTime)(linha?.Cells["FimEstacionamento"].Value);
            cboAviao.SelectedValue = linha?.Cells["IdAviao"].Value;
            cboHangar.SelectedValue = linha?.Cells["IdHangar"].Value;
        }
    }
}
