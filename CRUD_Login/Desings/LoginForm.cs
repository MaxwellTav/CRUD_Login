using System;
using System.Windows.Forms;

namespace CRUD_Login
{
    public partial class LoginForm : Form
    {
        #region Useless
        public LoginForm()
        { InitializeComponent(); }
        #endregion

        #region Variables
        string 
            StaticUser = "MaxwellT",
            StaticPass = "1234";
        #endregion

        #region Botones de navegación.
        void NavegationFunction(object Sender, EventArgs Event)
        {
            Control _control = (Control)Sender;

            if (_control.Tag != "")
            {
                Login_Panel.Visible = false;
                CreateUser_Panel.Visible = false;
                EditUser_Panel.Visible = false;


                switch (_control.Tag)
                {
                    //Si presiona, el botón de crear.
                    case "create":
                        CreateUser_Panel.Visible = true;
                        break;

                    //Si presiona, el botón de editar.
                    case "edit":
                        MessageBox.Show("Nota para el usuario:\nEste programa es fácil de editar los datos ya guardados solo para que intencionalmente sean editados. " +
                        "Obviamente que en un proyecto profesional/real pues se le pondrá protección adicional o algún otro método el cual vaya correspondiente con " +
                        "el programa en cuestión...\n\nEste error de diseño el cual puedes modificar el usuario con 3 clicks es solo informativo, no es hecho así debido " +
                        "a mal diseño del proyecto",
                        "ATENCIÓN...",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        EditUser_Panel.Visible = true;
                        break;

                    //Si presiona, el botón de ir al login/cancelar.
                    case "go2login":
                        Login_Panel.Visible = true;
                        break;
                }
            }
            else
            { MessageBox.Show("El control (objeto) que se le mandó no tiene etiqueta", "Error code: 0x7092001", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion

        #region Funciones.

        /// <summary>
        /// Función que se encarga de las configuraciones básicas del formulario,
        /// esta función recibe un parametro del tipo objeto llamada "Sender" y
        /// otro parametro del tipo EventArgs llamada "Event" las cuales servirá para
        /// decidir que hace la función; En el caso de que reciba el nombre del boton de
        /// salir, pues la aplicación sale, y así sucesivamente.
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        private void FormSettings(object Sender, EventArgs Event)
        {
            //Creando una variable del tipo control para recibir el parametro sender.
            Control _control = (Control)Sender;

            switch (_control.Name)
            {
                //Botón salir.
                case "Exit_Button":
                    DialogResult MessageOutput = MessageBox.Show
                        ("¿Está seguro que desea salir de la aplicación?\nLos cambios no se aplicarán si no se han guardado",
                        "¡Está saliendo de la app!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (MessageOutput == DialogResult.Yes)
                        Application.Exit();
                    break;

                //Botón Minimizar.
                case "Minimize_Button":
                    WindowState = FormWindowState.Minimized;
                    break;

                //Botón Minimizar, Maximizar
                case "MaximizeNormal_Button":
                    switch (WindowState)
                    {
                        case FormWindowState.Normal:
                            foreach (Panel _Panel in Controls)
                                if (_Panel.Tag == "Views")
                                    _Panel.BorderStyle = BorderStyle.Fixed3D;
                            WindowState = FormWindowState.Maximized;
                            break;

                        case FormWindowState.Maximized:
                            WindowState = FormWindowState.Normal;
                            foreach (Panel _Panel in Controls)
                                if (_Panel.Tag == "Views")
                                    _Panel.BorderStyle = BorderStyle.None;
                            break;
                    }
                    break;
            }
        }

        /// <summary>
        /// Función que se encarga de setear la configuración inicial.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Index_Load(object sender, EventArgs e)
        {
            #region Tamaño y ubicación.
            //Configurando el tamaño del formulario principal.
            Size = new System.Drawing.Size(480, 502);

            //Configurando los demás paneles para mostrar el deseado.
            #region Comentarios propios
            /*
             * Tamaño del formulario = 480, 502
             * Tamaño del panel de login = 456, 395
             * Ubicación del panel de login = 12, 95
             */
            #endregion
            foreach (Panel _Panel in Controls)
            {
                //Comprobar si el panel tiene la etiqueta "Views" para que así
                //no estorben los demás paneles (ya que el programa tiene varios).
                if (_Panel.Tag == "Views")
                {
                    _Panel.Location = new System.Drawing.Point(12, 95);
                    _Panel.Size = new System.Drawing.Size(456, 395);
                    _Panel.Visible = false;
                }
            }

            //Activando el que sí queremos ver en primer lugar.
            Login_Panel.Visible = true;
            #endregion
        }

        #endregion
    }
}
