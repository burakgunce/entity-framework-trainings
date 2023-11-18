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

            //employee ýd si 1 olan employee nasýl getýrýlýr

        }

        private void btnFirstEmployee_Click(object sender, EventArgs e)
        {
            //employee ýd si 1 olan employee nasýl getýrýlýr
            Employee employee = dbContext.Employees.FirstOrDefault(e => e.EmployeeId == 1);
            MessageBox.Show(employee.FirstName + employee.LastName);
            //where birden fazla deger donebýlýcegý ýcýn kullanýlmamalý 
            //firstordefault u eger tek býr deger gelýcegýnden emýnsek kullanýrýz yoksa singleordefault
            //gender için firstordefault dersen birden fazla olucagý ýcýn patlar ama sibgleordefault ta patlamaz
        }

        private void dgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int id = (int)dgvEmployees[0, index].Value;
        }
    }
}