
namespace Form_calcu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.resu = new System.Windows.Forms.Label();
            this.Soma = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(12, 67);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(85, 20);
            this.txt1.TabIndex = 1;
            this.txt1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(200, 67);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(91, 20);
            this.txt2.TabIndex = 2;
            // 
            // resu
            // 
            this.resu.AutoSize = true;
            this.resu.Location = new System.Drawing.Point(154, 179);
            this.resu.Name = "resu";
            this.resu.Size = new System.Drawing.Size(0, 13);
            this.resu.TabIndex = 3;
            // 
            // Soma
            // 
            this.Soma.Location = new System.Drawing.Point(12, 93);
            this.Soma.Name = "Soma";
            this.Soma.Size = new System.Drawing.Size(75, 23);
            this.Soma.TabIndex = 4;
            this.Soma.Text = "Soma";
            this.Soma.UseVisualStyleBackColor = true;
            this.Soma.Click += new System.EventHandler(this.Soma_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(12, 122);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(75, 23);
            this.sub.TabIndex = 5;
            this.sub.Text = "Subtração";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(200, 122);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(87, 23);
            this.division.TabIndex = 6;
            this.division.Text = "Divição";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // multi
            // 
            this.multi.Location = new System.Drawing.Point(200, 93);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(87, 23);
            this.multi.TabIndex = 7;
            this.multi.Text = "Multiplicação";
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.multi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resultado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Digite 1° numero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Digite o 1° numero";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(57, 215);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(394, 277);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.division);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.Soma);
            this.Controls.Add(this.resu);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label resu;
        private System.Windows.Forms.Button Soma;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

