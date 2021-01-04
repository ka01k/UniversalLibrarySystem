using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestAPPBD.ADMIN_MANAGERS;

namespace TestAPPBD
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private ADMIN_CitiesManager CitiesMngr = new ADMIN_CitiesManager();
        private ADMIN_ContinentsManager ContinentsMngr = new ADMIN_ContinentsManager();
        private ADMIN_CountriesManager CountriesMngr = new ADMIN_CountriesManager();
        private ADMIN_UsersManager UsersMngr = new ADMIN_UsersManager();
        private ADMIN_WritersManager WritersMngr = new ADMIN_WritersManager();
        private ADMIN_SalesManager SalesMngr = new ADMIN_SalesManager();
        private ADMIN_BooksManager BooksMngr = new ADMIN_BooksManager();
        private ADMIN_GenresManager GenresMngr = new ADMIN_GenresManager();
        private readonly ADMIN_WorkPosManager WorkPosMngr = new ADMIN_WorkPosManager();
        private ADMIN_WorkersManager WorkersMngr = new ADMIN_WorkersManager();
        private ADMIN_ProvidersManager ProvidersMngr = new ADMIN_ProvidersManager();
        private ADMIN_OrdersManager OrdersMngr = new ADMIN_OrdersManager();
        private ADMIN_WarehouseManager WareHouseMngr = new ADMIN_WarehouseManager();

        

        private void управлениеАккаунтамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersMngr.Show();
        }

        private void управлениеПродажамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesMngr.Show();
        }

        private void таблицаМатерикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContinentsMngr.Show();
        }

        private void таблицаСтраныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CountriesMngr.Show();
        }

        private void таблицаГородаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CitiesMngr.Show();
        }

        private void таблицаАвторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WritersMngr.Show();
        }

        private void таблицаЖанрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenresMngr.Show();
        }

        private void таблицаКнигиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BooksMngr.Show();
        }

        private void таблицаДолжностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkPosMngr.Show();
        }

        private void таблицаРаботикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkersMngr.Show();
        }

        private void таблицаПоставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProvidersMngr.Show();
        }

        private void таблицаЗаказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdersMngr.Show();
        }

        private void таблицаСкладToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WareHouseMngr.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
