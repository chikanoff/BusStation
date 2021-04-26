using BusStation.BLL.DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BusStation.GUI.AdministratorWindow
{
    public partial class AdministratorForm
    {
        public void InitRouteStopsDataGridView()
        {
            routeStopDataGridView.AutoGenerateColumns = false;
            routeStopDataGridView.AllowUserToAddRows = false;
            routeStopDataGridView.AllowUserToDeleteRows = false;

            DataGridViewComboBoxColumn _routeColumn = new DataGridViewComboBoxColumn()
            {
                Name = "RouteId",
                HeaderText = "Маршрут",
                DataSource = _routes,
                DisplayMember = "Name",
                ValueMember = "Id",
                DataPropertyName = "RouteId"
            };

            DataGridViewComboBoxColumn _stopColumn = new DataGridViewComboBoxColumn()
            {
                Name = "StopId",
                HeaderText = "Остановка",
                DataSource = _stops,
                DisplayMember = "Name",
                ValueMember = "Id",
                DataPropertyName = "StopId"
            };

            DataGridViewTextBoxColumn _stopNumberColumn = new DataGridViewTextBoxColumn()
            {
                Name = "StopNumberInRoute",
                HeaderText = "Количество остановок",
                DataPropertyName = "StopNumberInRoute"
            };

            DataGridViewTextBoxColumn _distanceColumn = new DataGridViewTextBoxColumn()
            {
                Name = "DistanceFromStart",
                HeaderText = "Раcстояние от начала маршрута",
                DataPropertyName = "DistanceFromStart"
            };

            DataGridViewButtonColumn updateColumn = new DataGridViewButtonColumn()
            {
                Name = "Update",
                HeaderText = "",
                Text = "Обновить",
                UseColumnTextForButtonValue = true
            };

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn()
            {
                Name = "Delete",
                HeaderText = "",
                Text = "Удалить",
                UseColumnTextForButtonValue = true
            };

            routeStopDataGridView.Columns.Add(_routeColumn);
            routeStopDataGridView.Columns.Add(_stopColumn);
            routeStopDataGridView.Columns.Add(_stopNumberColumn);
            routeStopDataGridView.Columns.Add(_distanceColumn);
            routeStopDataGridView.Columns.Add(updateColumn);
            routeStopDataGridView.Columns.Add(deleteColumn);

            routeStopDataGridView.DataSource = _routeStops;
        }

        private void AddRouteStop(RouteStopDTO routeStop)
        {
            try
            {
                _routeStopService.Create(routeStop);
                routeStop.Id = _routeStopService.Get().Where(r => r.RouteId == routeStop.RouteId && r.StopId == routeStop.RouteId && r.StopNumberInRoute == routeStop.StopNumberInRoute).LastOrDefault().Id;
                _routeStops.Add(routeStop);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка! {e.Message}.", "Ошибка");
            }
        }

        private void UpdateRouteStop(int index)
        {
            try
            {
                RouteStopDTO routeStop = _routeStops[index];
                _routeStopService.Update(routeStop);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка! {e.Message}.", "Ошибка");
            }

            // TODO: service.
        }

        private void DeleteRouteStop(int index)
        {
            if (_routeStops.Count == 1)
            {
                MessageBox.Show($"Ошибка удаления записи (последняя запись)!", "Ошибка");
                return;
            }

            try
            {
                RouteStopDTO routeStop = _routeStops[index];
                _routeStopService.Delete(routeStop.Id);
                _routeStops.Remove(routeStop);

                InitLists();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка! {e.Message}.", "Ошибка");
            }
        }
    }
}
