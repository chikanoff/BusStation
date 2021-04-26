using BusStation.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusStation.GUI.AdministratorWindow
{
    public partial class AdministratorForm
    {
        public void InitTicketDataGridView()
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
                DataPropertyName = "EndStopId",
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
                ReadOnly = true
            };

            DataGridViewTextBoxColumn _priceColumn = new DataGridViewTextBoxColumn()
            {
                Name = "Price",
                HeaderText = "Цена",
                DataPropertyName = "Price"
            };

            ticketDataGridView.Columns.Add(_tripColumn);
            ticketDataGridView.Columns.Add(_startPointColumn);
            ticketDataGridView.Columns.Add(_endPointColumn);
            ticketDataGridView.Columns.Add(_priceColumn);

            ticketDataGridView.DataSource = _tickets;
        }

        private void AddTicket(TicketDTO ticket)
        {
            try
            {
                _ticketService.Create(ticket);
                ticket.Id = _ticketService.Get().Where(t => t.TripId == ticket.TripId && t.StartStopId == ticket.StartStopId && t.EndStopId == ticket.EndStopId).LastOrDefault().Id;
                _tickets.Add(ticket);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка! {e.Message}.", "Ошибка");
            }
        }
    }
}
