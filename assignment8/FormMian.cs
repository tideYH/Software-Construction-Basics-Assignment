using assignment5;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment7
{
    public partial class FormMian : Form
    {
        OrderService orderService=new OrderService();
        public String Keyword { get; set; }
        //public event Action<FormEdit> ShowEditForm;

        public FormMian()
        {   

            InitializeComponent();
            InitOrders();
            orderBindingSource.DataSource = orderService.QueryOrdersByPredicate(o => true);
            comboBox1.SelectedIndex = 0;
            textBox1.DataBindings.Add("Text", this, "Keyword");
            
        }

        private void InitOrders()
        {
            Order order1 = new Order(1, new Customer("王华华"));

            order1.AddOrderDetail(new OrderDetails(new Product("apple",5),10));
            order1.AddOrderDetail(new OrderDetails(new Product("egg", 2), 61));
            orderService.AddOrder(order1);
            Order order2 = new Order(2, new Customer("廖廖"));
            order2.AddOrderDetail(new OrderDetails(new Product("egg", 2), 10));
            orderService.AddOrder(order2);
        }

        public class OrderContext : DbContext
        {
            public DbSet<Order> Orders { get; set; }
            public DbSet<OrderDetails> OrderItems { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseMySQL("server=localhost;database=orderdb;user=root;password=88880000");//填写自己的密码
            }
        }


        public void QueryAll()
        {
            orderBindingSource.DataSource = orderService.QueryOrdersByPredicate(order => true);
            orderBindingSource.ResetBindings(false);
        }

        private void Query_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0://所有订单
                        orderBindingSource.DataSource = orderService.QueryOrdersByPredicate(o => true);
                        break;
                    case 1://根据ID查询
                        int Keyint = int.Parse(Keyword);//进行一步转换
                        orderBindingSource.DataSource = orderService.QueryOrdersByPredicate(o=>o.OrderId== Keyint);
                        break;
                    case 2://根据客户名字查询
                        orderBindingSource.DataSource = orderService.QueryOrdersByPredicate(o => o.Customer.Name == Keyword);
                        break;
                    case 3://根据货物名字查询
                        orderBindingSource.DataSource = orderService.QueryOrdersByPredicate(o => o.OrderDetails.Any(d=>d.Product.Name== Keyword) );
                        break;
                    
                }
                orderBindingSource.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();
            formAdd.ShowDialog();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void orderDetailsBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
