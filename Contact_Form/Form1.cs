using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Contact_Form
{
    public partial class Form1 : Form
    {
        TestEntities test;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox1.Enabled = true;
                custID.Focus();
                Customer c = new Customer();
                test.Customers.Add(c);
                customerBindingSource.Add(c);
                customerBindingSource.MoveLast();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            
            custID.Focus();

        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            customerBindingSource.ResetBindings(false);
            foreach (DbEntityEntry entry in test.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.State = System.Data.Entity.EntityState.Detached;
                        break;
                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                }
            }
        }

        private void bntUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                customerBindingSource.EndEdit();
                test.SaveChangesAsync();
                groupBox1.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                customerBindingSource.ResetBindings(false);
            }
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            test = new TestEntities();
            customerBindingSource.DataSource = test.Customers.ToList();
            
        }

      

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure u want to delete this record?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    test.Customers.Remove(customerBindingSource.Current as Customer);
                }
            }
        }
    }
}
