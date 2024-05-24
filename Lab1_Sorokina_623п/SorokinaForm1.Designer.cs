namespace Lab1_Sorokina_623п
{
    partial class SorokinaForm1
    {

        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing"
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SorokinaForm1));
            lblExp = new Label();
            temperatureBox1 = new WFormsControlLib.TemperatureBox();
            temperatureBox2 = new WFormsControlLib.TemperatureBox();
            temperatureBox3 = new WFormsControlLib.TemperatureBox();
            temperatureBox4 = new WFormsControlLib.TemperatureBox();
            temperatureBox5 = new WFormsControlLib.TemperatureBox();
            SuspendLayout();
            // 
            // lblExp
            // 
            lblExp.AutoSize = true;
            lblExp.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblExp.Location = new Point(60, 46);
            lblExp.Name = "lblExp";
            lblExp.Size = new Size(634, 32);
            lblExp.TabIndex = 0;
            lblExp.Text = "Введіть значення температури у будь-якій шкалі";
            // 
            // temperatureBox1
            // 
            temperatureBox1.Location = new Point(60, 93);
            temperatureBox1.Name = "temperatureBox1";
            temperatureBox1.Size = new Size(499, 253);
            temperatureBox1.TabIndex = 1;
            temperatureBox1.TemperatureCelsius = 0D;
            // 
            // temperatureBox2
            // 
            temperatureBox2.Location = new Point(0, 0);
            temperatureBox2.Name = "temperatureBox2";
            temperatureBox2.Size = new Size(722, 285);
            temperatureBox2.TabIndex = 2;
            temperatureBox2.TemperatureCelsius = 0D;
            // 
            // temperatureBox3
            // 
            temperatureBox3.Location = new Point(8, 8);
            temperatureBox3.Name = "temperatureBox3";
            temperatureBox3.Size = new Size(722, 285);
            temperatureBox3.TabIndex = 3;
            temperatureBox3.TemperatureCelsius = 0D;
            // 
            // temperatureBox4
            // 
            temperatureBox4.Location = new Point(22, 0);
            temperatureBox4.Name = "temperatureBox4";
            temperatureBox4.Size = new Size(8, 8);
            temperatureBox4.TabIndex = 4;
            temperatureBox4.TemperatureCelsius = 0D;
            // 
            // temperatureBox5
            // 
            temperatureBox5.Location = new Point(14, 0);
            temperatureBox5.Name = "temperatureBox5";
            temperatureBox5.Size = new Size(722, 285);
            temperatureBox5.TabIndex = 5;
            temperatureBox5.TemperatureCelsius = 0D;
            temperatureBox5.Load += temperatureBox5_Load;
            // 
            // SorokinaForm1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 358);
            Controls.Add(temperatureBox5);
            Controls.Add(temperatureBox4);
            Controls.Add(temperatureBox3);
            Controls.Add(temperatureBox2);
            Controls.Add(temperatureBox1);
            Controls.Add(lblExp);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SorokinaForm1";
            Text = "Сорокіна Анна 623п";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblExp;
        private WFormsControlLib.TemperatureBox temperatureBox1;
        private WFormsControlLib.TemperatureBox temperatureBox2;
        private WFormsControlLib.TemperatureBox temperatureBox3;
        private WFormsControlLib.TemperatureBox temperatureBox4;
        private WFormsControlLib.TemperatureBox temperatureBox5;
    }
}
