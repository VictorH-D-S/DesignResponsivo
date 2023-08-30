namespace DesignResponsivo
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
            panel1 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            menuEsquerdo = new Panel();
            menuCima = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(324, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 188);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(70, 114);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(67, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(124, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 57);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // menuEsquerdo
            // 
            menuEsquerdo.Anchor = AnchorStyles.Left;
            menuEsquerdo.BackColor = Color.Coral;
            menuEsquerdo.Location = new Point(0, 2);
            menuEsquerdo.Name = "menuEsquerdo";
            menuEsquerdo.Size = new Size(270, 434);
            menuEsquerdo.TabIndex = 1;
            menuEsquerdo.Paint += menuEsquerdo_Paint;
            // 
            // menuCima
            // 
            menuCima.Anchor = AnchorStyles.Top;
            menuCima.BackColor = SystemColors.ControlText;
            menuCima.Location = new Point(0, 3);
            menuCima.Name = "menuCima";
            menuCima.Size = new Size(920, 97);
            menuCima.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 441);
            Controls.Add(menuEsquerdo);
            Controls.Add(panel1);
            Controls.Add(menuCima);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Panel menuEsquerdo;
        private Panel menuCima;
    }
}