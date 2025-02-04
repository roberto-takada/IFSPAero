namespace IFSPAero.App.Forms
{
    partial class CadastraVoo
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
            cboAeroportoSaida = new ReaLTaiizor.Controls.MaterialComboBox();
            txtBoxId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboAeroportoChegada = new ReaLTaiizor.Controls.MaterialComboBox();
            cboCapitao = new ReaLTaiizor.Controls.MaterialComboBox();
            cboAviao = new ReaLTaiizor.Controls.MaterialComboBox();
            cboVoo = new ReaLTaiizor.Controls.MaterialComboBox();
            dateTimeSaida = new DateTimePicker();
            dateTimeChegada = new DateTimePicker();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            tabControlCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(dateTimeChegada);
            tabPageCadastro.Controls.Add(dateTimeSaida);
            tabPageCadastro.Controls.Add(cboVoo);
            tabPageCadastro.Controls.Add(cboAviao);
            tabPageCadastro.Controls.Add(cboCapitao);
            tabPageCadastro.Controls.Add(cboAeroportoChegada);
            tabPageCadastro.Controls.Add(txtBoxId);
            tabPageCadastro.Controls.Add(cboAeroportoSaida);
            tabPageCadastro.Controls.SetChildIndex(btnConfirmar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(cboAeroportoSaida, 0);
            tabPageCadastro.Controls.SetChildIndex(txtBoxId, 0);
            tabPageCadastro.Controls.SetChildIndex(cboAeroportoChegada, 0);
            tabPageCadastro.Controls.SetChildIndex(cboCapitao, 0);
            tabPageCadastro.Controls.SetChildIndex(cboAviao, 0);
            tabPageCadastro.Controls.SetChildIndex(cboVoo, 0);
            tabPageCadastro.Controls.SetChildIndex(dateTimeSaida, 0);
            tabPageCadastro.Controls.SetChildIndex(dateTimeChegada, 0);
            // 
            // cboAeroportoSaida
            // 
            cboAeroportoSaida.AutoResize = false;
            cboAeroportoSaida.BackColor = Color.FromArgb(255, 255, 255);
            cboAeroportoSaida.Depth = 0;
            cboAeroportoSaida.DrawMode = DrawMode.OwnerDrawVariable;
            cboAeroportoSaida.DropDownHeight = 174;
            cboAeroportoSaida.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAeroportoSaida.DropDownWidth = 121;
            cboAeroportoSaida.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboAeroportoSaida.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboAeroportoSaida.FormattingEnabled = true;
            cboAeroportoSaida.Hint = "Aeroporto de Saída";
            cboAeroportoSaida.IntegralHeight = false;
            cboAeroportoSaida.ItemHeight = 43;
            cboAeroportoSaida.Location = new Point(233, 5);
            cboAeroportoSaida.MaxDropDownItems = 4;
            cboAeroportoSaida.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboAeroportoSaida.Name = "cboAeroportoSaida";
            cboAeroportoSaida.Size = new Size(274, 49);
            cboAeroportoSaida.StartIndex = 0;
            cboAeroportoSaida.TabIndex = 2;
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
            txtBoxId.TabIndex = 7;
            txtBoxId.TabStop = false;
            txtBoxId.TextAlign = HorizontalAlignment.Left;
            txtBoxId.TrailingIcon = null;
            txtBoxId.UseSystemPasswordChar = false;
            // 
            // cboAeroportoChegada
            // 
            cboAeroportoChegada.AutoResize = false;
            cboAeroportoChegada.BackColor = Color.FromArgb(255, 255, 255);
            cboAeroportoChegada.Depth = 0;
            cboAeroportoChegada.DrawMode = DrawMode.OwnerDrawVariable;
            cboAeroportoChegada.DropDownHeight = 174;
            cboAeroportoChegada.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAeroportoChegada.DropDownWidth = 121;
            cboAeroportoChegada.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboAeroportoChegada.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboAeroportoChegada.FormattingEnabled = true;
            cboAeroportoChegada.Hint = "Aeroporto de Chegada";
            cboAeroportoChegada.IntegralHeight = false;
            cboAeroportoChegada.ItemHeight = 43;
            cboAeroportoChegada.Location = new Point(513, 5);
            cboAeroportoChegada.MaxDropDownItems = 4;
            cboAeroportoChegada.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboAeroportoChegada.Name = "cboAeroportoChegada";
            cboAeroportoChegada.Size = new Size(267, 49);
            cboAeroportoChegada.StartIndex = 0;
            cboAeroportoChegada.TabIndex = 8;
            // 
            // cboCapitao
            // 
            cboCapitao.AutoResize = false;
            cboCapitao.BackColor = Color.FromArgb(255, 255, 255);
            cboCapitao.Depth = 0;
            cboCapitao.DrawMode = DrawMode.OwnerDrawVariable;
            cboCapitao.DropDownHeight = 174;
            cboCapitao.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCapitao.DropDownWidth = 121;
            cboCapitao.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboCapitao.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboCapitao.FormattingEnabled = true;
            cboCapitao.Hint = "Capitão do Avião";
            cboCapitao.IntegralHeight = false;
            cboCapitao.ItemHeight = 43;
            cboCapitao.Location = new Point(233, 60);
            cboCapitao.MaxDropDownItems = 4;
            cboCapitao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCapitao.Name = "cboCapitao";
            cboCapitao.Size = new Size(546, 49);
            cboCapitao.StartIndex = 0;
            cboCapitao.TabIndex = 9;
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
            cboAviao.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboAviao.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboAviao.FormattingEnabled = true;
            cboAviao.Hint = "Código do Avião";
            cboAviao.IntegralHeight = false;
            cboAviao.ItemHeight = 43;
            cboAviao.Location = new Point(233, 115);
            cboAviao.MaxDropDownItems = 4;
            cboAviao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboAviao.Name = "cboAviao";
            cboAviao.Size = new Size(274, 49);
            cboAviao.StartIndex = 0;
            cboAviao.TabIndex = 10;
            // 
            // cboVoo
            // 
            cboVoo.AutoResize = false;
            cboVoo.BackColor = Color.FromArgb(255, 255, 255);
            cboVoo.Depth = 0;
            cboVoo.DrawMode = DrawMode.OwnerDrawVariable;
            cboVoo.DropDownHeight = 174;
            cboVoo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVoo.DropDownWidth = 121;
            cboVoo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboVoo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboVoo.FormattingEnabled = true;
            cboVoo.Hint = "Tipo de Vôo";
            cboVoo.IntegralHeight = false;
            cboVoo.ItemHeight = 43;
            cboVoo.Location = new Point(513, 115);
            cboVoo.MaxDropDownItems = 4;
            cboVoo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboVoo.Name = "cboVoo";
            cboVoo.Size = new Size(266, 49);
            cboVoo.StartIndex = 0;
            cboVoo.TabIndex = 11;
            // 
            // dateTimeSaida
            // 
            dateTimeSaida.Location = new Point(17, 74);
            dateTimeSaida.Name = "dateTimeSaida";
            dateTimeSaida.Size = new Size(200, 23);
            dateTimeSaida.TabIndex = 12;
            // 
            // dateTimeChegada
            // 
            dateTimeChegada.Location = new Point(17, 126);
            dateTimeChegada.Name = "dateTimeChegada";
            dateTimeChegada.Size = new Size(200, 23);
            dateTimeChegada.TabIndex = 13;
            // 
            // CadastraVoo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastraVoo";
            Text = "IFSPAero - Vôo";
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            tabControlCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboAeroportoSaida;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBoxId;
        private ReaLTaiizor.Controls.MaterialComboBox cboAeroportoChegada;
        private ReaLTaiizor.Controls.MaterialComboBox cboVoo;
        private ReaLTaiizor.Controls.MaterialComboBox cboAviao;
        private ReaLTaiizor.Controls.MaterialComboBox cboCapitao;
        private DateTimePicker dateTimeChegada;
        private DateTimePicker dateTimeSaida;
    }
}