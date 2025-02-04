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
            tabPageCadastro.Controls.SetChildIndex(btnConfirmar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtBoxFuncao, 0);
            tabPageCadastro.Controls.SetChildIndex(txtBoxId, 0);
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
            txtBoxFuncao.Location = new Point(217, 153);
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
            txtBoxFuncao.Size = new Size(352, 48);
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
            txtBoxId.Location = new Point(217, 75);
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
            txtBoxId.Size = new Size(352, 48);
            txtBoxId.TabIndex = 5;
            txtBoxId.TabStop = false;
            txtBoxId.TextAlign = HorizontalAlignment.Left;
            txtBoxId.TrailingIcon = null;
            txtBoxId.UseSystemPasswordChar = false;
            // 
            // CadastraFuncaoFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastraFuncaoFuncionario";
            Text = "CadastraFuncaoFuncionario";
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