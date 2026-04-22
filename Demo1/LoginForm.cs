namespace Demo1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_Login.Text) || string.IsNullOrEmpty(txtBox_Password.Text))
            {
                SetInfo("ѕол€ не должны быть пустыми!!!");
            }
            if (txtBox_Login.Text != "admin")
            {
                SetInfo("у вас нет прав)))");
            }
        }

        private void txtBox_Login_TextChanged(object sender, EventArgs e)
        {
            ClearInfo();
        }

        private void txtBox_Password_TextChanged(object sender, EventArgs e)
        {
            ClearInfo();
        }

        private void ClearInfo()
        {
            lbl_Info.Text = string.Empty;
        }

        private void SetInfo(string text)
        {
            lbl_Info.Text = text;
        }
    }
}
