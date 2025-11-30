using System;
using System.Data;
using System.Windows.Forms;

namespace HallsProjects
{
    public partial class HallsListForm : Form
    {
        private User _currentUser;
        private HallService _hallService;

        public HallsListForm(User user)
        {
            _currentUser = user;
            _hall_service_check();
            _hallService = new HallService();
            InitializeComponent();

            // Wire events
            btnSearch.Click += BtnSearch_Click;
            btnViewDetails.Click += BtnViewDetails_Click;
            btnBack.Click += (s, e) => this.Close();

            LoadHalls();
        }

        private void _hall_service_check() { }

        private void LoadHalls()
        {
            DataTable dt = _hallService.GetAllHalls();
            dgvHalls.DataSource = dt;

            if (dgvHalls.Columns.Contains("ImagePath"))
                dgvHalls.Columns["ImagePath"].Visible = false;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string location = txtLocation.Text.Trim();
            decimal? minPrice = string.IsNullOrEmpty(txtMinPrice.Text) ? (decimal?)null : decimal.Parse(txtMinPrice.Text);
            decimal? maxPrice = string.IsNullOrEmpty(txtMaxPrice.Text) ? (decimal?)null : decimal.Parse(txtMaxPrice.Text);
            int? minCapacity = string.IsNullOrEmpty(txtMinCapacity.Text) ? (int?)null : int.Parse(txtMinCapacity.Text);

            DataTable dt = _hallService.SearchHalls(location, minPrice, maxPrice, minCapacity);
            dgvHalls.DataSource = dt;

            if (dgvHalls.Columns.Contains("ImagePath"))
                dgvHalls.Columns["ImagePath"].Visible = false;
        }

        private void BtnViewDetails_Click(object sender, EventArgs e)
        {
            if (dgvHalls.SelectedRows.Count > 0)
            {
                int hallId = Convert.ToInt32(dgvHalls.SelectedRows[0].Cells["HallID"].Value);
                Hall hall = _hallService.GetHallById(hallId);

                HallDetailsForm form = new HallDetailsForm(_currentUser, hall);
                this.Hide();
                form.FormClosed += (s, args) => this.Show();
                form.Show();
            }
            else
            {
                MessageBox.Show("Please select a hall to view details.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}



