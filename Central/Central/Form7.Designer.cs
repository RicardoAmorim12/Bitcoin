namespace Central
{
    partial class cadRecibo
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label descricaoLabel;
            this.btcCentralDataSet = new Central.btcCentralDataSet();
            this.reciboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reciboTableAdapter = new Central.btcCentralDataSetTableAdapters.ReciboTableAdapter();
            this.tableAdapterManager = new Central.btcCentralDataSetTableAdapters.TableAdapterManager();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            nomeLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btcCentralDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reciboBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(264, 146);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(44, 15);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(264, 182);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(38, 15);
            valorLabel.TabIndex = 5;
            valorLabel.Text = "Valor:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(264, 221);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(65, 15);
            descricaoLabel.TabIndex = 7;
            descricaoLabel.Text = "Descricao:";
            // 
            // btcCentralDataSet
            // 
            this.btcCentralDataSet.DataSetName = "btcCentralDataSet";
            this.btcCentralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reciboBindingSource
            // 
            this.reciboBindingSource.DataMember = "Recibo";
            this.reciboBindingSource.DataSource = this.btcCentralDataSet;
            // 
            // reciboTableAdapter
            // 
            this.reciboTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BancoTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.CompraTableAdapter = null;
            this.tableAdapterManager.GastoTableAdapter = null;
            this.tableAdapterManager.InformacaoTableAdapter = null;
            this.tableAdapterManager.ReciboTableAdapter = this.reciboTableAdapter;
            this.tableAdapterManager.UpdateOrder = Central.btcCentralDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reciboBindingSource, "Nome", true));
            this.nomeTextBox.Enabled = false;
            this.nomeTextBox.Location = new System.Drawing.Point(335, 143);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(274, 21);
            this.nomeTextBox.TabIndex = 4;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reciboBindingSource, "Valor", true));
            this.valorTextBox.Enabled = false;
            this.valorTextBox.Location = new System.Drawing.Point(335, 179);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(100, 21);
            this.valorTextBox.TabIndex = 6;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reciboBindingSource, "Descricao", true));
            this.descricaoTextBox.Enabled = false;
            this.descricaoTextBox.Location = new System.Drawing.Point(335, 218);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(274, 21);
            this.descricaoTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(343, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 9;
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
            this.button2.Location = new System.Drawing.Point(496, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 10;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cadRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "cadRecibo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Recibos";
            this.Load += new System.EventHandler(this.cadRecibo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btcCentralDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reciboBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private btcCentralDataSet btcCentralDataSet;
        private System.Windows.Forms.BindingSource reciboBindingSource;
        private btcCentralDataSetTableAdapters.ReciboTableAdapter reciboTableAdapter;
        private btcCentralDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}