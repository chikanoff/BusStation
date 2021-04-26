using BusStation.BLL.DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BusStation.GUI.AdministratorWindow
{
    public partial class AdministratorForm
    {
        public void InitBusDataGridView()
        {
            busDataGridView.AutoGenerateColumns = false;
            busDataGridView.AllowUserToAddRows = false;
            busDataGridView.AllowUserToDeleteRows = false;

            DataGridViewTextBoxColumn _capacityColumn = new DataGridViewTextBoxColumn()
            {
                Name = "Capacity",
                HeaderText = "Вместимость",
                DataPropertyName = "Capacity"
            };

            DataGridViewComboBoxColumn _categoryColumn = new DataGridViewComboBoxColumn()
            {
                Name = "CategoryId",
                HeaderText = "Вид транспорта",
                DataSource = _busCategories,
                DisplayMember = "Name",
                ValueMember = "Id",
                DataPropertyName = "CategoryId"
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

            busDataGridView.Columns.Add(_capacityColumn);
            busDataGridView.Columns.Add(_categoryColumn);
            busDataGridView.Columns.Add(updateColumn);
            busDataGridView.Columns.Add(deleteColumn);

            busDataGridView.DataSource = _buses;
        }

        private void AddBus(BusDTO bus)
        {
            try
            {
                _busService.Create(bus);
                bus.Id = _busService.Get().Where(b => b.Capacity == bus.Capacity && b.CategoryId == bus.CategoryId).LastOrDefault().Id;
                _buses.Add(bus);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка! {e.Message}.", "Ошибка");
            }
        }

        private void UpdateBus(int index)
        {
            try
            {
                BusDTO bus = _buses[index];
                _busService.Update(bus);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка! {e.Message}.", "Ошибка");
            }
        }

        private void DeleteBus(int index)
        {
            if (_buses.Count == 1)
            {
                MessageBox.Show($"Ошибка удаления записи (последняя запись)!", "Ошибка");
                return;
            };

            try
            {
                BusDTO bus = _buses[index];
                _busService.Delete(bus.Id);
                _buses.Remove(bus);

                InitLists();
                UpdateDataGridViews();
                InitComboBoxs();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка! {e.Message}.", "Ошибка");
            }
        }
    }
}
