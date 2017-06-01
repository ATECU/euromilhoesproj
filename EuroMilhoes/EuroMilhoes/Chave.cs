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


        public string toFich()
        {
            string numSt = "";
            string esSt = "";
            foreach(int x in lista)
            {
                numSt += x.ToString() + "|";
            }
            foreach (int x in listaE)
            {
                esSt += x.ToString() + "|";

            }
            return numSt + esSt;
        }

        public string premio(List<int> num, List<int> es)
        {
            string numero = "", estrelas = "", premio = "";

            foreach (int x in num)
            {
                numero += x.ToString() + " ";
            }
            foreach(int x in es)
            {
                estrelas += x.ToString() + " ";
            }



            if (num.Count == 5 && es.Count == 2 )
            {
                premio = "1";
            }
            else if (num.Count == 5 && es.Count == 1)
            {

                premio = "2";
            }
            else if (num.Count == 5 && es.Count == 0)
            {

                premio = "3";
            }
            else if (num.Count == 4 && es.Count == 2)
            {

                premio = "4";
            }
            else if (num.Count == 4 && es.Count == 1)
            {

                premio = "5";
            }
            else if (num.Count == 3 && es.Count == 2)
            {

                premio = "6";
            }
            else if (num.Count == 4 && es.Count == 0)
            {

                premio = "7";
            }
            else if (num.Count == 2 && es.Count == 2)
            {

                premio = "8";
            }
            else if (num.Count == 3 && es.Count == 1)
            {

                premio = "9";
            }
            else if (num.Count == 3 && es.Count == 0)
            {

                premio = "10";
            }
            else if (num.Count == 1 && es.Count == 2)
            {

                premio = "11";
            }
            else if (num.Count == 2 && es.Count == 1)
            {

                premio = "12";
            }
            else if (num.Count == 2 && es.Count == 0)
            {

                premio = "13";
            }
            else
            {
                premio = "0";
            }




            if (premio == "0")
            {
                return num.Count + " Numeros + " + es.Count + " estrelas \n\n" + "NAO GANHOU NENHUM PRÉMIO !!!";
            }


            if (estrelas != "" && numero == "")
            {
                return num.Count + " Numeros + " + es.Count + " estrelas \n\n"
                + estrelas + "\n\n " + " GANHOU O " + premio + "º PRÉMIO!";
            }

            else if(numero != "" && estrelas == "")
            {
                return num.Count + " Numeros + " + es.Count + " estrelas \n\n"
              + numero + "\n\n " + " GANHOU O " + premio + "º PRÉMIO!";
            }


            return num.Count + " Numeros + " + es.Count  + " estrelas \n\n" 
                + numero + "                  " + estrelas + "\n\n " + "GANHOU O " + premio + "º PRÉMIO ! ";
        }

    }
}