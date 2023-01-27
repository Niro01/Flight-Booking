using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airbus_Reservation_Form
{
    public partial class Passenger_Lookup : Form
    {
        //create Passenger object and list of all passengers that are found based on a search from the main form
        private List<Passenger> foundPassengers;
        public Passenger passenger;
        //create variable for mode (delete or view)
        private string viewMode;
        //create variable for cancellation, so no operation is performed
        public bool isOperationCancelled;

        //create constructor and pass the mode to it 
        public Passenger_Lookup(string viewMode)
        {
            InitializeComponent();
            foundPassengers = viewMode == "delete" ? Form1.foundPassengers : Form1.passengers;
            passenger = new Passenger();
            isOperationCancelled = false;
            this.viewMode = viewMode;
        }

        //when the form loads, sort the passengers by seat row number and column letter
        private void Passenger_Lookup_Load(object sender, EventArgs e)
        {
            foundPassengers = foundPassengers.OrderBy(c => c.SeatNumber).OrderBy(r => r.SeatPosition).ToList();
            dgvPassangers.DataSource = foundPassengers;
        }

        //cancel operation, do not do anything just close theform
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            isOperationCancelled = true;
            this.Close();
        }

        //when user clicks the name in the grid view, bound it with the passeneger object
        //(only do this is if we are deleting passenger, not when we are only viewing them)

        private void dgvPassangers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (viewMode != "view")
            {
                passenger = (Passenger)dgvPassangers.CurrentRow.DataBoundItem;
                Hide();
            }
        }
    }
}