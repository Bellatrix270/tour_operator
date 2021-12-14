
namespace tour_operator
{
    partial class FormLogin
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.yt_ButtonLogin = new tour_operator.yt_Button();
            this.textBoxOLPassword = new tour_operator.TexBoxOneLine();
            this.textBoxOLLogin = new tour_operator.TexBoxOneLine();
            this.buttonCloseProg = new System.Windows.Forms.Button();
            this.pictureBoxHeader = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ObelixPro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(72, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Войти, как туроператор";
            // 
            // yt_ButtonLogin
            // 
            this.yt_ButtonLogin.BackColor = System.Drawing.Color.White;
            this.yt_ButtonLogin.BackColorAdditional = System.Drawing.Color.Gray;
            this.yt_ButtonLogin.BackColorGradientEnabled = false;
            this.yt_ButtonLogin.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.yt_ButtonLogin.BorderColor = System.Drawing.Color.Tomato;
            this.yt_ButtonLogin.BorderColorEnabled = false;
            this.yt_ButtonLogin.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.yt_ButtonLogin.BorderColorOnHoverEnabled = false;
            this.yt_ButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yt_ButtonLogin.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.yt_ButtonLogin.ForeColor = System.Drawing.Color.Black;
            this.yt_ButtonLogin.Location = new System.Drawing.Point(152, 450);
            this.yt_ButtonLogin.Name = "yt_ButtonLogin";
            this.yt_ButtonLogin.RoundingEnable = true;
            this.yt_ButtonLogin.Size = new System.Drawing.Size(150, 30);
            this.yt_ButtonLogin.TabIndex = 6;
            this.yt_ButtonLogin.Text = "Войти";
            this.yt_ButtonLogin.Click += new System.EventHandler(this.yt_ButtonLogin_Click);
            // 
            // textBoxOLPassword
            // 
            this.textBoxOLPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBoxOLPassword.ColorHintText = System.Drawing.Color.Gray;
            this.textBoxOLPassword.ColorLine = System.Drawing.Color.White;
            this.textBoxOLPassword.ForeColor = System.Drawing.Color.White;
            this.textBoxOLPassword.HintText = "Пароль";
            this.textBoxOLPassword.Location = new System.Drawing.Point(152, 329);
            this.textBoxOLPassword.Name = "textBoxOLPassword";
            this.textBoxOLPassword.OffsetYLine = 25;
            this.textBoxOLPassword.Size = new System.Drawing.Size(150, 40);
            this.textBoxOLPassword.TabIndex = 5;
            this.textBoxOLPassword.Text = "Пароль";
            this.textBoxOLPassword.ValidateState = tour_operator.TexBoxOneLine.validateState.None;
            this.textBoxOLPassword.WidthLine = 1F;
            // 
            // textBoxOLLogin
            // 
            this.textBoxOLLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBoxOLLogin.ColorHintText = System.Drawing.Color.Gray;
            this.textBoxOLLogin.ColorLine = System.Drawing.Color.White;
            this.textBoxOLLogin.ForeColor = System.Drawing.Color.White;
            this.textBoxOLLogin.HintText = "Логин или email";
            this.textBoxOLLogin.Location = new System.Drawing.Point(152, 231);
            this.textBoxOLLogin.Name = "textBoxOLLogin";
            this.textBoxOLLogin.OffsetYLine = 25;
            this.textBoxOLLogin.Size = new System.Drawing.Size(150, 40);
            this.textBoxOLLogin.TabIndex = 4;
            this.textBoxOLLogin.Text = "Логин или email";
            this.textBoxOLLogin.ValidateState = tour_operator.TexBoxOneLine.validateState.None;
            this.textBoxOLLogin.WidthLine = 1F;
            // 
            // buttonCloseProg
            // 
            this.buttonCloseProg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.buttonCloseProg.BackgroundImage = global::tour_operator.Properties.Resources.close;
            this.buttonCloseProg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCloseProg.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonCloseProg.FlatAppearance.BorderSize = 0;
            this.buttonCloseProg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseProg.Location = new System.Drawing.Point(448, 5);
            this.buttonCloseProg.Name = "buttonCloseProg";
            this.buttonCloseProg.Size = new System.Drawing.Size(15, 15);
            this.buttonCloseProg.TabIndex = 3;
            this.buttonCloseProg.UseVisualStyleBackColor = false;
            this.buttonCloseProg.Click += new System.EventHandler(this.buttonCloseProg_Click);
            // 
            // pictureBoxHeader
            // 
            this.pictureBoxHeader.Image = global::tour_operator.Properties.Resources.UpperBar;
            this.pictureBoxHeader.Location = new System.Drawing.Point(1, 0);
            this.pictureBoxHeader.Name = "pictureBoxHeader";
            this.pictureBoxHeader.Size = new System.Drawing.Size(480, 33);
            this.pictureBoxHeader.TabIndex = 2;
            this.pictureBoxHeader.TabStop = false;
            this.pictureBoxHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(480, 720);
            this.Controls.Add(this.yt_ButtonLogin);
            this.Controls.Add(this.textBoxOLPassword);
            this.Controls.Add(this.textBoxOLLogin);
            this.Controls.Add(this.buttonCloseProg);
            this.Controls.Add(this.pictureBoxHeader);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mazarine Sunset Company";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxHeader;
        private System.Windows.Forms.Button buttonCloseProg;
        private TexBoxOneLine textBoxOLLogin;
        private TexBoxOneLine textBoxOLPassword;
        private yt_Button yt_ButtonLogin;
    }
}

