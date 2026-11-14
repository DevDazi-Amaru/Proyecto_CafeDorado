namespace Proyecto_CafeDorado
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.ProviderContra = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ProviderUsu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnInicio = new Guna.UI2.WinForms.Guna2Button();
            this.TxtContraseña = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TxtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnMinimizar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSalir = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_HOR_POSITIVE;
            this.guna2BorderlessForm1.BorderRadius = global::Proyecto_CafeDorado.Properties.Settings.Default.Border;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockForm = false;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.BorderRadius = 25;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.ProviderContra);
            this.guna2Panel2.Controls.Add(this.ProviderUsu);
            this.guna2Panel2.Controls.Add(this.btnInicio);
            this.guna2Panel2.Controls.Add(this.TxtContraseña);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel2.Controls.Add(this.TxtUsuario);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(237)))), ((int)(((byte)(230)))));
            this.guna2Panel2.Location = new System.Drawing.Point(485, 130);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.BorderRadius = 5;
            this.guna2Panel2.ShadowDecoration.Depth = 5;
            this.guna2Panel2.ShadowDecoration.Enabled = true;
            this.guna2Panel2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 13, 12);
            this.guna2Panel2.Size = new System.Drawing.Size(300, 350);
            this.guna2Panel2.TabIndex = 1;
            // 
            // ProviderContra
            // 
            this.ProviderContra.BackColor = System.Drawing.Color.Transparent;
            this.ProviderContra.ForeColor = System.Drawing.Color.Red;
            this.ProviderContra.IsSelectionEnabled = false;
            this.ProviderContra.Location = new System.Drawing.Point(47, 257);
            this.ProviderContra.Name = "ProviderContra";
            this.ProviderContra.Size = new System.Drawing.Size(195, 15);
            this.ProviderContra.TabIndex = 6;
            this.ProviderContra.Text = "Por favor, Ingrese una contraseña valida\r\n";
            this.ProviderContra.Visible = false;
            // 
            // ProviderUsu
            // 
            this.ProviderUsu.BackColor = System.Drawing.Color.Transparent;
            this.ProviderUsu.ForeColor = System.Drawing.Color.Red;
            this.ProviderUsu.IsSelectionEnabled = false;
            this.ProviderUsu.Location = new System.Drawing.Point(47, 145);
            this.ProviderUsu.Name = "ProviderUsu";
            this.ProviderUsu.Size = new System.Drawing.Size(170, 15);
            this.ProviderUsu.TabIndex = 5;
            this.ProviderUsu.Text = "Por favor, Ingrese un usuario valido";
            this.ProviderUsu.Visible = false;
            // 
            // btnInicio
            // 
            this.btnInicio.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInicio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInicio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInicio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInicio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnInicio.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.btnInicio.Location = new System.Drawing.Point(28, 292);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(250, 39);
            this.btnInicio.TabIndex = 4;
            this.btnInicio.Text = "INICIAR SESION";
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.BackColor = System.Drawing.Color.Transparent;
            this.TxtContraseña.BorderColor = System.Drawing.Color.Black;
            this.TxtContraseña.BorderRadius = 15;
            this.TxtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtContraseña.DefaultText = "";
            this.TxtContraseña.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtContraseña.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtContraseña.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtContraseña.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtContraseña.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(237)))), ((int)(((byte)(230)))));
            this.TxtContraseña.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtContraseña.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.TxtContraseña.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtContraseña.IconLeft = global::Proyecto_CafeDorado.Properties.Resources.password_icon;
            this.TxtContraseña.IconRight = global::Proyecto_CafeDorado.Properties.Resources.eye_icon;
            this.TxtContraseña.Location = new System.Drawing.Point(27, 201);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.PlaceholderText = "";
            this.TxtContraseña.SelectedText = "";
            this.TxtContraseña.ShadowDecoration.BorderRadius = 5;
            this.TxtContraseña.ShadowDecoration.Depth = 5;
            this.TxtContraseña.ShadowDecoration.Enabled = true;
            this.TxtContraseña.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.TxtContraseña.Size = new System.Drawing.Size(252, 50);
            this.TxtContraseña.TabIndex = 3;
            this.TxtContraseña.UseSystemPasswordChar = true;
            this.TxtContraseña.IconRightClick += new System.EventHandler(this.TxtContraseña_IconRightClick);
            this.TxtContraseña.TextChanged += new System.EventHandler(this.TxtContraseña_TextChanged);
            this.TxtContraseña.Click += new System.EventHandler(this.TxtContraseña_Click);
            this.TxtContraseña.Enter += new System.EventHandler(this.TxtContraseña_Enter);
            this.TxtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtContraseña_KeyPress);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(26, 174);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(97, 21);
            this.guna2HtmlLabel4.TabIndex = 2;
            this.guna2HtmlLabel4.Text = "Contraseña";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.Transparent;
            this.TxtUsuario.BorderColor = System.Drawing.Color.Black;
            this.TxtUsuario.BorderRadius = 15;
            this.TxtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUsuario.DefaultText = "";
            this.TxtUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUsuario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(237)))), ((int)(((byte)(230)))));
            this.TxtUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.TxtUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtUsuario.IconLeft = global::Proyecto_CafeDorado.Properties.Resources.male_icon;
            this.TxtUsuario.Location = new System.Drawing.Point(27, 91);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.PlaceholderText = "";
            this.TxtUsuario.SelectedText = "";
            this.TxtUsuario.ShadowDecoration.BorderRadius = 5;
            this.TxtUsuario.ShadowDecoration.Depth = 5;
            this.TxtUsuario.ShadowDecoration.Enabled = true;
            this.TxtUsuario.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.TxtUsuario.Size = new System.Drawing.Size(252, 50);
            this.TxtUsuario.TabIndex = 0;
            this.TxtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged);
            this.TxtUsuario.Click += new System.EventHandler(this.TxtUsuario_Click);
            this.TxtUsuario.Enter += new System.EventHandler(this.TxtUsuario_Enter);
            this.TxtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuario_KeyPress);
            this.TxtUsuario.Leave += new System.EventHandler(this.TxtUsuario_Leave);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(26, 68);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(58, 21);
            this.guna2HtmlLabel3.TabIndex = 1;
            this.guna2HtmlLabel3.Text = "Usuario";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(227, 14);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(52, 25);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "Login";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(532, 28);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(160, 53);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "COOPERATIVA CAFE DORADO";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(490, 486);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(292, 15);
            this.guna2HtmlLabel5.TabIndex = 5;
            this.guna2HtmlLabel5.Text = "© 2026 Coop. Cafe Dorado. Todos los Derechos reservados.\r\n\r\n";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(575, 503);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(121, 15);
            this.guna2HtmlLabel6.TabIndex = 6;
            this.guna2HtmlLabel6.Text = "Desarrollado por Devaru.";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::Proyecto_CafeDorado.Properties.Resources.LOGO_CAFEDORADO_TRANSPARENTE;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(431, 6);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(95, 95);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnMinimizar.HoverState.Image = global::Proyecto_CafeDorado.Properties.Resources.mathematics_sign_minus_round_icon;
            this.btnMinimizar.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnMinimizar.Image = global::Proyecto_CafeDorado.Properties.Resources.mathematics_sign_minus_round_icon;
            this.btnMinimizar.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnMinimizar.ImageRotate = 0F;
            this.btnMinimizar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnMinimizar.Location = new System.Drawing.Point(792, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSalir.HoverState.Image = global::Proyecto_CafeDorado.Properties.Resources.red_x_icon;
            this.btnSalir.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSalir.Image = global::Proyecto_CafeDorado.Properties.Resources.red_x_icon;
            this.btnSalir.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSalir.ImageRotate = 0F;
            this.btnSalir.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSalir.Location = new System.Drawing.Point(818, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSalir.Size = new System.Drawing.Size(20, 20);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.UseTransparentBackground = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImage = global::Proyecto_CafeDorado.Properties.Resources.CAFE_DOODLES;
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.BorderRadius = 25;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(425, 525);
            this.guna2Panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(850, 525);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ImageButton btnSalir;
        private Guna.UI2.WinForms.Guna2ImageButton btnMinimizar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox TxtUsuario;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox TxtContraseña;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2Button btnInicio;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel ProviderUsu;
        private Guna.UI2.WinForms.Guna2HtmlLabel ProviderContra;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

