namespace Registro.UI.Registro
{
    partial class RegistroForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroForm));
            this.IdLabel = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.ApellidosLabel = new System.Windows.Forms.Label();
            this.ApellidoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BalanceTextBox = new System.Windows.Forms.TextBox();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.SexoComboBox = new System.Windows.Forms.ComboBox();
            this.CedulaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.MatriculaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.TelefonoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CelularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.IdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.IdLabel.Location = new System.Drawing.Point(36, 51);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(27, 24);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "ID";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BuscarButton.Location = new System.Drawing.Point(643, 20);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(115, 55);
            this.BuscarButton.TabIndex = 2;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.NombreLabel.Location = new System.Drawing.Point(36, 104);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(79, 24);
            this.NombreLabel.TabIndex = 3;
            this.NombreLabel.Text = "Nombre";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.NombreTextBox.Location = new System.Drawing.Point(234, 100);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(524, 28);
            this.NombreTextBox.TabIndex = 4;
            // 
            // ApellidosLabel
            // 
            this.ApellidosLabel.AutoSize = true;
            this.ApellidosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ApellidosLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ApellidosLabel.Location = new System.Drawing.Point(36, 144);
            this.ApellidosLabel.Name = "ApellidosLabel";
            this.ApellidosLabel.Size = new System.Drawing.Size(88, 24);
            this.ApellidosLabel.TabIndex = 5;
            this.ApellidosLabel.Text = "Apellidos";
            // 
            // ApellidoTextBox
            // 
            this.ApellidoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ApellidoTextBox.Location = new System.Drawing.Point(234, 140);
            this.ApellidoTextBox.Name = "ApellidoTextBox";
            this.ApellidoTextBox.Size = new System.Drawing.Size(524, 28);
            this.ApellidoTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(36, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cedula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(36, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Matricula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(36, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(36, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Celular";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.EmailTextBox.Location = new System.Drawing.Point(234, 358);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(524, 28);
            this.EmailTextBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(36, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(36, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Fecha de nacimiento";
            // 
            // FechaNacimientoDateTimePicker
            // 
            this.FechaNacimientoDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.FechaNacimientoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FechaNacimientoDateTimePicker.Location = new System.Drawing.Point(234, 405);
            this.FechaNacimientoDateTimePicker.Name = "FechaNacimientoDateTimePicker";
            this.FechaNacimientoDateTimePicker.Size = new System.Drawing.Size(524, 26);
            this.FechaNacimientoDateTimePicker.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(36, 451);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Sexo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.Location = new System.Drawing.Point(36, 493);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "Balance";
            // 
            // BalanceTextBox
            // 
            this.BalanceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BalanceTextBox.Location = new System.Drawing.Point(234, 489);
            this.BalanceTextBox.Name = "BalanceTextBox";
            this.BalanceTextBox.ReadOnly = true;
            this.BalanceTextBox.Size = new System.Drawing.Size(524, 28);
            this.BalanceTextBox.TabIndex = 22;
            this.BalanceTextBox.TextChanged += new System.EventHandler(this.BalanceTextBox_TextChanged);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(234, 536);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(111, 54);
            this.NuevoButton.TabIndex = 23;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(442, 536);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(115, 54);
            this.GuardarButton.TabIndex = 24;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(643, 536);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(115, 54);
            this.EliminarButton.TabIndex = 25;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // SexoComboBox
            // 
            this.SexoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SexoComboBox.FormattingEnabled = true;
            this.SexoComboBox.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.SexoComboBox.Location = new System.Drawing.Point(234, 447);
            this.SexoComboBox.Name = "SexoComboBox";
            this.SexoComboBox.Size = new System.Drawing.Size(524, 28);
            this.SexoComboBox.TabIndex = 26;
            this.SexoComboBox.SelectedIndexChanged += new System.EventHandler(this.SexoComboBox_SelectedIndexChanged);
            // 
            // CedulaMaskedTextBox
            // 
            this.CedulaMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CedulaMaskedTextBox.Location = new System.Drawing.Point(234, 187);
            this.CedulaMaskedTextBox.Mask = "000-0000000-0";
            this.CedulaMaskedTextBox.Name = "CedulaMaskedTextBox";
            this.CedulaMaskedTextBox.Size = new System.Drawing.Size(524, 27);
            this.CedulaMaskedTextBox.TabIndex = 27;
            // 
            // MatriculaMaskedTextBox
            // 
            this.MatriculaMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatriculaMaskedTextBox.Location = new System.Drawing.Point(234, 232);
            this.MatriculaMaskedTextBox.Mask = "0000-0000";
            this.MatriculaMaskedTextBox.Name = "MatriculaMaskedTextBox";
            this.MatriculaMaskedTextBox.Size = new System.Drawing.Size(524, 27);
            this.MatriculaMaskedTextBox.TabIndex = 28;
            // 
            // TelefonoMaskedTextBox
            // 
            this.TelefonoMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonoMaskedTextBox.Location = new System.Drawing.Point(234, 275);
            this.TelefonoMaskedTextBox.Mask = "000-000-0000";
            this.TelefonoMaskedTextBox.Name = "TelefonoMaskedTextBox";
            this.TelefonoMaskedTextBox.Size = new System.Drawing.Size(524, 27);
            this.TelefonoMaskedTextBox.TabIndex = 29;
            // 
            // CelularMaskedTextBox
            // 
            this.CelularMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CelularMaskedTextBox.Location = new System.Drawing.Point(234, 319);
            this.CelularMaskedTextBox.Mask = "000-000-0000";
            this.CelularMaskedTextBox.Name = "CelularMaskedTextBox";
            this.CelularMaskedTextBox.Size = new System.Drawing.Size(524, 27);
            this.CelularMaskedTextBox.TabIndex = 30;
            // 
            // IdNumericUpDown
            // 
            this.IdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.IdNumericUpDown.Location = new System.Drawing.Point(234, 49);
            this.IdNumericUpDown.Name = "IdNumericUpDown";
            this.IdNumericUpDown.Size = new System.Drawing.Size(393, 26);
            this.IdNumericUpDown.TabIndex = 31;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // RegistroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 612);
            this.Controls.Add(this.IdNumericUpDown);
            this.Controls.Add(this.CelularMaskedTextBox);
            this.Controls.Add(this.TelefonoMaskedTextBox);
            this.Controls.Add(this.MatriculaMaskedTextBox);
            this.Controls.Add(this.CedulaMaskedTextBox);
            this.Controls.Add(this.SexoComboBox);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BalanceTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FechaNacimientoDateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApellidoTextBox);
            this.Controls.Add(this.ApellidosLabel);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.IdLabel);
            this.Name = "RegistroForm";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.RegistroForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label ApellidosLabel;
        private System.Windows.Forms.TextBox ApellidoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker FechaNacimientoDateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BalanceTextBox;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.ComboBox SexoComboBox;
        private System.Windows.Forms.MaskedTextBox CedulaMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox MatriculaMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox TelefonoMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox CelularMaskedTextBox;
        private System.Windows.Forms.NumericUpDown IdNumericUpDown;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}