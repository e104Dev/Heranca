using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Leao leao = new Leao("http://aws.amz.net/lion.jpg",
                "carne", "selvagem", 8);

            Aguia aguia = new Aguia("http://aws.amz.net/eagle.jpg",
                "carne", "savana", 4);

            Console.WriteLine(leao);
            Console.WriteLine(aguia);

            leao.comer();
            leao.dormir();

        }
    }
}
