using System.Diagnostics.Metrics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TriardClass;

namespace PR6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Информация пока не заполненно");
        }

        private void btCalculation_Click(object sender, RoutedEventArgs e)
        {
            Triard triardOne = new Triard();
            Triard triardTwo = new Triard();
            bool boolOneFirstPositiveNumber = int.TryParse(tbOneTriardFirstNumber.Text, out int oneFirstPositiveNumber);
            bool boolTwoFirstPositiveNumber = int.TryParse(tbTwoTriardFirstNumber.Text, out int twoFirstPositiveNumber);
            bool boolThreeFirstPositiveNumber = int.TryParse(tbThreeTriardFirstNumber.Text, out int threeFirstPositiveNumber);
            bool boolOneSecondPositiveNumber = int.TryParse(tbOneTriardSecondNumber.Text, out int oneSecondPositiveNumber);
            bool boolTwoSecondPositiveNumber = int.TryParse(tbTwoTriardSecondNumber.Text, out int twoSecondPositiveNumber);
            bool boolThreeSecondPositiveNumber = int.TryParse(tbThreeTriardSecondNumber.Text, out int threeSecondPositiveNumber);
            if (boolOneFirstPositiveNumber == true || boolTwoFirstPositiveNumber == true || boolThreeFirstPositiveNumber == true || boolOneSecondPositiveNumber == true || boolTwoSecondPositiveNumber == true || boolThreeSecondPositiveNumber == true)
            {
                triardOne.SetParams(oneFirstPositiveNumber, twoFirstPositiveNumber, threeFirstPositiveNumber);
                triardTwo.SetParams(oneSecondPositiveNumber, twoSecondPositiveNumber, threeSecondPositiveNumber);
                if (triardOne == triardTwo) MessageBox.Show("Триады равны");
                else MessageBox.Show("Триады не равны");
            }
            else MessageBox.Show("Туда сюда");
        }
    }
}