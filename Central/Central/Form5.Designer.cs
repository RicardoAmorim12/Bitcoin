namespace Central
{
    partial class cadBanco
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
            System.Windows.Forms.Label moedaLabel;
            System.Windows.Forms.Label carteiraLabel;
            this.btcCentralDataSet = new Central.btcCentralDataSet();
            this.bancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoTableAdapter = new Central.btcCentralDataSetTableAdapters.BancoTableAdapter();
            this.tableAdapterManager = new Central.btcCentralDataSetTableAdapters.TableAdapterManager();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.moedaTextBox = new System.Windows.Forms.TextBox();
            this.carteiraTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            nomeLabel = new System.Windows.Forms.Label();
            moedaLabel = new System.Windows.Forms.Label();
            carteiraLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btcCentralDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(265, 151);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(44, 15);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // moedaLabel
            // 
            moedaLabel.AutoSize = true;
            moedaLabel.Location = new System.Drawing.Point(265, 188);
            moedaLabel.Name = "moedaLabel";
            moedaLabel.Size = new System.Drawing.Size(49, 15);
            moedaLabel.TabIndex = 5;
            moedaLabel.Text = "Moeda:";
            // 
            // carteiraLabel
            // 
            carteiraLabel.AutoSize = true;
            carteiraLabel.Location = new System.Drawing.Point(265, 225);
            carteiraLabel.Name = "carteiraLabel";
            carteiraLabel.Size = new System.Drawing.Size(53, 15);
            carteiraLabel.TabIndex = 7;
            carteiraLabel.Text = "Carteira:";
            // 
            // btcCentralDataSet
            // 
            this.btcCentralDataSet.DataSetName = "btcCentralDataSet";
            this.btcCentralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bancoBindingSource
            // 
            this.bancoBindingSource.DataMember = "Banco";
            this.bancoBindingSource.DataSource = this.btcCentralDataSet;
            // 
            // bancoTableAdapter
            // 
            this.bancoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BancoTableAdapter = this.bancoTableAdapter;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.CompraTableAdapter = null;
            this.tableAdapterManager.GastoTableAdapter = null;
            this.tableAdapterManager.InformacaoTableAdapter = null;
            this.tableAdapterManager.ReciboTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Central.btcCentralDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bancoBindingSource, "Nome", true));
            this.nomeTextBox.Enabled = false;
            this.nomeTextBox.Location = new System.Drawing.Point(324, 148);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(256, 21);
            this.nomeTextBox.TabIndex = 4;
            // 
            // moedaTextBox
            // 
            this.moedaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bancoBindingSource, "Moeda", true));
            this.moedaTextBox.Enabled = false;
            this.moedaTextBox.Location = new System.Drawing.Point(324, 185);
            this.moedaTextBox.Name = "moedaTextBox";
            this.moedaTextBox.Size = new System.Drawing.Size(100, 21);
            this.moedaTextBox.TabIndex = 6;
            // 
            // carteiraTextBox
            // 
            this.carteiraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bancoBindingSource, "Carteira", true));
            this.carteiraTextBox.Enabled = false;
            this.carteiraTextBox.Location = new System.Drawing.Point(324, 222);
            this.carteiraTextBox.Name = "carteiraTextBox";
            this.carteiraTextBox.Size = new System.Drawing.Size(323, 21);
            this.carteiraTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(324, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
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
            this.button2.Location = new System.Drawing.Point(485, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 34);
            this.button2.TabIndex = 10;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cadBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(moedaLabel);
            this.Controls.Add(this.moedaTextBox);
            this.Controls.Add(carteiraLabel);
            this.Controls.Add(this.carteiraTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "cadBanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Bancário";
            this.Load += new System.EventHandler(this.cadBanco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btcCentralDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private btcCentralDataSet btcCentralDataSet;
        private System.Windows.Forms.BindingSource bancoBindingSource;
        private btcCentralDataSetTableAdapters.BancoTableAdapter bancoTableAdapter;
        private btcCentralDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox moedaTextBox;
        private System.Windows.Forms.TextBox carteiraTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}