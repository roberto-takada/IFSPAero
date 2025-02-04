namespace IFSPAero.App.Forms
{
    partial class CadastraHangar
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
            txtBoxCodigo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboAeroporto = new ReaLTaiizor.Controls.MaterialComboBox();
            txtBoxId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            tabControlCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtBoxId);
            tabPageCadastro.Controls.Add(cboAeroporto);
            tabPageCadastro.Controls.Add(txtBoxCodigo);
            tabPageCadastro.Controls.SetChildIndex(btnConfirmar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtBoxCodigo, 0);
            tabPageCadastro.Controls.SetChildIndex(cboAeroporto, 0);
            tabPageCadastro.Controls.SetChildIndex(txtBoxId, 0);
            // 
            // txtBoxCodigo
            // 
            txtBoxCodigo.AnimateReadOnly = false;
            txtBoxCodigo.AutoCompleteMode = AutoCompleteMode.None;
            txtBoxCodigo.AutoCompleteSource = AutoCompleteSource.None;
            txtBoxCodigo.BackgroundImageLayout = ImageLayout.None;
            txtBoxCodigo.CharacterCasing = CharacterCasing.Normal;
            txtBoxCodigo.Depth = 0;
            txtBoxCodigo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBoxCodigo.HideSelection = true;
            txtBoxCodigo.Hint = "Código";
            txtBoxCodigo.LeadingIcon = null;
            txtBoxCodigo.Location = new Point(312, 72);
            txtBoxCodigo.MaxLength = 32767;
            txtBoxCodigo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBoxCodigo.Name = "txtBoxCodigo";
            txtBoxCodigo.PasswordChar = '\0';
            txtBoxCodigo.PrefixSuffixText = null;
            txtBoxCodigo.ReadOnly = false;
            txtBoxCodigo.RightToLeft = RightToLeft.No;
            txtBoxCodigo.SelectedText = "";
            txtBoxCodigo.SelectionLength = 0;
            txtBoxCodigo.SelectionStart = 0;
            txtBoxCodigo.ShortcutsEnabled = true;
            txtBoxCodigo.Size = new Size(453, 48);
            txtBoxCodigo.TabIndex = 2;
            txtBoxCodigo.TabStop = false;
            txtBoxCodigo.TextAlign = HorizontalAlignment.Left;
            txtBoxCodigo.TrailingIcon = null;
            txtBoxCodigo.UseSystemPasswordChar = false;
            // 
            // cboAeroporto
            // 
            cboAeroporto.AutoResize = false;
            cboAeroporto.BackColor = Color.FromArgb(255, 255, 255);
            cboAeroporto.Depth = 0;
            cboAeroporto.DrawMode = DrawMode.OwnerDrawVariable;
            cboAeroporto.DropDownHeight = 174;
            cboAeroporto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAeroporto.DropDownWidth = 121;
            cboAeroporto.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboAeroporto.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboAeroporto.FormattingEnabled = true;
            cboAeroporto.IntegralHeight = false;
            cboAeroporto.ItemHeight = 43;
            cboAeroporto.Location = new Point(312, 17);
            cboAeroporto.MaxDropDownItems = 4;
            cboAeroporto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboAeroporto.Name = "cboAeroporto";
            cboAeroporto.Size = new Size(453, 49);
            cboAeroporto.StartIndex = 0;
            cboAeroporto.TabIndex = 3;
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
            txtBoxId.Location = new Point(22, 18);
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
            txtBoxId.Size = new Size(284, 48);
            txtBoxId.TabIndex = 4;
            txtBoxId.TabStop = false;
            txtBoxId.TextAlign = HorizontalAlignment.Left;
            txtBoxId.TrailingIcon = null;
            txtBoxId.UseSystemPasswordChar = false;
            // 
            // CadastraHangar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastraHangar";
            Text = "CadastraHangar";
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            tabControlCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboAeroporto;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBoxCodigo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBoxId;
    }
}