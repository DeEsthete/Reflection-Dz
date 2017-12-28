using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_Dz
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            Type type = typeof(Console);

            var memebersInfo = type.GetMethods();

            foreach (var info in memebersInfo)
            {
                Console.WriteLine(info);
            }

            #endregion
            Console.ReadLine();

            #region Task2
            User user = new User("Aleksey Popov", "LexaSuper", "qwerty123");
            Type typeUser = typeof(User);

            var memebersInfoUser = typeUser.GetProperties();

            for (int i = 0; i < memebersInfoUser.Length; i++)
            {
                Console.WriteLine(memebersInfoUser[i] + " " + memebersInfoUser[i].GetValue(user));
            }
            #endregion
            Console.ReadLine();
        }
    }
}
