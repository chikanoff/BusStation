using BusStation.BLL.DTO;
using BusStation.BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BusStation.GUI.GuestWindow
{
    public partial class GuestForm : Form
    {
        private readonly TicketService _ticketService;
        private readonly StopService _stopService;
        private readonly TripService _tripService;

        private BindingList<TicketDTO> _tickets;
        private BindingList<StopDTO> _stops;
        private BindingList<TripDTO> _trips;

        public GuestForm(TicketService ticketService, StopService stopService, TripService tripService)
        {
            _ticketService = ticketService;
            _stopService = stopService;
            _tripService = tripService;

            InitializeComponent();
            InitLists();
            InitTicketDataGridView();
            InitComboBoxs();
        }

        private void InitLists()
        {
            try
            {
                var ticekts = _ticketService.Get();
                _tickets = new BindingList<TicketDTO>((IList<TicketDTO>)ticekts);

                var trips = _tripService.Get();
                _trips = new BindingList<TripDTO>((IList<TripDTO>)trips);

                var stops = _stopService.Get();
                _stops = new BindingList<StopDTO>((IList<StopDTO>)stops);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка! {e.Message}.", "Ошибка");
            }
        }

        private void InitTicketDataGridView()
        {
            ticketDataGridView.AutoGenerateColumns = false;
            ticketDataGridView.AllowUserToAddRows = false;
            ticketDataGridView.AllowUserToDeleteRows = false;

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

            DataGridViewComboBoxColumn _startStopColumn = new DataGridViewComboBoxColumn()
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

            DataGridViewComboBoxColumn _endStopColumn = new DataGridViewComboBoxColumn()
            {
                Name = "EndStopId",
                HeaderText = "Пункт прибытия",
                DataSource = _stops,
                DisplayMember = "Name",
                ValueMember = "Id",
                DataPropertyName = "EndStopId",
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
                ReadOnly = true
            };

            ticketDataGridView.Columns.Add(_tripColumn);
            ticketDataGridView.Columns.Add(_startStopColumn);
            ticketDataGridView.Columns.Add(_endStopColumn);

            ticketDataGridView.DataSource = _tickets;
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

        private void GuestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int startId = (int)startStopComboBox.SelectedValue;
            int endId = (int)endStopComboBox.SelectedValue;
            ticketDataGridView.DataSource = _tickets.Where(t => t.StartStopId == startId && t.EndStopId == endId).ToList();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ticketDataGridView.DataSource = _tickets;
        }
    }
}
