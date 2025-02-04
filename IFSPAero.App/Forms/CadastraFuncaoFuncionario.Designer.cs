namespace IFSPAero.App.Forms
{
    partial class CadastraFuncaoFuncionario
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
            txtBoxFuncao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBoxId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            tabControlCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtBoxId);
            tabPageCadastro.Controls.Add(txtBoxFuncao);
            tabPageCadastro.Margin = new Padding(3, 5, 3, 5);
            tabPageCadastro.Padding = new Padding(3, 5, 3, 5);
            tabPageCadastro.Size = new Size(907, 496);
            tabPageCadastro.Controls.SetChildIndex(btnConfirmar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtBoxFuncao, 0);
            tabPageCadastro.Controls.SetChildIndex(txtBoxId, 0);
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(819, 449);
            btnConfirmar.Margin = new Padding(6, 11, 6, 11);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Margin = new Padding(3, 5, 3, 5);
            tabPageConsulta.Padding = new Padding(3, 5, 3, 5);
            tabPageConsulta.Size = new Size(907, 496);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(684, 449);
            btnCancelar.Margin = new Padding(6, 11, 6, 11);
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(595, 426);
            btnExcluir.Margin = new Padding(6, 11, 6, 11);
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(709, 426);
            btnAlterar.Margin = new Padding(6, 11, 6, 11);
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(830, 426);
            btnNovo.Margin = new Padding(6, 11, 6, 11);
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Location = new Point(3, 113);
            tabControlCadastro.Margin = new Padding(3, 5, 3, 5);
            tabControlCadastro.Size = new Size(915, 529);
            // 
            // txtBoxFuncao
            // 
            txtBoxFuncao.AnimateReadOnly = false;
            txtBoxFuncao.AutoCompleteMode = AutoCompleteMode.None;
            txtBoxFuncao.AutoCompleteSource = AutoCompleteSource.None;
            txtBoxFuncao.BackgroundImageLayout = ImageLayout.None;
            txtBoxFuncao.CharacterCasing = CharacterCasing.Normal;
            txtBoxFuncao.Depth = 0;
            txtBoxFuncao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBoxFuncao.HideSelection = true;
            txtBoxFuncao.Hint = "Função";
            txtBoxFuncao.LeadingIcon = null;
            txtBoxFuncao.Location = new Point(248, 204);
            txtBoxFuncao.Margin = new Padding(3, 4, 3, 4);
            txtBoxFuncao.MaxLength = 32767;
            txtBoxFuncao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBoxFuncao.Name = "txtBoxFuncao";
            txtBoxFuncao.PasswordChar = '\0';
            txtBoxFuncao.PrefixSuffixText = null;
            txtBoxFuncao.ReadOnly = false;
            txtBoxFuncao.RightToLeft = RightToLeft.No;
            txtBoxFuncao.SelectedText = "";
            txtBoxFuncao.SelectionLength = 0;
            txtBoxFuncao.SelectionStart = 0;
            txtBoxFuncao.ShortcutsEnabled = true;
            txtBoxFuncao.Size = new Size(402, 48);
            txtBoxFuncao.TabIndex = 3;
            txtBoxFuncao.TabStop = false;
            txtBoxFuncao.TextAlign = HorizontalAlignment.Left;
            txtBoxFuncao.TrailingIcon = null;
            txtBoxFuncao.UseSystemPasswordChar = false;
            // 
            // txtBoxId
            // 
            txtBoxId.AnimateReadOnly = false;
            txtBoxId.AutoCompleteMode = AutoCompleteMode.None;
            txtBoxId.AutoCompleteSource = AutoCompleteSource.None;
            txtBoxId.BackgroundImageLayout = ImageLayout.None;
            txtBoxId.CharacterCasing = CharacterCasing.Normal;
            txtBoxId.Depth = 0;
            txtBoxId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBoxId.HideSelection = true;
            txtBoxId.Hint = "ID";
            txtBoxId.LeadingIcon = null;
            txtBoxId.Location = new Point(248, 100);
            txtBoxId.Margin = new Padding(3, 4, 3, 4);
            txtBoxId.MaxLength = 32767;
            txtBoxId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBoxId.Name = "txtBoxId";
            txtBoxId.PasswordChar = '\0';
            txtBoxId.PrefixSuffixText = null;
            txtBoxId.ReadOnly = false;
            txtBoxId.RightToLeft = RightToLeft.No;
            txtBoxId.SelectedText = "";
            txtBoxId.SelectionLength = 0;
            txtBoxId.SelectionStart = 0;
            txtBoxId.ShortcutsEnabled = true;
            txtBoxId.Size = new Size(402, 48);
            txtBoxId.TabIndex = 5;
            txtBoxId.TabStop = false;
            txtBoxId.TextAlign = HorizontalAlignment.Left;
            txtBoxId.TrailingIcon = null;
            txtBoxId.UseSystemPasswordChar = false;
            // 
            // CadastraFuncaoFuncionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 647);
            Location = new Point(0, 0);
            Margin = new Padding(3, 5, 3, 5);
            Name = "CadastraFuncaoFuncionario";
            Padding = new Padding(3, 113, 3, 5);
            Text = "IFSPAero - Funções";
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            tabControlCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBoxFuncao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBoxId;
    }
}