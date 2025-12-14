namespace Quanlythuvien.UI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmdLogin = new Button();
            cmdCan = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(354, 87);
            label1.Name = "label1";
            label1.Size = new Size(178, 38);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 204);
            label2.Name = "label2";
            label2.Size = new Size(103, 23);
            label2.TabIndex = 1;
            label2.Text = "Tên truy cập";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 266);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // cmdLogin
            // 
            cmdLogin.Location = new Point(278, 358);
            cmdLogin.Name = "cmdLogin";
            cmdLogin.Size = new Size(106, 33);
            cmdLogin.TabIndex = 3;
            cmdLogin.Text = "Đăng nhập";
            cmdLogin.UseVisualStyleBackColor = true;
            cmdLogin.Click += cmdLogin_Click;
            // 
            // cmdCan
            // 
            cmdCan.Location = new Point(567, 358);
            cmdCan.Name = "cmdCan";
            cmdCan.Size = new Size(106, 33);
            cmdCan.TabIndex = 4;
            cmdCan.Text = "Huỷ bỏ";
            cmdCan.UseVisualStyleBackColor = true;
            cmdCan.Click += cmdCan_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(379, 196);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(319, 30);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(379, 258);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(319, 30);
            txtPassword.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.ErrorImage = Properties.Resources.z7254206241031_b8bc972c53eef7f064bf8b9bbf7aa852;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(38, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 135);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 476);
            Controls.Add(pictureBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(cmdCan);
            Controls.Add(cmdLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "LoginForm";
            Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button cmdLogin;
        private Button cmdCan;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private PictureBox pictureBox1;
    }
}