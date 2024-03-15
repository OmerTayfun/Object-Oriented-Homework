using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomework
{
    public class TeacherCreditManager:BaseCreditManager,ICreditManager
    {
        public override void Calculate()
        {
            Console.WriteLine("Öğretmen kredisi hesaplandı");
        }

        //public void Save()  Save operasyonunu BaseCreditManager'dan çekeceği için gerek kalmayacak 
        //{
        //    throw new NotImplementedException();
        //}
        public override void Save()
        {
            Console.WriteLine("Kayıt tamamlandı.");
            base.Save();
        }
    }
}
