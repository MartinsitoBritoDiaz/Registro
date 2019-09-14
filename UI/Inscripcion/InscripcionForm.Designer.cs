namespace Registro.UI.Inscripcion
{
    partial class InscripcionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InscripcionForm));
            this.InscripcionIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.InscripcionIdLabel = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.EstudianteIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.EstudianteIdLabel = new System.Windows.Forms.Label();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MontoLabel = new System.Windows.Forms.Label();
            this.MontoTextBox = new System.Windows.Forms.TextBox();
            this.DepositoLabel = new System.Windows.Forms.Label();
            this.DepositoTextBox = new System.Windows.Forms.TextBox();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.BalanceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComentariosRichTextBox = new System.Windows.Forms.RichTextBox();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.InscripcionIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // InscripcionIdNumericUpDown
            // 
            this.InscripcionIdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InscripcionIdNumericUpDown.Location = new System.Drawing.Point(194, 45);
            this.InscripcionIdNumericUpDown.Name = "InscripcionIdNumericUpDown";
            this.InscripcionIdNumericUpDown.Size = new System.Drawing.Size(260, 27);
            this.InscripcionIdNumericUpDown.TabIndex = 0;
            // 
            // InscripcionIdLabel
            // 
            this.InscripcionIdLabel.AutoSize = true;
            this.InscripcionIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InscripcionIdLabel.Location = new System.Drawing.Point(24, 45);
            this.InscripcionIdLabel.Name = "InscripcionIdLabel";
            this.InscripcionIdLabel.Size = new System.Drawing.Size(112, 20);
            this.InscripcionIdLabel.TabIndex = 1;
            this.InscripcionIdLabel.Text = "Inscripción ID";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BuscarButton.Location = new System.Drawing.Point(474, 45);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(109, 64);
            this.BuscarButton.TabIndex = 2;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // EstudianteIdNumericUpDown
            // 
            this.EstudianteIdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstudianteIdNumericUpDown.Location = new System.Drawing.Point(194, 82);
            this.EstudianteIdNumericUpDown.Name = "EstudianteIdNumericUpDown";
            this.EstudianteIdNumericUpDown.Size = new System.Drawing.Size(260, 27);
            this.EstudianteIdNumericUpDown.TabIndex = 3;
            // 
            // EstudianteIdLabel
            // 
            this.EstudianteIdLabel.AutoSize = true;
            this.EstudianteIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstudianteIdLabel.Location = new System.Drawing.Point(24, 82);
            this.EstudianteIdLabel.Name = "EstudianteIdLabel";
            this.EstudianteIdLabel.Size = new System.Drawing.Size(110, 20);
            this.EstudianteIdLabel.TabIndex = 4;
            this.EstudianteIdLabel.Text = "Estudiante ID";
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaLabel.Location = new System.Drawing.Point(24, 135);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(55, 20);
            this.FechaLabel.TabIndex = 5;
            this.FechaLabel.Text = "Fecha";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDateTimePicker.Location = new System.Drawing.Point(194, 128);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(389, 27);
            this.FechaDateTimePicker.TabIndex = 6;
            // 
            // MontoLabel
            // 
            this.MontoLabel.AutoSize = true;
            this.MontoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MontoLabel.Location = new System.Drawing.Point(24, 180);
            this.MontoLabel.Name = "MontoLabel";
            this.MontoLabel.Size = new System.Drawing.Size(55, 20);
            this.MontoLabel.TabIndex = 7;
            this.MontoLabel.Text = "Monto";
            // 
            // MontoTextBox
            // 
            this.MontoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MontoTextBox.Location = new System.Drawing.Point(194, 173);
            this.MontoTextBox.Name = "MontoTextBox";
            this.MontoTextBox.Size = new System.Drawing.Size(389, 27);
            this.MontoTextBox.TabIndex = 8;
            // 
            // DepositoLabel
            // 
            this.DepositoLabel.AutoSize = true;
            this.DepositoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositoLabel.Location = new System.Drawing.Point(24, 221);
            this.DepositoLabel.Name = "DepositoLabel";
            this.DepositoLabel.Size = new System.Drawing.Size(76, 20);
            this.DepositoLabel.TabIndex = 9;
            this.DepositoLabel.Text = "Deposito";
            // 
            // DepositoTextBox
            // 
            this.DepositoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositoTextBox.Location = new System.Drawing.Point(194, 214);
            this.DepositoTextBox.Name = "DepositoTextBox";
            this.DepositoTextBox.Size = new System.Drawing.Size(389, 27);
            this.DepositoTextBox.TabIndex = 10;
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLabel.Location = new System.Drawing.Point(24, 264);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(70, 20);
            this.BalanceLabel.TabIndex = 11;
            this.BalanceLabel.Text = "Balance";
            // 
            // BalanceTextBox
            // 
            this.BalanceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceTextBox.Location = new System.Drawing.Point(194, 257);
            this.BalanceTextBox.Name = "BalanceTextBox";
            this.BalanceTextBox.ReadOnly = true;
            this.BalanceTextBox.Size = new System.Drawing.Size(389, 27);
            this.BalanceTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Comentarios";
            // 
            // ComentariosRichTextBox
            // 
            this.ComentariosRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComentariosRichTextBox.Location = new System.Drawing.Point(194, 299);
            this.ComentariosRichTextBox.Name = "ComentariosRichTextBox";
            this.ComentariosRichTextBox.Size = new System.Drawing.Size(389, 124);
            this.ComentariosRichTextBox.TabIndex = 14;
            this.ComentariosRichTextBox.Text = "";
            // 
            // NuevoButton
            // 
            this.NuevoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(52, 469);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(132, 58);
            this.NuevoButton.TabIndex = 15;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(237, 469);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(132, 58);
            this.GuardarButton.TabIndex = 16;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(431, 469);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(132, 58);
            this.EliminarButton.TabIndex = 17;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // MyerrorProvider
            // 
            this.MyerrorProvider.ContainerControl = this;
            // 
            // InscripcionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 551);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.ComentariosRichTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BalanceTextBox);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.DepositoTextBox);
            this.Controls.Add(this.DepositoLabel);
            this.Controls.Add(this.MontoTextBox);
            this.Controls.Add(this.MontoLabel);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.FechaLabel);
            this.Controls.Add(this.EstudianteIdLabel);
            this.Controls.Add(this.EstudianteIdNumericUpDown);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.InscripcionIdLabel);
            this.Controls.Add(this.InscripcionIdNumericUpDown);
            this.Name = "InscripcionForm";
            this.Text = "Inscripcion";
            this.Load += new System.EventHandler(this.InscripcionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InscripcionIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown InscripcionIdNumericUpDown;
        private System.Windows.Forms.Label InscripcionIdLabel;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.NumericUpDown EstudianteIdNumericUpDown;
        private System.Windows.Forms.Label EstudianteIdLabel;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label MontoLabel;
        private System.Windows.Forms.TextBox MontoTextBox;
        private System.Windows.Forms.Label DepositoLabel;
        private System.Windows.Forms.TextBox DepositoTextBox;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.TextBox BalanceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox ComentariosRichTextBox;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.ErrorProvider MyerrorProvider;
    }
}