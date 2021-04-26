using BusStation.BLL.DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BusStation.GUI.AdministratorWindow
{
    public partial class AdministratorForm
    {
        public void InitStopDataGridView()
        {
            stopDataGridView.AutoGenerateColumns = false;
            stopDataGridView.AllowUserToAddRows = false;
            stopDataGridView.AllowUserToDeleteRows = false;

            DataGridViewTextBoxColumn _nameColumn = new DataGridViewTextBoxColumn()
            {
                Name = "Name",
                HeaderText = "Название",
                DataPropertyName = "Name"
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

            stopDataGridView.Columns.Add(_nameColumn);
            stopDataGridView.Columns.Add(updateColumn);
            stopDataGridView.Columns.Add(deleteColumn);

            stopDataGridView.DataSource = _stops;
        }

        private void AddStop(StopDTO stop)
        {
            try
            {
                _stopService.Create(stop);
                stop.Id = _stopService.Get().Where(s => s.Name == s.Name).LastOrDefault().Id;
                _stops.Add(stop);

                InitComboBoxs();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка! {e.Message}.", "Ошибка");
            }
        }

        private void UpdateStop(int index)
        {
            try
            {
                StopDTO stop = _stops[index];
                _stopService.Update(stop);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка! {e.Message}.", "Ошибка");
            }
        }

        private void DeleteStop(int index)
        {
            if (_stops.Count == 1)
            {
                MessageBox.Show($"Ошибка удаления записи (последняя запись)!", "Ошибка");
                return;
            }

            try
            {
                StopDTO stop = _stops[index];
                _stopService.Delete(stop.Id);
                _stops.Remove(stop);

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
