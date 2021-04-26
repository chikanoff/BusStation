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

namespace BusStation.GUI.UserWindow
{
    public partial class UserForm : Form
    {
        private readonly StopService _stopService;
        private readonly TripService _tripService;
        private readonly TicketService _ticketService;
        private readonly UserTicketService _userTicketService;

        private BindingList<StopDTO> _stops;
        private BindingList<TripDTO> _trips;
        private BindingList<TicketDTO> _tickets;
        private BindingList<UserTicketDTO> _userTickets;

        private UserDTO _user;

        public UserForm(StopService stopService, TripService tripService, TicketService ticketService, UserTicketService userTicketService, UserDTO user)
        {
            _stopService = stopService;
            _tripService = tripService;
            _ticketService = ticketService;
            _userTicketService = userTicketService;

            _user = user;

            InitializeComponent();
            InitLists();
            InitDataGridViews();
            InitComboBoxs();
        }

        private void InitLists()
        {
            try
            {
                var trips = _tripService.Get();
                _trips = new BindingList<TripDTO>((IList<TripDTO>)trips);

                var stops = _stopService.Get();
                _stops = new BindingList<StopDTO>((IList<StopDTO>)stops);

                var tickets = _ticketService.Get();
                _tickets = new BindingList<TicketDTO>((IList<TicketDTO>)tickets);

                var userTicekts = _userTicketService.Get().Where(u => u.UserId == _user.Id).ToList();
                _userTickets = new BindingList<UserTicketDTO>(userTicekts);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка! {e.Message}.", "Ошибка");
            }
        }

        private void InitDataGridViews()
        {
            InitTicketsDataGridView();
            InitUserTicketDataGridView();
        }

        private void InitTicketsDataGridView()
        {
            ticketDataGridView.AutoGenerateColumns = false;
            ticketDataGridView.AllowUserToAddRows = false;
            ticketDataGridView.AllowUserToDeleteRows = false;

            DataGridViewTextBoxColumn _IdColumn = new DataGridViewTextBoxColumn()
            {
                Name = "Id",
                HeaderText = "Номер билета",
                DataPropertyName = "Id",
                ReadOnly = true
            };

            DataGridViewComboBoxColumn _tripColumn = new DataGridViewComboBoxColumn()
            {
                Name = "TripId",
                HeaderText = "Дата",
                DataSource = _trips,
                DisplayMember = "Date",
                ValueMember = "Id",
                DataPropertyName = "TripId",
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
                ReadOnly = true

            };

            DataGridViewComboBoxColumn _startPointColumn = new DataGridViewComboBoxColumn()
            {
                Name = "StartStopId",
                HeaderText = "Пункт отправления",
                DataSource = _stops,
                DisplayMember = "Name",
                ValueMember = "Id",
                DataPropertyName = "StartStopId",
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
                ReadOnly = true
            };

            DataGridViewComboBoxColumn _endPointColumn = new DataGridViewComboBoxColumn()
            {
                Name = "EndStopId",
                HeaderText = "Пункт прибытия",
                DataSource = _stops,
                DisplayMember = "Name",
                ValueMember = "Id",
                DataPropertyName = "StartStopId",
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
                ReadOnly = true
            };

            DataGridViewTextBoxColumn _priceColumn = new DataGridViewTextBoxColumn()
            {
                Name = "Price",
                HeaderText = "Цена",
                DataPropertyName = "Price",
                ReadOnly = true
            };

            ticketDataGridView.Columns.Add(_IdColumn);
            ticketDataGridView.Columns.Add(_tripColumn);
            ticketDataGridView.Columns.Add(_startPointColumn);
            ticketDataGridView.Columns.Add(_endPointColumn);
            ticketDataGridView.Columns.Add(_priceColumn);

            ticketDataGridView.DataSource = _tickets;
        }

        private void InitUserTicketDataGridView()
        {
            userTicketsDataGridView.AutoGenerateColumns = false;
            userTicketsDataGridView.AllowUserToAddRows = false;
            userTicketsDataGridView.AllowUserToDeleteRows = false;

            DataGridViewTextBoxColumn _IdColumn = new DataGridViewTextBoxColumn()
            {
                Name = "TicketId",
                HeaderText = "Номер билета",
                DataPropertyName = "TicketId",
                ReadOnly = true
            };

            DataGridViewComboBoxColumn _priceColumn = new DataGridViewComboBoxColumn()
            {
                Name = "TicketId",
                HeaderText = "Цена",
                DataSource = _tickets,
                DisplayMember = "Price",
                ValueMember = "Id",
                DataPropertyName = "TicketId",
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
                ReadOnly = true
            };

            userTicketsDataGridView.Columns.Add(_IdColumn);
            userTicketsDataGridView.Columns.Add(_priceColumn);

            userTicketsDataGridView.DataSource = _userTickets;
        }

        private void InitComboBoxs()
        {
            startStopComboBox.DataSource = _stopService.Get();
            startStopComboBox.DisplayMember = "Name";
            startStopComboBox.ValueMember = "Id";

            endStopComboBox.DataSource = _stopService.Get();
            endStopComboBox.DisplayMember = "Name";
            endStopComboBox.ValueMember = "Id";
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            try
            {
                int tripId = _trips.Where(t => t.Date.Date == dateTimePicker.Value.Date).FirstOrDefault()?.Id ?? default;
                int startId = _stops.Where(s => s.Name == startStopComboBox.Text).FirstOrDefault()?.Id ?? default;
                int endId = _stops.Where(s => s.Name == endStopComboBox.Text).FirstOrDefault()?.Id ?? default;

                TicketDTO ticket = _tickets.Where(t => t.TripId == tripId && t.StartStopId == startId && t.EndStopId == endId).FirstOrDefault();

                if (ticket == null)
                {
                    MessageBox.Show("Билета с такими данными не существует!", "Ошибка");
                    return;

                }

                UserTicketDTO userTicketDTO = new UserTicketDTO
                {
                    UserId = _user.Id,
                    TicketId = ticket.Id
                };

                _userTicketService.Create(userTicketDTO);

                _userTickets = new BindingList<UserTicketDTO>(_userTicketService.Get().Where(t => t.UserId == _user.Id).ToList());
                userTicketsDataGridView.DataSource = _userTickets;

                MessageBox.Show("Билета успешно куплен!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}
