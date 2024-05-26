namespace _20200305010Project
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            ControlPanel controlPanel = new ControlPanel();
            controlPanel.Show();
            this.Hide(); 
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide(); 
        }

       
    }
}
