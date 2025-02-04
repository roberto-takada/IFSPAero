namespace IFSPAero.App.Forms
{
    partial class CadastraAviaoEstacionado
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
            txtBoxId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboHangar = new ReaLTaiizor.Controls.MaterialComboBox();
            dateTimeComeco = new DateTimePicker();
            cboAviao = new ReaLTaiizor.Controls.MaterialComboBox();
            dateTimeFim = new DateTimePicker();
            txtBoxDuracao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            tabControlCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtBoxDuracao);
            tabPageCadastro.Controls.Add(dateTimeFim);
            tabPageCadastro.Controls.Add(cboAviao);
            tabPageCadastro.Controls.Add(dateTimeComeco);
            tabPageCadastro.Controls.Add(cboHangar);
            tabPageCadastro.Controls.Add(txtBoxId);
            tabPageCadastro.Controls.SetChildIndex(btnConfirmar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtBoxId, 0);
            tabPageCadastro.Controls.SetChildIndex(cboHangar, 0);
            tabPageCadastro.Controls.SetChildIndex(dateTimeComeco, 0);
            tabPageCadastro.Controls.SetChildIndex(cboAviao, 0);
            tabPageCadastro.Controls.SetChildIndex(dateTimeFim, 0);
            tabPageCadastro.Controls.SetChildIndex(txtBoxDuracao, 0);
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
            txtBoxId.Location = new Point(6, 6);
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
            txtBoxId.Size = new Size(221, 48);
            txtBoxId.TabIndex = 6;
            txtBoxId.TabStop = false;
            txtBoxId.TextAlign = HorizontalAlignment.Left;
            txtBoxId.TrailingIcon = null;
            txtBoxId.UseSystemPasswordChar = false;
            // 
            // cboHangar
            // 
            cboHangar.AutoResize = false;
            cboHangar.BackColor = Color.FromArgb(255, 255, 255);
            cboHangar.Depth = 0;
            cboHangar.DrawMode = DrawMode.OwnerDrawVariable;
            cboHangar.DropDownHeight = 174;
            cboHangar.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHangar.DropDownWidth = 121;
            cboHangar.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboHangar.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboHangar.FormattingEnabled = true;
            cboHangar.Hint = "Hangar";
            cboHangar.IntegralHeight = false;
            cboHangar.ItemHeight = 43;
            cboHangar.Location = new Point(244, 6);
            cboHangar.MaxDropDownItems = 4;
            cboHangar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboHangar.Name = "cboHangar";
            cboHangar.Size = new Size(287, 49);
            cboHangar.StartIndex = 0;
            cboHangar.TabIndex = 7;
            // 
            // dateTimeComeco
            // 
            dateTimeComeco.Location = new Point(557, 20);
            dateTimeComeco.MinDate = new DateTime(1960, 1, 1, 0, 0, 0, 0);
            dateTimeComeco.Name = "dateTimeComeco";
            dateTimeComeco.Size = new Size(200, 23);
            dateTimeComeco.TabIndex = 8;
            // 
            // cboAviao
            // 
            cboAviao.AutoResize = false;
            cboAviao.BackColor = Color.FromArgb(255, 255, 255);
            cboAviao.Depth = 0;
            cboAviao.DrawMode = DrawMode.OwnerDrawVariable;
            cboAviao.DropDownHeight = 174;
            cboAviao.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAviao.DropDownWidth = 121;
            cboAviao.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboAviao.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboAviao.FormattingEnabled = true;
            cboAviao.Hint = "Avião";
            cboAviao.IntegralHeight = false;
            cboAviao.ItemHeight = 43;
            cboAviao.Location = new Point(244, 79);
            cboAviao.MaxDropDownItems = 4;
            cboAviao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboAviao.Name = "cboAviao";
            cboAviao.Size = new Size(287, 49);
            cboAviao.StartIndex = 0;
            cboAviao.TabIndex = 9;
            // 
            // dateTimeFim
            // 
            dateTimeFim.Location = new Point(557, 88);
            dateTimeFim.MinDate = new DateTime(1960, 1, 1, 0, 0, 0, 0);
            dateTimeFim.Name = "dateTimeFim";
            dateTimeFim.Size = new Size(200, 23);
            dateTimeFim.TabIndex = 10;
            // 
            // txtBoxDuracao
            // 
            txtBoxDuracao.AnimateReadOnly = false;
            txtBoxDuracao.AutoCompleteMode = AutoCompleteMode.None;
            txtBoxDuracao.AutoCompleteSource = AutoCompleteSource.None;
            txtBoxDuracao.BackgroundImageLayout = ImageLayout.None;
            txtBoxDuracao.CharacterCasing = CharacterCasing.Normal;
            txtBoxDuracao.Depth = 0;
            txtBoxDuracao.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBoxDuracao.HideSelection = true;
            txtBoxDuracao.Hint = "Duração do Estacionamento (Não é necessário digitar)";
            txtBoxDuracao.LeadingIcon = null;
            txtBoxDuracao.Location = new Point(17, 178);
            txtBoxDuracao.MaxLength = 32767;
            txtBoxDuracao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBoxDuracao.Name = "txtBoxDuracao";
            txtBoxDuracao.PasswordChar = '\0';
            txtBoxDuracao.PrefixSuffixText = null;
            txtBoxDuracao.ReadOnly = false;
            txtBoxDuracao.RightToLeft = RightToLeft.No;
            txtBoxDuracao.SelectedText = "";
            txtBoxDuracao.SelectionLength = 0;
            txtBoxDuracao.SelectionStart = 0;
            txtBoxDuracao.ShortcutsEnabled = true;
            txtBoxDuracao.Size = new Size(751, 48);
            txtBoxDuracao.TabIndex = 11;
            txtBoxDuracao.TabStop = false;
            txtBoxDuracao.TextAlign = HorizontalAlignment.Left;
            txtBoxDuracao.TrailingIcon = null;
            txtBoxDuracao.UseSystemPasswordChar = false;
            // 
            // CadastraAviaoEstacionado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastraAviaoEstacionado";
            Text = "IFSPAero - Estacionamento de Aviões";
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            tabControlCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBoxId;
        private ReaLTaiizor.Controls.MaterialComboBox cboHangar;
        private DateTimePicker dateTimeFim;
        private ReaLTaiizor.Controls.MaterialComboBox cboAviao;
        private DateTimePicker dateTimeComeco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBoxDuracao;
    }
}