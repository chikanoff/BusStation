using BusStation.BLL.DTO;
using BusStation.BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BusStation.GUI.AdministratorWindow
{
    public partial class AdministratorForm : Form
    {
        private readonly UserService _userService;
        private readonly TripService _tripService;
        private readonly RouteService _routeService;
        private readonly BusService _busService;
        private readonly BusCategoryService _busCategoryService;
        private readonly StopService _stopService;
        private readonly RouteStopService _routeStopService;
        private readonly TicketService _ticketService;

        private BindingList<UserDTO> _users;
        private BindingList<TripDTO> _trips;
        private BindingList<RouteDTO> _routes;
        private BindingList<BusDTO> _buses;
        private BindingList<BusCategoryDTO> _busCategories;
        private BindingList<StopDTO> _stops;
        private BindingList<RouteStopDTO> _routeStops;
        private BindingList<TicketDTO> _tickets;

        public AdministratorForm(UserService userService, TripService tripService, RouteService routeService, BusService busService, BusCategoryService busCategoryService, StopService stopService, RouteStopService routeStopService, TicketService ticketService)
        {
            _userService = userService;
            _tripService = tripService;
            _busService = busService;
            _routeService = routeService;
            _busCategoryService = busCategoryService;
            _stopService = stopService;
            _routeStopService = routeStopService;
            _ticketService = ticketService;

            InitializeComponent();

            InitLists();
            InitDataGridViews();
            InitComboBoxs();
        }

        private void InitLists()
        {
            try
            {
                var users = _userService.Get();
                _users = new BindingList<UserDTO>((IList<UserDTO>)users);

                var trips = _tripService.Get();
                _trips = new BindingList<TripDTO>((IList<TripDTO>)trips);

                var routes = _routeService.Get();
                _routes = new BindingList<RouteDTO>((IList<RouteDTO>)routes);

                var buses = _busService.Get();
                _buses = new BindingList<BusDTO>((IList<BusDTO>)buses);

                var busCategories = _busCategoryService.Get();
                _busCategories = new BindingList<BusCategoryDTO>((IList<BusCategoryDTO>)busCategories);

                var stops = _stopService.Get();
                _stops = new BindingList<StopDTO>((IList<StopDTO>)stops);

                var routeStops = _routeStopService.Get();
                _routeStops = new BindingList<RouteStopDTO>((IList<RouteStopDTO>)routeStops);

                var tickets = _ticketService.Get();
                _tickets = new BindingList<TicketDTO>((IList<TicketDTO>)tickets);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка! {e.Message}.", "Ошибка");
            }
        }

        private void InitDataGridViews()
        {
            InitUserDataGridView();
            InitTripDataGridView();
            InitRouteDataGridView();
            InitBusDataGridView();
            InitStopDataGridView();
            InitRouteStopsDataGridView();
            InitTicketDataGridView();
        }

        private void UpdateDataGridViews()
        {
            busDataGridView.DataSource = _buses;
            routeDataGridView.DataSource = _routes;
            routeStopDataGridView.DataSource = _routeStops;
            stopDataGridView.DataSource = _stops;
            tripDataGridView.DataSource = _trips;
            userDataGridView.DataSource = _users;

            InitComboBoxs();
        }

        private void InitComboBoxs()
        {
            InitIsAdminComboBox();

            addRouteComboBox.DataSource = _routes;
            addRouteComboBox.DisplayMember = "Name";
            addRouteComboBox.ValueMember = "Id";

            addBusComboBox.DataSource = _buses;
            addBusComboBox.DisplayMember = "Id";
            addBusComboBox.ValueMember = "Id";

            addCategoryComboBox.DataSource = _busCategories;
            addCategoryComboBox.DisplayMember = "Name";
            addCategoryComboBox.ValueMember = "Id";

            addRouteForRSComboBox.DataSource = _routes;
            addRouteForRSComboBox.DisplayMember = "Name";
            addRouteForRSComboBox.ValueMember = "Id";

            addStopForRSComboBox.DataSource = _stopService.Get();
            addStopForRSComboBox.DisplayMember = "Name";
            addStopForRSComboBox.ValueMember = "Id";

            addTripTComboBox.DataSource = _trips;
            addTripTComboBox.DisplayMember = "Date";
            addTripTComboBox.ValueMember = "Id";

            addStartPointTComboBox.DataSource = _stopService.Get();
            addStartPointTComboBox.DisplayMember = "Name";
            addStartPointTComboBox.ValueMember = "Id";

            addEndPointTComboBox.DataSource = _stopService.Get();
            addEndPointTComboBox.DisplayMember = "Name";
            addEndPointTComboBox.ValueMember = "Id";
        }

        private void usersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var buttonColumn = senderGrid.Columns[e.ColumnIndex] as DataGridViewButtonColumn;

            if (buttonColumn == null || e.RowIndex < 0)
                return;

            if (buttonColumn.Name == "Update")
            {
                UpdateUser(e.RowIndex);
                return;
            }

            if (buttonColumn.Name == "Delete")
            {
                DeleteUser(e.RowIndex);
                return;
            }
        }

        private void userAddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addLoginTextBox.Text) || string.IsNullOrEmpty(addPasswordTextBox.Text))
            {
                MessageBox.Show("Введите логин(пароль)!", "Ошибка");
                return;
            }

            UserDTO user = new UserDTO
            {
                Username = addLoginTextBox.Text,
                Password = addPasswordTextBox.Text,
                IsAdmin = (bool)addIsAdminComboBox.SelectedItem
            };

            AddUser(user);
        }

        private void tripDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            object value = tripDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            var comboBoxColumn = (tripDataGridView.Columns[e.ColumnIndex]) as DataGridViewComboBoxColumn;
            if (comboBoxColumn != null && comboBoxColumn.Items.Contains(value))
            {
                e.ThrowException = false;
            }
        }

        private void addTripButton_Click(object sender, EventArgs e)
        {
            TripDTO trip = new TripDTO
            {
                BusId = (int)addBusComboBox.SelectedValue,
                RouteId = (int)addRouteComboBox.SelectedValue,
                Date = dateTimePicker.Value
            };

            AddTrip(trip);
        }

        private void tripDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var buttonColumn = senderGrid.Columns[e.ColumnIndex] as DataGridViewButtonColumn;

            if (buttonColumn == null || e.RowIndex < 0)
                return;

            if (buttonColumn.Name == "Update")
            {
                UpdateTrip(e.RowIndex);
                return;
            }

            if (buttonColumn.Name == "Delete")
            {
                DeleteTrip(e.RowIndex);
                return;
            }
        }

        private void AdministratorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
        }

        private void addRouteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addRouteTextBox.Text))
            {
                MessageBox.Show("Введите название маршрута!", "Ошибка");
                return;
            }

            RouteDTO route = new RouteDTO { Name = addRouteTextBox.Text };

            AddRoute(route);
        }

        private void addBusButton_Click(object sender, EventArgs e)
        {
            int capacity = default;
            if (string.IsNullOrEmpty(addCapacityTextBox.Text) || !int.TryParse(addCapacityTextBox.Text, out capacity))
            {
                MessageBox.Show("Введите вместимость автобуса!", "Ошибка");
                return;
            }

            BusDTO bus = new BusDTO
            {
                Capacity = capacity,
                CategoryId = (int)addCategoryComboBox.SelectedValue
            };

            AddBus(bus);
        }

        private void busDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var buttonColumn = senderGrid.Columns[e.ColumnIndex] as DataGridViewButtonColumn;

            if (buttonColumn == null || e.RowIndex < 0)
                return;

            if (buttonColumn.Name == "Update")
            {
                UpdateBus(e.RowIndex);
                return;
            }

            if (buttonColumn.Name == "Delete")
            {
                DeleteBus(e.RowIndex);
                return;
            }
        }

        private void StopDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var buttonColumn = senderGrid.Columns[e.ColumnIndex] as DataGridViewButtonColumn;

            if (buttonColumn == null || e.RowIndex < 0)
                return;

            if (buttonColumn.Name == "Update")
            {
                UpdateStop(e.RowIndex);
                return;
            }

            if (buttonColumn.Name == "Delete")
            {
                DeleteStop(e.RowIndex);
                return;
            }
        }

        private void addStopButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addStopNameTextBox.Text))
            {
                MessageBox.Show("Введите название остановки!", "Ошибка");
                return;
            }

            StopDTO stop = new StopDTO
            {
                Name = addStopNameTextBox.Text
            };

            AddStop(stop);
        }

        private void routeStopDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var buttonColumn = senderGrid.Columns[e.ColumnIndex] as DataGridViewButtonColumn;

            if (buttonColumn == null || e.RowIndex < 0)
                return;

            if (buttonColumn.Name == "Update")
            {
                UpdateRouteStop(e.RowIndex);
                return;
            }

            if (buttonColumn.Name == "Delete")
            {
                DeleteRouteStop(e.RowIndex);
                return;
            }
        }

        private void addRouteStopButton_Click(object sender, EventArgs e)
        {
            int stopNumber = default;
            int distance = default;

            if (string.IsNullOrEmpty(addStopNumberTextBox.Text) || !int.TryParse(addStopNumberTextBox.Text, out stopNumber))
            {
                MessageBox.Show("Введите количество остановок!", "Ошибка");
                return;
            }

            if (string.IsNullOrEmpty(addDistanceTextBox.Text) || !int.TryParse(addDistanceTextBox.Text, out distance))
            {
                MessageBox.Show("Введите расстояние от начала маршрута!", "Ошибка");
                return;
            }

            RouteStopDTO routeStop = new RouteStopDTO
            {
                RouteId = (int)addRouteForRSComboBox.SelectedValue,
                StopId = (int)addStopForRSComboBox.SelectedValue,
                StopNumberInRoute = stopNumber,
                DistanceFromStart = distance
            };

            AddRouteStop(routeStop);
        }

        private void addTicektButton_Click(object sender, EventArgs e)
        {
            int price = default;

            if (string.IsNullOrEmpty(addPriceTextBox.Text) || !int.TryParse(addPriceTextBox.Text, out price))
            {
                MessageBox.Show("Введите цену!", "Ошибка");
                return;
            }

            TicketDTO ticket = new TicketDTO
            {
                TripId = (int)addTripTComboBox.SelectedValue,
                StartStopId = (int)addStartPointTComboBox.SelectedValue,
                EndStopId = (int)addEndPointTComboBox.SelectedValue,
                Price = price
            };

            AddTicket(ticket);
        }
    }
}
