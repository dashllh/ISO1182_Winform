namespace ISO1182_Winform
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            cmbUserType.SelectedIndex = 0;
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            txtPasswd.Focus();
        }

        private void lblChangePasswd_Click(object sender, EventArgs e)
        {
            ChangePasswdForm changePasswdForm = new ChangePasswdForm();
            changePasswdForm.ShowDialog();
        }
    }
}
