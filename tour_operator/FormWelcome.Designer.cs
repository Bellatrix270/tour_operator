
namespace tour_operator
{
    partial class FormWelcome
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
            this.labelShow = new System.Windows.Forms.Label();
            this.ButtonBackground = new tour_operator.yt_Button();
            this.SuspendLayout();
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.labelShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelShow.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShow.ForeColor = System.Drawing.Color.LightGray;
            this.labelShow.Location = new System.Drawing.Point(538, 651);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(189, 21);
            this.labelShow.TabIndex = 1;
            this.labelShow.Text = "Больше не показывать";
            this.labelShow.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.labelShow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // ButtonBackground
            // 
            this.ButtonBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.ButtonBackground.BackColorAdditional = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ButtonBackground.BackColorGradientEnabled = true;
            this.ButtonBackground.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.ButtonBackground.BorderColor = System.Drawing.Color.Tomato;
            this.ButtonBackground.BorderColorEnabled = false;
            this.ButtonBackground.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.ButtonBackground.BorderColorOnHoverEnabled = false;
            this.ButtonBackground.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonBackground.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBackground.ForeColor = System.Drawing.Color.White;
            this.ButtonBackground.Location = new System.Drawing.Point(-4, -3);
            this.ButtonBackground.Name = "ButtonBackground";
            this.ButtonBackground.Rounding = 5;
            this.ButtonBackground.RoundingEnable = true;
            this.ButtonBackground.Size = new System.Drawing.Size(1271, 688);
            this.ButtonBackground.TabIndex = 0;
            this.ButtonBackground.Text = "Mazarine Sunset Company - Tour operator";
            // 
            // FormWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.labelShow);
            this.Controls.Add(this.ButtonBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Language - Языкова школа";
            this.Load += new System.EventHandler(this.FormWelcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private yt_Button ButtonBackground;
        private System.Windows.Forms.Label labelShow;
    }
}