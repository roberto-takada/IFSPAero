namespace IFSPAero.App.FormBase
{
    partial class CadastroBase
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
            tabControlCadastro = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageCadastro = new TabPage();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            btnConfirmar = new ReaLTaiizor.Controls.MaterialButton();
            tabPageConsulta = new TabPage();
            dataGridViewConsulta = new DataGridView();
            btnExcluir = new ReaLTaiizor.Controls.MaterialButton();
            btnAlterar = new ReaLTaiizor.Controls.MaterialButton();
            btnNovo = new ReaLTaiizor.Controls.MaterialButton();
            tabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsulta).BeginInit();
            SuspendLayout();
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Controls.Add(tabPageCadastro);
            tabControlCadastro.Controls.Add(tabPageConsulta);
            tabControlCadastro.Depth = 0;
            tabControlCadastro.Dock = DockStyle.Fill;
            tabControlCadastro.Location = new Point(3, 85);
            tabControlCadastro.Margin = new Padding(3, 4, 3, 4);
            tabControlCadastro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabControlCadastro.Multiline = true;
            tabControlCadastro.Name = "tabControlCadastro";
            tabControlCadastro.SelectedIndex = 0;
            tabControlCadastro.Size = new Size(894, 511);
            tabControlCadastro.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(btnCancelar);
            tabPageCadastro.Controls.Add(btnConfirmar);
            tabPageCadastro.Location = new Point(4, 29);
            tabPageCadastro.Margin = new Padding(3, 4, 3, 4);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3, 4, 3, 4);
            tabPageCadastro.Size = new Size(886, 478);
            tabPageCadastro.TabIndex = 0;
            tabPageCadastro.Text = "Cadastro";
            tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancelar.Location = new Point(691, 434);
            btnCancelar.Margin = new Padding(5, 8, 5, 8);
            btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(96, 36);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConfirmar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnConfirmar.Depth = 0;
            btnConfirmar.HighEmphasis = true;
            btnConfirmar.Icon = null;
            btnConfirmar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnConfirmar.Location = new Point(797, 434);
            btnConfirmar.Margin = new Padding(5, 8, 5, 8);
            btnConfirmar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.NoAccentTextColor = Color.Empty;
            btnConfirmar.Size = new Size(76, 36);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Salvar";
            btnConfirmar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnConfirmar.UseAccentColor = false;
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(dataGridViewConsulta);
            tabPageConsulta.Controls.Add(btnExcluir);
            tabPageConsulta.Controls.Add(btnAlterar);
            tabPageConsulta.Controls.Add(btnNovo);
            tabPageConsulta.Location = new Point(4, 29);
            tabPageConsulta.Margin = new Padding(3, 4, 3, 4);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new Padding(3, 4, 3, 4);
            tabPageConsulta.Size = new Size(886, 478);
            tabPageConsulta.TabIndex = 1;
            tabPageConsulta.Text = "Consulta";
            tabPageConsulta.UseVisualStyleBackColor = true;
            tabPageConsulta.Enter += tabPageConsulta_Enter;
            // 
            // dataGridViewConsulta
            // 
            dataGridViewConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConsulta.Dock = DockStyle.Top;
            dataGridViewConsulta.Location = new Point(3, 4);
            dataGridViewConsulta.Margin = new Padding(3, 4, 3, 4);
            dataGridViewConsulta.Name = "dataGridViewConsulta";
            dataGridViewConsulta.RowHeadersWidth = 51;
            dataGridViewConsulta.Size = new Size(880, 393);
            dataGridViewConsulta.TabIndex = 3;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExcluir.Depth = 0;
            btnExcluir.HighEmphasis = true;
            btnExcluir.Icon = null;
            btnExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnExcluir.Location = new Point(611, 430);
            btnExcluir.Margin = new Padding(5, 8, 5, 8);
            btnExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.NoAccentTextColor = Color.Empty;
            btnExcluir.Size = new Size(80, 36);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExcluir.UseAccentColor = false;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAlterar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAlterar.Depth = 0;
            btnAlterar.HighEmphasis = true;
            btnAlterar.Icon = null;
            btnAlterar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnAlterar.Location = new Point(711, 430);
            btnAlterar.Margin = new Padding(5, 8, 5, 8);
            btnAlterar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAlterar.Name = "btnAlterar";
            btnAlterar.NoAccentTextColor = Color.Empty;
            btnAlterar.Size = new Size(84, 36);
            btnAlterar.TabIndex = 1;
            btnAlterar.Text = "Alterar";
            btnAlterar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAlterar.UseAccentColor = false;
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnNovo
            // 
            btnNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovo.Depth = 0;
            btnNovo.HighEmphasis = true;
            btnNovo.Icon = null;
            btnNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNovo.Location = new Point(817, 430);
            btnNovo.Margin = new Padding(5, 8, 5, 8);
            btnNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNovo.Name = "btnNovo";
            btnNovo.NoAccentTextColor = Color.Empty;
            btnNovo.Size = new Size(64, 36);
            btnNovo.TabIndex = 0;
            btnNovo.Text = "Novo";
            btnNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovo.UseAccentColor = false;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // CadastroBase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            Controls.Add(tabControlCadastro);
            DrawerTabControl = tabControlCadastro;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(900, 600);
            Name = "CadastroBase";
            Padding = new Padding(3, 85, 3, 4);
            Text = "FormBase";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsulta).EndInit();
            ResumeLayout(false);
        }

        #endregion
        protected TabPage tabPageCadastro;
        protected ReaLTaiizor.Controls.MaterialButton btnConfirmar;
        protected TabPage tabPageConsulta;
        protected ReaLTaiizor.Controls.MaterialButton btnCancelar;
        protected ReaLTaiizor.Controls.MaterialButton btnExcluir;
        protected ReaLTaiizor.Controls.MaterialButton btnAlterar;
        protected ReaLTaiizor.Controls.MaterialButton btnNovo;
        protected DataGridView dataGridViewConsulta;
        protected ReaLTaiizor.Controls.MaterialTabControl tabControlCadastro;
    }
}