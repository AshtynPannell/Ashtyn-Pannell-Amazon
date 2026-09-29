namespace Ashtyn_Pannell_Amazon
{
    public partial class Form1 : Form
    {
        int count = 0;

        public Form1()
        {
            InitializeComponent();

            listView.View = View.Details;
            listView.FullRowSelect = true;
            listView.GridLines = true;

            listView.Columns.Add("Product ID", 90);
            listView.Columns.Add("Product Name", 90);
            listView.Columns.Add("Product Description", 120);
            listView.Columns.Add("Product Category", 110);
            listView.Columns.Add("Product Price", 90);
            listView.Columns.Add("Created At", 150);
            listView.Columns.Add("SellerSKU", 120);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtPID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text))
            {
                return;
            }

            Product product;

            if (count == 0)
            {
                product = new Product
                {
                    ProductID = txtPID.Text,
                    ProductName = txtName.Text,
                    ProductDescription = txtDescription.Text,
                    ProductCategory = txtCategory.Text,
                    ProductPrice = txtPrice.Text
                };
            }

           
            else if (count == 1)
            {
                product = new Product(
                    txtPID.Text,
                    txtName.Text
                );

                product.ProductDescription = txtDescription.Text;
                product.ProductCategory = txtCategory.Text;
                product.ProductPrice = txtPrice.Text;
            }

           
            else
            {
                product = new Product(
                    txtPID.Text,
                    txtName.Text,
                    txtDescription.Text,
                    txtCategory.Text,
                    txtPrice.Text,
                    "SKU-001"
                );
            }

           
            ListViewItem item = new ListViewItem(product.ProductID);
            item.SubItems.Add(product.ProductName);
            item.SubItems.Add(product.ProductDescription);
            item.SubItems.Add(product.ProductCategory);
            item.SubItems.Add(product.ProductPrice);
            item.SubItems.Add(product.CreatedAt.ToString());
            item.SubItems.Add(product.SellerSKU);

            listView.Items.Add(item);

            count++;
        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                while (listView.SelectedItems.Count > 0)
                {
                    listView.Items.Remove(listView.SelectedItems[0]);
                    count--;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPID.Clear();
            txtName.Clear();
            txtDescription.Clear();
            txtCategory.Clear();
            txtPrice.Clear();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            lblCount.Text = "List Count: " + listView.Items.Count +
                            " | Products Created: " + Product.ProductCount;
        }
    }
}