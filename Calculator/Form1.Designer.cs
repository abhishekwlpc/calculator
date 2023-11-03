namespace Calculator
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
            textBox1 = new TextBox();
            on = new Button();
            backspace = new Button();
            clear = new Button();
            add = new Button();
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            sub = new Button();
            b4 = new Button();
            b5 = new Button();
            b6 = new Button();
            mul = new Button();
            b7 = new Button();
            b8 = new Button();
            b9 = new Button();
            div = new Button();
            point = new Button();
            b0 = new Button();
            result = new Button();
            off = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(637, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            // 
            // on
            // 
            on.Location = new Point(23, 74);
            on.Name = "on";
            on.Size = new Size(98, 52);
            on.TabIndex = 1;
            on.Text = "ON";
            on.UseVisualStyleBackColor = true;
            on.Click += off_Click;
            // 
            // backspace
            // 
            backspace.Location = new Point(187, 74);
            backspace.Name = "backspace";
            backspace.Size = new Size(98, 52);
            backspace.TabIndex = 2;
            backspace.Text = "<<";
            backspace.UseVisualStyleBackColor = true;
            backspace.Click += backspace_Click;
            // 
            // clear
            // 
            clear.Location = new Point(351, 74);
            clear.Name = "clear";
            clear.Size = new Size(98, 52);
            clear.TabIndex = 3;
            clear.Text = "CLEAN";
            clear.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            add.Location = new Point(514, 74);
            add.Name = "add";
            add.Size = new Size(98, 52);
            add.TabIndex = 4;
            add.Text = "+";
            add.UseVisualStyleBackColor = true;
            // 
            // b1
            // 
            b1.Location = new Point(23, 161);
            b1.Name = "b1";
            b1.Size = new Size(98, 52);
            b1.TabIndex = 5;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = true;
            // 
            // b2
            // 
            b2.Location = new Point(187, 161);
            b2.Name = "b2";
            b2.Size = new Size(98, 52);
            b2.TabIndex = 6;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = true;
            // 
            // b3
            // 
            b3.Location = new Point(351, 161);
            b3.Name = "b3";
            b3.Size = new Size(98, 52);
            b3.TabIndex = 7;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = true;
            // 
            // sub
            // 
            sub.Location = new Point(514, 161);
            sub.Name = "sub";
            sub.Size = new Size(98, 52);
            sub.TabIndex = 8;
            sub.Text = "-";
            sub.UseVisualStyleBackColor = true;
            // 
            // b4
            // 
            b4.Location = new Point(23, 249);
            b4.Name = "b4";
            b4.Size = new Size(98, 52);
            b4.TabIndex = 9;
            b4.Text = "4";
            b4.UseVisualStyleBackColor = true;
            // 
            // b5
            // 
            b5.Location = new Point(187, 249);
            b5.Name = "b5";
            b5.Size = new Size(98, 52);
            b5.TabIndex = 10;
            b5.Text = "5";
            b5.UseVisualStyleBackColor = true;
            // 
            // b6
            // 
            b6.Location = new Point(351, 249);
            b6.Name = "b6";
            b6.Size = new Size(98, 52);
            b6.TabIndex = 11;
            b6.Text = "6";
            b6.UseVisualStyleBackColor = true;
            // 
            // mul
            // 
            mul.Location = new Point(514, 249);
            mul.Name = "mul";
            mul.Size = new Size(98, 52);
            mul.TabIndex = 12;
            mul.Text = "*";
            mul.UseVisualStyleBackColor = true;
            // 
            // b7
            // 
            b7.Location = new Point(23, 340);
            b7.Name = "b7";
            b7.Size = new Size(98, 52);
            b7.TabIndex = 13;
            b7.Text = "7";
            b7.UseVisualStyleBackColor = true;
            // 
            // b8
            // 
            b8.Location = new Point(187, 340);
            b8.Name = "b8";
            b8.Size = new Size(98, 52);
            b8.TabIndex = 14;
            b8.Text = "8";
            b8.UseVisualStyleBackColor = true;
            // 
            // b9
            // 
            b9.Location = new Point(351, 338);
            b9.Name = "b9";
            b9.Size = new Size(98, 54);
            b9.TabIndex = 15;
            b9.Text = "9";
            b9.UseVisualStyleBackColor = true;
            // 
            // div
            // 
            div.Location = new Point(514, 340);
            div.Name = "div";
            div.Size = new Size(98, 52);
            div.TabIndex = 16;
            div.Text = "/";
            div.UseVisualStyleBackColor = true;
            // 
            // point
            // 
            point.Location = new Point(23, 436);
            point.Name = "point";
            point.Size = new Size(98, 52);
            point.TabIndex = 17;
            point.Text = ".";
            point.UseVisualStyleBackColor = true;
            // 
            // b0
            // 
            b0.Location = new Point(187, 436);
            b0.Name = "b0";
            b0.Size = new Size(98, 52);
            b0.TabIndex = 18;
            b0.Text = "0";
            b0.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            result.Location = new Point(351, 436);
            result.Name = "result";
            result.Size = new Size(261, 52);
            result.TabIndex = 19;
            result.Text = "=";
            result.UseVisualStyleBackColor = true;
            // 
            // off
            // 
            off.Location = new Point(23, 74);
            off.Name = "off";
            off.Size = new Size(98, 52);
            off.TabIndex = 20;
            off.Text = "OFF";
            off.UseVisualStyleBackColor = true;
            off.Click += off_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 544);
            Controls.Add(off);
            Controls.Add(result);
            Controls.Add(b0);
            Controls.Add(point);
            Controls.Add(div);
            Controls.Add(b9);
            Controls.Add(b8);
            Controls.Add(b7);
            Controls.Add(mul);
            Controls.Add(b6);
            Controls.Add(b5);
            Controls.Add(b4);
            Controls.Add(sub);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(b1);
            Controls.Add(add);
            Controls.Add(clear);
            Controls.Add(backspace);
            Controls.Add(on);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        

        #endregion

        private TextBox textBox1;
        private Button on;
        private Button backspace;
        private Button clear;
        private Button add;
        private Button b1;
        private Button b2;
        private Button b3;
        private Button sub;
        private Button b4;
        private Button b5;
        private Button b6;
        private Button mul;
        private Button b7;
        private Button b8;
        private Button b9;
        private Button div;
        private Button point;
        private Button b0;
        private Button result;
        private Button off;
    }
}