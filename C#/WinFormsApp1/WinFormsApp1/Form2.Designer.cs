namespace WinFormsApp1
{
    partial class Form2
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
            comboBox1=new ComboBox();
            comboBox2=new ComboBox();
            button1=new Button();
            label1=new Label();
            label2=new Label();
            label3=new Label();
            label4=new Label();
            label5=new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled=true;
            comboBox1.Location=new Point(24, 281);
            comboBox1.Name="comboBox1";
            comboBox1.Size=new Size(265, 33);
            comboBox1.TabIndex=0;
            comboBox1.SelectedIndexChanged+=comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled=true;
            comboBox2.Location=new Point(438, 281);
            comboBox2.Name="comboBox2";
            comboBox2.Size=new Size(262, 33);
            comboBox2.TabIndex=1;
            comboBox2.SelectedIndexChanged+=comboBox2_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location=new Point(861, 253);
            button1.Name="button1";
            button1.Size=new Size(106, 61);
            button1.TabIndex=2;
            button1.Text="Karşılaştır";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI Emoji", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(24, 233);
            label1.Name="label1";
            label1.Size=new Size(258, 37);
            label1.TabIndex=3;
            label1.Text="1.Çikolata Markası";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Segoe UI Emoji", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location=new Point(438, 233);
            label2.Name="label2";
            label2.Size=new Size(258, 37);
            label2.TabIndex=4;
            label2.Text="2.Çikolata Markası";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new Font("Swis721 Blk BT", 11F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location=new Point(295, 288);
            label3.Name="label3";
            label3.Size=new Size(70, 26);
            label3.TabIndex=5;
            label3.Text="Fiyat";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Font=new Font("Swis721 Blk BT", 11F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location=new Point(717, 288);
            label4.Name="label4";
            label4.Size=new Size(70, 26);
            label4.TabIndex=6;
            label4.Text="Fiyat";
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point(1001, 288);
            label5.Name="label5";
            label5.Size=new Size(61, 25);
            label5.TabIndex=7;
            label5.Text="Sonuç";
            // 
            // Form2
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1147, 599);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name="Form2";
            Text="Karşılaştır";
            Load+=Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}