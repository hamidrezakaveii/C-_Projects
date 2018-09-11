namespace MyGauge
{
    partial class MyGauge
    {

        private System.ComponentModel.IContainer components = null;




        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "MyGauge";
            this.Size = new System.Drawing.Size(442, 182);
            this.ResumeLayout(false);

        }

    }
}
