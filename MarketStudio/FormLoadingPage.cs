using MarketStudio.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketStudio
{
    public enum TypePage
    {
        Cargando = 1,
        Usuarios = 2,
        Empleados = 3,
        Inicio = 4,
        Ventas = 5, 
        Inventario = 6,
        Gastos = 7,
        Proveedores = 8,
        Balance = 9,
        Imprimir = 10,
        Compartir = 11
    }
    public partial class FormLoadingPage : Form
    {
        int segundos = 1;
        int seg = -1;
        public FormLoadingPage(TypePage type)
        {
            InitializeComponent();
            Renderizar(type);
        }

        void Renderizar(TypePage type)
        {
            switch (type)
            {
                case TypePage.Cargando:
                    picLoading.Image = Resources.GifCargando;
                    txtArea.Text = "cargando...";
                    break;
                case TypePage.Usuarios:
                    picLoading.Image = Resources.GifUsuarios;
                    txtArea.Text = "usuarios";
                    break;
                case TypePage.Empleados:
                    picLoading.Image = Resources.GifEmpleados;
                    txtArea.Text = "empleados";
                    break;
                case TypePage.Inicio:
                    picLoading.Image = Resources.GifInicio;
                    txtArea.Text = "inicio";
                    break;
                case TypePage.Ventas:
                    picLoading.Image = Resources.GifVentas;
                    txtArea.Text = "ventas";
                    break;
                case TypePage.Inventario:
                    picLoading.Image = Resources.GifProductos;
                    txtArea.Text = "productos";
                    break;
                case TypePage.Gastos:
                    picLoading.Image = Resources.GifGastos;
                    txtArea.Text = "gastos";
                    break;
                case TypePage.Proveedores:
                    picLoading.Image = Resources.GifProveedores;
                    txtArea.Text = "proveedores";
                    break;
                case TypePage.Balance:
                    picLoading.Image = Resources.GifBalance;
                    txtArea.Text = "balance";
                    break;
                case TypePage.Imprimir:
                    picLoading.Image = Resources.GifImprimir;
                    txtArea.Text = "Imprimir";
                    break;
                case TypePage.Compartir:
                    picLoading.Image = Resources.GifCompartir;
                    txtArea.Text = "Compartir";
                    break;
                default:
                    break;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (seg >= segundos)
                this.Close();
            else
                seg++;
        }
    }
}
