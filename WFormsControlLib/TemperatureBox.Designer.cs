namespace WFormsControlLib
{
    partial class TemperatureBox : UserControl
    {

  
        private System.ComponentModel.IContainer components = null;

      
        /// <param name="disposing"> .</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

  
        private void InitializeComponent()
        {
            textBoxF = new TextBox();
            textBoxK = new TextBox();
            textBoxC = new TextBox();
            lblF = new Label();
            lblK = new Label();
            lblC = new Label();
            SuspendLayout();
            // 
            // textBoxF
            // 
            textBoxF.Location = new Point(286, 143);
            textBoxF.Name = "textBoxF";
            textBoxF.ReadOnly = true;
            textBoxF.Size = new Size(172, 31);
            textBoxF.TabIndex = 12;
            // 
            // textBoxK
            // 
            textBoxK.Location = new Point(286, 90);
            textBoxK.Name = "textBoxK";
            textBoxK.ReadOnly = true;
            textBoxK.Size = new Size(172, 31);
            textBoxK.TabIndex = 11;
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(286, 32);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(172, 31);
            textBoxC.TabIndex = 10;
            textBoxC.TextChanged += textBoxCelsius_TextChanged;
            // 
            // lblF
            // 
            lblF.AutoSize = true;
            lblF.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblF.Location = new Point(29, 148);
            lblF.Name = "lblF";
            lblF.Size = new Size(234, 26);
            lblF.TabIndex = 9;
            lblF.Text = "Шкала Фаренгейта:";
            // 
            // lblK
            // 
            lblK.AutoSize = true;
            lblK.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblK.Location = new Point(29, 95);
            lblK.Name = "lblK";
            lblK.Size = new Size(202, 26);
            lblK.TabIndex = 8;
            lblK.Text = "Шкала Кельвіна:";
            lblK.Click += lblK_Click;
            // 
            // lblC
            // 
            lblC.AutoSize = true;
            lblC.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblC.Location = new Point(29, 34);
            lblC.Name = "lblC";
            lblC.Size = new Size(190, 26);
            lblC.TabIndex = 7;
            lblC.Text = "Шкала Цельсія:";
            // 
            // TemperatureBox
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxF);
            Controls.Add(textBoxK);
            Controls.Add(textBoxC);
            Controls.Add(lblF);
            Controls.Add(lblK);
            Controls.Add(lblC);
            Name = "TemperatureBox";
            Size = new Size(481, 190);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxF;
        private TextBox textBoxK;
        private TextBox textBoxC;
        private Label lblF;
        private Label lblK;
        private Label lblC;
    }
}
