using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Agencia_de_Viaje
{
    public partial class Form1 : Form
    {
        private MySqlConnection conexion = new MySqlConnection("server=localhost; " + "port=3306; " + "database=proyecto; " + " user id=marlyn; " + "password=ma123456;");
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string varid = id.Text.TrimEnd();
            string varnombres = nombre.Text.TrimEnd();
            string varapellidos = apellido.Text.TrimEnd();
            string vartelefono = telefono.Text.TrimEnd();
            string vardireccion = direccion.Text.TrimEnd();
            string varpais = pais.Text.TrimEnd();
            string varciudad = ciudad.Text.TrimEnd();
            conexion.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand("insert into empleados(idEmpleados, Nombre, Apellido, Direccion, Ciudad, Pais, Telefono) values ('" + varid + "','" + varnombres + "','" + varapellidos + "','" + vardireccion + "','" + varciudad + "','" + varpais + "','" + vartelefono + "')", conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show(" Se ha Guardado Con exito al empleado ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conexion.Close();
            id.Clear();
            nombre.Clear();
            apellido.Clear();
            telefono.Clear();
            direccion.Clear();
            pais.Clear();
            ciudad.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idempleado = id.Text.TrimEnd();
            string comando_de_consulta = "select*from empleados where idEmpleados =" + idempleado;
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(comando_de_consulta, conexion);
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                nombre.Text = registro["Nombre"].ToString();
                apellido.Text = registro["Apellido"].ToString();
                direccion.Text = registro["Direccion"].ToString();
                pais.Text = registro["Pais"].ToString();
                ciudad.Text = registro["Ciudad"].ToString();
                telefono.Text = registro["Telefono"].ToString();
            }
            else
            {
                MessageBox.Show("No existe un empleado con ese id ingresado");
            }
            conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string varciudadorigen = Convert.ToString(origen.Text);
            string varciudadestino = Convert.ToString(destino.Text);
            double varadultos = Convert.ToDouble(adultos.Text);
            double varniños = Convert.ToDouble(niños.Text);
            double total = 0;
            if (origen.Text == destino.Text)
            {
                MessageBox.Show(" No se puede elegir la misma ciudad como origen y destino... ");
            }
            else
            {
                if (destino.Text == "Quibdó")
                {
                    total = Convert.ToDouble((varniños * 80000) + (varadultos * 90000));
                    precio.Text = total.ToString();
                }
                if (destino.Text == "Bogotá")
                {
                    total = Convert.ToDouble((varniños * 100000) + (varadultos * 120000));
                    precio.Text = total.ToString();
                }
                if (destino.Text == "Cali")
                {
                    total = Convert.ToDouble((varniños * 110000) + (varadultos * 130000));
                    precio.Text = total.ToString();
                }
                if (destino.Text == "Ibagué")
                {
                    total = Convert.ToDouble((varniños * 120000) + (varadultos * 130000));
                    precio.Text = total.ToString();
                }
                if (destino.Text == "Villavicencio")
                {
                    total = Convert.ToDouble((varniños * 130000) + (varadultos * 140000));
                    precio.Text = total.ToString();
                }
                if (destino.Text == "Pasto")
                {
                    total = Convert.ToDouble((varniños * 140000) + (varadultos * 150000));
                    precio.Text = total.ToString();
                }
                if (destino.Text == "Armenia")
                {
                    total = Convert.ToDouble((varniños * 150000) + (varadultos * 160000));
                    precio.Text = total.ToString();
                }
                if (destino.Text == "Ibagué")
                {
                    total = Convert.ToDouble((varniños * 160000) + (varadultos * 170000));
                    precio.Text = total.ToString();
                }
                if (destino.Text == "Pereira")
                {
                    total = Convert.ToDouble((varniños * 180000) + (varadultos * 190000));
                    precio.Text = total.ToString();
                }
                if (destino.Text == "Cúcuta")
                {
                    total = Convert.ToDouble((varniños * 190000) + (varadultos * 195000));
                    precio.Text = total.ToString();
                }
                if (destino.Text == "Manizales")
                {
                    total = Convert.ToDouble((varniños * 200000) + (varadultos * 210000));
                    precio.Text = total.ToString();
                }
                if (destino.Text == "Santa Marta")
                {
                    total = Convert.ToDouble((varniños * 210000) + (varadultos * 220000));
                    precio.Text = total.ToString();
                }
                if (destino.Text == "Bucaramanga")
                {
                    total = Convert.ToDouble((varniños * 220000) + (varadultos * 230000));
                    precio.Text = total.ToString();
                }
                if (destino.Text == "Cartagena")
                {
                    total = Convert.ToDouble((varniños * 230000) + (varadultos * 240000));
                    precio.Text = total.ToString();
                }
                if (destino.Text == "Barranquilla")
                {
                    total = Convert.ToDouble((varniños * 240000) + (varadultos * 250000));
                    precio.Text = total.ToString();
                }
                if (destino.Text == "Medellín")
                {
                    total = Convert.ToDouble((varniños * 250000) + (varadultos * 260000));
                    precio.Text = total.ToString();
                }
                if (destino.Text == "valledupar")
                {
                    total = Convert.ToDouble((varniños * 260000) + (varadultos * 270000));
                    precio.Text = total.ToString();
                }
                if (destino.Text == "Popayán")
                {
                    total = Convert.ToDouble((varniños * 270000) + (varadultos * 280000));
                    precio.Text = total.ToString();
                }
                if (destino.Text == "Neiva")
                {
                    total = Convert.ToDouble((varniños * 280000) + (varadultos * 290000));
                    precio.Text = total.ToString();
                }
                if (destino.Text == "Montería")
                {
                    total = Convert.ToDouble((varniños * 290000) + (varadultos * 300000));
                    precio.Text = total.ToString();
                }
                if (destino.Text == "Sincelejo")
                {
                    total = Convert.ToDouble((varniños * 300000) + (varadultos * 310000));
                    precio.Text = total.ToString();
                }
                TextWriter guardarfactura;
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.Filter = "Archivos De Texto|*.txt";
                guardar.Title = "Guardar";
                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    string ruta = guardar.FileName;
                    guardarfactura = new StreamWriter(ruta);
                    guardarfactura.WriteLine("-----------FACTURA DE VUELO ----------------");
                    guardarfactura.WriteLine("|-Trabajador :" + id.Text);
                    guardarfactura.WriteLine("|-Nombres: " + nombre.Text);
                    guardarfactura.WriteLine("|-Apellidos: " + apellido.Text);
                    guardarfactura.WriteLine("|-Telefono: " + telefono.Text);
                    guardarfactura.WriteLine("|-direccion: " + direccion.Text);
                    guardarfactura.WriteLine("|-Pais: " + pais.Text);
                    guardarfactura.WriteLine("|-ciudad: " + ciudad.Text);
                    guardarfactura.WriteLine("|-------------------------------------------");
                    guardarfactura.WriteLine("|-Ciudad de Orgien: " + varciudadorigen);
                    guardarfactura.WriteLine("|-Ciudad de Destino: " + varciudadestino);
                    guardarfactura.WriteLine("|-Fecha de Salida: " + fechasali.Text);
                    guardarfactura.WriteLine("|-Fecha de Llegada: " + fecharegre.Text);
                    guardarfactura.WriteLine("|-Cantidad De Niños: " + varniños);
                    guardarfactura.WriteLine("|-Cantidad De Adultos: " + varadultos);
                    guardarfactura.WriteLine("|-Valor Total del Vuelo:" + total);
                    guardarfactura.WriteLine("---------------------------------------------");
                    guardarfactura.Close();
                }
                guardar.Dispose();
            }
        }
    }
}
