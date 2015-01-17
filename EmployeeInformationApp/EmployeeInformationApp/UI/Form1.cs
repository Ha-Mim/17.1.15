using System.Windows.Forms;

namespace EmployeeInformationApp.UI
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void addEmployeeButton_Click(object sender, System.EventArgs e)
        {
            EmployeeInformationUI add=new EmployeeInformationUI();
            add.Show();
        }

        private void AddDesignationButton_Click(object sender, System.EventArgs e)
        {
            AddDesignationUI addDesignation=new AddDesignationUI();
            addDesignation.Show();
        }

        private void findEditButton_Click(object sender, System.EventArgs e)
        {
            FindEditUI find=new FindEditUI();
            find.Show();
        }

        private void MainUI_Load(object sender, System.EventArgs e)
        {

        }
    }
}
