using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string student1 = "İlker";
            string student2 = "Sena";
            string student3 = "İlayda";
            //ayrı ayrı değişkenler olduğu için yönetimi zor 
            //"array" ile aynı tipteki değerleri değişkenleri tek bir noktada yönetip,
            //tek bir değişkenle yönetme şeklinde ve ona hızlıca ulaşma, döngü ile dönme ihtiyacında
            //array lerden yararlanırız

            string[] students = new string[3];
            students[0] = "İlker";
            students[1] = "Sena";
            students[2] = "İlayda";

            string[] students2 = { "İlker", "Sena", "İlayda" };


            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
