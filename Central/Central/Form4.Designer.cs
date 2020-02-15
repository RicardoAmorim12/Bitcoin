namespace Central
{
    partial class cadInfo
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
            System.Windows.Forms.Label maquinaLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label wattsLabel;
            System.Windows.Forms.Label moedaLabel;
            System.Windows.Forms.Label instalacaoLabel;
            this.btcCentralDataSet = new Central.btcCentralDataSet();
            this.informacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.informacaoTableAdapter = new Central.btcCentralDataSetTableAdapters.InformacaoTableAdapter();
            this.tableAdapterManager = new Central.btcCentralDataSetTableAdapters.TableAdapterManager();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.maquinaTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.wattsTextBox = new System.Windows.Forms.TextBox();
            this.moedaTextBox = new System.Windows.Forms.TextBox();
            this.instalacaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            nomeLabel = new System.Windows.Forms.Label();
            maquinaLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            wattsLabel = new System.Windows.Forms.Label();
            moedaLabel = new System.Windows.Forms.Label();
            instalacaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btcCentralDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informacaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(297, 122);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(44, 15);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // maquinaLabel
            // 
            maquinaLabel.AutoSize = true;
            maquinaLabel.Location = new System.Drawing.Point(297, 158);
            maquinaLabel.Name = "maquinaLabel";
            maquinaLabel.Size = new System.Drawing.Size(59, 15);
            maquinaLabel.TabIndex = 5;
            maquinaLabel.Text = "Maquina:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(297, 195);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(74, 15);
            quantidadeLabel.TabIndex = 7;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // wattsLabel
            // 
            wattsLabel.AutoSize = true;
            wattsLabel.Location = new System.Drawing.Point(463, 192);
            wattsLabel.Name = "wattsLabel";
            wattsLabel.Size = new System.Drawing.Size(40, 15);
            wattsLabel.TabIndex = 9;
            wattsLabel.Text = "Watts:";
            // 
            // moedaLabel
            // 
            moedaLabel.AutoSize = true;
            moedaLabel.Location = new System.Drawing.Point(297, 231);
            moedaLabel.Name = "moedaLabel";
            moedaLabel.Size = new System.Drawing.Size(49, 15);
            moedaLabel.TabIndex = 11;
            moedaLabel.Text = "Moeda:";
            // 
            // instalacaoLabel
            // 
            instalacaoLabel.AutoSize = true;
            instalacaoLabel.Location = new System.Drawing.Point(297, 268);
            instalacaoLabel.Name = "instalacaoLabel";
            instalacaoLabel.Size = new System.Drawing.Size(66, 15);
            instalacaoLabel.TabIndex = 13;
            instalacaoLabel.Text = "Instalacao:";
            // 
            // btcCentralDataSet
            // 
            this.btcCentralDataSet.DataSetName = "btcCentralDataSet";
            this.btcCentralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // informacaoBindingSource
            // 
            this.informacaoBindingSource.DataMember = "Informacao";
            this.informacaoBindingSource.DataSource = this.btcCentralDataSet;
            // 
            // informacaoTableAdapter
            // 
            this.informacaoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BancoTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.CompraTableAdapter = null;
            this.tableAdapterManager.GastoTableAdapter = null;
            this.tableAdapterManager.InformacaoTableAdapter = this.informacaoTableAdapter;
            this.tableAdapterManager.ReciboTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Central.btcCentralDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informacaoBindingSource, "Nome", true));
            this.nomeTextBox.Enabled = false;
            this.nomeTextBox.Location = new System.Drawing.Point(377, 119);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(225, 21);
            this.nomeTextBox.TabIndex = 4;
            // 
            // maquinaTextBox
            // 
            this.maquinaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informacaoBindingSource, "Maquina", true));
            this.maquinaTextBox.Enabled = false;
            this.maquinaTextBox.Location = new System.Drawing.Point(377, 155);
            this.maquinaTextBox.Name = "maquinaTextBox";
            this.maquinaTextBox.Size = new System.Drawing.Size(225, 21);
            this.maquinaTextBox.TabIndex = 6;
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informacaoBindingSource, "Quantidade", true));
            this.quantidadeTextBox.Enabled = false;
            this.quantidadeTextBox.Location = new System.Drawing.Point(377, 192);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(69, 21);
            this.quantidadeTextBox.TabIndex = 8;
            // 
            // wattsTextBox
            // 
            this.wattsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informacaoBindingSource, "Watts", true));
            this.wattsTextBox.Enabled = false;
            this.wattsTextBox.Location = new System.Drawing.Point(509, 189);
            this.wattsTextBox.Name = "wattsTextBox";
            this.wattsTextBox.Size = new System.Drawing.Size(93, 21);
            this.wattsTextBox.TabIndex = 10;
            // 
            // moedaTextBox
            // 
            this.moedaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informacaoBindingSource, "Moeda", true));
            this.moedaTextBox.Enabled = false;
            this.moedaTextBox.Location = new System.Drawing.Point(377, 228);
            this.moedaTextBox.Name = "moedaTextBox";
            this.moedaTextBox.Size = new System.Drawing.Size(225, 21);
            this.moedaTextBox.TabIndex = 12;
            // 
            // instalacaoDateTimePicker
            // 
            this.instalacaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.informacaoBindingSource, "Instalacao", true));
            this.instalacaoDateTimePicker.Enabled = false;
            this.instalacaoDateTimePicker.Location = new System.Drawing.Point(377, 264);
            this.instalacaoDateTimePicker.Name = "instalacaoDateTimePicker";
            this.instalacaoDateTimePicker.Size = new System.Drawing.Size(225, 21);
            this.instalacaoDateTimePicker.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(348, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 31);
            this.button1.TabIndex = 15;
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
            this.button2.Location = new System.Drawing.Point(520, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 31);
            this.button2.TabIndex = 16;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cadInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(maquinaLabel);
            this.Controls.Add(this.maquinaTextBox);
            this.Controls.Add(quantidadeLabel);
            this.Controls.Add(this.quantidadeTextBox);
            this.Controls.Add(wattsLabel);
            this.Controls.Add(this.wattsTextBox);
            this.Controls.Add(moedaLabel);
            this.Controls.Add(this.moedaTextBox);
            this.Controls.Add(instalacaoLabel);
            this.Controls.Add(this.instalacaoDateTimePicker);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "cadInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Informações";
            this.Load += new System.EventHandler(this.cadInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btcCentralDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informacaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private btcCentralDataSet btcCentralDataSet;
        private System.Windows.Forms.BindingSource informacaoBindingSource;
        private btcCentralDataSetTableAdapters.InformacaoTableAdapter informacaoTableAdapter;
        private btcCentralDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox maquinaTextBox;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.TextBox wattsTextBox;
        private System.Windows.Forms.TextBox moedaTextBox;
        private System.Windows.Forms.DateTimePicker instalacaoDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}