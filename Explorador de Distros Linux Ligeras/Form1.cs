using System.Diagnostics;

namespace Explorador_de_Distros_Linux_Ligeras
{
    public partial class Form1 : Form
    {
        private readonly String rutaResources =
            Path.Combine(Application.StartupPath, "Resources");
        public Form1()
        {
            InitializeComponent();
            CargarDistribuciones();
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CargarDistribuciones()  //funcion o metodo para cargar las distribuciones al iniciar el programa
        {
            //limpiar el combobox
            comboDistro.Items.Clear();
            //agregar las distribuciones al combobox
            comboDistro.Items.Add("Puppy Linux");
            comboDistro.Items.Add("Slax");
            comboDistro.Items.Add("antiX");
            comboDistro.Items.Add("Debian");
            comboDistro.Items.Add("Tiny core Linux");

            //no seleccionar ningun item al inicio
            comboDistro.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //revisar que es combobox tenga informacion
            if (comboDistro.SelectedIndex == -1)
            {
                //al estar vacio indica que no realize ninguna accion si es que esta vacio el combobox
            }

            String distroSeleccionada = comboDistro.SelectedItem.ToString(); //convertirlo a texto

            //switch
            switch (distroSeleccionada)
            {

                case "Puppy Linux":

                    MostrarDistro(
                        "Puppy Linux",
                        "Puppy Linux es una distribución ligera " +
                        "diseñada para funcionar correctamente en " +
                        "equipos con pocos recursos.\r\n\r\n" +
                        "Requisitos aproximados:\r\n" +
                        "• Procesador x86 o compatible\r\n" +
                        "• 1 GB de RAM recomendado\r\n" +
                        "• Espacio reducido en disco",
                        "puppy.png",
                        "https://puppylinux-woof-ce.github.io/"
                    );

                    break;


                case "Slax":

                    MostrarDistro(
                        "Slax",
                        "Slax es una distribución Linux pequeña y " +
                        "portable que puede ejecutarse desde una " +
                        "memoria USB.\r\n\r\n" +
                        "Requisitos aproximados:\r\n" +
                        "• Procesador compatible con x86_64\r\n" +
                        "• 512 MB de RAM o más\r\n" +
                        "• Espacio reducido en almacenamiento",
                        "slax.png",
                        "https://www.slax.org/"
                    );

                    break;


                case "antiX":

                    MostrarDistro(
                        "antiX",
                        "antiX es una distribución Linux ligera " +
                        "basada en Debian y orientada especialmente " +
                        "a equipos antiguos.\r\n\r\n" +
                        "Requisitos aproximados:\r\n" +
                        "• Procesador compatible con x86_64\r\n" +
                        "• 512 MB de RAM como mínimo recomendado\r\n" +
                        "• Poco espacio de almacenamiento",
                        "antix.png",
                        "https://antixlinux.com/"
                    );

                    break;


                case "Debian":

                    MostrarDistro(
                        "Debian",
                        "Debian es una de las distribuciones Linux " +
                        "más conocidas y utilizadas. Puede instalarse " +
                        "con diferentes entornos de escritorio y también " +
                        "puede configurarse para equipos con pocos recursos.\r\n\r\n" +
                        "Requisitos aproximados:\r\n" +
                        "• Procesador compatible\r\n" +
                        "• 512 MB de RAM para instalaciones ligeras\r\n" +
                        "• Espacio de almacenamiento variable",
                        "debian.png",
                        "https://www.debian.org/"
                    );

                    break;


                case "Tiny core Linux":

                    MostrarDistro(
                        "Tiny core Linux",
                        "Tiny Core Linux es una distribución " +
                        "extremadamente pequeña que está diseñada " +
                        "para utilizar muy pocos recursos del equipo.\r\n\r\n" +
                        "Requisitos aproximados:\r\n" +
                        "• Procesador compatible\r\n" +
                        "• 128 MB de RAM o más\r\n" +
                        "• Muy poco espacio de almacenamiento",
                        "tiny.jpg",
                        "http://www.tinycorelinux.net/"
                    );

                    break;
            }
        }
        //metodo para mostrar la informacion (es una funcion???, al parecer se les llama metodos)
        private void MostrarDistro(
            string nombre,
            string descripcion,
            string nombreimagen,
            string url) //son los parametros???
        {
            //mostrar la descripción
            Descripcion.Text =
                nombre + "\r\n\r\n" + descripcion;
            //informacion de descarga
            LinkDescarga.Tag = url;
            //mostramos el enlace
            LinkDescarga.Text = "Visitar sitio web de " + nombre;
            //cargar la imagen
            try
            {
                string rutaimagen =
                    Path.Combine(rutaResources, nombreimagen);
                if (File.Exists(rutaimagen))
                {
                    //liberar imagen anterior
                    if (picLogo.Image != null)
                    {
                        picLogo.Image.Dispose();
                        picLogo.Image = null;
                    }
                    picLogo.Image = Image.FromFile(rutaimagen);
                }
                else
                {
                    picLogo.Image = null;
                    MessageBox.Show("no se encontró la imagen: " + rutaimagen);
                }

            }
            catch (Exception ex)
            {
                picLogo.Image = null;
                MessageBox.Show("no fue posible cargar la imagen. \r\n\r\n" +
                    ex.Message,
                    "error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void LinkDescarga_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (LinkDescarga.Tag != null)
                {
                    string url = LinkDescarga.Tag.ToString();
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true
                    }
                        );
                }


            }
            catch (Exception ex) { }
        }

        }
    }

