using BusStation.BLL.DTO;
using BusStation.BLL.Services;
using BusStation.GUI.AdministratorWindow;
using BusStation.GUI.GuestWindow;
using BusStation.GUI.UserWindow;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BusStation.GUI
{
    public partial class MainForm : Form
    {
        private readonly UserService _userService;
        private readonly StopService _stopService;
        private readonly RouteService _routeService;
        private readonly BusService _busService;
        private readonly BusCategoryService _busCategoryService;
        private readonly TripService _tripService;
        private readonly TicketService _ticketService;
        private readonly RouteStopService _routeStopService;
        private readonly UserTicketService _userTicketService;

        public MainForm(UserService userService, StopService stopService, RouteService routeService, BusService busService, TripService tripService, TicketService ticketService, RouteStopService routeStopService, UserTicketService userTicketService, BusCategoryService busCategoryService)
        {
            InitializeComponent();

            _userService = userService;
            _stopService = stopService;
            _routeService = routeService;
            _busService = busService;
            _tripService = tripService;
            _ticketService = ticketService;
            _routeStopService = routeStopService;
            _userTicketService = userTicketService;
            _busCategoryService = busCategoryService;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string loginString = loginTextBox.Text;
            string passwordString = passwordTextBox.Text;

            if (string.IsNullOrEmpty(loginString) || string.IsNullOrEmpty(passwordString))
            {
                MessageBox.Show("Введите логинь(пароль)!", "Ошибка");
                return;
            }

            try
            {
                var user = _userService.Get().Where(u => u.Username == loginString && u.Password == passwordString).FirstOrDefault();

                if (user == null)
                    throw new Exception("Вы ввели неправильный логин(пароль)!");

                if (user.IsAdmin)
                {
                    AdministratorForm administratorWindow = new AdministratorForm(_userService, _tripService, _routeService, _busService, _busCategoryService, _stopService, _routeStopService, _ticketService);
                    administratorWindow.Owner = this;
                    administratorWindow.Show();
                }
                else
                {
                    UserForm userWindow = new UserForm(_stopService, _tripService, _ticketService, _userTicketService, user);
                    userWindow.Owner = this;
                    userWindow.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void guestLoginButton_Click(object sender, EventArgs e)
        {
            GuestForm guestForm = new GuestForm(_ticketService, _stopService, _tripService);
            guestForm.Owner = this;
            guestForm.Show();
            Hide();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(_userService);
            registerForm.Owner = this;
            registerForm.Show();
            Hide();
        }
    }
}
