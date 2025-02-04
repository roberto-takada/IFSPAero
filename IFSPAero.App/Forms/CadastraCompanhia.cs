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
    public partial class CadastraCompanhia : CadastroBase
    {
        private IBaseService<Companhia> _companhiaService;
        private List<CompanhiaModel> companhias;
        public CadastraCompanhia(IBaseService<Companhia> companhiaService)
        {
            _companhiaService = companhiaService;
            InitializeComponent();
        }

        private void PreencheObjeto(Companhia companhia)
        {
            companhia.Nome = txtBoxCompanhia.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtBoxId.Text, out var id))
                    {
                        var companhia = _companhiaService.GetById<Companhia>(id);
                        PreencheObjeto(companhia);
                        _companhiaService.Update<Companhia, Companhia, CompanhiaValidator>(companhia);
                    }
                }
                else
                {
                    var companhia = new Companhia();
                    PreencheObjeto(companhia);
                    _companhiaService.Add<Companhia, Companhia, CompanhiaValidator>(companhia);
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
                _companhiaService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSPAERO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            companhias = _companhiaService.Get<CompanhiaModel>().ToList();
            dataGridViewConsulta.DataSource = companhias;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtBoxId.Text = linha?.Cells["Id"].Value.ToString();
            txtBoxCompanhia.Text = linha?.Cells["Nome"].Value.ToString();
        }
    }
}
