namespace RegistroArticulosDetalle.UI.Registros
{
    partial class rCotizar
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
            this.label9 = new System.Windows.Forms.Label();
            this.Id_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaCotizacion_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Persona_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Comentarios_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Total_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.Agregar_button = new System.Windows.Forms.Button();
            this.DetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.Importe_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.Precio_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Cantidad_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Articulo_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Buscar_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Eliminar_button = new System.Windows.Forms.Button();
            this.Nuevo_button = new System.Windows.Forms.Button();
            this.Guardar_button = new System.Windows.Forms.Button();
            this.ValidarErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Remover_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Id_numericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Total_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Importe_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Precio_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad_numericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValidarErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(120, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "Id:";
            // 
            // Id_numericUpDown
            // 
            this.Id_numericUpDown.Location = new System.Drawing.Point(154, 23);
            this.Id_numericUpDown.Name = "Id_numericUpDown";
            this.Id_numericUpDown.Size = new System.Drawing.Size(88, 20);
            this.Id_numericUpDown.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(372, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Fecha:";
            // 
            // FechaCotizacion_dateTimePicker
            // 
            this.FechaCotizacion_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaCotizacion_dateTimePicker.Location = new System.Drawing.Point(432, 19);
            this.FechaCotizacion_dateTimePicker.Name = "FechaCotizacion_dateTimePicker";
            this.FechaCotizacion_dateTimePicker.Size = new System.Drawing.Size(89, 20);
            this.FechaCotizacion_dateTimePicker.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(80, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Persona:";
            // 
            // Persona_comboBox
            // 
            this.Persona_comboBox.FormattingEnabled = true;
            this.Persona_comboBox.Location = new System.Drawing.Point(154, 55);
            this.Persona_comboBox.Name = "Persona_comboBox";
            this.Persona_comboBox.Size = new System.Drawing.Size(367, 21);
            this.Persona_comboBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Remover_button);
            this.groupBox1.Controls.Add(this.Comentarios_textBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Total_numericUpDown);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Agregar_button);
            this.groupBox1.Controls.Add(this.DetalleDataGridView);
            this.groupBox1.Controls.Add(this.Importe_numericUpDown);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Precio_numericUpDown);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Cantidad_numericUpDown);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Articulo_comboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(8, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 430);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Cotizacion";
            // 
            // Comentarios_textBox
            // 
            this.Comentarios_textBox.Location = new System.Drawing.Point(7, 377);
            this.Comentarios_textBox.Multiline = true;
            this.Comentarios_textBox.Name = "Comentarios_textBox";
            this.Comentarios_textBox.Size = new System.Drawing.Size(584, 47);
            this.Comentarios_textBox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(6, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 19);
            this.label8.TabIndex = 43;
            this.label8.Text = "Comentarios:";
            // 
            // Total_numericUpDown
            // 
            this.Total_numericUpDown.Location = new System.Drawing.Point(409, 343);
            this.Total_numericUpDown.Name = "Total_numericUpDown";
            this.Total_numericUpDown.Size = new System.Drawing.Size(99, 22);
            this.Total_numericUpDown.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(352, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 19);
            this.label7.TabIndex = 41;
            this.label7.Text = "Total:";
            // 
            // Agregar_button
            // 
            this.Agregar_button.Image = global::RegistroArticulosDetalle.Properties.Resources.new2;
            this.Agregar_button.Location = new System.Drawing.Point(531, 16);
            this.Agregar_button.Name = "Agregar_button";
            this.Agregar_button.Size = new System.Drawing.Size(31, 28);
            this.Agregar_button.TabIndex = 4;
            this.Agregar_button.UseVisualStyleBackColor = true;
            this.Agregar_button.Click += new System.EventHandler(this.Agregar_button_Click);
            // 
            // DetalleDataGridView
            // 
            this.DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDataGridView.Location = new System.Drawing.Point(7, 76);
            this.DetalleDataGridView.Name = "DetalleDataGridView";
            this.DetalleDataGridView.Size = new System.Drawing.Size(587, 255);
            this.DetalleDataGridView.TabIndex = 39;
            // 
            // Importe_numericUpDown
            // 
            this.Importe_numericUpDown.Location = new System.Drawing.Point(409, 41);
            this.Importe_numericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.Importe_numericUpDown.Name = "Importe_numericUpDown";
            this.Importe_numericUpDown.Size = new System.Drawing.Size(99, 22);
            this.Importe_numericUpDown.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(405, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 37;
            this.label6.Text = "Importe:";
            // 
            // Precio_numericUpDown
            // 
            this.Precio_numericUpDown.Location = new System.Drawing.Point(292, 40);
            this.Precio_numericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.Precio_numericUpDown.Name = "Precio_numericUpDown";
            this.Precio_numericUpDown.Size = new System.Drawing.Size(99, 22);
            this.Precio_numericUpDown.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(288, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "Precio:";
            // 
            // Cantidad_numericUpDown
            // 
            this.Cantidad_numericUpDown.Location = new System.Drawing.Point(199, 41);
            this.Cantidad_numericUpDown.Name = "Cantidad_numericUpDown";
            this.Cantidad_numericUpDown.Size = new System.Drawing.Size(87, 22);
            this.Cantidad_numericUpDown.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(195, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "Cantidad:";
            // 
            // Articulo_comboBox
            // 
            this.Articulo_comboBox.FormattingEnabled = true;
            this.Articulo_comboBox.Location = new System.Drawing.Point(7, 40);
            this.Articulo_comboBox.Name = "Articulo_comboBox";
            this.Articulo_comboBox.Size = new System.Drawing.Size(159, 23);
            this.Articulo_comboBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Articulo:";
            // 
            // Buscar_button
            // 
            this.Buscar_button.Image = global::RegistroArticulosDetalle.Properties.Resources.find;
            this.Buscar_button.Location = new System.Drawing.Point(248, 14);
            this.Buscar_button.Name = "Buscar_button";
            this.Buscar_button.Size = new System.Drawing.Size(34, 35);
            this.Buscar_button.TabIndex = 40;
            this.Buscar_button.UseVisualStyleBackColor = true;
            this.Buscar_button.Click += new System.EventHandler(this.Buscar_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Eliminar_button);
            this.groupBox2.Controls.Add(this.Nuevo_button);
            this.groupBox2.Controls.Add(this.Guardar_button);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(186, 528);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 81);
            this.groupBox2.TabIndex = 41;
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
            // ValidarErrorProvider
            // 
            this.ValidarErrorProvider.ContainerControl = this;
            // 
            // Remover_button
            // 
            this.Remover_button.Image = global::RegistroArticulosDetalle.Properties.Resources.remove;
            this.Remover_button.Location = new System.Drawing.Point(530, 47);
            this.Remover_button.Name = "Remover_button";
            this.Remover_button.Size = new System.Drawing.Size(32, 24);
            this.Remover_button.TabIndex = 44;
            this.Remover_button.UseVisualStyleBackColor = true;
            this.Remover_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // rCotizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(620, 621);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Buscar_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Persona_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FechaCotizacion_dateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Id_numericUpDown);
            this.Controls.Add(this.label9);
            this.MaximizeBox = false;
            this.Name = "rCotizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Cotizacion";
            ((System.ComponentModel.ISupportInitialize)(this.Id_numericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Total_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Importe_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Precio_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad_numericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ValidarErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown Id_numericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FechaCotizacion_dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Persona_comboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Agregar_button;
        private System.Windows.Forms.DataGridView DetalleDataGridView;
        private System.Windows.Forms.NumericUpDown Importe_numericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Precio_numericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Cantidad_numericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Articulo_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Buscar_button;
        private System.Windows.Forms.NumericUpDown Total_numericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Eliminar_button;
        private System.Windows.Forms.Button Nuevo_button;
        private System.Windows.Forms.Button Guardar_button;
        private System.Windows.Forms.TextBox Comentarios_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider ValidarErrorProvider;
        private System.Windows.Forms.Button Remover_button;
    }
}