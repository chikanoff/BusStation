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
        public void InitUserDataGridView()
        {
            userDataGridView.AutoGenerateColumns = false;
            userDataGridView.AllowUserToAddRows = false;
            userDataGridView.AllowUserToDeleteRows = false;

            DataGridViewTextBoxColumn usernameColumn = new DataGridViewTextBoxColumn()
            {
                Name = "Username",
                HeaderText = "Логин",
                DataPropertyName = "Username"
            };

            DataGridViewTextBoxColumn passwordColumn = new DataGridViewTextBoxColumn()
            {
                Name = "Password",
                HeaderText = "Пароль",
                DataPropertyName = "Password"
            };

            DataGridViewCheckBoxColumn isAdminColumn = new DataGridViewCheckBoxColumn()
            {
                Name = "IsAdmin",
                HeaderText = "Доступ администратора",
                DataPropertyName = "IsAdmin"
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

            userDataGridView.Columns.Add(usernameColumn);
            userDataGridView.Columns.Add(passwordColumn);
            userDataGridView.Columns.Add(isAdminColumn);
            userDataGridView.Columns.Add(updateColumn);
            userDataGridView.Columns.Add(deleteColumn);

            userDataGridView.DataSource = _users;
        }

        private void InitIsAdminComboBox()
        {
            object[] isAdminValues = new object[] { true, false };
            addIsAdminComboBox.Items.AddRange(isAdminValues);
            addIsAdminComboBox.SelectedIndex = 0;
        }

        private void AddUser(UserDTO user)
        {
            try
            {
                _userService.Create(user);
                user.Id = _userService.Get().Where(u => u.Username == user.Username && u.Password == user.Password && u.IsAdmin == user.IsAdmin).LastOrDefault().Id;
                _users.Add(user);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка! {e.Message}.", "Ошибка");
            }
        }

        private void UpdateUser(int index)
        {
            UserDTO user = _users[index];

            if (string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password))
            {
                MessageBox.Show($"Ошибка обновления записи (Индекс: {index})!", "Ошибка");
                return;
            }

            try
            {
                _userService.Update(user);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка! {e.Message}.", "Ошибка");
            }

            // TODO: service.
        }

        private void DeleteUser(int index)
        {
            if (_users.Count == 1)
            {
                MessageBox.Show($"Ошибка удаления записи (последняя запись)!", "Ошибка");
                return;
            }

            try
            {
                UserDTO user = _users[index];
                _userService.Delete(user.Id);
                _users.Remove(user);

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
