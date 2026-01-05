namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            num1 = new TextBox();
            num2 = new TextBox();
            add = new Button();
            sub = new Button();
            devide = new Button();
            multiply = new Button();
            result = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 53);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "number 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 85);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "number 2";
            // 
            // num1
            // 
            num1.Location = new Point(170, 55);
            num1.Name = "num1";
            num1.Size = new Size(125, 27);
            num1.TabIndex = 2;
            // 
            // num2
            // 
            num2.Location = new Point(170, 85);
            num2.Name = "num2";
            num2.Size = new Size(125, 27);
            num2.TabIndex = 3;
            // 
            // add
            // 
            add.Location = new Point(91, 133);
            add.Name = "add";
            add.Size = new Size(53, 29);
            add.TabIndex = 4;
            add.Text = "+";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // sub
            // 
            sub.Location = new Point(150, 133);
            sub.Name = "sub";
            sub.Size = new Size(43, 29);
            sub.TabIndex = 5;
            sub.Text = "-";
            sub.UseVisualStyleBackColor = true;
            sub.Click += sub_Click_1;
            // 
            // devide
            // 
            devide.Location = new Point(252, 133);
            devide.Name = "devide";
            devide.Size = new Size(43, 29);
            devide.TabIndex = 6;
            devide.Text = "/";
            devide.UseVisualStyleBackColor = true;
            devide.Click += devide_Click_1;
            // 
            // multiply
            // 
            multiply.Location = new Point(199, 133);
            multiply.Name = "multiply";
            multiply.Size = new Size(49, 29);
            multiply.TabIndex = 7;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = true;
            multiply.Click += multiply_Click;
            // 
            // result
            // 
            result.Location = new Point(159, 182);
            result.Name = "result";
            result.Size = new Size(125, 27);
            result.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 185);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 9;
            label3.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(result);
            Controls.Add(multiply);
            Controls.Add(devide);
            Controls.Add(sub);
            Controls.Add(add);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox num1;
        private TextBox num2;
        private Button add;
        private Button sub;
        private Button devide;
        private Button multiply;
        private TextBox result;
        private Label label3;
    }
}
