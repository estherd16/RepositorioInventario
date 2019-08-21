namespace capaPresentacionWF
{
    partial class fSolicitud
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
            this.tabSolicitud = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateTimePickerHoraFinal = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaUso = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaSol = new System.Windows.Forms.DateTimePicker();
            this.comboBoxIdUsuario = new System.Windows.Forms.ComboBox();
            this.comboBoxIdRecursos = new System.Windows.Forms.ComboBox();
            this.labelidUs = new System.Windows.Forms.Label();
            this.labelidRec = new System.Windows.Forms.Label();
            this.textBoxAsignatura = new System.Windows.Forms.TextBox();
            this.textBoxCarrera = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxAula = new System.Windows.Forms.TextBox();
            this.textBoxNivel = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewSolicitud = new System.Windows.Forms.DataGridView();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.timeHoraInicio = new System.Windows.Forms.Timer(this.components);
            this.tabSolicitud.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolicitud)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSolicitud
            // 
            this.tabSolicitud.Controls.Add(this.tabPage1);
            this.tabSolicitud.Controls.Add(this.tabPage2);
            this.tabSolicitud.Location = new System.Drawing.Point(2, 1);
            this.tabSolicitud.Name = "tabSolicitud";
            this.tabSolicitud.SelectedIndex = 0;
            this.tabSolicitud.Size = new System.Drawing.Size(476, 505);
            this.tabSolicitud.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.dateTimePickerHoraFinal);
            this.tabPage1.Controls.Add(this.dateTimePickerHoraInicio);
            this.tabPage1.Controls.Add(this.dateTimePickerFechaUso);
            this.tabPage1.Controls.Add(this.dateTimePickerFechaSol);
            this.tabPage1.Controls.Add(this.comboBoxIdUsuario);
            this.tabPage1.Controls.Add(this.comboBoxIdRecursos);
            this.tabPage1.Controls.Add(this.labelidUs);
            this.tabPage1.Controls.Add(this.labelidRec);
            this.tabPage1.Controls.Add(this.textBoxAsignatura);
            this.tabPage1.Controls.Add(this.textBoxCarrera);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.buttonGuardar);
            this.tabPage1.Controls.Add(this.textBoxAula);
            this.tabPage1.Controls.Add(this.textBoxNivel);
            this.tabPage1.Controls.Add(this.textBoxId);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.labelId);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(468, 479);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            // 
            // dateTimePickerHoraFinal
            // 
            this.dateTimePickerHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHoraFinal.Location = new System.Drawing.Point(155, 275);
            this.dateTimePickerHoraFinal.Name = "dateTimePickerHoraFinal";
            this.dateTimePickerHoraFinal.ShowUpDown = true;
            this.dateTimePickerHoraFinal.Size = new System.Drawing.Size(206, 20);
            this.dateTimePickerHoraFinal.TabIndex = 28;
            // 
            // dateTimePickerHoraInicio
            // 
            this.dateTimePickerHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHoraInicio.Location = new System.Drawing.Point(155, 238);
            this.dateTimePickerHoraInicio.Name = "dateTimePickerHoraInicio";
            this.dateTimePickerHoraInicio.ShowUpDown = true;
            this.dateTimePickerHoraInicio.Size = new System.Drawing.Size(206, 20);
            this.dateTimePickerHoraInicio.TabIndex = 27;
            this.dateTimePickerHoraInicio.Value = new System.DateTime(2019, 7, 26, 0, 18, 34, 0);
            // 
            // dateTimePickerFechaUso
            // 
            this.dateTimePickerFechaUso.Location = new System.Drawing.Point(155, 200);
            this.dateTimePickerFechaUso.Name = "dateTimePickerFechaUso";
            this.dateTimePickerFechaUso.Size = new System.Drawing.Size(206, 20);
            this.dateTimePickerFechaUso.TabIndex = 26;
            // 
            // dateTimePickerFechaSol
            // 
            this.dateTimePickerFechaSol.Location = new System.Drawing.Point(155, 163);
            this.dateTimePickerFechaSol.Name = "dateTimePickerFechaSol";
            this.dateTimePickerFechaSol.Size = new System.Drawing.Size(206, 20);
            this.dateTimePickerFechaSol.TabIndex = 25;
            // 
            // comboBoxIdUsuario
            // 
            this.comboBoxIdUsuario.FormattingEnabled = true;
            this.comboBoxIdUsuario.Location = new System.Drawing.Point(155, 416);
            this.comboBoxIdUsuario.Name = "comboBoxIdUsuario";
            this.comboBoxIdUsuario.Size = new System.Drawing.Size(206, 21);
            this.comboBoxIdUsuario.TabIndex = 24;
            // 
            // comboBoxIdRecursos
            // 
            this.comboBoxIdRecursos.FormattingEnabled = true;
            this.comboBoxIdRecursos.Location = new System.Drawing.Point(155, 381);
            this.comboBoxIdRecursos.Name = "comboBoxIdRecursos";
            this.comboBoxIdRecursos.Size = new System.Drawing.Size(206, 21);
            this.comboBoxIdRecursos.TabIndex = 23;
            // 
            // labelidUs
            // 
            this.labelidUs.AutoSize = true;
            this.labelidUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidUs.ForeColor = System.Drawing.Color.Beige;
            this.labelidUs.Location = new System.Drawing.Point(60, 419);
            this.labelidUs.Name = "labelidUs";
            this.labelidUs.Size = new System.Drawing.Size(55, 16);
            this.labelidUs.TabIndex = 22;
            this.labelidUs.Text = "Usuario";
            // 
            // labelidRec
            // 
            this.labelidRec.AutoSize = true;
            this.labelidRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidRec.ForeColor = System.Drawing.Color.Beige;
            this.labelidRec.Location = new System.Drawing.Point(60, 384);
            this.labelidRec.Name = "labelidRec";
            this.labelidRec.Size = new System.Drawing.Size(66, 16);
            this.labelidRec.TabIndex = 21;
            this.labelidRec.Text = "Recursos";
            // 
            // textBoxAsignatura
            // 
            this.textBoxAsignatura.Location = new System.Drawing.Point(155, 346);
            this.textBoxAsignatura.Name = "textBoxAsignatura";
            this.textBoxAsignatura.Size = new System.Drawing.Size(206, 20);
            this.textBoxAsignatura.TabIndex = 20;
            // 
            // textBoxCarrera
            // 
            this.textBoxCarrera.Location = new System.Drawing.Point(155, 311);
            this.textBoxCarrera.Name = "textBoxCarrera";
            this.textBoxCarrera.Size = new System.Drawing.Size(206, 20);
            this.textBoxCarrera.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Beige;
            this.label11.Location = new System.Drawing.Point(60, 349);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Asignatura";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Beige;
            this.label9.Location = new System.Drawing.Point(60, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Carrera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Beige;
            this.label2.Location = new System.Drawing.Point(60, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Hora Final";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(204, 450);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 13;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxAula
            // 
            this.textBoxAula.Location = new System.Drawing.Point(155, 82);
            this.textBoxAula.Name = "textBoxAula";
            this.textBoxAula.Size = new System.Drawing.Size(206, 20);
            this.textBoxAula.TabIndex = 11;
            // 
            // textBoxNivel
            // 
            this.textBoxNivel.Location = new System.Drawing.Point(155, 121);
            this.textBoxNivel.Name = "textBoxNivel";
            this.textBoxNivel.Size = new System.Drawing.Size(206, 20);
            this.textBoxNivel.TabIndex = 10;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(155, 44);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(206, 20);
            this.textBoxId.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Beige;
            this.label7.Location = new System.Drawing.Point(59, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hora Inicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Beige;
            this.label6.Location = new System.Drawing.Point(59, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha Uso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Beige;
            this.label5.Location = new System.Drawing.Point(59, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha Solicitud";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Beige;
            this.label4.Location = new System.Drawing.Point(59, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nivel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Beige;
            this.label3.Location = new System.Drawing.Point(59, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aula";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.ForeColor = System.Drawing.Color.Beige;
            this.labelId.Location = new System.Drawing.Point(59, 44);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(73, 16);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "Id Solicitud";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Beige;
            this.label1.Location = new System.Drawing.Point(201, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Solicitud";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.dataGridViewSolicitud);
            this.tabPage2.Controls.Add(this.buttonEliminar);
            this.tabPage2.Controls.Add(this.buttonEditar);
            this.tabPage2.Controls.Add(this.textBoxBuscar);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(468, 479);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalles";
            // 
            // dataGridViewSolicitud
            // 
            this.dataGridViewSolicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSolicitud.Location = new System.Drawing.Point(2, 143);
            this.dataGridViewSolicitud.Name = "dataGridViewSolicitud";
            this.dataGridViewSolicitud.Size = new System.Drawing.Size(462, 272);
            this.dataGridViewSolicitud.TabIndex = 4;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(349, 49);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(255, 49);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(82, 50);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(164, 20);
            this.textBoxBuscar.TabIndex = 1;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Beige;
            this.label8.Location = new System.Drawing.Point(26, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Buscar";
            // 
            // fSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 509);
            this.Controls.Add(this.tabSolicitud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fSolicitud";
            this.Text = "Solicitud";
            this.Load += new System.EventHandler(this.fSolicitud_Load);
            this.tabSolicitud.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolicitud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSolicitud;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxAsignatura;
        private System.Windows.Forms.TextBox textBoxCarrera;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxAula;
        private System.Windows.Forms.TextBox textBoxNivel;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewSolicitud;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelidUs;
        private System.Windows.Forms.Label labelidRec;
        private System.Windows.Forms.ComboBox comboBoxIdUsuario;
        private System.Windows.Forms.ComboBox comboBoxIdRecursos;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaUso;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaSol;
        private System.Windows.Forms.Timer timeHoraInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerHoraFinal;
        private System.Windows.Forms.DateTimePicker dateTimePickerHoraInicio;
    }
}