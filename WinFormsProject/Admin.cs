using WinFormsProject.Entities;

namespace WinFormsProject
{
    public partial class Admin : Form
    {
        private GetUser _currentUser;

        public Admin()
        {
            InitializeComponent();
        }

        public Admin(GetUser currentUser) : this()
        {
            _currentUser = currentUser;
            DisplayUserInfo();
        }

        private void DisplayUserInfo()
        {
            if (_currentUser != null)
            {
                lbl_userInfo.Text = $"Welcome, Admin {_currentUser.Name} {_currentUser.Surname}!\n" +
                                    $"Role: {_currentUser.RoleName}\n" +
                                    $"Email: {_currentUser.Email}\n" +
                                    $"Balance: {_currentUser.Balance}AZN\n" +
                                    $"Birthday: {_currentUser.Birthday.ToShortDateString()}";
            }
            else
            {
                lbl_userInfo.Text = "Welcome, Guest!";
            }
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Users usersForm = new Users(_currentUser))
            {
                usersForm.ShowDialog();
            }
            this.Show();
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            using (Products productsForm = new Products())
            {
                productsForm.ShowDialog(); 
            }
            this.Show();
        }

    }
}
