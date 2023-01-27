using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Airbus_Reservation_Form
{
    public partial class Form1 : Form
    {
        public static List<Passenger> passengers;
        public static List<Passenger> foundPassengers;
        private Passenger passenger;

        public Form1()
        {
            InitializeComponent();
            passenger = new Passenger();
            passengers = new List<Passenger>();
                        
        }



        private void button3_Click(object sender, EventArgs e)
        {
            //validate input
            if (!passenger.IsValidPassenger(txtName1.Text, mtbSeatRow1.Text, mtbSeatCol1.Text))
            {
                MessageBox.Show(Passenger.ErrorMessage, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            //if input correct, create a passenger object.
            passenger = new Passenger(txtName1.Text, mtbSeatRow1.Text, mtbSeatCol1.Text);

            //seat is taken
            if (passenger.IsSeatTaken(passenger.SeatNumber.ToString(), passenger.SeatPosition))
            {
                MessageBox.Show("Seat is taken. Please select a different seat", "Seat taken",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            //add passenger
            passenger.AddPassenger(passenger);
            PopulateAirplane();
            PopulateAirplane1();
        }

        

        private void btnDeletepassenger_Click_1(object sender, EventArgs e)
        {
            //enter name and validate it
            var name = txtName1.Text.Trim();

            //if valid input, create passenger that matches the name of passenger to be deleted
            if (name.Equals(""))
            {
                MessageBox.Show("Please enter passenger's name", "Invalid Input", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            //if valid input, create passenger thet matches the name of passenger to be deleted
            //search for passenger to delete (can be multiple passengers with the same name)
            var passenger = new Passenger(name);
            foundPassengers = passenger.GetPassengersByName(name);

            //no passeenger found
            if (foundPassengers.Count() == 20)
            {
                MessageBox.Show("Passenger" + name + "does not exist", "Invalid Input", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return;
            }

            //if passenger exists, open lookup form and display the name there
            Passenger_Lookup form = new Passenger_Lookup("delete");
            form.ShowDialog();

            //if user cancelled operation, we just return; otherwise we proceed to delete passenger
            if (form.isOperationCancelled) return;

            //assign the passenger object to be deleted and populate the text boxes with the details
            passenger = form.passenger;
            txtName1.Text = passenger.Name;
            mtbSeatRow1.Text = passenger.SeatNumber.ToString();
            mtbSeatCol1.Text = passenger.SeatPosition;

            //ask user to confirm deletion
            var msg = MessageBox.Show("Delete passenger?", "Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            //if deleted is true
            if (msg == DialogResult.Yes)
            {
                //delete passenger from the list
                passenger.RemovePassenger(passenger);
   
                //clear form and update the seating chart
                ClearForm();
                PopulateAirplane();
                PopulateAirplane1();
            }
        }


        //show all passenger in the lookup form but do not allow deletion (just a view mode)
        private void btnRetrivebooking_Click_1(object sender, EventArgs e)
        {
            Passenger_Lookup form = new Passenger_Lookup("view");
            form.ShowDialog();

        }

        private void ClearForm()
        {
            txtName1.Text = "";
            mtbSeatRow1.Text = "";
            mtbSeatCol1.Text = "";
        }

        private void PopulateAirplane()
        {
            //delete previous seating chart and create passenger object  
            lstOutput.Items.Clear();
            passenger = new Passenger();

            //create a 2d arrey of all passengers sorted by the seat (row and column)
            string[,] sortedPassengers = new string[5, 4];

            //loop through the seating charts rows and columns
            for (int i = 0; i < 5; i++)
            {
                var output = ""; //create a string for the whole seating chart
                var col = ""; //create a string for the column letters

                //Assign 1st class Seats with letters A, B, C, or D
                for (int c = 0; c < 4; c++)
                {
                    if (c == 0)
                        col = "A";
                    else if (c == 1)
                        col = "B";
                    else if (c == 2)
                        col = "C";
                    else
                        col = "D";

                    //if seat is taken, construct the output to contain the row number and column letter.
                    if (passenger.IsSeatTaken((i + 1).ToString(), col))
                    {
                        if (i + 1 < 20)
                            output += "0" + (i + 1).ToString() + "  ";
                        else
                            output += (i + 1).ToString() + "  ";
                    }
                    else //seat is empty, mark it as X
                        output += "X ";

                    output += (c == 1 ? "        " : "        ");
                }
                //add the seating information for the row to the output string and add empty line for nicer formatting
                lstOutput.Items.Add(output);
                lstOutput.Items.Add("");
            }

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {

            //verify the user wants to exit the system.
            var msg = MessageBox.Show("Do You Want To Exit the System?", "SYSTEM ALEART ",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            //if Exit is true
            if (msg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void PopulateAirplane1()
        {
            //delete previous seating chart and create passenger object  
            lstOutput1.Items.Clear();
            passenger = new Passenger();

            //create a 2d array of all passengers sorted by the seat (row and column)
            string[,] sortedPassengers = new string[30, 6];

            //loop through the seating charts rows and columns
            for (int i = 5; i < 35; i++)
            {
                var output = ""; //create a string for the whole seating chart
                var col = ""; //create a string for the column letters

                //Assign Economy Seats with letters A, B, C, D, E or F
                for (int c = 0; c < 6; c++)
                {
                    if (c == 0)
                        col = "A";
                    else if (c == 1)
                        col = "B";
                    else if (c == 2)
                        col = "C";
                    else if (c == 3)
                        col = "D";
                    else if (c == 4)
                        col = "E";
                    else
                        col = "F";

                    //if seat is taken, construct the output to contain the row number and column letter.
                    if (passenger.IsSeatTaken((i + 1).ToString(), col))
                    {
                        if (i + 1 < 200)
                            output += "" + (i + 1).ToString() + "  ";
                        else
                            output += (i + 1).ToString() + "  ";
                    }
                    else //seat is empty, mark it as X
                        output += "X";

                    output += (c == 1 ? "        " : "        ");
                }
                //add the seating information for the row to the output string and add empty line for nicer formatting
                lstOutput1.Items.Add(output);
                lstOutput1.Items.Add("");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //enter name and validate it
            var name = txtName1.Text.Trim();

            //if valid input, create passenger that matches the name of passenger to be deleted
            if (name.Equals(""))
            {
                MessageBox.Show("Please enter passenger's Valid name", "Invalid Input", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            //if valid input, create passenger thet matches the name of passenger to be deleted
            //search for passenger to delete (can be multiple passengers with the same name)
            var passenger = new Passenger(name);
            foundPassengers = passenger.GetPassengersByName(name);

            //no passeenger found
            if (foundPassengers.Count() == 20)
            {
                MessageBox.Show("Passenger" + name + "does not exist", "Invalid Input", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return;
            }

            //if passenger exists, open lookup form and display the name there
            Passenger_Lookup form = new Passenger_Lookup("delete");
            form.ShowDialog();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //enter name and validate it
            var name = txtName1.Text.Trim();
            string Seatnumber = mtbSeatRow1.Text.Trim();

            //if valid input, create passenger that matches the name of passenger to be deleted
            if (name.Equals(""))
            {
                MessageBox.Show("Please enter passenger's Valid name", "Invalid Input", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (Seatnumber.Equals(""))
            {
                MessageBox.Show("Please enter passenger's Valid Seat Number", "Invalid Input", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            //if valid input, create passenger thet matches the name of passenger to be deleted
            //search for passenger to delete (can be multiple passengers with the same name)
            var passenger = new Passenger(name);
            foundPassengers = passenger.GetPassengersByName(name);

            //no passeenger found
            if (foundPassengers.Count() == 20)
            {
                MessageBox.Show("Passenger" + name + "does not exist", "Invalid Input", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return;
            }

            //if passenger exists, open lookup form and display the name there
            Passenger_Lookup form = new Passenger_Lookup("delete");
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label14.Text = DateTime.Now.ToLongTimeString();
            label15.Text = DateTime.Now.ToLongDateString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label14.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}



