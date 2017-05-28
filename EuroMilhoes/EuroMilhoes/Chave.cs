using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroMilhoes
{
    class Chave
    {
        private int  num;

        private Random rnd = new Random();
        private List<int> lista = new List<int>();
        private List<int> listaE = new List<int>();
        public Chave() 
        {

            for (int x = 0; x < 5; x++)
            {
                num = rnd.Next(1, 51);
                do
                {
                    num = rnd.Next(1, 51);
                } while (lista.Contains(num));
                lista.Add(num);



            }
            for (int x = 0; x < 2; x++)
            {
                do
                {
                    num = rnd.Next(1, 13);
                } while (listaE.Contains(num));
                listaE.Add(num);



            }

        }

        public Chave(List<int> num, List<int> estrelas)
        {

            this.lista = num;
            this.listaE = estrelas;


        }

        public List<int> getListaN()
        {
            lista.Sort();

            return this.lista;
        }
        public List<int> getListaE()
        {
            listaE.Sort();
            return this.listaE;
        }
       
    }
}
