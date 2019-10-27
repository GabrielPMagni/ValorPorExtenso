using System;
using System.Text;
using System.Linq;

namespace ValorPorExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número entre 0 e 999 bilhões: "); //Imprime na tela o que deve ser feito
            decimal num = LerNum(); //variavel num recebe retorno da função LerNum
            
            //Feito em uma nova função e não no Main para poder ser chamada em 
            //caso de erro sem precisar retornar ao Main
             
            StringBuilder resultado = ParaExtenso(num);
            Console.WriteLine(resultado);
            TrabalharString(resultado, num);
        }
        
        private static void TrabalharString(StringBuilder bruto, decimal num)
        {
            string numeroExtenso = num.ToString().Reverse().ToString();
        }

        private static decimal LerNum()
        {
            try
            {
                string stringNumero = Console.ReadLine();
                decimal num = decimal.Parse(stringNumero);
                if (num >= 0 && num <= 999999999999.99m)
                {
                    return num;
                }
                else
                {
                    Console.WriteLine("Digite somente números entre 0 e 999 bilhões");
                    return LerNum();
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine("Encontrado erro:" + erro);
                return LerNum();
            }
        }

        private static StringBuilder ParaExtenso(decimal num)
        {
            StringBuilder numeroPorExtenso = new StringBuilder();
            string stringNumero = num.ToString();

            void UnidadesDecimal()
            {
                if (num == 0.01m)
                {
                    numeroPorExtenso.Append(" um");
                    num -= 0.01m;
                }
                else if (num == 0.02m)
                {
                    numeroPorExtenso.Append(" dois");
                    num -= 0.02m;
                }
                else if (num == 0.03m)
                {
                    numeroPorExtenso.Append(" três");
                    num -= 0.03m;
                }
                else if (num == 0.04m)
                {
                    numeroPorExtenso.Append(" quatro");
                    num -= 0.04m;
                }
                else if (num == 0.05m)
                {
                    numeroPorExtenso.Append(" cinco");
                    num -= 0.05m;
                }
                else if (num == 0.06m)
                {
                    numeroPorExtenso.Append(" seis");
                    num -= 0.06m;
                }
                else if (num == 0.07m)
                {
                    numeroPorExtenso.Append(" sete");
                    num -= 0.07m;
                }
                else if (num == 0.08m)
                {
                    numeroPorExtenso.Append(" oito");
                    num -= 0.08m;
                }
                else if (num == 0.09m)
                {
                    numeroPorExtenso.Append(" nove");
                    num -= 0.09m;
                }
            }
            void DezenasDecimal()
            {
                if (num < 0.10m)
                {
                    UnidadesDecimal();
                }
                else if (num < 0.20m)
                {
                    if (num == 0.10m)
                    {
                        numeroPorExtenso.Append(" dez");
                        num -= 0.10m;
                    }
                    else if (num == 0.11m)
                    {
                        numeroPorExtenso.Append(" onze");
                        num -= 0.11m;
                    }
                    else if (num == 0.12m)
                    {
                        numeroPorExtenso.Append(" doze");
                        num -= 0.12m;
                    }
                    else if (num == 0.13m)
                    {
                        numeroPorExtenso.Append(" treze");
                        num -= 0.13m;
                    }
                    else if (num == 0.14m)
                    {
                        numeroPorExtenso.Append(" quatorze");
                        num -= 0.14m;
                    }
                    else if (num == 0.15m)
                    {
                        numeroPorExtenso.Append(" quinze");
                        num -= 0.15m;
                    }
                    else if (num == 0.16m)
                    {
                        numeroPorExtenso.Append(" dezesseis");
                        num -= 0.16m;
                    }
                    else if (num == 0.17m)
                    {
                        numeroPorExtenso.Append(" dezessete");
                        num -= 0.17m;
                    }
                    else if (num == 0.18m)
                    {
                        numeroPorExtenso.Append(" dezoito");
                        num -= 0.18m;
                    }
                    else if (num == 0.19m)
                    {
                        numeroPorExtenso.Append(" dezenove");
                        num -= 0.19m;
                    }
                }
                else if (num < 0.30m)
                {
                    num -= 0.20m;
                    numeroPorExtenso.Append(" vinte");
                }
                else if (num < 0.40m)
                {
                    num -= 0.30m;
                    numeroPorExtenso.Append(" trinta");
                }
                else if (num < 0.50m)
                {
                    num -= 0.40m;
                    numeroPorExtenso.Append(" quarenta");
                }
                else if (num < 0.60m)
                {
                    num -= 0.50m;
                    numeroPorExtenso.Append(" cinquenta");
                }
                else if (num < 0.70m)
                {
                    num -= 0.60m;
                    numeroPorExtenso.Append(" sessenta");
                }
                else if (num < 0.80m)
                {
                    num -= 0.70m;

                    numeroPorExtenso.Append(" setenta");

                }
                else if (num < 0.90m)
                {
                    num -= 0.80m;

                    numeroPorExtenso.Append(" oitenta");

                }
                else if (num < 1)
                {
                    num -= 0.90m;
                    numeroPorExtenso.Append(" noventa");

                }
                UnidadesDecimal();
            }

            void Unidades()
            {
                if (num >= 9)
                {
                    num -= 9;
                    numeroPorExtenso.Append(" nove");

                }
                else if (num >= 8)
                {
                    num -= 8;
                    numeroPorExtenso.Append(" oito");

                }
                else if (num >= 7)
                {
                    num -= 7;
                    numeroPorExtenso.Append(" sete");

                }
                else if (num >= 6)
                {
                    num -= 6;
                    numeroPorExtenso.Append(" seis");

                }
                else if (num >= 5)
                {
                    num -= 5;
                    numeroPorExtenso.Append(" cinco");

                }
                else if (num >= 4)
                {
                    num -= 4;
                    numeroPorExtenso.Append(" quatro");

                }
                else if (num >= 3)
                {
                    num -= 3;
                    numeroPorExtenso.Append(" três");

                }
                else if (num >= 2)
                {
                    num -= 2;
                    numeroPorExtenso.Append(" dois");

                }
                else if (num >= 1)
                {
                    num -= 1;
                    numeroPorExtenso.Append(" um");
                }
                DezenasDecimal();
            }

            void Dezenas()
            {
                if (num < 10)
                {
                    Unidades();
                }
                else if (num < 20)
                {
                    if (num >= 19)
                    {
                        num -= 19;
                        numeroPorExtenso.Append(" dezenove");

                    }
                    else if (num >= 18)
                    {
                        num -= 18;
                        numeroPorExtenso.Append(" dezoito");

                    }
                    else if (num >= 17)
                    {
                        num -= 17;
                        numeroPorExtenso.Append(" dezessete");

                    }
                    else if (num >= 16)
                    {
                        num -= 16;
                        numeroPorExtenso.Append(" dezesseis");

                    }
                    else if (num >= 15)
                    {
                        num -= 15;
                        numeroPorExtenso.Append(" quinze");

                    }
                    else if (num >= 14)
                    {
                        num -= 14;
                        numeroPorExtenso.Append(" quatorze");

                    }
                    else if (num >= 13)
                    {
                        num -= 13;
                        numeroPorExtenso.Append(" treze");

                    }
                    else if (num >= 12)
                    {
                        num -= 12;
                        numeroPorExtenso.Append(" doze");

                    }
                    else if (num >= 11)
                    {
                        num -= 11;
                        numeroPorExtenso.Append(" onze");

                    }
                    else if (num >= 10)
                    {
                        num -= 10;
                        numeroPorExtenso.Append(" dez");


                    }
                }
                else if (num < 30)
                {
                    num -= 20;

                    numeroPorExtenso.Append(" vinte");

                }
                else if (num < 40)
                {
                    num -= 30;

                    numeroPorExtenso.Append(" trinta");

                }
                else if (num < 50)
                {
                    num -= 40;

                    numeroPorExtenso.Append(" quarenta");

                }
                else if (num < 60)
                {
                    num -= 50;

                    numeroPorExtenso.Append(" cinquenta");

                }
                else if (num < 70)
                {
                    num -= 60;

                    numeroPorExtenso.Append(" seis");

                }
                else if (num < 80)
                {
                    num -= 70;

                    numeroPorExtenso.Append(" setenta");

                }
                else if (num < 90)
                {
                    num -= 80;

                    numeroPorExtenso.Append(" oitenta");

                }
                else if (num < 100)
                {
                    num -= 90;
                    numeroPorExtenso.Append(" noventa");

                }
                Unidades();
            }

            void Centenas()
            {

                if (num < 100)
                {
                    Dezenas();

                }
                else if (num < 200)
                {
                    num -= 100;
                    if (num == 0)
                    {
                        numeroPorExtenso.Append(" cem");
                    }
                    else if (num < 1)
                    {
                        numeroPorExtenso.Append(" cem");
                        DezenasDecimal();
                    } else if (num >= 1)
                    {
                        numeroPorExtenso.Append(" cento");
                        Dezenas();
                    }

                }
                else if (num < 300)
                {
                    num -= 200;
                    numeroPorExtenso.Append(" duzentos");


                }
                else if (num < 400)
                {
                    num -= 300;

                    numeroPorExtenso.Append(" trezentos");

                }
                else if (num < 500)
                {
                    num -= 400;

                    numeroPorExtenso.Append(" quatrocentos");

                }
                else if (num < 600)
                {
                    num -= 500;

                    numeroPorExtenso.Append(" quinhentos");

                }
                else if (num < 700)
                {
                    num -= 600;

                    numeroPorExtenso.Append(" seiscentos");

                }
                else if (num < 800)
                {
                    num -= 700;

                    numeroPorExtenso.Append(" setecentos");

                }
                else if (num < 900)
                {
                    num -= 800;

                    numeroPorExtenso.Append(" oitocentos");

                }
                else if (num < 1000)
                {
                    num -= 900;

                    numeroPorExtenso.Append(" novecentos");

                }
                Dezenas();
            }


            void Milhar()
            {
                if (num < 1000)
                {
                    Centenas();
                }
                else if (num < 2000)
                {
                    num -= 1000;
                    numeroPorExtenso.Append(" um");

                }
                else if (num < 3000)
                {
                    num -= 2000;
                    numeroPorExtenso.Append(" dois");

                }
                else if (num < 4000)
                {
                    num -= 3000;
                    numeroPorExtenso.Append(" três");

                }
                else if (num < 5000)
                {
                    num -= 4000;
                    numeroPorExtenso.Append(" quatro");

                }
                else if (num < 6000)
                {
                    num -= 5000;
                    numeroPorExtenso.Append(" cinco");

                }
                else if (num < 7000)
                {
                    num -= 6000;
                    numeroPorExtenso.Append(" seis");

                }
                else if (num < 8000)
                {
                    num -= 7000;
                    numeroPorExtenso.Append(" sete");

                }
                else if (num < 9000)
                {
                    num -= 8000;
                    numeroPorExtenso.Append(" oito");

                }
                else if (num < 10000)
                {
                    num -= 9000;
                    numeroPorExtenso.Append(" nove");

                }
                Centenas();
            }

            void Milhar1()
            {
                if (num < 10000)
                {
                    Milhar();
                }

                else if (num < 20000)
                {
                    if (num >= 19000)
                    {
                        num -= 19000;
                        numeroPorExtenso.Append(" dezenove");

                    }
                    else if (num >= 18000)
                    {
                        num -= 18000;

                        numeroPorExtenso.Append(" dezoito");

                    }
                    else if (num >= 17000)
                    {
                        num -= 17000;

                        numeroPorExtenso.Append(" dezessete");

                    }
                    else if (num >= 16000)
                    {
                        num -= 16000;

                        numeroPorExtenso.Append(" dezesseis");

                    }
                    else if (num >= 15000)
                    {
                        num -= 15000;

                        numeroPorExtenso.Append(" quinze");

                    }
                    else if (num >= 14000)
                    {
                        num -= 14000;

                        numeroPorExtenso.Append(" quatorze");

                    }
                    else if (num >= 13000)
                    {
                        num -= 13000;

                        numeroPorExtenso.Append(" treze");

                    }
                    else if (num >= 12000)
                    {
                        num -= 12000;

                        numeroPorExtenso.Append(" doze");

                    }
                    else if (num >= 11000)
                    {
                        num -= 11000;

                        numeroPorExtenso.Append(" onze");

                    }
                    else if (num >= 10000)
                    {
                        num -= 10000;
                        numeroPorExtenso.Append(" dez");

                    }
                }
                else if (num < 30000)
                {
                    num -= 20000;
                    numeroPorExtenso.Append(" vinte");

                }
                else if (num < 40000)
                {
                    num -= 30000;
                    numeroPorExtenso.Append(" trinta");

                }
                else if (num < 50000)
                {
                    num -= 40000;
                    numeroPorExtenso.Append(" quarenta");

                }
                else if (num < 60000)
                {
                    num -= 50000;
                    numeroPorExtenso.Append(" cinquenta");

                }
                else if (num < 70000)
                {
                    num -= 60000;
                    numeroPorExtenso.Append(" sessenta");

                }
                else if (num < 80000)
                {
                    num -= 70000;
                    numeroPorExtenso.Append(" setenta");

                }
                else if (num < 90000)
                {
                    num -= 80000;
                    numeroPorExtenso.Append(" oitenta");

                }
                else if (num < 100000)
                {
                    num -= 90000;
                    numeroPorExtenso.Append(" noventa");

                }
                Milhar();
            }

            void Milhar2()
            {
                if (num < 100000)
                {
                    Milhar1();
                }
                else if (num < 200000)
                {
                    num -= 100000;
                    numeroPorExtenso.Append(" cem");

                }
                else if (num < 300000)
                {
                    num -= 200000;
                    numeroPorExtenso.Append(" duzentos");

                }
                else if (num < 400000)
                {
                    num -= 300000;
                    numeroPorExtenso.Append(" trezentos");

                }
                else if (num < 500000)
                {
                    num -= 400000;
                    numeroPorExtenso.Append(" quatrocentos");

                }
                else if (num < 600000)
                {
                    num -= 500000;
                    numeroPorExtenso.Append(" quinhentos");

                }
                else if (num < 700000)
                {
                    num -= 600000;
                    numeroPorExtenso.Append(" seiscentos");

                }
                else if (num < 800000)
                {
                    num -= 700000;
                    numeroPorExtenso.Append(" setecentos");

                }
                else if (num < 900000)
                {
                    num -= 800000;
                    numeroPorExtenso.Append(" oitocentos");

                }
                else if (num < 1000000)
                {
                    num -= 900000;
                    numeroPorExtenso.Append(" novecentos");

                }
                Milhar1();
            }

            void Milhao()
            {
                if (num < 1000000)
                {
                    Milhar2();
                }
                else if (num < 2000000)
                {
                    num -= 1000000;

                    numeroPorExtenso.Append(" um");

                }
                else if (num < 3000000)
                {
                    numeroPorExtenso.Append(" dois");
                    num -= 2000000;

                }
                else if (num < 4000000)
                {
                    numeroPorExtenso.Append(" três");
                    num -= 3000000;

                }
                else if (num < 5000000)
                {
                    numeroPorExtenso.Append(" quatro");
                    num -= 4000000;

                }
                else if (num < 6000000)
                {
                    numeroPorExtenso.Append(" cinco");
                    num -= 5000000;

                }
                else if (num < 7000000)
                {
                    numeroPorExtenso.Append(" seis");
                    num -= 6000000;

                }
                else if (num < 8000000)
                {
                    numeroPorExtenso.Append(" sete");
                    num -= 7000000000;

                }
                else if (num < 9000000)
                {
                    numeroPorExtenso.Append(" oito");
                    num -= 8000000;

                }
                else if (num < 10000000)
                {
                    numeroPorExtenso.Append(" nove");
                    num -= 9000000;

                }
                Milhar2();

            }

            void Milhao1()
            {
                if (num < 10000000)
                {
                    Milhao();
                }
                else if (num < 20000000)
                {
                    if (num >= 19000000)
                    {
                        numeroPorExtenso.Append(" dezenove");
                        num -= 19000000;
                    }
                    else if (num >= 18000000)
                    {
                        numeroPorExtenso.Append(" dezoito");
                        num -= 18000000;


                    }
                    else if (num >= 17000000)
                    {
                        numeroPorExtenso.Append(" dezessete");
                        num -= 17000000;

                    }
                    else if (num >= 16000000)
                    {
                        numeroPorExtenso.Append(" dezesseis");
                        num -= 16000000;

                    }
                    else if (num >= 15000000)
                    {
                        numeroPorExtenso.Append(" quinze");
                        num -= 15000000;

                    }
                    else if (num >= 14000000)
                    {
                        numeroPorExtenso.Append(" quatorze");
                        num -= 14000000;

                    }
                    else if (num >= 13000000)
                    {
                        numeroPorExtenso.Append(" treze");
                        num -= 13000000;

                    }
                    else if (num >= 12000000)
                    {
                        numeroPorExtenso.Append(" doze");
                        num -= 12000000;

                    }
                    else if (num >= 11000000)
                    {
                        numeroPorExtenso.Append(" onze");
                        num -= 11000000;

                    }
                    else if (num >= 10000000)
                    {
                        numeroPorExtenso.Append(" dez");
                        num -= 10000000;

                    }

                }
                else if (num < 30000000)
                {
                    numeroPorExtenso.Append(" vinte");
                    num -= 20000000;
                }
                else if (num < 40000000)
                {
                    numeroPorExtenso.Append(" trinta");
                    num -= 30000000;
                }
                else if (num < 50000000)
                {
                    numeroPorExtenso.Append(" quarenta");
                    num -= 40000000;
                }
                else if (num < 60000000)
                {
                    numeroPorExtenso.Append(" cinquenta");
                    num -= 50000000;
                }
                else if (num < 70000000)
                {
                    numeroPorExtenso.Append(" sessenta");
                    num -= 60000000;
                }
                else if (num < 80000000)
                {
                    numeroPorExtenso.Append(" setenta");
                    num -= 70000000;
                }
                else if (num < 90000000)
                {
                    numeroPorExtenso.Append(" oitenta");
                    num -= 80000000;
                }
                else if (num < 100000000)
                {
                    numeroPorExtenso.Append(" noventa");
                    num -= 90000000;
                }
                Milhao();

            }

            void Milhao2()
            {
                if (num < 100000000)
                {
                    Milhao1();
                }
                else if (num < 200000000)
                {
                    numeroPorExtenso.Append(" cem");
                    num -= 100000000;
                }
                else if (num < 300000000)
                {
                    numeroPorExtenso.Append(" duzentos");
                    num -= 200000000;
                }
                else if (num < 400000000)
                {
                    numeroPorExtenso.Append(" trezentos");
                    num -= 300000000;
                }
                else if (num < 500000000)
                {
                    numeroPorExtenso.Append(" quatrocentos");
                    num -= 400000000;
                }
                else if (num < 600000000)
                {
                    numeroPorExtenso.Append(" quinhentos");
                    num -= 500000000;
                }
                else if (num < 700000000)
                {
                    numeroPorExtenso.Append(" seiscentos");
                    num -= 600000000;
                }
                else if (num < 800000000)
                {
                    numeroPorExtenso.Append(" setecentos");
                    num -= 700000000;
                }
                else if (num < 900000000)
                {
                    numeroPorExtenso.Append(" oitocentos");
                    num -= 800000000;
                }
                else if (num < 1000000000)
                {
                    numeroPorExtenso.Append(" novecentos");
                    num -= 900000000;
                }
                Milhao1();

            }

            void Bilhao()
            {
                if (num < 1000000000)
                {
                    Milhao2();
                }
                else if (num < 2000000000)
                {
                    numeroPorExtenso.Append(" um");
                    num -= 1000000000;

                }
                else if (num < 3000000000)
                {
                    numeroPorExtenso.Append(" dois");
                    num -= 2000000000;

                }
                else if (num < 4000000000)
                {
                    numeroPorExtenso.Append(" três");
                    num -= 3000000000;

                }
                else if (num < 5000000000)
                {
                    numeroPorExtenso.Append(" quatro");
                    num -= 4000000000;

                }
                else if (num < 6000000000)
                {
                    numeroPorExtenso.Append(" cinco");
                    num -= 5000000000;

                }
                else if (num < 7000000000)
                {
                    numeroPorExtenso.Append(" seis");
                    num -= 6000000000;

                }
                else if (num < 8000000000)
                {
                    numeroPorExtenso.Append(" sete");
                    num -= 7000000000;

                }
                else if (num < 9000000000)
                {
                    numeroPorExtenso.Append(" oito");
                    num -= 8000000000;

                }
                else if (num < 10000000000)
                {
                    numeroPorExtenso.Append(" nove");
                    num -= 9000000000;

                }
                Milhao2();

            }

            void Bilhao1()
            {
                if (num < 10000000000)
                {
                    Bilhao();
                }
                else if (num < 20000000000)
                {
                    if (num >= 19000000000)
                    {
                        numeroPorExtenso.Append(" dezenove");
                        num -= 19000000000;
                    }
                    else if (num >= 18000000000)
                    {
                        numeroPorExtenso.Append(" dezoito");
                        num -= 18000000000;


                    }
                    else if (num >= 17000000000)
                    {
                        numeroPorExtenso.Append(" dezessete");
                        num -= 17000000000;

                    }
                    else if (num >= 16000000000)
                    {
                        numeroPorExtenso.Append(" dezesseis");
                        num -= 16000000000;

                    }
                    else if (num >= 15000000000)
                    {
                        numeroPorExtenso.Append(" quinze");
                        num -= 15000000000;

                    }
                    else if (num >= 14000000000)
                    {
                        numeroPorExtenso.Append(" quatorze");
                        num -= 14000000000;

                    }
                    else if (num >= 13000000000)
                    {
                        numeroPorExtenso.Append(" treze");
                        num -= 13000000000;

                    }
                    else if (num >= 12000000000)
                    {
                        numeroPorExtenso.Append(" doze");
                        num -= 12000000000;

                    }
                    else if (num >= 11000000000)
                    {
                        numeroPorExtenso.Append(" onze");
                        num -= 11000000000;

                    }
                    else if (num >= 10000000000)
                    {
                        numeroPorExtenso.Append(" dez");
                        num -= 10000000000;

                    }

                }
                else if (num < 30000000000)
                {
                    numeroPorExtenso.Append(" vinte");
                    num -= 20000000000;
                }
                else if (num < 40000000000)
                {
                    numeroPorExtenso.Append(" trinta");
                    num -= 30000000000;
                }
                else if (num < 50000000000)
                {
                    numeroPorExtenso.Append(" quarenta");
                    num -= 40000000000;
                }
                else if (num < 60000000000)
                {
                    numeroPorExtenso.Append(" cinquenta");
                    num -= 50000000000;
                }
                else if (num < 70000000000)
                {
                    numeroPorExtenso.Append(" sessenta");
                    num -= 60000000000;
                }
                else if (num < 80000000000)
                {
                    numeroPorExtenso.Append(" setenta");
                    num -= 70000000000;
                }
                else if (num < 90000000000)
                {
                    numeroPorExtenso.Append(" oitenta");
                    num -= 80000000000;
                }
                else if (num < 100000000000)
                {
                    numeroPorExtenso.Append(" noventa");
                    num -= 90000000000;
                }
                Bilhao();

            }

            void Bilhao2()
            {
                if (num < 100000000000)
                {
                    Bilhao1();
                }
                else if (num < 200000000000)
                {
                    numeroPorExtenso.Append(" cem");
                    num -= 100000000000;
                }
                else if (num < 300000000000)
                {
                    numeroPorExtenso.Append(" duzentos");
                    num -= 200000000000;
                }
                else if (num < 400000000000)
                {
                    numeroPorExtenso.Append(" trezentos");
                    num -= 300000000000;
                }
                else if (num < 500000000000)
                {
                    numeroPorExtenso.Append(" quatrocentos");
                    num -= 400000000000;
                }
                else if (num < 600000000000)
                {
                    numeroPorExtenso.Append(" quinhentos");
                    num -= 500000000000;
                }
                else if (num < 700000000000)
                {
                    numeroPorExtenso.Append(" seiscentos");
                    num -= 600000000000;
                }
                else if (num < 800000000000)
                {
                    numeroPorExtenso.Append(" setecentos");
                    num -= 700000000000;
                }
                else if (num < 900000000000)
                {
                    numeroPorExtenso.Append(" oitocentos");
                    num -= 800000000000;
                }
                else if (num <= 999999999999.99m)
                {
                    numeroPorExtenso.Append(" novecentos");
                    num -= 900000000000;
                }

                
                Bilhao1();

            }

            if (num > 0)
            {
                Bilhao2();
            }
            else
            {
                numeroPorExtenso.Append("zero");
            }
            return numeroPorExtenso;
        }
    }
}
