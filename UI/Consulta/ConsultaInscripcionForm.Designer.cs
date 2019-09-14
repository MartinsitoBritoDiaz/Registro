namespace Registro.UI.Consulta
{
    partial class ConsultaInscripcionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaInscripcionForm));
            this.ConsultaButton = new System.Windows.Forms.Button();
            this.CriterioLabel = new System.Windows.Forms.Label();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.FiltroLabel = new System.Windows.Forms.Label();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HastaLabel = new System.Windows.Forms.Label();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdeLabel = new System.Windows.Forms.Label();
            this.ConsultaDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultaButton
            // 
            this.ConsultaButton.Image = ((System.Drawing.Image)(resources.GetObject("ConsultaButton.Image")));
            this.ConsultaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConsultaButton.Location = new System.Drawing.Point(922, 34);
            this.ConsultaButton.Name = "ConsultaButton";
            this.ConsultaButton.Size = new System.Drawing.Size(97, 27);
            this.ConsultaButton.TabIndex = 19;
            this.ConsultaButton.Text = "Consulta";
            this.ConsultaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ConsultaButton.UseVisualStyleBackColor = true;
            this.ConsultaButton.Click += new System.EventHandler(this.ConsultaButton_Click);
            // 
            // CriterioLabel
            // 
            this.CriterioLabel.AutoSize = true;
            this.CriterioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CriterioLabel.Location = new System.Drawing.Point(688, 9);
            this.CriterioLabel.Name = "CriterioLabel";
            this.CriterioLabel.Size = new System.Drawing.Size(64, 20);
            this.CriterioLabel.TabIndex = 18;
            this.CriterioLabel.Text = "Criterio";
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CriterioTextBox.Location = new System.Drawing.Point(692, 36);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(224, 24);
            this.CriterioTextBox.TabIndex = 17;
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Todo",
            "ID",
            "Nombre",
            "Cedula",
            "Matricula"});
            this.FiltroComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Todo",
            "Id"});
            this.FiltroComboBox.Location = new System.Drawing.Point(551, 34);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(127, 26);
            this.FiltroComboBox.TabIndex = 16;
            this.FiltroComboBox.SelectedIndexChanged += new System.EventHandler(this.FiltroComboBox_SelectedIndexChanged);
            // 
            // FiltroLabel
            // 
            this.FiltroLabel.AutoSize = true;
            this.FiltroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FiltroLabel.Location = new System.Drawing.Point(555, 9);
            this.FiltroLabel.Name = "FiltroLabel";
            this.FiltroLabel.Size = new System.Drawing.Size(47, 20);
            this.FiltroLabel.TabIndex = 15;
            this.FiltroLabel.Text = "Filtro";
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.HastaDateTimePicker.Location = new System.Drawing.Point(280, 36);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.HastaDateTimePicker.TabIndex = 14;
            // 
            // HastaLabel
            // 
            this.HastaLabel.AutoSize = true;
            this.HastaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.HastaLabel.Location = new System.Drawing.Point(276, 9);
            this.HastaLabel.Name = "HastaLabel";
            this.HastaLabel.Size = new System.Drawing.Size(54, 20);
            this.HastaLabel.TabIndex = 13;
            this.HastaLabel.Text = "Hasta";
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(6, 36);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(268, 22);
            this.DesdeDateTimePicker.TabIndex = 12;
            // 
            // DesdeLabel
            // 
            this.DesdeLabel.AutoSize = true;
            this.DesdeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DesdeLabel.Location = new System.Drawing.Point(2, 9);
            this.DesdeLabel.Name = "DesdeLabel";
            this.DesdeLabel.Size = new System.Drawing.Size(58, 20);
            this.DesdeLabel.TabIndex = 11;
            this.DesdeLabel.Text = "Desde";
            // 
            // ConsultaDataGridView
            // 
            this.ConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaDataGridView.Location = new System.Drawing.Point(6, 73);
            this.ConsultaDataGridView.Name = "ConsultaDataGridView";
            this.ConsultaDataGridView.RowHeadersWidth = 51;
            this.ConsultaDataGridView.RowTemplate.Height = 24;
            this.ConsultaDataGridView.Size = new System.Drawing.Size(1013, 474);
            this.ConsultaDataGridView.TabIndex = 10;
            // 
            // ConsultaInscripcionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 554);
            this.Controls.Add(this.ConsultaButton);
            this.Controls.Add(this.CriterioLabel);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.FiltroLabel);
            this.Controls.Add(this.HastaDateTimePicker);
            this.Controls.Add(this.HastaLabel);
            this.Controls.Add(this.DesdeDateTimePicker);
            this.Controls.Add(this.DesdeLabel);
            this.Controls.Add(this.ConsultaDataGridView);
            this.Name = "ConsultaInscripcionForm";
            this.Text = "Consulta Inscripcion";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConsultaButton;
        private System.Windows.Forms.Label CriterioLabel;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label FiltroLabel;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.Label HastaLabel;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.Label DesdeLabel;
        private System.Windows.Forms.DataGridView ConsultaDataGridView;
    }
}