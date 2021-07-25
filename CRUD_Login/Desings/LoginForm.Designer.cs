
namespace CRUD_Login
{
    partial class LoginForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Form_Drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.TopBar_Panel = new System.Windows.Forms.Panel();
            this.Title_Label = new System.Windows.Forms.Label();
            this.Exit_Button = new Guna.UI2.WinForms.Guna2CircleButton();
            this.MaximizeNormal_Button = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.Minimize_Button = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Form_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Login_Panel = new System.Windows.Forms.Panel();
            this.LoginButton = new Guna.UI2.WinForms.Guna2Button();
            this.ForgotPassw_Label = new System.Windows.Forms.Label();
            this.CreateAccount_Label = new System.Windows.Forms.Label();
            this.PasswordTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Password_Image = new System.Windows.Forms.PictureBox();
            this.Logo_Image = new System.Windows.Forms.PictureBox();
            this.UserTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.User_Image = new System.Windows.Forms.PictureBox();
            this.User_Separator = new Guna.UI2.WinForms.Guna2Separator();
            this.Password_Separator = new Guna.UI2.WinForms.Guna2Separator();
            this.CreateUser_Panel = new System.Windows.Forms.Panel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.CreateUser_Button = new Guna.UI2.WinForms.Guna2Button();
            this.PasswordCreate_Label = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordCreate_Image = new System.Windows.Forms.PictureBox();
            this.LogoCreate_Image = new System.Windows.Forms.PictureBox();
            this.UserCreate_Label = new Guna.UI2.WinForms.Guna2TextBox();
            this.UserCreate_Image = new System.Windows.Forms.PictureBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.EditUser_Panel = new System.Windows.Forms.Panel();
            this.CancelEdit_Button = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.PasswordEdit_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordEdit_Image = new System.Windows.Forms.PictureBox();
            this.LogoeDIT_Image = new System.Windows.Forms.PictureBox();
            this.UserEdit_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.UserEdit_Image = new System.Windows.Forms.PictureBox();
            this.EditUser_Separator = new Guna.UI2.WinForms.Guna2Separator();
            this.EditPassword_Separator = new Guna.UI2.WinForms.Guna2Separator();
            this.TopBar_Panel.SuspendLayout();
            this.Login_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Password_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_Image)).BeginInit();
            this.CreateUser_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordCreate_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoCreate_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserCreate_Image)).BeginInit();
            this.EditUser_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordEdit_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoeDIT_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserEdit_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Form_Drag
            // 
            this.Form_Drag.TargetControl = this.TopBar_Panel;
            // 
            // TopBar_Panel
            // 
            this.TopBar_Panel.BackgroundImage = global::CRUD_Login.Properties.Resources.TopBackground;
            resources.ApplyResources(this.TopBar_Panel, "TopBar_Panel");
            this.TopBar_Panel.Controls.Add(this.Title_Label);
            this.TopBar_Panel.Controls.Add(this.Exit_Button);
            this.TopBar_Panel.Controls.Add(this.MaximizeNormal_Button);
            this.TopBar_Panel.Controls.Add(this.Minimize_Button);
            this.TopBar_Panel.Name = "TopBar_Panel";
            // 
            // Title_Label
            // 
            resources.ApplyResources(this.Title_Label, "Title_Label");
            this.Title_Label.BackColor = System.Drawing.Color.Transparent;
            this.Title_Label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Title_Label.Name = "Title_Label";
            // 
            // Exit_Button
            // 
            resources.ApplyResources(this.Exit_Button, "Exit_Button");
            this.Exit_Button.Animated = true;
            this.Exit_Button.BackColor = System.Drawing.Color.Transparent;
            this.Exit_Button.CheckedState.Parent = this.Exit_Button;
            this.Exit_Button.CustomImages.Parent = this.Exit_Button;
            this.Exit_Button.FillColor = System.Drawing.Color.Crimson;
            this.Exit_Button.ForeColor = System.Drawing.Color.White;
            this.Exit_Button.HoverState.Parent = this.Exit_Button;
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Exit_Button.ShadowDecoration.Parent = this.Exit_Button;
            this.Exit_Button.Click += new System.EventHandler(this.FormSettings);
            // 
            // MaximizeNormal_Button
            // 
            resources.ApplyResources(this.MaximizeNormal_Button, "MaximizeNormal_Button");
            this.MaximizeNormal_Button.Animated = true;
            this.MaximizeNormal_Button.AutoRoundedCorners = true;
            this.MaximizeNormal_Button.BackColor = System.Drawing.Color.Transparent;
            this.MaximizeNormal_Button.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MaximizeNormal_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MaximizeNormal_Button.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.MaximizeNormal_Button.CheckedState.InnerColor = System.Drawing.Color.White;
            this.MaximizeNormal_Button.CheckedState.Parent = this.MaximizeNormal_Button;
            this.MaximizeNormal_Button.Name = "MaximizeNormal_Button";
            this.MaximizeNormal_Button.ShadowDecoration.Parent = this.MaximizeNormal_Button;
            this.MaximizeNormal_Button.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.MaximizeNormal_Button.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.MaximizeNormal_Button.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.MaximizeNormal_Button.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.MaximizeNormal_Button.UncheckedState.Parent = this.MaximizeNormal_Button;
            this.MaximizeNormal_Button.Click += new System.EventHandler(this.FormSettings);
            // 
            // Minimize_Button
            // 
            resources.ApplyResources(this.Minimize_Button, "Minimize_Button");
            this.Minimize_Button.Animated = true;
            this.Minimize_Button.BackColor = System.Drawing.Color.Transparent;
            this.Minimize_Button.CheckedState.Parent = this.Minimize_Button;
            this.Minimize_Button.CustomImages.Parent = this.Minimize_Button;
            this.Minimize_Button.FillColor = System.Drawing.Color.Silver;
            this.Minimize_Button.ForeColor = System.Drawing.Color.White;
            this.Minimize_Button.HoverState.Parent = this.Minimize_Button;
            this.Minimize_Button.Name = "Minimize_Button";
            this.Minimize_Button.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Minimize_Button.ShadowDecoration.Parent = this.Minimize_Button;
            this.Minimize_Button.Click += new System.EventHandler(this.FormSettings);
            // 
            // Form_Elipse
            // 
            this.Form_Elipse.BorderRadius = 10;
            this.Form_Elipse.TargetControl = this;
            // 
            // Login_Panel
            // 
            resources.ApplyResources(this.Login_Panel, "Login_Panel");
            this.Login_Panel.Controls.Add(this.LoginButton);
            this.Login_Panel.Controls.Add(this.ForgotPassw_Label);
            this.Login_Panel.Controls.Add(this.CreateAccount_Label);
            this.Login_Panel.Controls.Add(this.PasswordTextbox);
            this.Login_Panel.Controls.Add(this.Password_Image);
            this.Login_Panel.Controls.Add(this.Logo_Image);
            this.Login_Panel.Controls.Add(this.UserTextbox);
            this.Login_Panel.Controls.Add(this.User_Image);
            this.Login_Panel.Controls.Add(this.User_Separator);
            this.Login_Panel.Controls.Add(this.Password_Separator);
            this.Login_Panel.Name = "Login_Panel";
            this.Login_Panel.Tag = "Views";
            // 
            // LoginButton
            // 
            this.LoginButton.Animated = true;
            this.LoginButton.CheckedState.Parent = this.LoginButton;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.CustomImages.Parent = this.LoginButton;
            resources.ApplyResources(this.LoginButton, "LoginButton");
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.HoverState.Parent = this.LoginButton;
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.ShadowDecoration.Parent = this.LoginButton;
            // 
            // ForgotPassw_Label
            // 
            resources.ApplyResources(this.ForgotPassw_Label, "ForgotPassw_Label");
            this.ForgotPassw_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgotPassw_Label.ForeColor = System.Drawing.Color.Blue;
            this.ForgotPassw_Label.Name = "ForgotPassw_Label";
            this.ForgotPassw_Label.Tag = "edit";
            this.ForgotPassw_Label.Click += new System.EventHandler(this.NavegationFunction);
            // 
            // CreateAccount_Label
            // 
            resources.ApplyResources(this.CreateAccount_Label, "CreateAccount_Label");
            this.CreateAccount_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateAccount_Label.ForeColor = System.Drawing.Color.Blue;
            this.CreateAccount_Label.Name = "CreateAccount_Label";
            this.CreateAccount_Label.Tag = "create";
            this.CreateAccount_Label.Click += new System.EventHandler(this.NavegationFunction);
            // 
            // PasswordTextbox
            // 
            resources.ApplyResources(this.PasswordTextbox, "PasswordTextbox");
            this.PasswordTextbox.BackColor = System.Drawing.SystemColors.Control;
            this.PasswordTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PasswordTextbox.BorderThickness = 0;
            this.PasswordTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextbox.DefaultText = "";
            this.PasswordTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextbox.DisabledState.Parent = this.PasswordTextbox;
            this.PasswordTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PasswordTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextbox.FocusedState.Parent = this.PasswordTextbox;
            this.PasswordTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextbox.HoverState.Parent = this.PasswordTextbox;
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '\0';
            this.PasswordTextbox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.PasswordTextbox.PlaceholderText = "PASSWORD";
            this.PasswordTextbox.SelectedText = "";
            this.PasswordTextbox.ShadowDecoration.Parent = this.PasswordTextbox;
            this.PasswordTextbox.UseSystemPasswordChar = true;
            // 
            // Password_Image
            // 
            resources.ApplyResources(this.Password_Image, "Password_Image");
            this.Password_Image.BackgroundImage = global::CRUD_Login.Properties.Resources.Password;
            this.Password_Image.Name = "Password_Image";
            this.Password_Image.TabStop = false;
            // 
            // Logo_Image
            // 
            resources.ApplyResources(this.Logo_Image, "Logo_Image");
            this.Logo_Image.BackgroundImage = global::CRUD_Login.Properties.Resources.Debian;
            this.Logo_Image.Name = "Logo_Image";
            this.Logo_Image.TabStop = false;
            // 
            // UserTextbox
            // 
            resources.ApplyResources(this.UserTextbox, "UserTextbox");
            this.UserTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UserTextbox.BorderThickness = 0;
            this.UserTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserTextbox.DefaultText = "";
            this.UserTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserTextbox.DisabledState.Parent = this.UserTextbox;
            this.UserTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UserTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserTextbox.FocusedState.Parent = this.UserTextbox;
            this.UserTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserTextbox.HoverState.Parent = this.UserTextbox;
            this.UserTextbox.Name = "UserTextbox";
            this.UserTextbox.PasswordChar = '\0';
            this.UserTextbox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.UserTextbox.PlaceholderText = "USER";
            this.UserTextbox.SelectedText = "";
            this.UserTextbox.ShadowDecoration.Parent = this.UserTextbox;
            // 
            // User_Image
            // 
            resources.ApplyResources(this.User_Image, "User_Image");
            this.User_Image.BackgroundImage = global::CRUD_Login.Properties.Resources.UserIcon;
            this.User_Image.Name = "User_Image";
            this.User_Image.TabStop = false;
            // 
            // User_Separator
            // 
            resources.ApplyResources(this.User_Separator, "User_Separator");
            this.User_Separator.Name = "User_Separator";
            // 
            // Password_Separator
            // 
            resources.ApplyResources(this.Password_Separator, "Password_Separator");
            this.Password_Separator.Name = "Password_Separator";
            // 
            // CreateUser_Panel
            // 
            resources.ApplyResources(this.CreateUser_Panel, "CreateUser_Panel");
            this.CreateUser_Panel.Controls.Add(this.guna2Button2);
            this.CreateUser_Panel.Controls.Add(this.CreateUser_Button);
            this.CreateUser_Panel.Controls.Add(this.PasswordCreate_Label);
            this.CreateUser_Panel.Controls.Add(this.PasswordCreate_Image);
            this.CreateUser_Panel.Controls.Add(this.LogoCreate_Image);
            this.CreateUser_Panel.Controls.Add(this.UserCreate_Label);
            this.CreateUser_Panel.Controls.Add(this.UserCreate_Image);
            this.CreateUser_Panel.Controls.Add(this.guna2Separator1);
            this.CreateUser_Panel.Controls.Add(this.guna2Separator2);
            this.CreateUser_Panel.Name = "CreateUser_Panel";
            this.CreateUser_Panel.Tag = "Views";
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.No;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.guna2Button2, "guna2Button2");
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Tag = "go2login";
            this.guna2Button2.Click += new System.EventHandler(this.NavegationFunction);
            // 
            // CreateUser_Button
            // 
            this.CreateUser_Button.Animated = true;
            this.CreateUser_Button.CheckedState.Parent = this.CreateUser_Button;
            this.CreateUser_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateUser_Button.CustomImages.Parent = this.CreateUser_Button;
            this.CreateUser_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.CreateUser_Button, "CreateUser_Button");
            this.CreateUser_Button.ForeColor = System.Drawing.Color.White;
            this.CreateUser_Button.HoverState.Parent = this.CreateUser_Button;
            this.CreateUser_Button.Name = "CreateUser_Button";
            this.CreateUser_Button.ShadowDecoration.Parent = this.CreateUser_Button;
            // 
            // PasswordCreate_Label
            // 
            resources.ApplyResources(this.PasswordCreate_Label, "PasswordCreate_Label");
            this.PasswordCreate_Label.BackColor = System.Drawing.SystemColors.Control;
            this.PasswordCreate_Label.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PasswordCreate_Label.BorderThickness = 0;
            this.PasswordCreate_Label.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordCreate_Label.DefaultText = "";
            this.PasswordCreate_Label.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordCreate_Label.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordCreate_Label.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordCreate_Label.DisabledState.Parent = this.PasswordCreate_Label;
            this.PasswordCreate_Label.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordCreate_Label.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PasswordCreate_Label.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordCreate_Label.FocusedState.Parent = this.PasswordCreate_Label;
            this.PasswordCreate_Label.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordCreate_Label.HoverState.Parent = this.PasswordCreate_Label;
            this.PasswordCreate_Label.Name = "PasswordCreate_Label";
            this.PasswordCreate_Label.PasswordChar = '\0';
            this.PasswordCreate_Label.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.PasswordCreate_Label.PlaceholderText = "CREATE PASSWORD";
            this.PasswordCreate_Label.SelectedText = "";
            this.PasswordCreate_Label.ShadowDecoration.Parent = this.PasswordCreate_Label;
            this.PasswordCreate_Label.UseSystemPasswordChar = true;
            // 
            // PasswordCreate_Image
            // 
            resources.ApplyResources(this.PasswordCreate_Image, "PasswordCreate_Image");
            this.PasswordCreate_Image.BackgroundImage = global::CRUD_Login.Properties.Resources.Password;
            this.PasswordCreate_Image.Name = "PasswordCreate_Image";
            this.PasswordCreate_Image.TabStop = false;
            // 
            // LogoCreate_Image
            // 
            resources.ApplyResources(this.LogoCreate_Image, "LogoCreate_Image");
            this.LogoCreate_Image.BackgroundImage = global::CRUD_Login.Properties.Resources.Create_User;
            this.LogoCreate_Image.Name = "LogoCreate_Image";
            this.LogoCreate_Image.TabStop = false;
            // 
            // UserCreate_Label
            // 
            resources.ApplyResources(this.UserCreate_Label, "UserCreate_Label");
            this.UserCreate_Label.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UserCreate_Label.BorderThickness = 0;
            this.UserCreate_Label.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserCreate_Label.DefaultText = "";
            this.UserCreate_Label.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserCreate_Label.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserCreate_Label.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserCreate_Label.DisabledState.Parent = this.UserCreate_Label;
            this.UserCreate_Label.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserCreate_Label.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UserCreate_Label.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserCreate_Label.FocusedState.Parent = this.UserCreate_Label;
            this.UserCreate_Label.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserCreate_Label.HoverState.Parent = this.UserCreate_Label;
            this.UserCreate_Label.Name = "UserCreate_Label";
            this.UserCreate_Label.PasswordChar = '\0';
            this.UserCreate_Label.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.UserCreate_Label.PlaceholderText = "CREATE USER";
            this.UserCreate_Label.SelectedText = "";
            this.UserCreate_Label.ShadowDecoration.Parent = this.UserCreate_Label;
            // 
            // UserCreate_Image
            // 
            resources.ApplyResources(this.UserCreate_Image, "UserCreate_Image");
            this.UserCreate_Image.BackgroundImage = global::CRUD_Login.Properties.Resources.UserIcon;
            this.UserCreate_Image.Name = "UserCreate_Image";
            this.UserCreate_Image.TabStop = false;
            // 
            // guna2Separator1
            // 
            resources.ApplyResources(this.guna2Separator1, "guna2Separator1");
            this.guna2Separator1.Name = "guna2Separator1";
            // 
            // guna2Separator2
            // 
            resources.ApplyResources(this.guna2Separator2, "guna2Separator2");
            this.guna2Separator2.Name = "guna2Separator2";
            // 
            // EditUser_Panel
            // 
            resources.ApplyResources(this.EditUser_Panel, "EditUser_Panel");
            this.EditUser_Panel.Controls.Add(this.CancelEdit_Button);
            this.EditUser_Panel.Controls.Add(this.guna2Button1);
            this.EditUser_Panel.Controls.Add(this.PasswordEdit_TextBox);
            this.EditUser_Panel.Controls.Add(this.PasswordEdit_Image);
            this.EditUser_Panel.Controls.Add(this.LogoeDIT_Image);
            this.EditUser_Panel.Controls.Add(this.UserEdit_TextBox);
            this.EditUser_Panel.Controls.Add(this.UserEdit_Image);
            this.EditUser_Panel.Controls.Add(this.EditUser_Separator);
            this.EditUser_Panel.Controls.Add(this.EditPassword_Separator);
            this.EditUser_Panel.Name = "EditUser_Panel";
            this.EditUser_Panel.Tag = "Views";
            // 
            // CancelEdit_Button
            // 
            this.CancelEdit_Button.Animated = true;
            this.CancelEdit_Button.CheckedState.Parent = this.CancelEdit_Button;
            this.CancelEdit_Button.Cursor = System.Windows.Forms.Cursors.No;
            this.CancelEdit_Button.CustomImages.Parent = this.CancelEdit_Button;
            this.CancelEdit_Button.FillColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.CancelEdit_Button, "CancelEdit_Button");
            this.CancelEdit_Button.ForeColor = System.Drawing.Color.White;
            this.CancelEdit_Button.HoverState.Parent = this.CancelEdit_Button;
            this.CancelEdit_Button.Name = "CancelEdit_Button";
            this.CancelEdit_Button.ShadowDecoration.Parent = this.CancelEdit_Button;
            this.CancelEdit_Button.Tag = "go2login";
            this.CancelEdit_Button.Click += new System.EventHandler(this.NavegationFunction);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Goldenrod;
            resources.ApplyResources(this.guna2Button1, "guna2Button1");
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            // 
            // PasswordEdit_TextBox
            // 
            resources.ApplyResources(this.PasswordEdit_TextBox, "PasswordEdit_TextBox");
            this.PasswordEdit_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.PasswordEdit_TextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PasswordEdit_TextBox.BorderThickness = 0;
            this.PasswordEdit_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordEdit_TextBox.DefaultText = "";
            this.PasswordEdit_TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordEdit_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordEdit_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordEdit_TextBox.DisabledState.Parent = this.PasswordEdit_TextBox;
            this.PasswordEdit_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordEdit_TextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PasswordEdit_TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordEdit_TextBox.FocusedState.Parent = this.PasswordEdit_TextBox;
            this.PasswordEdit_TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordEdit_TextBox.HoverState.Parent = this.PasswordEdit_TextBox;
            this.PasswordEdit_TextBox.Name = "PasswordEdit_TextBox";
            this.PasswordEdit_TextBox.PasswordChar = '\0';
            this.PasswordEdit_TextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.PasswordEdit_TextBox.PlaceholderText = "EDIT PASSWORD";
            this.PasswordEdit_TextBox.SelectedText = "";
            this.PasswordEdit_TextBox.ShadowDecoration.Parent = this.PasswordEdit_TextBox;
            this.PasswordEdit_TextBox.UseSystemPasswordChar = true;
            // 
            // PasswordEdit_Image
            // 
            resources.ApplyResources(this.PasswordEdit_Image, "PasswordEdit_Image");
            this.PasswordEdit_Image.BackgroundImage = global::CRUD_Login.Properties.Resources.Password;
            this.PasswordEdit_Image.Name = "PasswordEdit_Image";
            this.PasswordEdit_Image.TabStop = false;
            // 
            // LogoeDIT_Image
            // 
            resources.ApplyResources(this.LogoeDIT_Image, "LogoeDIT_Image");
            this.LogoeDIT_Image.BackgroundImage = global::CRUD_Login.Properties.Resources.Edit_User;
            this.LogoeDIT_Image.Name = "LogoeDIT_Image";
            this.LogoeDIT_Image.TabStop = false;
            // 
            // UserEdit_TextBox
            // 
            resources.ApplyResources(this.UserEdit_TextBox, "UserEdit_TextBox");
            this.UserEdit_TextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UserEdit_TextBox.BorderThickness = 0;
            this.UserEdit_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserEdit_TextBox.DefaultText = "";
            this.UserEdit_TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserEdit_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserEdit_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserEdit_TextBox.DisabledState.Parent = this.UserEdit_TextBox;
            this.UserEdit_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserEdit_TextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UserEdit_TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserEdit_TextBox.FocusedState.Parent = this.UserEdit_TextBox;
            this.UserEdit_TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserEdit_TextBox.HoverState.Parent = this.UserEdit_TextBox;
            this.UserEdit_TextBox.Name = "UserEdit_TextBox";
            this.UserEdit_TextBox.PasswordChar = '\0';
            this.UserEdit_TextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.UserEdit_TextBox.PlaceholderText = "EDIT USER";
            this.UserEdit_TextBox.SelectedText = "";
            this.UserEdit_TextBox.ShadowDecoration.Parent = this.UserEdit_TextBox;
            // 
            // UserEdit_Image
            // 
            resources.ApplyResources(this.UserEdit_Image, "UserEdit_Image");
            this.UserEdit_Image.BackgroundImage = global::CRUD_Login.Properties.Resources.UserIcon;
            this.UserEdit_Image.Name = "UserEdit_Image";
            this.UserEdit_Image.TabStop = false;
            // 
            // EditUser_Separator
            // 
            resources.ApplyResources(this.EditUser_Separator, "EditUser_Separator");
            this.EditUser_Separator.Name = "EditUser_Separator";
            // 
            // EditPassword_Separator
            // 
            resources.ApplyResources(this.EditPassword_Separator, "EditPassword_Separator");
            this.EditPassword_Separator.Name = "EditPassword_Separator";
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.TopBar_Panel);
            this.Controls.Add(this.Login_Panel);
            this.Controls.Add(this.CreateUser_Panel);
            this.Controls.Add(this.EditUser_Panel);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Load += new System.EventHandler(this.Index_Load);
            this.TopBar_Panel.ResumeLayout(false);
            this.TopBar_Panel.PerformLayout();
            this.Login_Panel.ResumeLayout(false);
            this.Login_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Password_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_Image)).EndInit();
            this.CreateUser_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PasswordCreate_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoCreate_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserCreate_Image)).EndInit();
            this.EditUser_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PasswordEdit_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoeDIT_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserEdit_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DragControl Form_Drag;
        private Guna.UI2.WinForms.Guna2Elipse Form_Elipse;
        private Guna.UI2.WinForms.Guna2CircleButton Minimize_Button;
        private Guna.UI2.WinForms.Guna2CircleButton Exit_Button;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        public Guna.UI2.WinForms.Guna2ToggleSwitch MaximizeNormal_Button;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel TopBar_Panel;
        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.Panel Login_Panel;
        private Guna.UI2.WinForms.Guna2Button LoginButton;
        private System.Windows.Forms.Label ForgotPassw_Label;
        private System.Windows.Forms.Label CreateAccount_Label;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTextbox;
        private System.Windows.Forms.PictureBox Password_Image;
        private System.Windows.Forms.PictureBox Logo_Image;
        private Guna.UI2.WinForms.Guna2TextBox UserTextbox;
        private System.Windows.Forms.PictureBox User_Image;
        private Guna.UI2.WinForms.Guna2Separator User_Separator;
        private Guna.UI2.WinForms.Guna2Separator Password_Separator;
        private System.Windows.Forms.Panel CreateUser_Panel;
        private Guna.UI2.WinForms.Guna2Button CreateUser_Button;
        private Guna.UI2.WinForms.Guna2TextBox PasswordCreate_Label;
        private System.Windows.Forms.PictureBox PasswordCreate_Image;
        private System.Windows.Forms.PictureBox LogoCreate_Image;
        private Guna.UI2.WinForms.Guna2TextBox UserCreate_Label;
        private System.Windows.Forms.PictureBox UserCreate_Image;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private System.Windows.Forms.Panel EditUser_Panel;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox PasswordEdit_TextBox;
        private System.Windows.Forms.PictureBox PasswordEdit_Image;
        private System.Windows.Forms.PictureBox LogoeDIT_Image;
        private Guna.UI2.WinForms.Guna2TextBox UserEdit_TextBox;
        private System.Windows.Forms.PictureBox UserEdit_Image;
        private Guna.UI2.WinForms.Guna2Separator EditUser_Separator;
        private Guna.UI2.WinForms.Guna2Separator EditPassword_Separator;
        private Guna.UI2.WinForms.Guna2Button CancelEdit_Button;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}

