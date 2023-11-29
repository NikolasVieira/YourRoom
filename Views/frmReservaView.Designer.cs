namespace YourRoom.Views
{
    partial class frmReservaView
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
            this.grbDadosPedido = new System.Windows.Forms.GroupBox();
            this.txtDataHora = new System.Windows.Forms.TextBox();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.grbItensPedido = new System.Windows.Forms.GroupBox();
            this.dgvPedidoItens = new System.Windows.Forms.DataGridView();
            this.IdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grbDadosPedido.SuspendLayout();
            this.grbItensPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoItens)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDadosPedido
            // 
            this.grbDadosPedido.Controls.Add(this.txtDataHora);
            this.grbDadosPedido.Controls.Add(this.txtIdPedido);
            this.grbDadosPedido.Controls.Add(this.label3);
            this.grbDadosPedido.Controls.Add(this.label2);
            this.grbDadosPedido.Controls.Add(this.txtIdCliente);
            this.grbDadosPedido.Controls.Add(this.label1);
            this.grbDadosPedido.Controls.Add(this.txtNomeCliente);
            this.grbDadosPedido.Location = new System.Drawing.Point(12, 23);
            this.grbDadosPedido.Name = "grbDadosPedido";
            this.grbDadosPedido.Size = new System.Drawing.Size(548, 111);
            this.grbDadosPedido.TabIndex = 7;
            this.grbDadosPedido.TabStop = false;
            this.grbDadosPedido.Text = "Dados do pedido";
            // 
            // txtDataHora
            // 
            this.txtDataHora.Location = new System.Drawing.Point(78, 81);
            this.txtDataHora.Name = "txtDataHora";
            this.txtDataHora.ReadOnly = true;
            this.txtDataHora.Size = new System.Drawing.Size(119, 20);
            this.txtDataHora.TabIndex = 7;
            this.txtDataHora.TabStop = false;
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Location = new System.Drawing.Point(9, 81);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.ReadOnly = true;
            this.txtIdPedido.Size = new System.Drawing.Size(63, 20);
            this.txtIdPedido.TabIndex = 5;
            this.txtIdPedido.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data/Hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Pedido";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(9, 31);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.ReadOnly = true;
            this.txtIdCliente.Size = new System.Drawing.Size(36, 20);
            this.txtIdCliente.TabIndex = 1;
            this.txtIdCliente.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(51, 31);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(491, 20);
            this.txtNomeCliente.TabIndex = 2;
            this.txtNomeCliente.TabStop = false;
            // 
            // grbItensPedido
            // 
            this.grbItensPedido.Controls.Add(this.dgvPedidoItens);
            this.grbItensPedido.Controls.Add(this.lblValorTotal);
            this.grbItensPedido.Controls.Add(this.label4);
            this.grbItensPedido.Location = new System.Drawing.Point(12, 140);
            this.grbItensPedido.Name = "grbItensPedido";
            this.grbItensPedido.Size = new System.Drawing.Size(548, 249);
            this.grbItensPedido.TabIndex = 8;
            this.grbItensPedido.TabStop = false;
            this.grbItensPedido.Text = "Itens do pedido";
            // 
            // dgvPedidoItens
            // 
            this.dgvPedidoItens.AllowUserToAddRows = false;
            this.dgvPedidoItens.AllowUserToDeleteRows = false;
            this.dgvPedidoItens.AllowUserToOrderColumns = true;
            this.dgvPedidoItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedidoItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidoItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduto,
            this.DescricaoProduto,
            this.ValorUnitario,
            this.Quantidade,
            this.ValorTotal});
            this.dgvPedidoItens.Location = new System.Drawing.Point(6, 32);
            this.dgvPedidoItens.MultiSelect = false;
            this.dgvPedidoItens.Name = "dgvPedidoItens";
            this.dgvPedidoItens.RowHeadersVisible = false;
            this.dgvPedidoItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidoItens.Size = new System.Drawing.Size(536, 190);
            this.dgvPedidoItens.TabIndex = 9;
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
            // lblValorTotal
            // 
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(226, 225);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(316, 19);
            this.lblValorTotal.TabIndex = 8;
            this.lblValorTotal.Text = "Valor total: R$ 0,00";
            this.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Produto";
            // 
            // frmReservaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 413);
            this.Controls.Add(this.grbDadosPedido);
            this.Controls.Add(this.grbItensPedido);
            this.Name = "frmReservaView";
            this.Text = "frmReservaView";
            this.grbDadosPedido.ResumeLayout(false);
            this.grbDadosPedido.PerformLayout();
            this.grbItensPedido.ResumeLayout(false);
            this.grbItensPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDadosPedido;
        private System.Windows.Forms.TextBox txtDataHora;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.GroupBox grbItensPedido;
        private System.Windows.Forms.DataGridView dgvPedidoItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label label4;
    }
}