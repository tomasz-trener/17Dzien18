using P03AplikacjaPogodaClientAPI.ViewModels.ProductViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace P03AplikacjaPogodaClientAPI.Controls
{
    /// <summary>
    /// Interaction logic for ProductControl.xaml
    /// </summary>
    public partial class ProductControl : UserControl
    {
        public ProductControl()
        {
            InitializeComponent();
        }




        public ProductVM Product
        {
            get { return (ProductVM)GetValue(ProductProperty); }
            set { SetValue(ProductProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Product.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProductProperty =
            DependencyProperty.Register("Product", typeof(ProductVM), typeof(ProductControl), new PropertyMetadata(new ProductVM() {  Title="a", Description="b"}, SetText));


        private static void SetText(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ProductControl control =  (ProductControl)d;

            
            control.productTitle.Content = ((ProductVM)e.NewValue).Title;
            control.productDescription.Text = ((ProductVM)e.NewValue).Description;
             
            

        }


    }
}
