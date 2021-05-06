
namespace CurrencyConvertor {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if ( disposing && (components != null) ) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.euro_value = new System.Windows.Forms.Label();
            this.dolar_value = new System.Windows.Forms.Label();
            this.ron_value = new System.Windows.Forms.Label();
            this.euro_btn = new System.Windows.Forms.RadioButton();
            this.usd_btn = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ron_btn = new System.Windows.Forms.RadioButton();
            this.user_input = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // euro_value
            // 
            this.euro_value.AutoSize = true;
            this.euro_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.euro_value.Location = new System.Drawing.Point(312, 262);
            this.euro_value.Name = "euro_value";
            this.euro_value.Size = new System.Drawing.Size(94, 31);
            this.euro_value.TabIndex = 0;
            this.euro_value.Text = "EUR : ";
            // 
            // dolar_value
            // 
            this.dolar_value.AutoSize = true;
            this.dolar_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dolar_value.Location = new System.Drawing.Point(311, 311);
            this.dolar_value.Name = "dolar_value";
            this.dolar_value.Size = new System.Drawing.Size(94, 31);
            this.dolar_value.TabIndex = 1;
            this.dolar_value.Text = "USD : ";
            // 
            // ron_value
            // 
            this.ron_value.AutoSize = true;
            this.ron_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ron_value.Location = new System.Drawing.Point(302, 353);
            this.ron_value.Name = "ron_value";
            this.ron_value.Size = new System.Drawing.Size(104, 31);
            this.ron_value.TabIndex = 2;
            this.ron_value.Text = "RON :  ";
            // 
            // euro_btn
            // 
            this.euro_btn.AutoSize = true;
            this.euro_btn.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.euro_btn.Location = new System.Drawing.Point(3, 12);
            this.euro_btn.Name = "euro_btn";
            this.euro_btn.Size = new System.Drawing.Size(67, 28);
            this.euro_btn.TabIndex = 4;
            this.euro_btn.TabStop = true;
            this.euro_btn.Text = "Euro";
            this.euro_btn.UseVisualStyleBackColor = true;
            // 
            // usd_btn
            // 
            this.usd_btn.AutoSize = true;
            this.usd_btn.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usd_btn.Location = new System.Drawing.Point(3, 39);
            this.usd_btn.Name = "usd_btn";
            this.usd_btn.Size = new System.Drawing.Size(65, 28);
            this.usd_btn.TabIndex = 5;
            this.usd_btn.TabStop = true;
            this.usd_btn.Text = "USD";
            this.usd_btn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.ron_btn);
            this.panel1.Controls.Add(this.usd_btn);
            this.panel1.Controls.Add(this.euro_btn);
            this.panel1.Location = new System.Drawing.Point(91, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 102);
            this.panel1.TabIndex = 6;
            // 
            // ron_btn
            // 
            this.ron_btn.AutoSize = true;
            this.ron_btn.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ron_btn.Location = new System.Drawing.Point(3, 62);
            this.ron_btn.Name = "ron_btn";
            this.ron_btn.Size = new System.Drawing.Size(62, 28);
            this.ron_btn.TabIndex = 6;
            this.ron_btn.TabStop = true;
            this.ron_btn.Text = "Ron";
            this.ron_btn.UseVisualStyleBackColor = true;
            // 
            // user_input
            // 
            this.user_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_input.Location = new System.Drawing.Point(91, 84);
            this.user_input.Name = "user_input";
            this.user_input.Size = new System.Drawing.Size(207, 53);
            this.user_input.TabIndex = 7;
            this.user_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user_input_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 479);
            this.Controls.Add(this.user_input);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ron_value);
            this.Controls.Add(this.dolar_value);
            this.Controls.Add(this.euro_value);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CurrencyConvertor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label euro_value;
        private System.Windows.Forms.Label dolar_value;
        private System.Windows.Forms.Label ron_value;
        private System.Windows.Forms.RadioButton euro_btn;
        private System.Windows.Forms.RadioButton usd_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton ron_btn;
        private System.Windows.Forms.TextBox user_input;
    }
}

