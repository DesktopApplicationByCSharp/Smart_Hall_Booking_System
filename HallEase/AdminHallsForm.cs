using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace HallsProjects
{
    public partial class AdminHallsForm : Form
    {
        private HallService _hallService;

        public AdminHallsForm()
        {
            _hallService = new HallService();
            InitializeComponent();

            // Wire designer events
            btnDelete.Click += BtnDelete_Click;
            btnBack.Click += (s, e) => this.Close();

            LoadHalls();
        }

        private void LoadHalls()
        {
            DataTable dt = _hallService.GetAllHalls();
            dgvHalls.DataSource = dt;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvHalls.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this hall? This action cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int hallId = Convert.ToInt32(dgvHalls.SelectedRows[0].Cells["HallID"].Value);
                    var result = _hallService.DeleteHall(hallId);

                    if (result.IsSuccess)
                    {
                        MessageBox.Show("Hall deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadHalls();
                    }
                    else
                    {
                        if (result.ErrorMessage.Contains("547"))
                        {
                            MessageBox.Show("Cannot delete hall because it has associated bookings.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show($"Failed to delete hall. Error: {result.ErrorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a hall to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}


