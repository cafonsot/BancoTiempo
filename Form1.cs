using System;
using System.Windows.Forms;
using System.Xml;


namespace XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();

            XmlElement tagPrincipal = doc.CreateElement("datosXML");
            doc.AppendChild(tagPrincipal);

            XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.InsertBefore(declaration, tagPrincipal);

            XmlElement tagUsuarios = doc.CreateElement("Usuarios");
            tagPrincipal.AppendChild(tagUsuarios);

            // Usuario 1
            XmlElement tagUsuario = doc.CreateElement("Usuario");

            XmlAttribute propID = doc.CreateAttribute("ID");
            propID.Value = "1";

            XmlElement tagNombre = doc.CreateElement("Nombre");
            XmlText textNombre = doc.CreateTextNode("Alex");
            tagNombre.AppendChild(textNombre);

            XmlElement tagApellido = doc.CreateElement("Apellido");
            XmlText textApellido = doc.CreateTextNode("Pinzano");
            tagApellido.AppendChild(textApellido);

            XmlElement tagEmail = doc.CreateElement("Email");
            XmlText textEmail = doc.CreateTextNode("apinzano@uoc.edu");
            tagEmail.AppendChild(textEmail);

            tagUsuario.SetAttributeNode(propID);

            tagUsuario.AppendChild(tagNombre);
            tagUsuario.AppendChild(tagApellido);
            tagUsuario.AppendChild(tagEmail);

            tagUsuarios.AppendChild(tagUsuario);
            /*--------------------------------*/

            // Guardamos el archivo XML, por defecto se dirigirá a la siguiente carpeta:
            // C:\Users\Public\Documents\XML\XML\bin\Debug\xml_datos_usuarios.xml
            // Es decir la en la carpeta Debug de donde tengamos guardado el proyecto XML\XML\bin\Debug
            doc.Save("xml_datos_usuarios.xml");

            Console.WriteLine("Se ha generado un archivo XML");
            Console.ReadLine();

            Console.WriteLine("Mostramos el XML en la consola:");
            doc.Save(Console.Out);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Para leer un documento
            XmlDocument document = new XmlDocument();
            string path = "C:\\Users\\Public\\Documents\\XML\\XML\\bin\\Debug\\xml_datos_usuarios.xml";
            document.Load(path);

            /*
            foreach(XmlNode node in document.DocumentElement.ChildNodes[0].ChildNodes)
            {
                //Console.WriteLine(node.ChildNodes[i].InnerText);
                Console.Write("Usuario con ID: " + XmlNode.Attributes["ID"].Value);

                foreach(XmlNode nodeItem in XmlNode.ChildNodes)
                {
                    Console.WriteLine("Nombre: " + nodeItem.InnerText); // InnerXml , outerXml devuelve toda la etiqueta
                }
            }
            */
            XmlNodeList itemNodes = document.SelectNodes("//datosXML//Usuarios//Usuario");
            foreach (XmlNode itemNode in itemNodes)
            {
                Console.WriteLine(itemNode.InnerText);
            }
        }

    }
}
