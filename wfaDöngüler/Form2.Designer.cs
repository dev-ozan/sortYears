namespace wfaDöngüler
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
            comboYillar = new ComboBox();
            btnYillar = new Button();
            btnTersyillar = new Button();
            SuspendLayout();
            // 
            // comboYillar
            // 
            comboYillar.FormattingEnabled = true;
            comboYillar.Location = new Point(68, 77);
            comboYillar.Margin = new Padding(4);
            comboYillar.Name = "comboYillar";
            comboYillar.Size = new Size(193, 29);
            comboYillar.TabIndex = 0;
            // 
            // btnYillar
            // 
            btnYillar.Location = new Point(68, 137);
            btnYillar.Margin = new Padding(4);
            btnYillar.Name = "btnYillar";
            btnYillar.Size = new Size(193, 32);
            btnYillar.TabIndex = 1;
            btnYillar.Text = "Yılları Sırala";
            btnYillar.UseVisualStyleBackColor = true;
            btnYillar.Click += btnYillar_Click;
            // 
            // btnTersyillar
            // 
            btnTersyillar.Location = new Point(68, 198);
            btnTersyillar.Margin = new Padding(4);
            btnTersyillar.Name = "btnTersyillar";
            btnTersyillar.Size = new Size(193, 32);
            btnTersyillar.TabIndex = 3;
            btnTersyillar.Text = "Tersten Sırala";
            btnTersyillar.UseVisualStyleBackColor = true;
            btnTersyillar.Click += btnTersyillar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 355);
            Controls.Add(btnTersyillar);
            Controls.Add(btnYillar);
            Controls.Add(comboYillar);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboYillar;
        private Button btnYillar;
        private Button btnTersyillar;
    }
}