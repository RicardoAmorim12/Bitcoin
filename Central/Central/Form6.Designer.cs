namespace Central
{
    partial class cadCompra
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
            System.Windows.Forms.Label itemLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label descricaoLabel;
            this.btcCentralDataSet = new Central.btcCentralDataSet();
            this.compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compraTableAdapter = new Central.btcCentralDataSetTableAdapters.CompraTableAdapter();
            this.tableAdapterManager = new Central.btcCentralDataSetTableAdapters.TableAdapterManager();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            itemLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btcCentralDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // itemLabel
            // 
            itemLabel.AutoSize = true;
            itemLabel.Location = new System.Drawing.Point(255, 139);
            itemLabel.Name = "itemLabel";
            itemLabel.Size = new System.Drawing.Size(34, 15);
            itemLabel.TabIndex = 3;
            itemLabel.Text = "Item:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(255, 176);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(74, 15);
            quantidadeLabel.TabIndex = 5;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(476, 176);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(38, 15);
            valorLabel.TabIndex = 7;
            valorLabel.Text = "Valor:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(255, 217);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(36, 15);
            dataLabel.TabIndex = 9;
            dataLabel.Text = "Data:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(255, 254);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(65, 15);
            descricaoLabel.TabIndex = 11;
            descricaoLabel.Text = "Descricao:";
            // 
            // btcCentralDataSet
            // 
            this.btcCentralDataSet.DataSetName = "btcCentralDataSet";
            this.btcCentralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compraBindingSource
            // 
            this.compraBindingSource.DataMember = "Compra";
            this.compraBindingSource.DataSource = this.btcCentralDataSet;
            // 
            // compraTableAdapter
            // 
            this.compraTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BancoTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.CompraTableAdapter = this.compraTableAdapter;
            this.tableAdapterManager.GastoTableAdapter = null;
            this.tableAdapterManager.InformacaoTableAdapter = null;
            this.tableAdapterManager.ReciboTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Central.btcCentralDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // itemTextBox
            // 
            this.itemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraBindingSource, "Item", true));
            this.itemTextBox.Enabled = false;
            this.itemTextBox.Location = new System.Drawing.Point(335, 136);
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.Size = new System.Drawing.Size(300, 21);
            this.itemTextBox.TabIndex = 4;
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraBindingSource, "Quantidade", true));
            this.quantidadeTextBox.Enabled = false;
            this.quantidadeTextBox.Location = new System.Drawing.Point(335, 173);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(116, 21);
            this.quantidadeTextBox.TabIndex = 6;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraBindingSource, "Valor", true));
            this.valorTextBox.Enabled = false;
            this.valorTextBox.Location = new System.Drawing.Point(520, 173);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(115, 21);
            this.valorTextBox.TabIndex = 8;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.compraBindingSource, "Data", true));
            this.dataDateTimePicker.Enabled = false;
            this.dataDateTimePicker.Location = new System.Drawing.Point(335, 212);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(191, 21);
            this.dataDateTimePicker.TabIndex = 10;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraBindingSource, "Descricao", true));
            this.descricaoTextBox.Enabled = false;
            this.descricaoTextBox.Location = new System.Drawing.Point(335, 251);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(300, 21);
            this.descricaoTextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(357, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OliveDrab;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(520, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 33);
            this.button2.TabIndex = 14;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cadCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(itemLabel);
            this.Controls.Add(this.itemTextBox);
            this.Controls.Add(quantidadeLabel);
            this.Controls.Add(this.quantidadeTextBox);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "cadCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Compras";
            this.Load += new System.EventHandler(this.cadCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btcCentralDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private btcCentralDataSet btcCentralDataSet;
        private System.Windows.Forms.BindingSource compraBindingSource;
        private btcCentralDataSetTableAdapters.CompraTableAdapter compraTableAdapter;
        private btcCentralDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}