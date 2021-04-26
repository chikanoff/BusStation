using BusStation.BLL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusStation.GUI.AdministratorWindow
{
    public partial class AdministratorForm
    {
        public void InitTripDataGridView()
        {
            tripDataGridView.AutoGenerateColumns = false;
            tripDataGridView.AllowUserToAddRows = false;
            tripDataGridView.AllowUserToDeleteRows = false;

            DataGridViewComboBoxColumn _routeColumn = new DataGridViewComboBoxColumn()
            {
                Name = "RouteId",
                HeaderText = "Маршрут",
                DataSource = _routes,
                DisplayMember = "Name",
                ValueMember = "Id",
                DataPropertyName = "RouteId"
            };

            DataGridViewComboBoxColumn _busColumn = new DataGridViewComboBoxColumn()
            {
                Name = "BusId",
                HeaderText = "Автобус",
                DataSource = _buses,
                DisplayMember = "Capacity",
                ValueMember = "Id",
                DataPropertyName = "BusId"
            };

            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn()
            {
                Name = "Date",
                HeaderText = "Дата",
                DataPropertyName = "Date"
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

            tripDataGridView.Columns.Add(_routeColumn);
            tripDataGridView.Columns.Add(_busColumn);
            tripDataGridView.Columns.Add(dateColumn);
            tripDataGridView.Columns.Add(updateColumn);
            tripDataGridView.Columns.Add(deleteColumn);

            tripDataGridView.DataSource = _trips;
        }

        private void AddTrip(TripDTO trip)
        {
            try
            {
                _tripService.Create(trip);
                trip.Id = _tripService.Get().Where(t => t.BusId == trip.BusId && t.Date.Date == trip.Date.Date && t.RouteId == trip.RouteId).LastOrDefault().Id;
                _trips.Add(trip);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка! {e.Message}.", "Ошибка");
            }
        }

        private void UpdateTrip(int index)
        {
            try
            {
                TripDTO trip = _trips[index];
                _tripService.Update(trip);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка! {e.Message}.", "Ошибка");
            }
        }

        private void DeleteTrip(int index)
        {
            if (_trips.Count == 1)
            {
                MessageBox.Show($"Ошибка удаления записи (последняя запись)!", "Ошибка");
                return;
            }

            try
            {
                TripDTO trip = _trips[index];
                _tripService.Delete(trip.Id);
                _trips.Remove(trip);

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
