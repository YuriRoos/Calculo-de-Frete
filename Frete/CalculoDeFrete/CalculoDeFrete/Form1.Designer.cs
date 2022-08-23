namespace CalculoDeFrete
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.valor = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.entrega = new System.Windows.Forms.GroupBox();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.btnCalcularFrete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblfrete = new System.Windows.Forms.Label();
            this.lblvalorcompra = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.entrega.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // valor
            // 
            this.valor.AutoSize = true;
            this.valor.Location = new System.Drawing.Point(6, 69);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(31, 13);
            this.valor.TabIndex = 0;
            this.valor.Text = "Valor";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(6, 33);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(35, 13);
            this.nome.TabIndex = 1;
            this.nome.Text = "Nome";
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Location = new System.Drawing.Point(6, 106);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(40, 13);
            this.estado.TabIndex = 2;
            this.estado.Text = "Estado";
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(67, 62);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(121, 20);
            this.txtvalor.TabIndex = 4;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(67, 26);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(161, 20);
            this.txtnome.TabIndex = 5;
            // 
            // entrega
            // 
            this.entrega.Controls.Add(this.cboestado);
            this.entrega.Controls.Add(this.btnLimparCampos);
            this.entrega.Controls.Add(this.btnCalcularFrete);
            this.entrega.Controls.Add(this.nome);
            this.entrega.Controls.Add(this.valor);
            this.entrega.Controls.Add(this.txtvalor);
            this.entrega.Controls.Add(this.txtnome);
            this.entrega.Controls.Add(this.estado);
            this.entrega.Location = new System.Drawing.Point(12, 12);
            this.entrega.Name = "entrega";
            this.entrega.Size = new System.Drawing.Size(360, 227);
            this.entrega.TabIndex = 6;
            this.entrega.TabStop = false;
            this.entrega.Text = "Dados da entrega";
            // 
            // cboestado
            // 
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.cboestado.Location = new System.Drawing.Point(67, 97);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(121, 21);
            this.cboestado.TabIndex = 8;
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Location = new System.Drawing.Point(201, 155);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(115, 45);
            this.btnLimparCampos.TabIndex = 7;
            this.btnLimparCampos.Text = "Limpar";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.LimparCampos_Click);
            // 
            // btnCalcularFrete
            // 
            this.btnCalcularFrete.Location = new System.Drawing.Point(40, 155);
            this.btnCalcularFrete.Name = "btnCalcularFrete";
            this.btnCalcularFrete.Size = new System.Drawing.Size(111, 45);
            this.btnCalcularFrete.TabIndex = 6;
            this.btnCalcularFrete.Text = "Calcular";
            this.btnCalcularFrete.UseVisualStyleBackColor = true;
            this.btnCalcularFrete.Click += new System.EventHandler(this.CalcularFrete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbltotal);
            this.groupBox2.Controls.Add(this.lblfrete);
            this.groupBox2.Controls.Add(this.lblvalorcompra);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(11, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 212);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valores calculados";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(115, 113);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(73, 13);
            this.lbltotal.TabIndex = 5;
            this.lbltotal.Text = "___________";
            // 
            // lblfrete
            // 
            this.lblfrete.AutoSize = true;
            this.lblfrete.Location = new System.Drawing.Point(115, 76);
            this.lblfrete.Name = "lblfrete";
            this.lblfrete.Size = new System.Drawing.Size(73, 13);
            this.lblfrete.TabIndex = 4;
            this.lblfrete.Text = "___________";
            // 
            // lblvalorcompra
            // 
            this.lblvalorcompra.AutoSize = true;
            this.lblvalorcompra.Location = new System.Drawing.Point(115, 39);
            this.lblvalorcompra.Name = "lblvalorcompra";
            this.lblvalorcompra.Size = new System.Drawing.Size(73, 13);
            this.lblvalorcompra.TabIndex = 3;
            this.lblvalorcompra.Text = "___________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Frete";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Valor da compra";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 494);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.entrega);
            this.Name = "Form1";
            this.Text = "Form1";
            this.entrega.ResumeLayout(false);
            this.entrega.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label valor;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label estado;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.GroupBox entrega;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.Button btnCalcularFrete;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblfrete;
        private System.Windows.Forms.Label lblvalorcompra;
    }
}

