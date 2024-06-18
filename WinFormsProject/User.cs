using WinFormsProject.Entities;
using System.Windows.Forms;

namespace WinFormsProject
{
    public partial class User : Form
    {
        private EditUser _currentUser;
        public User(EditUser currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            DisplayUserInfo();
        }

        private void DisplayUserInfo()
        {
            if (_currentUser != null)
            {
                lbl_userInfo.Text = $"Welcome, Member {_currentUser.Name} {_currentUser.Surname}!\n" +
                                    $"Email: {_currentUser.Email}\n" +
                                    $"Balance: {_currentUser.Balance} AZN\n" +
                                    $"Birthday: {_currentUser.Birthday.ToShortDateString()}";
            }
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            Deposit depositForm = new Deposit(_currentUser);
            depositForm.Show();
        }

        private void btn_shop_Click(object sender, EventArgs e)
        {
            Shop shopForm = new Shop(_currentUser);
            shopForm.Show();
        }
    }
}
