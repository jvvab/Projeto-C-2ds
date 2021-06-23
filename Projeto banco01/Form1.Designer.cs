
namespace Projeto_banco01
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttelefone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.lblnome = new System.Windows.Forms.Label();
            this.lbltel = new System.Windows.Forms.Label();
            this.lblnome2 = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.DgvListaCliente = new System.Windows.Forms.DataGridView();
            this.Btnatt = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(139, 25);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 31);
            this.txtcodigo.TabIndex = 1;
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(139, 84);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(307, 31);
            this.txtnome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // txttelefone
            // 
            this.txttelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefone.Location = new System.Drawing.Point(139, 148);
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(166, 31);
            this.txttelefone.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone:";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(139, 207);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(330, 31);
            this.txtemail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email:";
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(216, 276);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(155, 54);
            this.btncadastrar.TabIndex = 8;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.ForeColor = System.Drawing.Color.Red;
            this.lblnome.Location = new System.Drawing.Point(453, 101);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(0, 13);
            this.lblnome.TabIndex = 9;
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltel.ForeColor = System.Drawing.Color.Red;
            this.lbltel.Location = new System.Drawing.Point(316, 163);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(0, 16);
            this.lbltel.TabIndex = 10;
            // 
            // lblnome2
            // 
            this.lblnome2.AutoSize = true;
            this.lblnome2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome2.ForeColor = System.Drawing.Color.Red;
            this.lblnome2.Location = new System.Drawing.Point(452, 99);
            this.lblnome2.Name = "lblnome2";
            this.lblnome2.Size = new System.Drawing.Size(0, 16);
            this.lblnome2.TabIndex = 11;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.Red;
            this.lblemail.Location = new System.Drawing.Point(475, 220);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(0, 16);
            this.lblemail.TabIndex = 12;
            // 
            // DgvListaCliente
            // 
            this.DgvListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaCliente.Location = new System.Drawing.Point(36, 365);
            this.DgvListaCliente.Name = "DgvListaCliente";
            this.DgvListaCliente.Size = new System.Drawing.Size(513, 150);
            this.DgvListaCliente.TabIndex = 13;
            this.DgvListaCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaCliente_CellClick);
            // 
            // Btnatt
            // 
            this.Btnatt.Location = new System.Drawing.Point(36, 276);
            this.Btnatt.Name = "Btnatt";
            this.Btnatt.Size = new System.Drawing.Size(155, 54);
            this.Btnatt.TabIndex = 14;
            this.Btnatt.Text = "Atualizar";
            this.Btnatt.UseVisualStyleBackColor = true;
            this.Btnatt.Click += new System.EventHandler(this.Btnatt_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(394, 276);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(155, 54);
            this.btnexcluir.TabIndex = 15;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(575, 445);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(115, 55);
            this.btnvoltar.TabIndex = 131;
            this.btnvoltar.Text = "voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 527);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.Btnatt);
            this.Controls.Add(this.DgvListaCliente);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblnome2);
            this.Controls.Add(this.lbltel);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.Label lblnome2;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.DataGridView DgvListaCliente;
        private System.Windows.Forms.Button Btnatt;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnvoltar;
    }
}

