namespace Practica_04_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnSignUp = new Button();
            lblUsuario = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(68, 256);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(328, 27);
            txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(68, 316);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(328, 27);
            txtPass.TabIndex = 1;
            // 
            // btnSignUp
            // 
            btnSignUp.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSignUp.Location = new Point(149, 349);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(191, 60);
            btnSignUp.TabIndex = 2;
            btnSignUp.Text = "Click";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(78, 226);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(99, 27);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 286);
            label1.Name = "label1";
            label1.Size = new Size(143, 27);
            label1.TabIndex = 4;
            label1.Text = "Contraseña";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(443, 450);
            Controls.Add(label1);
            Controls.Add(lblUsuario);
            Controls.Add(btnSignUp);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnSignUp;
        private Label lblUsuario;
        private Label label1;
    }
}
