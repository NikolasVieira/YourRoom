namespace YourRoom.Views
{
    partial class frmReservaForm
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
            this.txtNomeHospede = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisarHospede = new System.Windows.Forms.Button();
            this.txtIdHospede = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdReserva = new System.Windows.Forms.TextBox();
            this.dtpDtReserva = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.dtpDtCheckIn = new System.Windows.Forms.DateTimePicker();
            this.txtIdQuarto = new System.Windows.Forms.TextBox();
            this.btnPesquisarQuarto = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuantidadeHospede = new System.Windows.Forms.TextBox();
            this.dtpDtCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomeHospede
            // 
            this.txtNomeHospede.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeHospede.Location = new System.Drawing.Point(75, 68);
            this.txtNomeHospede.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomeHospede.Name = "txtNomeHospede";
            this.txtNomeHospede.ReadOnly = true;
            this.txtNomeHospede.Size = new System.Drawing.Size(102, 20);
            this.txtNomeHospede.TabIndex = 2;
            this.txtNomeHospede.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospede";
            // 
            // btnPesquisarHospede
            // 
            this.btnPesquisarHospede.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarHospede.Location = new System.Drawing.Point(185, 68);
            this.btnPesquisarHospede.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPesquisarHospede.Name = "btnPesquisarHospede";
            this.btnPesquisarHospede.Size = new System.Drawing.Size(42, 29);
            this.btnPesquisarHospede.TabIndex = 3;
            this.btnPesquisarHospede.Text = "...";
            this.btnPesquisarHospede.UseVisualStyleBackColor = true;
            this.btnPesquisarHospede.Click += new System.EventHandler(this.btnPesquisarHospede_Click);
            // 
            // txtIdHospede
            // 
            this.txtIdHospede.Location = new System.Drawing.Point(15, 69);
            this.txtIdHospede.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdHospede.Name = "txtIdHospede";
            this.txtIdHospede.ReadOnly = true;
            this.txtIdHospede.Size = new System.Drawing.Size(52, 20);
            this.txtIdHospede.TabIndex = 1;
            this.txtIdHospede.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Reserva";
            // 
            // txtIdReserva
            // 
            this.txtIdReserva.Location = new System.Drawing.Point(13, 23);
            this.txtIdReserva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdReserva.Name = "txtIdReserva";
            this.txtIdReserva.ReadOnly = true;
            this.txtIdReserva.Size = new System.Drawing.Size(214, 20);
            this.txtIdReserva.TabIndex = 5;
            this.txtIdReserva.TabStop = false;
            // 
            // dtpDtReserva
            // 
            this.dtpDtReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDtReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtReserva.Location = new System.Drawing.Point(15, 236);
            this.dtpDtReserva.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDtReserva.Name = "dtpDtReserva";
            this.dtpDtReserva.Size = new System.Drawing.Size(212, 20);
            this.dtpDtReserva.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 221);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Data Reserva";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategoria.Location = new System.Drawing.Point(75, 111);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(102, 20);
            this.txtCategoria.TabIndex = 2;
            this.txtCategoria.TabStop = false;
            // 
            // dtpDtCheckIn
            // 
            this.dtpDtCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDtCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtCheckIn.Location = new System.Drawing.Point(15, 291);
            this.dtpDtCheckIn.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDtCheckIn.Name = "dtpDtCheckIn";
            this.dtpDtCheckIn.Size = new System.Drawing.Size(212, 20);
            this.dtpDtCheckIn.TabIndex = 26;
            // 
            // txtIdQuarto
            // 
            this.txtIdQuarto.Location = new System.Drawing.Point(15, 112);
            this.txtIdQuarto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdQuarto.Name = "txtIdQuarto";
            this.txtIdQuarto.ReadOnly = true;
            this.txtIdQuarto.Size = new System.Drawing.Size(52, 20);
            this.txtIdQuarto.TabIndex = 1;
            this.txtIdQuarto.TabStop = false;
            // 
            // btnPesquisarQuarto
            // 
            this.btnPesquisarQuarto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarQuarto.Location = new System.Drawing.Point(185, 111);
            this.btnPesquisarQuarto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPesquisarQuarto.Name = "btnPesquisarQuarto";
            this.btnPesquisarQuarto.Size = new System.Drawing.Size(42, 29);
            this.btnPesquisarQuarto.TabIndex = 3;
            this.btnPesquisarQuarto.Text = "...";
            this.btnPesquisarQuarto.UseVisualStyleBackColor = true;
            this.btnPesquisarQuarto.Click += new System.EventHandler(this.btnPesquisarQuarto_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 276);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Data Check-In";
            // 
            // txtQuantidadeHospede
            // 
            this.txtQuantidadeHospede.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantidadeHospede.Location = new System.Drawing.Point(15, 174);
            this.txtQuantidadeHospede.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuantidadeHospede.MaxLength = 2;
            this.txtQuantidadeHospede.Name = "txtQuantidadeHospede";
            this.txtQuantidadeHospede.Size = new System.Drawing.Size(212, 20);
            this.txtQuantidadeHospede.TabIndex = 5;
            this.txtQuantidadeHospede.Text = "1";
            // 
            // dtpDtCheckOut
            // 
            this.dtpDtCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDtCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtCheckOut.Location = new System.Drawing.Point(15, 346);
            this.dtpDtCheckOut.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDtCheckOut.Name = "dtpDtCheckOut";
            this.dtpDtCheckOut.Size = new System.Drawing.Size(212, 20);
            this.dtpDtCheckOut.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantidade Hospedes";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 331);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Data Check-Out";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quarto";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(156, 392);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(75, 392);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 30;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // frmReservaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 427);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDtCheckOut);
            this.Controls.Add(this.txtQuantidadeHospede);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDtCheckIn);
            this.Controls.Add(this.btnPesquisarQuarto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDtReserva);
            this.Controls.Add(this.txtIdQuarto);
            this.Controls.Add(this.txtIdReserva);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdHospede);
            this.Controls.Add(this.txtNomeHospede);
            this.Controls.Add(this.btnPesquisarHospede);
            this.Name = "frmReservaForm";
            this.Text = "frmReservaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNomeHospede;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisarHospede;
        private System.Windows.Forms.TextBox txtIdHospede;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdReserva;
        private System.Windows.Forms.DateTimePicker dtpDtReserva;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.DateTimePicker dtpDtCheckIn;
        private System.Windows.Forms.TextBox txtIdQuarto;
        private System.Windows.Forms.Button btnPesquisarQuarto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQuantidadeHospede;
        private System.Windows.Forms.DateTimePicker dtpDtCheckOut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
    }
}