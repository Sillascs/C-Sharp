namespace Lab02
{
    partial class lab02Form
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
            this.calcularButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trocoLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.moedas1Label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.moedas050Label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.moedas025Label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.moedas010Label = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.moedas005Label = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.moedas001Label = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.valorCompraTextBox = new System.Windows.Forms.TextBox();
            this.valorPagoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calcularButton
            // 
            this.calcularButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcularButton.Location = new System.Drawing.Point(45, 157);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(244, 117);
            this.calcularButton.TabIndex = 6;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor da compra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor pago em dinheiro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor do troco:";
            // 
            // trocoLabel
            // 
            this.trocoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trocoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trocoLabel.Location = new System.Drawing.Point(189, 112);
            this.trocoLabel.Name = "trocoLabel";
            this.trocoLabel.Size = new System.Drawing.Size(100, 20);
            this.trocoLabel.TabIndex = 5;
            this.trocoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(301, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Moedas para o troco";
            // 
            // moedas1Label
            // 
            this.moedas1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moedas1Label.Location = new System.Drawing.Point(301, 79);
            this.moedas1Label.Name = "moedas1Label";
            this.moedas1Label.Size = new System.Drawing.Size(35, 13);
            this.moedas1Label.TabIndex = 8;
            this.moedas1Label.Text = "0";
            this.moedas1Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(392, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Moedas de R$ 1,00";
            // 
            // moedas050Label
            // 
            this.moedas050Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moedas050Label.Location = new System.Drawing.Point(301, 119);
            this.moedas050Label.Name = "moedas050Label";
            this.moedas050Label.Size = new System.Drawing.Size(35, 13);
            this.moedas050Label.TabIndex = 10;
            this.moedas050Label.Text = "0";
            this.moedas050Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(392, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Moedas de R$ 0,50";
            // 
            // moedas025Label
            // 
            this.moedas025Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moedas025Label.Location = new System.Drawing.Point(301, 162);
            this.moedas025Label.Name = "moedas025Label";
            this.moedas025Label.Size = new System.Drawing.Size(35, 13);
            this.moedas025Label.TabIndex = 12;
            this.moedas025Label.Text = "0";
            this.moedas025Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(392, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Moedas de R$ 0,25";
            // 
            // moedas010Label
            // 
            this.moedas010Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moedas010Label.Location = new System.Drawing.Point(301, 199);
            this.moedas010Label.Name = "moedas010Label";
            this.moedas010Label.Size = new System.Drawing.Size(35, 13);
            this.moedas010Label.TabIndex = 14;
            this.moedas010Label.Text = "0";
            this.moedas010Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(392, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Moedas de R$ 0,10";
            // 
            // moedas005Label
            // 
            this.moedas005Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moedas005Label.Location = new System.Drawing.Point(301, 231);
            this.moedas005Label.Name = "moedas005Label";
            this.moedas005Label.Size = new System.Drawing.Size(35, 13);
            this.moedas005Label.TabIndex = 16;
            this.moedas005Label.Text = "0";
            this.moedas005Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(392, 231);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Moedas de R$ 0,05";
            // 
            // moedas001Label
            // 
            this.moedas001Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moedas001Label.Location = new System.Drawing.Point(301, 261);
            this.moedas001Label.Name = "moedas001Label";
            this.moedas001Label.Size = new System.Drawing.Size(35, 13);
            this.moedas001Label.TabIndex = 18;
            this.moedas001Label.Text = "0";
            this.moedas001Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(392, 261);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "Moedas de R$ 0,01";
            // 
            // valorCompraTextBox
            // 
            this.valorCompraTextBox.Location = new System.Drawing.Point(189, 46);
            this.valorCompraTextBox.Name = "valorCompraTextBox";
            this.valorCompraTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorCompraTextBox.TabIndex = 1;
            this.valorCompraTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // valorPagoTextBox
            // 
            this.valorPagoTextBox.Location = new System.Drawing.Point(189, 72);
            this.valorPagoTextBox.Name = "valorPagoTextBox";
            this.valorPagoTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorPagoTextBox.TabIndex = 3;
            this.valorPagoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lab02Form
            // 
            this.AcceptButton = this.calcularButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.valorPagoTextBox);
            this.Controls.Add(this.valorCompraTextBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.moedas001Label);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.moedas005Label);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.moedas010Label);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.moedas025Label);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.moedas050Label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.moedas1Label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trocoLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcularButton);
            this.Name = "lab02Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratório";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label trocoLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label moedas1Label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label moedas025Label;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label moedas010Label;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label moedas005Label;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label moedas001Label;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox valorCompraTextBox;
        private System.Windows.Forms.TextBox valorPagoTextBox;
        private System.Windows.Forms.Label moedas050Label;
    }
}

