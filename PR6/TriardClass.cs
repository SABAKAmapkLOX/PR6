using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TriardClass
{
    class Triard
    {
        public int onePositiveNumber;//Первое положительное число
        public int twoPositiveNumber;//Второе положительное число
        public int threePositiveNumber;//Третье положительное число
        public int OnePositiveNumber
        {
            get//Возвращаем значение поля
            {
                return onePositiveNumber;
            }
            set//Устанавливаем значение поля
            {
                if (value > 0) onePositiveNumber = value;
                else MessageBox.Show("В первом числе меньше нуля");

            }
        }
        public int TwoPositiveNumber
        {
            get
            {
                return twoPositiveNumber;
            }
            set
            {
                if (value > 0) twoPositiveNumber = value;
                else MessageBox.Show("Во втором числе меньше нуля");
            }
        }
        public int ThreePositiveNumber
        {
            get
            {
                return threePositiveNumber;
            }
            set
            {
                if (value > 0) threePositiveNumber = value;
                else MessageBox.Show("В третьем числе меньше нуля");
            }
        }
        public int SumNumber()//Возвращаем сумму положительных чисел
        {
            return OnePositiveNumber + TwoPositiveNumber + ThreePositiveNumber;
        }
        public void SetParams(int oneSetParams, int twoSetParams, int threeSetParams)//Перегрузка методов
        {
            OnePositiveNumber = oneSetParams;
            TwoPositiveNumber = twoSetParams;
            ThreePositiveNumber = threeSetParams;
        }
        public void SetParams(int oneSetParams, int twoSetParams)
        {
            OnePositiveNumber = oneSetParams;
            TwoPositiveNumber = twoSetParams;
            ThreePositiveNumber = oneSetParams + twoSetParams;
        }
        public void SetParams(int oneSetParams)
        {
            OnePositiveNumber = oneSetParams;
            TwoPositiveNumber = oneSetParams;
            ThreePositiveNumber = oneSetParams;
        }
        public static bool operator ==(Triard c1, Triard c2)//Перегрузим две операции сравнения.
                                                            //Сами операторы сравнения сравнивают значения свойств
                                                            //Всех положительных чисел и в зависимости от результата сравнения возвращают либо true, либо false.
        {
            bool result;
            if (c1.onePositiveNumber == c2.onePositiveNumber && c1.twoPositiveNumber == c2.twoPositiveNumber && c1.threePositiveNumber == c2.threePositiveNumber) result = true;
            else result = false;
            return result;
        }
        public static bool operator !=(Triard c1, Triard c2) 
        {
            return c1.onePositiveNumber != c2.onePositiveNumber && c1.twoPositiveNumber != c2.twoPositiveNumber && c1.threePositiveNumber != c2.threePositiveNumber;
        }
    }
}
