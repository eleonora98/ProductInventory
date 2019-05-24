using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductInventoryForms
{
    public partial class FormProductInventory : Form
    {
        private Inventory inventory = new Inventory();
        
        Shirt shirts = new Shirt();
        Pants pant = new Pants();
        Coat coats = new Coat();
        Dress dresses = new Dress();
        
        BindingSource productsBinding = new BindingSource();       
        private List<Product> shoppingCard = new List<Product>();
        BindingSource cardBinding = new BindingSource();
     
        private decimal totalPrice = 0;

        public FormProductInventory()
        {
            InitializeComponent();
            Setup();

            productsBinding.DataSource = inventory.Products;
            listBoxProductsInStore.DataSource = productsBinding;

            listBoxProductsInStore.DisplayMember = "Information";
            listBoxProductsInStore.ValueMember = "Information";


            cardBinding.DataSource = shoppingCard;
            listBoxProductsInInventory.DataSource = cardBinding;

            listBoxProductsInInventory.DisplayMember = "Information";
            listBoxProductsInInventory.ValueMember = "Information";


        }
        

        private void Setup()
        {
            inventory.Products.Add(new Shirt { Title = "Shirt1", Description = "Short shirt", Price = 10.5M, Color = "White", Size="S" });
            inventory.Products.Add(new Shirt { Title = "shirt2", Description = "Long shirt", Price = 12.5M, Color="Pink", Size="M" });
            inventory.Products.Add(new Pants { Title = "Pants1", Description = "Long pants", Price = 20.6M, Color = "Blue" });
            inventory.Products.Add(new Coat { Title = "Coat1", Description="Bulgarian coat", Price=200.00M, Leather=" Natural Leather" });
            inventory.Products.Add(new Coat { Title = "Coat2", Description = "Italian coat", Price = 90.00M, Leather = " Artificial Leather" });
            inventory.Products.Add(new Dress { Title="Dress1", Description="Spring Dress", Price=35.00M, Length="Long"});
            inventory.Products.Add(new Dress { Title = "Dress2", Description = "Summer Dress", Price = 30.00M, Length = "Short" });

            //Other way:

             /*Product[] Products = new Product[7];
               Products[0] = new Shirt() { Title = "Shirt1", Description = "Short shirt", Price = 10.5M, Color = "White",Size="S" };
               Products[1] = new Shirt() { Title = "shirt2", Description = "Long shirt", Price = 12.5M, Color="Pink",Size="M" };
               Products[2] = new Pants() { Title = "Pants1", Description = "Long pants", Price = 20.6M, Color = "Blue" };
               Products[3] = new Coat() { Title = "Coat1", Description="Bulgarian coat", Price=200.00M, Leather=" Natural Leather" };
               Products[4] = new Coat() {  Title = "Coat2", Description = "Italian coat", Price = 90.00M, Leather = " Artificial Leather" };
               Products[5] = new Dress() { Title="Dress1", Description="Spring Dress", Price=35.00M, Length="Long"};
               Products[6] = new Dress() { Title = "Dress2", Description = "Summer Dress", Price = 30.00M, Length = "Short" };          
               inventory.Products.Add(Products[0]);
               inventory.Products.Add(Products[1]);
               inventory.Products.Add(Products[2]);
               inventory.Products.Add(Products[3]);
               inventory.Products.Add(Products[4]);
               inventory.Products.Add(Products[5]);
               inventory.Products.Add(Products[6]);
             */
             

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Product selectedItem = (Product)listBoxProductsInStore.SelectedItem;

            shoppingCard.Add(selectedItem);
            cardBinding.ResetBindings(false);   
           
        }

        private void FormProductInventory_Load(object sender, EventArgs e)
        {
            labelProductsTotalPrice.Text = "0.0";
            labelValue.Text = "BGN";
        }

        private void buttonRemoveInventoryProduct_Click(object sender, EventArgs e)
        {
            Product selectedItem = (Product)listBoxProductsInInventory.SelectedItem;
           
                shoppingCard.Remove(selectedItem);
                cardBinding.ResetBindings(false);
                
                try
                {
                if (Convert.ToDecimal(labelProductsTotalPrice.Text) > 0)
                {
                    totalPrice = Convert.ToDecimal(labelProductsTotalPrice.Text) - (decimal)selectedItem.Price;
                    labelProductsTotalPrice.Text = Convert.ToString(totalPrice);
                }
                else
                {
                    totalPrice = 0;
                }  

                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("No products added");
                }
    
   
        }

        private void buttonProductsTotalprice_Click(object sender, EventArgs e)
        {
             
                foreach (Product product in shoppingCard)
                {
                    totalPrice = totalPrice + (decimal)product.Price;
                labelProductsTotalPrice.Text = Convert.ToString(totalPrice);
                  

                }
                labelProductsTotalPrice.Text = Convert.ToString(totalPrice);
            totalPrice = 0;
                
        }
        

        private void labelProductsTotalPrice_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonClearAllInventoryProducts_Click(object sender, EventArgs e)
        {

            shoppingCard.Clear();
            labelProductsTotalPrice.Text = "0.0";
            labelValue.Text = "BGN";

            cardBinding.ResetBindings(false);
            
        }

        
    }
}
