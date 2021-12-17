
namespace SerializeDesirialize
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbMensagem = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnDeseXML = new System.Windows.Forms.Button();
            this.btnSeriXML = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSalarioJson = new System.Windows.Forms.Label();
            this.lblIdadeJson = new System.Windows.Forms.Label();
            this.lblNomeJson = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSalarioSoap = new System.Windows.Forms.Label();
            this.lblIdadeSoap = new System.Windows.Forms.Label();
            this.lblNomeSOAP = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbMensagem
            // 
            this.txbMensagem.Location = new System.Drawing.Point(47, 50);
            this.txbMensagem.Name = "txbMensagem";
            this.txbMensagem.Size = new System.Drawing.Size(273, 23);
            this.txbMensagem.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Serializar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(245, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Deserializar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(166, 85);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(38, 15);
            this.lblMsg.TabIndex = 3;
            this.lblMsg.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSalario);
            this.groupBox1.Controls.Add(this.lblIdade);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.btnDeseXML);
            this.groupBox1.Controls.Add(this.btnSeriXML);
            this.groupBox1.Location = new System.Drawing.Point(454, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 152);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "XML";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(28, 112);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(38, 15);
            this.lblSalario.TabIndex = 4;
            this.lblSalario.Text = "label3";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(28, 93);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(38, 15);
            this.lblIdade.TabIndex = 3;
            this.lblIdade.Text = "label2";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(28, 74);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 15);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "label1";
            // 
            // btnDeseXML
            // 
            this.btnDeseXML.Location = new System.Drawing.Point(155, 35);
            this.btnDeseXML.Name = "btnDeseXML";
            this.btnDeseXML.Size = new System.Drawing.Size(75, 23);
            this.btnDeseXML.TabIndex = 1;
            this.btnDeseXML.Text = "Deserializar";
            this.btnDeseXML.UseVisualStyleBackColor = true;
            this.btnDeseXML.Click += new System.EventHandler(this.btnDeseXML_Click);
            // 
            // btnSeriXML
            // 
            this.btnSeriXML.Location = new System.Drawing.Point(28, 35);
            this.btnSeriXML.Name = "btnSeriXML";
            this.btnSeriXML.Size = new System.Drawing.Size(75, 23);
            this.btnSeriXML.TabIndex = 0;
            this.btnSeriXML.Text = "Serializar";
            this.btnSeriXML.UseVisualStyleBackColor = true;
            this.btnSeriXML.Click += new System.EventHandler(this.btnSeriXML_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSalarioJson);
            this.groupBox2.Controls.Add(this.lblIdadeJson);
            this.groupBox2.Controls.Add(this.lblNomeJson);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(47, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 144);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "JSON";
            // 
            // lblSalarioJson
            // 
            this.lblSalarioJson.AutoSize = true;
            this.lblSalarioJson.Location = new System.Drawing.Point(15, 117);
            this.lblSalarioJson.Name = "lblSalarioJson";
            this.lblSalarioJson.Size = new System.Drawing.Size(38, 15);
            this.lblSalarioJson.TabIndex = 6;
            this.lblSalarioJson.Text = "label3";
            // 
            // lblIdadeJson
            // 
            this.lblIdadeJson.AutoSize = true;
            this.lblIdadeJson.Location = new System.Drawing.Point(15, 90);
            this.lblIdadeJson.Name = "lblIdadeJson";
            this.lblIdadeJson.Size = new System.Drawing.Size(38, 15);
            this.lblIdadeJson.TabIndex = 5;
            this.lblIdadeJson.Text = "label2";
            // 
            // lblNomeJson
            // 
            this.lblNomeJson.AutoSize = true;
            this.lblNomeJson.Location = new System.Drawing.Point(15, 66);
            this.lblNomeJson.Name = "lblNomeJson";
            this.lblNomeJson.Size = new System.Drawing.Size(38, 15);
            this.lblNomeJson.TabIndex = 4;
            this.lblNomeJson.Text = "label1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(142, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Deserializar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Serializar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSalarioSoap);
            this.groupBox3.Controls.Add(this.lblIdadeSoap);
            this.groupBox3.Controls.Add(this.lblNomeSOAP);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Location = new System.Drawing.Point(364, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 144);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SOAP";
            // 
            // lblSalarioSoap
            // 
            this.lblSalarioSoap.AutoSize = true;
            this.lblSalarioSoap.Location = new System.Drawing.Point(23, 117);
            this.lblSalarioSoap.Name = "lblSalarioSoap";
            this.lblSalarioSoap.Size = new System.Drawing.Size(38, 15);
            this.lblSalarioSoap.TabIndex = 11;
            this.lblSalarioSoap.Text = "label3";
            // 
            // lblIdadeSoap
            // 
            this.lblIdadeSoap.AutoSize = true;
            this.lblIdadeSoap.Location = new System.Drawing.Point(23, 90);
            this.lblIdadeSoap.Name = "lblIdadeSoap";
            this.lblIdadeSoap.Size = new System.Drawing.Size(38, 15);
            this.lblIdadeSoap.TabIndex = 10;
            this.lblIdadeSoap.Text = "label2";
            // 
            // lblNomeSOAP
            // 
            this.lblNomeSOAP.AutoSize = true;
            this.lblNomeSOAP.Location = new System.Drawing.Point(23, 66);
            this.lblNomeSOAP.Name = "lblNomeSOAP";
            this.lblNomeSOAP.Size = new System.Drawing.Size(38, 15);
            this.lblNomeSOAP.TabIndex = 9;
            this.lblNomeSOAP.Text = "label1";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(159, 36);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Deserializar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(23, 36);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Serializar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbMensagem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbMensagem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeseXML;
        private System.Windows.Forms.Button btnSeriXML;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSalarioJson;
        private System.Windows.Forms.Label lblIdadeJson;
        private System.Windows.Forms.Label lblNomeJson;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblSalarioSoap;
        private System.Windows.Forms.Label lblIdadeSoap;
        private System.Windows.Forms.Label lblNomeSOAP;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

