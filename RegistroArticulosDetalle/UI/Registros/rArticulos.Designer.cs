namespace RegistroArticulosDetalle.UI.Registros
{
    partial class rArticulos
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Eliminar_button = new System.Windows.Forms.Button();
            this.Nuevo_button = new System.Windows.Forms.Button();
            this.Guardar_button = new System.Windows.Forms.Button();
            this.CantCotizada_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Existencia_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Precio_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Descripcion_textBox = new System.Windows.Forms.TextBox();
            this.FechaVenc_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ArticuloId_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Validar_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Buscar_button = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantCotizada_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Existencia_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Precio_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloId_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Validar_errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Eliminar_button);
            this.groupBox2.Controls.Add(this.Nuevo_button);
            this.groupBox2.Controls.Add(this.Guardar_button);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(107, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 81);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // Eliminar_button
            // 
            this.Eliminar_button.Image = global::RegistroArticulosDetalle.Properties.Resources.Delete;
            this.Eliminar_button.Location = new System.Drawing.Point(139, 28);
            this.Eliminar_button.Name = "Eliminar_button";
            this.Eliminar_button.Size = new System.Drawing.Size(43, 42);
            this.Eliminar_button.TabIndex = 2;
            this.Eliminar_button.UseVisualStyleBackColor = true;
            this.Eliminar_button.Click += new System.EventHandler(this.Eliminar_button_Click);
            // 
            // Nuevo_button
            // 
            this.Nuevo_button.Image = global::RegistroArticulosDetalle.Properties.Resources.new2;
            this.Nuevo_button.Location = new System.Drawing.Point(13, 28);
            this.Nuevo_button.Name = "Nuevo_button";
            this.Nuevo_button.Size = new System.Drawing.Size(43, 42);
            this.Nuevo_button.TabIndex = 1;
            this.Nuevo_button.UseVisualStyleBackColor = true;
            this.Nuevo_button.Click += new System.EventHandler(this.Nuevo_button_Click);
            // 
            // Guardar_button
            // 
            this.Guardar_button.Image = global::RegistroArticulosDetalle.Properties.Resources.Save;
            this.Guardar_button.Location = new System.Drawing.Point(76, 28);
            this.Guardar_button.Name = "Guardar_button";
            this.Guardar_button.Size = new System.Drawing.Size(43, 42);
            this.Guardar_button.TabIndex = 0;
            this.Guardar_button.UseVisualStyleBackColor = true;
            this.Guardar_button.Click += new System.EventHandler(this.Guardar_button_Click);
            // 
            // CantCotizada_numericUpDown
            // 
            this.CantCotizada_numericUpDown.Enabled = false;
            this.CantCotizada_numericUpDown.Location = new System.Drawing.Point(151, 164);
            this.CantCotizada_numericUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.CantCotizada_numericUpDown.Name = "CantCotizada_numericUpDown";
            this.CantCotizada_numericUpDown.Size = new System.Drawing.Size(104, 20);
            this.CantCotizada_numericUpDown.TabIndex = 20;
            this.toolTip1.SetToolTip(this.CantCotizada_numericUpDown, "MAX 300");
            // 
            // Existencia_numericUpDown
            // 
            this.Existencia_numericUpDown.Location = new System.Drawing.Point(307, 128);
            this.Existencia_numericUpDown.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.Existencia_numericUpDown.Name = "Existencia_numericUpDown";
            this.Existencia_numericUpDown.Size = new System.Drawing.Size(90, 20);
            this.Existencia_numericUpDown.TabIndex = 18;
            this.toolTip1.SetToolTip(this.Existencia_numericUpDown, "MAX 800");
            // 
            // Precio_numericUpDown
            // 
            this.Precio_numericUpDown.Location = new System.Drawing.Point(103, 128);
            this.Precio_numericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Precio_numericUpDown.Name = "Precio_numericUpDown";
            this.Precio_numericUpDown.Size = new System.Drawing.Size(104, 20);
            this.Precio_numericUpDown.TabIndex = 16;
            this.toolTip1.SetToolTip(this.Precio_numericUpDown, "MAX $100,000");
            // 
            // Descripcion_textBox
            // 
            this.Descripcion_textBox.Location = new System.Drawing.Point(103, 91);
            this.Descripcion_textBox.Name = "Descripcion_textBox";
            this.Descripcion_textBox.Size = new System.Drawing.Size(294, 20);
            this.Descripcion_textBox.TabIndex = 15;
            // 
            // FechaVenc_dateTimePicker
            // 
            this.FechaVenc_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaVenc_dateTimePicker.Location = new System.Drawing.Point(151, 59);
            this.FechaVenc_dateTimePicker.Name = "FechaVenc_dateTimePicker";
            this.FechaVenc_dateTimePicker.Size = new System.Drawing.Size(103, 20);
            this.FechaVenc_dateTimePicker.TabIndex = 14;
            // 
            // ArticuloId_numericUpDown
            // 
            this.ArticuloId_numericUpDown.Location = new System.Drawing.Point(151, 26);
            this.ArticuloId_numericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ArticuloId_numericUpDown.Name = "ArticuloId_numericUpDown";
            this.ArticuloId_numericUpDown.Size = new System.Drawing.Size(104, 20);
            this.ArticuloId_numericUpDown.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(65, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "Articulo Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(17, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "Fecha Vencimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(17, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "Descripcion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(46, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(228, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Existencia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(17, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cantidad Cotizada";
            // 
            // Validar_errorProvider
            // 
            this.Validar_errorProvider.ContainerControl = this;
            // 
            // Buscar_button
            // 
            this.Buscar_button.Image = global::RegistroArticulosDetalle.Properties.Resources.find;
            this.Buscar_button.Location = new System.Drawing.Point(264, 17);
            this.Buscar_button.Name = "Buscar_button";
            this.Buscar_button.Size = new System.Drawing.Size(36, 37);
            this.Buscar_button.TabIndex = 22;
            this.Buscar_button.UseVisualStyleBackColor = true;
            this.Buscar_button.Click += new System.EventHandler(this.Buscar_button_Click);
            // 
            // rArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(429, 309);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CantCotizada_numericUpDown);
            this.Controls.Add(this.Existencia_numericUpDown);
            this.Controls.Add(this.Precio_numericUpDown);
            this.Controls.Add(this.Descripcion_textBox);
            this.Controls.Add(this.FechaVenc_dateTimePicker);
            this.Controls.Add(this.Buscar_button);
            this.Controls.Add(this.ArticuloId_numericUpDown);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "rArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Articulos";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CantCotizada_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Existencia_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Precio_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloId_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Validar_errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Eliminar_button;
        private System.Windows.Forms.Button Nuevo_button;
        private System.Windows.Forms.Button Guardar_button;
        private System.Windows.Forms.NumericUpDown CantCotizada_numericUpDown;
        private System.Windows.Forms.NumericUpDown Existencia_numericUpDown;
        private System.Windows.Forms.NumericUpDown Precio_numericUpDown;
        private System.Windows.Forms.TextBox Descripcion_textBox;
        private System.Windows.Forms.DateTimePicker FechaVenc_dateTimePicker;
        private System.Windows.Forms.Button Buscar_button;
        private System.Windows.Forms.NumericUpDown ArticuloId_numericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider Validar_errorProvider;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}