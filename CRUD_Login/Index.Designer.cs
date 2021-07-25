
namespace CRUD_Login
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.Form_Drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Form_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.MaximizeNormal_Button = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.Minimize_Button = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Exit_Button = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TopBar_Panel = new System.Windows.Forms.Panel();
            this.Title_Label = new System.Windows.Forms.Label();
            this.TopBar_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Form_Drag
            // 
            this.Form_Drag.TargetControl = this.TopBar_Panel;
            // 
            // Form_Elipse
            // 
            this.Form_Elipse.BorderRadius = 10;
            this.Form_Elipse.TargetControl = this;
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
            // Index
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.TopBar_Panel);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Index";
            this.TopBar_Panel.ResumeLayout(false);
            this.TopBar_Panel.PerformLayout();
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
    }
}

