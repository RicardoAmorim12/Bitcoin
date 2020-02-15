namespace Central
{
    partial class cadGasto
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
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label vencimentoLabel;
            System.Windows.Forms.Label mensalLabel;
            this.btcCentralDataSet = new Central.btcCentralDataSet();
            this.gastoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gastoTableAdapter = new Central.btcCentralDataSetTableAdapters.GastoTableAdapter();
            this.tableAdapterManager = new Central.btcCentralDataSetTableAdapters.TableAdapterManager();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.vencimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mensalCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            descricaoLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            vencimentoLabel = new System.Windows.Forms.Label();
            mensalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btcCentralDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(260, 143);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(65, 15);
            descricaoLabel.TabIndex = 3;
            descricaoLabel.Text = "Descricao:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(260, 181);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(38, 15);
            valorLabel.TabIndex = 5;
            valorLabel.Text = "Valor:";
            // 
            // vencimentoLabel
            // 
            vencimentoLabel.AutoSize = true;
            vencimentoLabel.Location = new System.Drawing.Point(260, 220);
            vencimentoLabel.Name = "vencimentoLabel";
            vencimentoLabel.Size = new System.Drawing.Size(75, 15);
            vencimentoLabel.TabIndex = 7;
            vencimentoLabel.Text = "Vencimento:";
            // 
            // mensalLabel
            // 
            mensalLabel.AutoSize = true;
            mensalLabel.Location = new System.Drawing.Point(260, 257);
            mensalLabel.Name = "mensalLabel";
            mensalLabel.Size = new System.Drawing.Size(51, 15);
            mensalLabel.TabIndex = 9;
            mensalLabel.Text = "Mensal:";
            // 
            // btcCentralDataSet
            // 
            this.btcCentralDataSet.DataSetName = "btcCentralDataSet";
            this.btcCentralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gastoBindingSource
            // 
            this.gastoBindingSource.DataMember = "Gasto";
            this.gastoBindingSource.DataSource = this.btcCentralDataSet;
            // 
            // gastoTableAdapter
            // 
            this.gastoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BancoTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.CompraTableAdapter = null;
            this.tableAdapterManager.GastoTableAdapter = this.gastoTableAdapter;
            this.tableAdapterManager.InformacaoTableAdapter = null;
            this.tableAdapterManager.ReciboTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Central.btcCentralDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gastoBindingSource, "Descricao", true));
            this.descricaoTextBox.Enabled = false;
            this.descricaoTextBox.Location = new System.Drawing.Point(341, 140);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(351, 21);
            this.descricaoTextBox.TabIndex = 4;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gastoBindingSource, "Valor", true));
            this.valorTextBox.Enabled = false;
            this.valorTextBox.Location = new System.Drawing.Point(341, 178);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(106, 21);
            this.valorTextBox.TabIndex = 6;
            // 
            // vencimentoDateTimePicker
            // 
            this.vencimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.gastoBindingSource, "Vencimento", true));
            this.vencimentoDateTimePicker.Enabled = false;
            this.vencimentoDateTimePicker.Location = new System.Drawing.Point(341, 216);
            this.vencimentoDateTimePicker.Name = "vencimentoDateTimePicker";
            this.vencimentoDateTimePicker.Size = new System.Drawing.Size(241, 21);
            this.vencimentoDateTimePicker.TabIndex = 8;
            // 
            // mensalCheckBox
            // 
            this.mensalCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.gastoBindingSource, "Mensal", true));
            this.mensalCheckBox.Enabled = false;
            this.mensalCheckBox.Location = new System.Drawing.Point(341, 252);
            this.mensalCheckBox.Name = "mensalCheckBox";
            this.mensalCheckBox.Size = new System.Drawing.Size(200, 24);
            this.mensalCheckBox.TabIndex = 10;
            this.mensalCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(345, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 33);
            this.button1.TabIndex = 11;
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
            this.button2.Location = new System.Drawing.Point(487, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 34);
            this.button2.TabIndex = 12;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cadGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(vencimentoLabel);
            this.Controls.Add(this.vencimentoDateTimePicker);
            this.Controls.Add(mensalLabel);
            this.Controls.Add(this.mensalCheckBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "cadGasto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Gastos Mensais";
            this.Load += new System.EventHandler(this.cadGasto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btcCentralDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private btcCentralDataSet btcCentralDataSet;
        private System.Windows.Forms.BindingSource gastoBindingSource;
        private btcCentralDataSetTableAdapters.GastoTableAdapter gastoTableAdapter;
        private btcCentralDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.DateTimePicker vencimentoDateTimePicker;
        private System.Windows.Forms.CheckBox mensalCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}