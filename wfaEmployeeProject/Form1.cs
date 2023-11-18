using wfaEmployeeProject.Models;
using wfaEmployeeProject.NorthwindContext;

namespace wfaEmployeeProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NorthwindContext1 dbContext = new NorthwindContext1();
        private void btnShowEmployees_Click(object sender, EventArgs e)
        {
            List<Employee> employees = dbContext.Employees.ToList();
            dgvEmployees.DataSource = employees;

            //employee �d si 1 olan employee nas�l get�r�l�r

        }

        private void btnFirstEmployee_Click(object sender, EventArgs e)
        {
            //employee �d si 1 olan employee nas�l get�r�l�r
            Employee employee = dbContext.Employees.FirstOrDefault(e => e.EmployeeId == 1);
            MessageBox.Show(employee.FirstName + employee.LastName);
            //where birden fazla deger doneb�l�ceg� �c�n kullan�lmamal� 
            //firstordefault u eger tek b�r deger gel�ceg�nden em�nsek kullan�r�z yoksa singleordefault
            //gender i�in firstordefault dersen birden fazla olucag� �c�n patlar ama sibgleordefault ta patlamaz
        }

        private void dgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int id = (int)dgvEmployees[0, index].Value;
        }
    }
}