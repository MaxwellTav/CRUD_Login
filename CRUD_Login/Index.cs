using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Login
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

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
                            WindowState = FormWindowState.Maximized;
                            break;

                        case FormWindowState.Maximized:
                            WindowState = FormWindowState.Normal;
                            break;
                    }
                    break;
            }
        }
    }
}
