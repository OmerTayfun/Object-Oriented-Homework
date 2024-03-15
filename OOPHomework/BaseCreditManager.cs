using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomework
{
        public abstract class BaseCreditManager : ICreditManager
    {
        public abstract void Calculate(); // Calculate operasyonu değişken olduğu için abstract yazıyoruz ve
                                          // sadece imzasını alıyoruz.
        
        public virtual void Save()
        {
            Console.WriteLine("Kaydedildi");
        }
    }
}
