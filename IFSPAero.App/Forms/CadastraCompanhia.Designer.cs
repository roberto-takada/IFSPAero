namespace IFSPAero.App.Forms
{
    partial class CadastraCompanhia
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
            txtBoxCompanhia = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBoxId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            tabControlCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtBoxId);
            tabPageCadastro.Controls.Add(txtBoxCompanhia);
            tabPageCadastro.Margin = new Padding(3, 5, 3, 5);
            tabPageCadastro.Padding = new Padding(3, 5, 3, 5);
            tabPageCadastro.Size = new Size(913, 534);
            tabPageCadastro.Controls.SetChildIndex(btnConfirmar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtBoxCompanhia, 0);
            tabPageCadastro.Controls.SetChildIndex(txtBoxId, 0);
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(819, 482);
            btnConfirmar.Margin = new Padding(6, 11, 6, 11);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Margin = new Padding(3, 5, 3, 5);
            tabPageConsulta.Padding = new Padding(3, 5, 3, 5);
            tabPageConsulta.Size = new Size(913, 534);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(684, 482);
            btnCancelar.Margin = new Padding(6, 11, 6, 11);
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(595, 464);
            btnExcluir.Margin = new Padding(6, 11, 6, 11);
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(709, 464);
            btnAlterar.Margin = new Padding(6, 11, 6, 11);
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(830, 464);
            btnNovo.Margin = new Padding(6, 11, 6, 11);
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Location = new Point(3, 113);
            tabControlCadastro.Margin = new Padding(3, 5, 3, 5);
            tabControlCadastro.Size = new Size(921, 567);
            // 
            // txtBoxCompanhia
            // 
            txtBoxCompanhia.AnimateReadOnly = false;
            txtBoxCompanhia.AutoCompleteMode = AutoCompleteMode.None;
            txtBoxCompanhia.AutoCompleteSource = AutoCompleteSource.None;
            txtBoxCompanhia.BackgroundImageLayout = ImageLayout.None;
            txtBoxCompanhia.CharacterCasing = CharacterCasing.Normal;
            txtBoxCompanhia.Depth = 0;
            txtBoxCompanhia.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBoxCompanhia.HideSelection = true;
            txtBoxCompanhia.Hint = "Nome da Companhia";
            txtBoxCompanhia.LeadingIcon = null;
            txtBoxCompanhia.Location = new Point(311, 179);
            txtBoxCompanhia.Margin = new Padding(3, 4, 3, 4);
            txtBoxCompanhia.MaxLength = 32767;
            txtBoxCompanhia.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBoxCompanhia.Name = "txtBoxCompanhia";
            txtBoxCompanhia.PasswordChar = '\0';
            txtBoxCompanhia.PrefixSuffixText = null;
            txtBoxCompanhia.ReadOnly = false;
            txtBoxCompanhia.RightToLeft = RightToLeft.No;
            txtBoxCompanhia.SelectedText = "";
            txtBoxCompanhia.SelectionLength = 0;
            txtBoxCompanhia.SelectionStart = 0;
            txtBoxCompanhia.ShortcutsEnabled = true;
            txtBoxCompanhia.Size = new Size(286, 48);
            txtBoxCompanhia.TabIndex = 2;
            txtBoxCompanhia.TabStop = false;
            txtBoxCompanhia.TextAlign = HorizontalAlignment.Left;
            txtBoxCompanhia.TrailingIcon = null;
            txtBoxCompanhia.UseSystemPasswordChar = false;
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
            txtBoxId.Location = new Point(311, 107);
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
            txtBoxId.Size = new Size(286, 48);
            txtBoxId.TabIndex = 4;
            txtBoxId.TabStop = false;
            txtBoxId.TextAlign = HorizontalAlignment.Left;
            txtBoxId.TrailingIcon = null;
            txtBoxId.UseSystemPasswordChar = false;
            // 
            // CadastraCompanhia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 685);
            Location = new Point(0, 0);
            Margin = new Padding(3, 5, 3, 5);
            Name = "CadastraCompanhia";
            Padding = new Padding(3, 113, 3, 5);
            Text = "IFSPAero - Companhia";
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            tabControlCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBoxCompanhia;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBoxId;
    }
}