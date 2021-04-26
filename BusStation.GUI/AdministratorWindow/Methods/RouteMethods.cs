using BusStation.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusStation.GUI.AdministratorWindow
{
    public partial class AdministratorForm
    {
        public void InitRouteDataGridView()
        {
            routeDataGridView.AutoGenerateColumns = false;
            routeDataGridView.AllowUserToAddRows = false;
            routeDataGridView.AllowUserToDeleteRows = false;

            DataGridViewTextBoxColumn routeColumn = new DataGridViewTextBoxColumn()
            {
                Name = "Name",
                HeaderText = "Название",
                DataPropertyName = "Name"
            };

            routeDataGridView.Columns.Add(routeColumn);

            routeDataGridView.DataSource = _routes;
        }

        public void AddRoute(RouteDTO route)
        {
            try
            {
                _routeService.Create(route);
                _routes.Add(route);

                InitLists();
                UpdateDataGridViews();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка! {e.Message}.", "Ошибка");
            }
        }
    }
}
