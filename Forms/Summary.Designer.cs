
namespace WhiteSpaceNsp
{
    partial class Summary
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
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelPoints = new System.Windows.Forms.Label();
            this.labelRatio = new System.Windows.Forms.Label();
            this.valuePoints = new System.Windows.Forms.Label();
            this.valueRatio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("OCR A Extended", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(146, 59);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(514, 99);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "YOU WIN!";
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoints.Location = new System.Drawing.Point(203, 208);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(149, 39);
            this.labelPoints.TabIndex = 1;
            this.labelPoints.Text = "Points";
            // 
            // labelRatio
            // 
            this.labelRatio.AutoSize = true;
            this.labelRatio.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRatio.Location = new System.Drawing.Point(203, 307);
            this.labelRatio.Name = "labelRatio";
            this.labelRatio.Size = new System.Drawing.Size(215, 39);
            this.labelRatio.TabIndex = 2;
            this.labelRatio.Text = "Hit ratio";
            // 
            // valuePoints
            // 
            this.valuePoints.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valuePoints.Location = new System.Drawing.Point(460, 208);
            this.valuePoints.Name = "valuePoints";
            this.valuePoints.Size = new System.Drawing.Size(167, 39);
            this.valuePoints.TabIndex = 3;
            this.valuePoints.Text = "0";
            // 
            // valueRatio
            // 
            this.valueRatio.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueRatio.Location = new System.Drawing.Point(453, 307);
            this.valueRatio.Name = "valueRatio";
            this.valueRatio.Size = new System.Drawing.Size(335, 39);
            this.valueRatio.TabIndex = 4;
            this.valueRatio.Text = "0";
            // 
            // Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.valueRatio);
            this.Controls.Add(this.valuePoints);
            this.Controls.Add(this.labelRatio);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.labelStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Summary";
            this.Text = "Summary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Label labelRatio;
        private System.Windows.Forms.Label valuePoints;
        private System.Windows.Forms.Label valueRatio;
    }
}