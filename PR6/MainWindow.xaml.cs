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
            MessageBox.Show("Сделал:Ермаков Павел \nГруппа:ИСП-34\nЗадание:Использовать класс Triad (тройка положительных чисел). Разработать операции\r\nопределения равенства/неравенства чисел true/false. Разработать операции \r\nпроверки полного равенства/неравенства чисел в триадах (a1,b1,c1) == (a2,b2,c2).");
        }

        private void btCalculation_Click(object sender, RoutedEventArgs e)
        {
            Triard triardFirst = new Triard();//Это то что мы будем сравнивать
            Triard triardSecond = new Triard();//Будем сравнивать triardFirst с triardSecond
            bool boolOneFirstPositiveNumber = int.TryParse(tbOneTriardFirstNumber.Text, out int oneFirstPositiveNumber);
            bool boolTwoFirstPositiveNumber = int.TryParse(tbTwoTriardFirstNumber.Text, out int twoFirstPositiveNumber);
            bool boolThreeFirstPositiveNumber = int.TryParse(tbThreeTriardFirstNumber.Text, out int threeFirstPositiveNumber);
            bool boolOneSecondPositiveNumber = int.TryParse(tbOneTriardSecondNumber.Text, out int oneSecondPositiveNumber);
            bool boolTwoSecondPositiveNumber = int.TryParse(tbTwoTriardSecondNumber.Text, out int twoSecondPositiveNumber);
            bool boolThreeSecondPositiveNumber = int.TryParse(tbThreeTriardSecondNumber.Text, out int threeSecondPositiveNumber);
            if (boolOneFirstPositiveNumber == true || boolTwoFirstPositiveNumber == true || boolThreeFirstPositiveNumber == true || boolOneSecondPositiveNumber == true || boolTwoSecondPositiveNumber == true || boolThreeSecondPositiveNumber == true)
            {
                triardFirst.SetParams(oneFirstPositiveNumber, twoFirstPositiveNumber, threeFirstPositiveNumber);//Присваиваем для triardFirst значения
                triardSecond.SetParams(oneSecondPositiveNumber, twoSecondPositiveNumber, threeSecondPositiveNumber);//Тут тоже самое
                if (triardFirst == triardSecond) MessageBox.Show("Триады равны");
                else MessageBox.Show("Триады не равны");
            }
            else MessageBox.Show("Ввеведи циферки");
        }
    }
}