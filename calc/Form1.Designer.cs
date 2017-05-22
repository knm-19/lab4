namespace calc
{
    partial class Form1
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
            this.tbExpression = new System.Windows.Forms.TextBox();
            this.tbRes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btC = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btMod = new System.Windows.Forms.Button();
            this.Sum = new System.Windows.Forms.Button();
            this.btSubst = new System.Windows.Forms.Button();
            this.btMult = new System.Windows.Forms.Button();
            this.btDevid = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbExpression
            // 
            this.tbExpression.Location = new System.Drawing.Point(100, 27);
            this.tbExpression.Name = "tbExpression";
            this.tbExpression.Size = new System.Drawing.Size(293, 22);
            this.tbExpression.TabIndex = 0;
            // 
            // tbRes
            // 
            this.tbRes.Enabled = false;
            this.tbRes.Location = new System.Drawing.Point(100, 55);
            this.tbRes.Name = "tbRes";
            this.tbRes.Size = new System.Drawing.Size(293, 22);
            this.tbRes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Expression";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btC);
            this.groupBox1.Controls.Add(this.btBack);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(15, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 85);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editing";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btC
            // 
            this.btC.ForeColor = System.Drawing.Color.Red;
            this.btC.Location = new System.Drawing.Point(306, 21);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(55, 48);
            this.btC.TabIndex = 3;
            this.btC.Text = "С";
            this.btC.UseVisualStyleBackColor = true;
            // 
            // btBack
            // 
            this.btBack.ForeColor = System.Drawing.Color.Red;
            this.btBack.Location = new System.Drawing.Point(144, 21);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(147, 48);
            this.btBack.TabIndex = 2;
            this.btBack.Text = "Backspace";
            this.btBack.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(67, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = ")";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "(";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(21, 212);
            this.bt1.Margin = new System.Windows.Forms.Padding(4);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(57, 49);
            this.bt1.TabIndex = 5;
            this.bt1.TabStop = false;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(86, 212);
            this.bt2.Margin = new System.Windows.Forms.Padding(4);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(57, 49);
            this.bt2.TabIndex = 6;
            this.bt2.TabStop = false;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(151, 212);
            this.bt3.Margin = new System.Windows.Forms.Padding(4);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(57, 49);
            this.bt3.TabIndex = 7;
            this.bt3.TabStop = false;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(21, 269);
            this.bt4.Margin = new System.Windows.Forms.Padding(4);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(57, 49);
            this.bt4.TabIndex = 8;
            this.bt4.TabStop = false;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(86, 269);
            this.bt5.Margin = new System.Windows.Forms.Padding(4);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(57, 49);
            this.bt5.TabIndex = 9;
            this.bt5.TabStop = false;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(151, 269);
            this.bt6.Margin = new System.Windows.Forms.Padding(4);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(57, 49);
            this.bt6.TabIndex = 10;
            this.bt6.TabStop = false;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(21, 326);
            this.bt7.Margin = new System.Windows.Forms.Padding(4);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(57, 49);
            this.bt7.TabIndex = 11;
            this.bt7.TabStop = false;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(86, 326);
            this.bt8.Margin = new System.Windows.Forms.Padding(4);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(57, 49);
            this.bt8.TabIndex = 12;
            this.bt8.TabStop = false;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(151, 326);
            this.bt9.Margin = new System.Windows.Forms.Padding(4);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(57, 49);
            this.bt9.TabIndex = 13;
            this.bt9.TabStop = false;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(21, 383);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(57, 49);
            this.button8.TabIndex = 14;
            this.button8.TabStop = false;
            this.button8.Text = "+/-";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(86, 383);
            this.bt0.Margin = new System.Windows.Forms.Padding(4);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(57, 49);
            this.bt0.TabIndex = 15;
            this.bt0.TabStop = false;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            // 
            // btMod
            // 
            this.btMod.ForeColor = System.Drawing.Color.Red;
            this.btMod.Location = new System.Drawing.Point(151, 383);
            this.btMod.Margin = new System.Windows.Forms.Padding(4);
            this.btMod.Name = "btMod";
            this.btMod.Size = new System.Drawing.Size(57, 49);
            this.btMod.TabIndex = 16;
            this.btMod.TabStop = false;
            this.btMod.Text = "mod";
            this.btMod.UseVisualStyleBackColor = true;
            // 
            // Sum
            // 
            this.Sum.ForeColor = System.Drawing.Color.Red;
            this.Sum.Location = new System.Drawing.Point(216, 383);
            this.Sum.Margin = new System.Windows.Forms.Padding(4);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(57, 49);
            this.Sum.TabIndex = 17;
            this.Sum.TabStop = false;
            this.Sum.Text = "+";
            this.Sum.UseVisualStyleBackColor = true;
            // 
            // btSubst
            // 
            this.btSubst.ForeColor = System.Drawing.Color.Red;
            this.btSubst.Location = new System.Drawing.Point(216, 326);
            this.btSubst.Margin = new System.Windows.Forms.Padding(4);
            this.btSubst.Name = "btSubst";
            this.btSubst.Size = new System.Drawing.Size(57, 49);
            this.btSubst.TabIndex = 18;
            this.btSubst.TabStop = false;
            this.btSubst.Text = "-";
            this.btSubst.UseVisualStyleBackColor = true;
            // 
            // btMult
            // 
            this.btMult.ForeColor = System.Drawing.Color.Red;
            this.btMult.Location = new System.Drawing.Point(216, 269);
            this.btMult.Margin = new System.Windows.Forms.Padding(4);
            this.btMult.Name = "btMult";
            this.btMult.Size = new System.Drawing.Size(57, 49);
            this.btMult.TabIndex = 19;
            this.btMult.TabStop = false;
            this.btMult.Text = "*";
            this.btMult.UseVisualStyleBackColor = true;
            // 
            // btDevid
            // 
            this.btDevid.ForeColor = System.Drawing.Color.Red;
            this.btDevid.Location = new System.Drawing.Point(216, 212);
            this.btDevid.Margin = new System.Windows.Forms.Padding(4);
            this.btDevid.Name = "btDevid";
            this.btDevid.Size = new System.Drawing.Size(57, 49);
            this.btDevid.TabIndex = 20;
            this.btDevid.TabStop = false;
            this.btDevid.Text = "/";
            this.btDevid.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(321, 212);
            this.button21.Margin = new System.Windows.Forms.Padding(4);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(57, 49);
            this.button21.TabIndex = 21;
            this.button21.TabStop = false;
            this.button21.Text = "MR";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(319, 269);
            this.button22.Margin = new System.Windows.Forms.Padding(4);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(57, 49);
            this.button22.TabIndex = 22;
            this.button22.TabStop = false;
            this.button22.Text = "M+";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(319, 326);
            this.button23.Margin = new System.Windows.Forms.Padding(4);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(57, 49);
            this.button23.TabIndex = 23;
            this.button23.TabStop = false;
            this.button23.Text = "MC";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24
            // 
            this.button24.ForeColor = System.Drawing.Color.Red;
            this.button24.Location = new System.Drawing.Point(299, 383);
            this.button24.Margin = new System.Windows.Forms.Padding(4);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(77, 49);
            this.button24.TabIndex = 24;
            this.button24.TabStop = false;
            this.button24.Text = "=";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 483);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.btDevid);
            this.Controls.Add(this.btMult);
            this.Controls.Add(this.btSubst);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.btMod);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRes);
            this.Controls.Add(this.tbExpression);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbExpression;
        private System.Windows.Forms.TextBox tbRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btC;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btMod;
        private System.Windows.Forms.Button Sum;
        private System.Windows.Forms.Button btSubst;
        private System.Windows.Forms.Button btMult;
        private System.Windows.Forms.Button btDevid;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
    }
}

