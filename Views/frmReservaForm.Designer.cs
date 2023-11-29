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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            this.btnFinalizarReserva = new System.Windows.Forms.Button();
            this.btnFecharTela = new System.Windows.Forms.Button();
            this.grbReservaQuartos = new System.Windows.Forms.GroupBox();
            this.btnRemoverItem = new System.Windows.Forms.Button();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.IdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantidadeItem = new System.Windows.Forms.TextBox();
            this.txtIdQuarto = new System.Windows.Forms.TextBox();
            this.btnPesquisarQuarto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.grbDadosPedido = new System.Windows.Forms.GroupBox();
            this.txtDataHora = new System.Windows.Forms.TextBox();
            this.txtIdReserva = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.grbReservaQuartos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.grbDadosPedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelarReserva.Location = new System.Drawing.Point(11, 580);
            this.btnCancelarReserva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(170, 35);
            this.btnCancelarReserva.TabIndex = 19;
            this.btnCancelarReserva.Text = "Cancelar Reserva";
            this.btnCancelarReserva.UseVisualStyleBackColor = true;
            // 
            // btnFinalizarReserva
            // 
            this.btnFinalizarReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizarReserva.Location = new System.Drawing.Point(760, 580);
            this.btnFinalizarReserva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFinalizarReserva.Name = "btnFinalizarReserva";
            this.btnFinalizarReserva.Size = new System.Drawing.Size(170, 35);
            this.btnFinalizarReserva.TabIndex = 17;
            this.btnFinalizarReserva.Text = "Finalizar Reserva";
            this.btnFinalizarReserva.UseVisualStyleBackColor = true;
            // 
            // btnFecharTela
            // 
            this.btnFecharTela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFecharTela.Location = new System.Drawing.Point(938, 580);
            this.btnFecharTela.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFecharTela.Name = "btnFecharTela";
            this.btnFecharTela.Size = new System.Drawing.Size(123, 35);
            this.btnFecharTela.TabIndex = 18;
            this.btnFecharTela.Text = "Fechar tela";
            this.btnFecharTela.UseVisualStyleBackColor = true;
            // 
            // grbReservaQuartos
            // 
            this.grbReservaQuartos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbReservaQuartos.Controls.Add(this.btnRemoverItem);
            this.grbReservaQuartos.Controls.Add(this.lblValorTotal);
            this.grbReservaQuartos.Controls.Add(this.dgvReservas);
            this.grbReservaQuartos.Controls.Add(this.btnAdicionarItem);
            this.grbReservaQuartos.Controls.Add(this.label5);
            this.grbReservaQuartos.Controls.Add(this.txtQuantidadeItem);
            this.grbReservaQuartos.Controls.Add(this.txtIdQuarto);
            this.grbReservaQuartos.Controls.Add(this.btnPesquisarQuarto);
            this.grbReservaQuartos.Controls.Add(this.label4);
            this.grbReservaQuartos.Controls.Add(this.txtCategoria);
            this.grbReservaQuartos.Location = new System.Drawing.Point(11, 199);
            this.grbReservaQuartos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbReservaQuartos.Name = "grbReservaQuartos";
            this.grbReservaQuartos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbReservaQuartos.Size = new System.Drawing.Size(1050, 371);
            this.grbReservaQuartos.TabIndex = 16;
            this.grbReservaQuartos.TabStop = false;
            this.grbReservaQuartos.Text = "Quartos da Reserva";
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoverItem.Location = new System.Drawing.Point(927, 323);
            this.btnRemoverItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(112, 35);
            this.btnRemoverItem.TabIndex = 10;
            this.btnRemoverItem.Text = "Remover";
            this.btnRemoverItem.UseVisualStyleBackColor = true;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(567, 279);
            this.lblValorTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(474, 29);
            this.lblValorTotal.TabIndex = 8;
            this.lblValorTotal.Text = "Valor total: R$ 0,00";
            this.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.AllowUserToOrderColumns = true;
            this.dgvReservas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduto,
            this.DescricaoProduto,
            this.ValorUnitario,
            this.Quantidade,
            this.ValorTotal});
            this.dgvReservas.Location = new System.Drawing.Point(9, 91);
            this.dgvReservas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvReservas.MultiSelect = false;
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.RowHeadersVisible = false;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(1032, 185);
            this.dgvReservas.TabIndex = 7;
            // 
            // IdProduto
            // 
            this.IdProduto.DataPropertyName = "Produto.IdProduto";
            this.IdProduto.HeaderText = "Código";
            this.IdProduto.Name = "IdProduto";
            this.IdProduto.ReadOnly = true;
            this.IdProduto.Width = 80;
            // 
            // DescricaoProduto
            // 
            this.DescricaoProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescricaoProduto.DataPropertyName = "Produto.Descricao";
            this.DescricaoProduto.HeaderText = "Descrição";
            this.DescricaoProduto.Name = "DescricaoProduto";
            this.DescricaoProduto.ReadOnly = true;
            // 
            // ValorUnitario
            // 
            this.ValorUnitario.DataPropertyName = "ValorUnitario";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0,00";
            this.ValorUnitario.DefaultCellStyle = dataGridViewCellStyle1;
            this.ValorUnitario.HeaderText = "Preço";
            this.ValorUnitario.Name = "ValorUnitario";
            this.ValorUnitario.Width = 70;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.Quantidade.DefaultCellStyle = dataGridViewCellStyle2;
            this.Quantidade.HeaderText = "Qtd.";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Width = 70;
            // 
            // ValorTotal
            // 
            this.ValorTotal.DataPropertyName = "ValorTotal";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0,00";
            this.ValorTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.ValorTotal.HeaderText = "Total";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.Width = 70;
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarItem.Location = new System.Drawing.Point(940, 49);
            this.btnAdicionarItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(100, 29);
            this.btnAdicionarItem.TabIndex = 6;
            this.btnAdicionarItem.Text = "Adicionar";
            this.btnAdicionarItem.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(817, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantidade Hospedes";
            // 
            // txtQuantidadeItem
            // 
            this.txtQuantidadeItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantidadeItem.Location = new System.Drawing.Point(820, 54);
            this.txtQuantidadeItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuantidadeItem.MaxLength = 2;
            this.txtQuantidadeItem.Name = "txtQuantidadeItem";
            this.txtQuantidadeItem.Size = new System.Drawing.Size(110, 20);
            this.txtQuantidadeItem.TabIndex = 5;
            this.txtQuantidadeItem.Text = "1";
            // 
            // txtIdQuarto
            // 
            this.txtIdQuarto.Location = new System.Drawing.Point(9, 51);
            this.txtIdQuarto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdQuarto.Name = "txtIdQuarto";
            this.txtIdQuarto.ReadOnly = true;
            this.txtIdQuarto.Size = new System.Drawing.Size(56, 20);
            this.txtIdQuarto.TabIndex = 1;
            this.txtIdQuarto.TabStop = false;
            // 
            // btnPesquisarQuarto
            // 
            this.btnPesquisarQuarto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarQuarto.Location = new System.Drawing.Point(770, 49);
            this.btnPesquisarQuarto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPesquisarQuarto.Name = "btnPesquisarQuarto";
            this.btnPesquisarQuarto.Size = new System.Drawing.Size(42, 29);
            this.btnPesquisarQuarto.TabIndex = 3;
            this.btnPesquisarQuarto.Text = "...";
            this.btnPesquisarQuarto.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quarto";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategoria.Location = new System.Drawing.Point(76, 51);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(686, 20);
            this.txtCategoria.TabIndex = 2;
            this.txtCategoria.TabStop = false;
            // 
            // grbDadosPedido
            // 
            this.grbDadosPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDadosPedido.Controls.Add(this.txtDataHora);
            this.grbDadosPedido.Controls.Add(this.txtIdReserva);
            this.grbDadosPedido.Controls.Add(this.label3);
            this.grbDadosPedido.Controls.Add(this.label2);
            this.grbDadosPedido.Controls.Add(this.txtIdCliente);
            this.grbDadosPedido.Controls.Add(this.btnPesquisarCliente);
            this.grbDadosPedido.Controls.Add(this.label1);
            this.grbDadosPedido.Controls.Add(this.txtNomeCliente);
            this.grbDadosPedido.Location = new System.Drawing.Point(11, 19);
            this.grbDadosPedido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbDadosPedido.Name = "grbDadosPedido";
            this.grbDadosPedido.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbDadosPedido.Size = new System.Drawing.Size(1050, 171);
            this.grbDadosPedido.TabIndex = 15;
            this.grbDadosPedido.TabStop = false;
            this.grbDadosPedido.Text = "Dados do pedido";
            // 
            // txtDataHora
            // 
            this.txtDataHora.Location = new System.Drawing.Point(117, 125);
            this.txtDataHora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDataHora.Name = "txtDataHora";
            this.txtDataHora.ReadOnly = true;
            this.txtDataHora.Size = new System.Drawing.Size(176, 20);
            this.txtDataHora.TabIndex = 7;
            this.txtDataHora.TabStop = false;
            // 
            // txtIdReserva
            // 
            this.txtIdReserva.Location = new System.Drawing.Point(14, 125);
            this.txtIdReserva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdReserva.Name = "txtIdReserva";
            this.txtIdReserva.ReadOnly = true;
            this.txtIdReserva.Size = new System.Drawing.Size(92, 20);
            this.txtIdReserva.TabIndex = 5;
            this.txtIdReserva.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data/Hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Reserva";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(14, 48);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.ReadOnly = true;
            this.txtIdCliente.Size = new System.Drawing.Size(52, 20);
            this.txtIdCliente.TabIndex = 1;
            this.txtIdCliente.TabStop = false;
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarCliente.Location = new System.Drawing.Point(996, 48);
            this.btnPesquisarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(42, 29);
            this.btnPesquisarCliente.TabIndex = 3;
            this.btnPesquisarCliente.Text = "...";
            this.btnPesquisarCliente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeCliente.Location = new System.Drawing.Point(76, 48);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(912, 20);
            this.txtNomeCliente.TabIndex = 2;
            this.txtNomeCliente.TabStop = false;
            // 
            // frmReservaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 634);
            this.Controls.Add(this.btnCancelarReserva);
            this.Controls.Add(this.btnFinalizarReserva);
            this.Controls.Add(this.btnFecharTela);
            this.Controls.Add(this.grbReservaQuartos);
            this.Controls.Add(this.grbDadosPedido);
            this.Name = "frmReservaForm";
            this.Text = "frmReservaForm";
            this.grbReservaQuartos.ResumeLayout(false);
            this.grbReservaQuartos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.grbDadosPedido.ResumeLayout(false);
            this.grbDadosPedido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarReserva;
        private System.Windows.Forms.Button btnFinalizarReserva;
        private System.Windows.Forms.Button btnFecharTela;
        private System.Windows.Forms.GroupBox grbReservaQuartos;
        private System.Windows.Forms.Button btnRemoverItem;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.Button btnAdicionarItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantidadeItem;
        private System.Windows.Forms.TextBox txtIdQuarto;
        private System.Windows.Forms.Button btnPesquisarQuarto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.GroupBox grbDadosPedido;
        private System.Windows.Forms.TextBox txtDataHora;
        private System.Windows.Forms.TextBox txtIdReserva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCliente;
    }
}