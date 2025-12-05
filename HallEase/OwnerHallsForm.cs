using HallsProjects;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HallsProjects
{

     
public partial class OwnerHallsForm : Form
{
    private User _currentUser;
    private HallService _hallService;

    public OwnerHallsForm(User user)
    {
        _currentUser = user;
        _hallService = new HallService();
        InitializeComponent();

        // Wire up events to designer controls
        btnEdit.Click += BtnEdit_Click;
        btnDelete.Click += BtnDelete_Click;
        btnBack.Click += (s, e) => this.Close();

        LoadHalls();
    }

    private void LoadHalls()
    {
        DataTable dt = _hallService.GetHallsByOwner(_currentUser.UserID);
        dgvHalls.DataSource = dt;

        if (dgvHalls.Columns.Contains("ImagePath"))
            dgvHalls.Columns["ImagePath"].Visible = false;
    }

    private void BtnEdit_Click(object sender, EventArgs e)
    {
        if (dgvHalls.SelectedRows.Count > 0)
        {
            int hallId = Convert.ToInt32(dgvHalls.SelectedRows[0].Cells["HallID"].Value);
            Hall hall = _hallService.GetHallById(hallId);

            EditHallForm form = new EditHallForm(_currentUser, hall);
            this.Hide();
            form.FormClosed += (s, args) =>
            {
                this.Show();
                LoadHalls(); // Refresh list
            };
            form.Show();
        }
        else
        {
            MessageBox.Show("Please select a hall to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void BtnDelete_Click(object sender, EventArgs e)
    {
        if (dgvHalls.SelectedRows.Count > 0)
        {
            if (MessageBox.Show("Are you sure you want to delete this hall?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

