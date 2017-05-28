using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroMilhoes
{
    class Chave
    {
        private int num;

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
        public List<int> compareNum(Chave ch)
        {
            List<int> numWin = new List<int>();
            int count = 0;
                for (int i = 0; i < this.lista.Count; i++)
                {
                    for (int x = 0; x < ch.lista.Count; x++)
                    {
                        if (this.lista[i] == ch.lista[x])
                        {
                            numWin.Add(lista[i]);
                            count++;
                        }
                    }
                }

            return numWin;
        }
        public List<int> compareEs(Chave ch)
        {


            List<int> numEs = new List<int>();
            int count = 0;
            for (int i = 0; i < this.listaE.Count; i++)
            {
                for (int x = 0; x < ch.listaE.Count; x++)
                {
                    if (this.listaE[i] == ch.listaE[x])
                    {
                        numEs.Add(listaE[i]);
                        count++;
                    }
                }
            }

            return numEs;
        }
    }
}