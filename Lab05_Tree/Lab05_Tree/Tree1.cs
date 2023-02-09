using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Lab05_Tree
{
    public partial class Tree1 : Form
    {
        public Tree1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tree<Person> company = new Tree<Person>();
            company.Root = new TreeNode<Person>()
            {

                Data = new Person(1, "Econ. Francisco Adrián Briones Rugel", "Director General"),
                Parent = null

            };
            company.Root.Children = new List<TreeNode<Person>>()
            {
                new TreeNode<Person>()
                {
                    Data = new Person(2, "Ricardo Daniel Flores Gallardo", "Subdirector General de Cumplimiento Tributario"),
                    Parent = company.Root
                },
                new TreeNode<Person>()
                {
                    Data = new Person(3, "Miguel Ángel Játiva Coronel", "Subdirector General de Desarrollo Organizacional"),
                    Parent = company.Root
                }
            };
            company.Root.Children[0].Children = new List<TreeNode<Person>>()
            {
                new TreeNode<Person>()
                {
                    Data = new Person(4, "María Leonor Calero Pazmiño", "Directora Nacional Jurídica"),
                    Parent = company.Root.Children[0]
                },
                new TreeNode<Person>()
                {
                    Data = new Person(5, "Mauro Renato Tejada Ramón", "Director de Grandes Contribuyentes"),
                    Parent = company.Root.Children[0]
                },
                new TreeNode<Person>()
                {
                    Data = new Person(6, "Carlos Eduardo Jaramillo Totoy", "Director Nacional de Control Tributario Nacional Jurídica"),
                    Parent = company.Root.Children[0]
                },
                new TreeNode<Person>()
                {
                    Data = new Person(7, "María Caridad Carrion Solís", "Directora Nacional de Planificación y Gestión Estratégica"),
                    Parent = company.Root.Children[0]
                },
                new TreeNode<Person>()
                {
                    Data = new Person(8, "Juan Carlos Proaño Cordero ", "Director Nacional Administrativo - Financiero"),
                    Parent = company.Root.Children[0]
                },
                new TreeNode<Person>()
                {
                    Data = new Person(9, "Álvaro Hernan Toapanta Guambi", "Director Nacional de Talento Humano"),
                    Parent = company.Root.Children[0]
                },
                new TreeNode<Person>()
                {
                    Data = new Person(10, "Oswaldo Ramiro Espinosa Bravo", "Director Nacional de Tecnología"),
                    Parent = company.Root.Children[0]
                },
                new TreeNode<Person>()
                {
                    Data = new Person(11, "Maria Fernanda Parra Astudillo", "Directora Nacional de Recaudación y Asistencia al Ciudadano"),
                    Parent = company.Root.Children[0]
                }
            };
            company.Root.Children[1].Children = new List<TreeNode<Person>>()
            {
                new TreeNode<Person>()
                {
                    Data = new Person(12, "Andrés Felipe Córdova Pizarro", "Director Zonal 9 - Pichincha"),
                    Parent = company.Root.Children[1]
                },
                new TreeNode<Person>()
                {
                    Data = new Person(13, "Carlos Vicente Marín Quijije", "Director Zonal 8 - Guayas"),
                    Parent = company.Root.Children[1]
                },
                new TreeNode<Person>()
                {
                    Data = new Person(14, "Julio César Ruiz Zhingre", "Director Zonal 7 - Loja"),
                    Parent = company.Root.Children[1]
                },
                new TreeNode<Person>()
                {
                    Data = new Person(15, "Mayra Verónica Orellana Ullauri", "Directora Zonal 6 - Azuay"),
                    Parent = company.Root.Children[1]
                },
                new TreeNode<Person>()
                {
                    Data = new Person(16, "Jean Steve Carrera López", "Director Zonal 5 - Los Ríos"),
                    Parent = company.Root.Children[1]
                },
                new TreeNode<Person>()
                {
                    Data = new Person(17, "Monserrate Auxiliadora Holguín Alvia", "Directora Zonal 4 - Manabí"),
                    Parent = company.Root.Children[1]
                },
                new TreeNode<Person>()
                {
                    Data = new Person(18, "Tarquino Fidel Patiño Espín", "Director Zonal 3 - Tungurahua"),
                    Parent = company.Root.Children[1]
                },
                new TreeNode<Person>()
                {
                    Data = new Person(19, "Patricia de las Mercedes Borja Sevilla", "Directora Zonal 2 - Napo"),
                    Parent = company.Root.Children[1]
                },
                new TreeNode<Person>()
                {
                    Data = new Person(20, "Daniela Alejandra Proaño Cruz", "Directora Zonal 1 - Imbabura"),
                    Parent = company.Root.Children[1]
                }
            };
            

            TreeNode<Person> node1 = company.Root;
            treeView1.Nodes.Add(node1.Data.Role + " - " + node1.Data.Name  );

            foreach (var item in node1.Children)
            {
                TreeNode<Person> node2 = item;
                TreeNode tnode2 = new TreeNode();
                tnode2.Text = node2.Data.Role + " - " + node2.Data.Name;
                treeView1.Nodes[0].Nodes.Add(tnode2);

                foreach (var item2 in node2.Children)
                {
                    TreeNode<Person> node3 = item2;
                    TreeNode tnode3 = new TreeNode();
                    tnode3.Text = node3.Data.Role + " - " + node3.Data.Name;
                    tnode2.Nodes.Add(tnode3);
                    tnode2.ExpandAll();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

    }
}
