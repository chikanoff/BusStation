using BusStation.BLL.DTO;
using BusStation.BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusStation.GUI
{
    public partial class RegisterForm : Form
    {
        private readonly UserService _userService;

        public RegisterForm(UserService userService)
        {
            _userService = userService;
            InitializeComponent();
        }

        private void registorButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(loginTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("Введите логин(пароль)!", "Ошибка");
                return;
            }
            try
            {
                var users = _userService.Get();
                if (users.Any(u => u.Username == loginTextBox.Text))
                {
                    MessageBox.Show("Пользователь с таким именим уже существует!", "Ошибка");
                    return;
                }

                UserDTO user = new UserDTO
                {
                    Username = loginTextBox.Text,
                    Password = passwordTextBox.Text,
                    IsAdmin = false
                };
                    _userService.Create(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }

            MessageBox.Show("Вы успешно зарегестрированы!");

            Owner.Show();
            Close();
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
        }
    }
}
