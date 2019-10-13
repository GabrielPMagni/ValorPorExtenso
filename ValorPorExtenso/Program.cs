using System;
using System.Text;
using System.Linq;

namespace ValorPorExtenso
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número entre 0 e 999:"); //Imprime na tela o que deve ser feito
            decimal num = LerNum(); //variavel num recebe retorno da função LerNum
            /*
             * Feito em uma nova função e não no Main para poder ser chamada em 
             * caso de erro sem precisar retornar ao Main
             */
            StringBuilder sResultado = paraExtenso(num);
            Console.WriteLine(sResultado);
            trabalharString(sResultado, num);
        }
        
        private static void trabalharString(StringBuilder bruto, decimal num)
        {
            string sNum = num.ToString().Reverse().ToString();

        }

        private static decimal LerNum()
        {
            try
            {
                string num1;
                decimal num;
                num1 = Console.ReadLine();
                num = decimal.Parse(num1);
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

        private static StringBuilder paraExtenso(decimal num)
        {
            StringBuilder sb = new StringBuilder();
            Int64 iNum = Decimal.ToInt64(num);
            string sNum = num.ToString();
            string siNum = iNum.ToString();
            string sResultado ="";

            void unidades_decimal()
            {
                if (num == 0.01m)
                {
                    sb.Append(" um");
                    num -= 0.01m;

                }
                else if (num == 0.02m)
                {
                    sb.Append(" dois");
                    num -= 0.02m;

                }
                else if (num == 0.03m)
                {
                    sb.Append(" três");
                    num -= 0.03m;

                }
                else if (num == 0.04m)
                {
                    sb.Append(" quatro");
                    num -= 0.04m;

                }
                else if (num == 0.05m)
                {
                    sb.Append(" cinco");
                    num -= 0.05m;

                }
                else if (num == 0.06m)
                {
                    sb.Append(" seis");
                    num -= 0.06m;

                }
                else if (num == 0.07m)
                {
                    sb.Append(" sete");
                    num -= 0.07m;

                }
                else if (num == 0.08m)
                {
                    sb.Append(" oito");
                    num -= 0.08m;

                }
                else if (num == 0.09m)
                {
                    sb.Append(" nove");
                    num -= 0.09m;

                }
            }

            void dezenas_decimal()
            {
                if (num < 0.10m)
                {
                    unidades_decimal();
                }
                else if (num < 0.20m)
                {
                    if (num == 0.10m)
                    {
                        sb.Append(" dez");
                        num -= 0.10m;

                    }
                    else if (num == 0.11m)
                    {
                        sb.Append(" onze");
                        num -= 0.11m;

                    }
                    else if (num == 0.12m)
                    {
                        sb.Append(" doze");
                        num -= 0.12m;

                    }
                    else if (num == 0.13m)
                    {
                        sb.Append(" treze");
                        num -= 0.13m;

                    }
                    else if (num == 0.14m)
                    {
                        sb.Append(" quatorze");
                        num -= 0.14m;

                    }
                    else if (num == 0.15m)
                    {
                        sb.Append(" quinze");
                        num -= 0.15m;

                    }
                    else if (num == 0.16m)
                    {
                        sb.Append(" dezesseis");
                        num -= 0.16m;

                    }
                    else if (num == 0.17m)
                    {
                        sb.Append(" dezessete");
                        num -= 0.17m;

                    }
                    else if (num == 0.18m)
                    {
                        sb.Append(" dezoito");
                        num -= 0.18m;

                    }
                    else if (num == 0.19m)
                    {
                        sb.Append(" dezenove");
                        num -= 0.19m;

                    }
                }
                else if (num < 0.30m)
                {

                    num -= 0.20m;
                    sb.Append(" vinte");


                }
                else if (num < 0.40m)
                {
                    num -= 0.30m;
                    sb.Append(" trinta");

                }
                else if (num < 0.50m)
                {
                    num -= 0.40m;

                    sb.Append(" quarenta");

                }
                else if (num < 0.60m)
                {
                    num -= 0.50m;

                    sb.Append(" cinquenta");

                }
                else if (num < 0.70m)
                {
                    num -= 0.60m;

                    sb.Append(" sessenta");

                }
                else if (num < 0.80m)
                {
                    num -= 0.70m;

                    sb.Append(" setenta");

                }
                else if (num < 0.90m)
                {
                    num -= 0.80m;

                    sb.Append(" oitenta");

                }
                else if (num < 1)
                {
                    num -= 0.90m;
                    sb.Append(" noventa");

                }
                unidades_decimal();
            }

            void unidades()
            {
                if (num >= 9)
                {
                    num -= 9;
                    sb.Append(" nove");

                }
                else if (num >= 8)
                {
                    num -= 8;
                    sb.Append(" oito");

                }
                else if (num >= 7)
                {
                    num -= 7;
                    sb.Append(" sete");

                }
                else if (num >= 6)
                {
                    num -= 6;
                    sb.Append(" seis");

                }
                else if (num >= 5)
                {
                    num -= 5;
                    sb.Append(" cinco");

                }
                else if (num >= 4)
                {
                    num -= 4;
                    sb.Append(" quatro");

                }
                else if (num >= 3)
                {
                    num -= 3;
                    sb.Append(" três");

                }
                else if (num >= 2)
                {
                    num -= 2;
                    sb.Append(" dois");

                }
                else if (num >= 1)
                {
                    num -= 1;
                    sb.Append(" um");

                }
                
                dezenas_decimal();
                
            }

            void dezenas()
            {
                if (num < 10)
                {
                    unidades();
                }
                else if (num < 20)
                {
                    if (num >= 19)
                    {
                        num -= 19;
                        sb.Append(" dezenove");

                    }
                    else if (num >= 18)
                    {
                        num -= 18;
                        sb.Append(" dezoito");

                    }
                    else if (num >= 17)
                    {
                        num -= 17;
                        sb.Append(" dezessete");

                    }
                    else if (num >= 16)
                    {
                        num -= 16;
                        sb.Append(" dezesseis");

                    }
                    else if (num >= 15)
                    {
                        num -= 15;
                        sb.Append(" quinze");

                    }
                    else if (num >= 14)
                    {
                        num -= 14;
                        sb.Append(" quatorze");

                    }
                    else if (num >= 13)
                    {
                        num -= 13;
                        sb.Append(" treze");

                    }
                    else if (num >= 12)
                    {
                        num -= 12;
                        sb.Append(" doze");

                    }
                    else if (num >= 11)
                    {
                        num -= 11;
                        sb.Append(" onze");

                    }
                    else if (num >= 10)
                    {
                        num -= 10;
                        sb.Append(" dez");


                    }
                }
                else if (num < 30)
                {
                    num -= 20;

                    sb.Append(" vinte");

                }
                else if (num < 40)
                {
                    num -= 30;

                    sb.Append(" trinta");

                }
                else if (num < 50)
                {
                    num -= 40;

                    sb.Append(" quarenta");

                }
                else if (num < 60)
                {
                    num -= 50;

                    sb.Append(" cinquenta");

                }
                else if (num < 70)
                {
                    num -= 60;

                    sb.Append(" seis");

                }
                else if (num < 80)
                {
                    num -= 70;

                    sb.Append(" setenta");

                }
                else if (num < 90)
                {
                    num -= 80;

                    sb.Append(" oitenta");

                }
                else if (num < 100)
                {
                    num -= 90;
                    sb.Append(" noventa");

                }
                unidades();
            }

            void centenas()
            {

                if (num < 100)
                {
                    dezenas();

                }
                else if (num < 200)
                {
                    num -= 100;
                    if (num == 0)
                    {
                        sb.Append(" cem");
                    }
                    else if (num < 1)
                    {
                        sb.Append(" cem");
                        dezenas_decimal();
                    } else if (num >= 1)
                    {
                        sb.Append(" cento");
                        dezenas();
                    }

                }
                else if (num < 300)
                {
                    num -= 200;
                    sb.Append(" duzentos");


                }
                else if (num < 400)
                {
                    num -= 300;

                    sb.Append(" trezentos");

                }
                else if (num < 500)
                {
                    num -= 400;

                    sb.Append(" quatrocentos");

                }
                else if (num < 600)
                {
                    num -= 500;

                    sb.Append(" quinhentos");

                }
                else if (num < 700)
                {
                    num -= 600;

                    sb.Append(" seiscentos");

                }
                else if (num < 800)
                {
                    num -= 700;

                    sb.Append(" setecentos");

                }
                else if (num < 900)
                {
                    num -= 800;

                    sb.Append(" oitocentos");

                }
                else if (num < 1000)
                {
                    num -= 900;

                    sb.Append(" novecentos");

                }
                dezenas();
            }


            void milhar()
            {
                if (num < 1000)
                {
                    centenas();
                }
                else if (num < 2000)
                {
                    num -= 1000;
                    sb.Append(" um");

                }
                else if (num < 3000)
                {
                    num -= 2000;
                    sb.Append(" dois");

                }
                else if (num < 4000)
                {
                    num -= 3000;
                    sb.Append(" três");

                }
                else if (num < 5000)
                {
                    num -= 4000;
                    sb.Append(" quatro");

                }
                else if (num < 6000)
                {
                    num -= 5000;
                    sb.Append(" cinco");

                }
                else if (num < 7000)
                {
                    num -= 6000;
                    sb.Append(" seis");

                }
                else if (num < 8000)
                {
                    num -= 7000;
                    sb.Append(" sete");

                }
                else if (num < 9000)
                {
                    num -= 8000;
                    sb.Append(" oito");

                }
                else if (num < 10000)
                {
                    num -= 9000;
                    sb.Append(" nove");

                }
                centenas();
            }

            void milhar1()
            {
                if (num < 10000)
                {
                    milhar();
                }

                else if (num < 20000)
                {
                    if (num >= 19000)
                    {
                        num -= 19000;
                        sb.Append(" dezenove");

                    }
                    else if (num >= 18000)
                    {
                        num -= 18000;

                        sb.Append(" dezoito");

                    }
                    else if (num >= 17000)
                    {
                        num -= 17000;

                        sb.Append(" dezessete");

                    }
                    else if (num >= 16000)
                    {
                        num -= 16000;

                        sb.Append(" dezesseis");

                    }
                    else if (num >= 15000)
                    {
                        num -= 15000;

                        sb.Append(" quinze");

                    }
                    else if (num >= 14000)
                    {
                        num -= 14000;

                        sb.Append(" quatorze");

                    }
                    else if (num >= 13000)
                    {
                        num -= 13000;

                        sb.Append(" treze");

                    }
                    else if (num >= 12000)
                    {
                        num -= 12000;

                        sb.Append(" doze");

                    }
                    else if (num >= 11000)
                    {
                        num -= 11000;

                        sb.Append(" onze");

                    }
                    else if (num >= 10000)
                    {
                        num -= 10000;
                        sb.Append(" dez");

                    }
                }
                else if (num < 30000)
                {
                    num -= 20000;
                    sb.Append(" vinte");

                }
                else if (num < 40000)
                {
                    num -= 30000;
                    sb.Append(" trinta");

                }
                else if (num < 50000)
                {
                    num -= 40000;
                    sb.Append(" quarenta");

                }
                else if (num < 60000)
                {
                    num -= 50000;
                    sb.Append(" cinquenta");

                }
                else if (num < 70000)
                {
                    num -= 60000;
                    sb.Append(" sessenta");

                }
                else if (num < 80000)
                {
                    num -= 70000;
                    sb.Append(" setenta");

                }
                else if (num < 90000)
                {
                    num -= 80000;
                    sb.Append(" oitenta");

                }
                else if (num < 100000)
                {
                    num -= 90000;
                    sb.Append(" noventa");

                }
                milhar();
            }

            void milhar2()
            {
                if (num < 100000)
                {
                    milhar1();
                }
                else if (num < 200000)
                {
                    num -= 100000;
                    sb.Append(" cem");

                }
                else if (num < 300000)
                {
                    num -= 200000;
                    sb.Append(" duzentos");

                }
                else if (num < 400000)
                {
                    num -= 300000;
                    sb.Append(" trezentos");

                }
                else if (num < 500000)
                {
                    num -= 400000;
                    sb.Append(" quatrocentos");

                }
                else if (num < 600000)
                {
                    num -= 500000;
                    sb.Append(" quinhentos");

                }
                else if (num < 700000)
                {
                    num -= 600000;
                    sb.Append(" seiscentos");

                }
                else if (num < 800000)
                {
                    num -= 700000;
                    sb.Append(" setecentos");

                }
                else if (num < 900000)
                {
                    num -= 800000;
                    sb.Append(" oitocentos");

                }
                else if (num < 1000000)
                {
                    num -= 900000;
                    sb.Append(" novecentos");

                }
                milhar1();
            }

            void milhao()
            {
                if (num < 1000000)
                {
                    milhar2();
                }
                else if (num < 2000000)
                {
                    num -= 1000000;

                    sb.Append(" um");

                }
                else if (num < 3000000)
                {
                    sb.Append(" dois");
                    num -= 2000000;

                }
                else if (num < 4000000)
                {
                    sb.Append(" três");
                    num -= 3000000;

                }
                else if (num < 5000000)
                {
                    sb.Append(" quatro");
                    num -= 4000000;

                }
                else if (num < 6000000)
                {
                    sb.Append(" cinco");
                    num -= 5000000;

                }
                else if (num < 7000000)
                {
                    sb.Append(" seis");
                    num -= 6000000;

                }
                else if (num < 8000000)
                {
                    sb.Append(" sete");
                    num -= 7000000000;

                }
                else if (num < 9000000)
                {
                    sb.Append(" oito");
                    num -= 8000000;

                }
                else if (num < 10000000)
                {
                    sb.Append(" nove");
                    num -= 9000000;

                }
                milhar2();

            }

            void milhao1()
            {
                if (num < 10000000)
                {
                    milhao();
                }
                else if (num < 20000000)
                {
                    if (num >= 19000000)
                    {
                        sb.Append(" dezenove");
                        num -= 19000000;
                    }
                    else if (num >= 18000000)
                    {
                        sb.Append(" dezoito");
                        num -= 18000000;


                    }
                    else if (num >= 17000000)
                    {
                        sb.Append(" dezessete");
                        num -= 17000000;

                    }
                    else if (num >= 16000000)
                    {
                        sb.Append(" dezesseis");
                        num -= 16000000;

                    }
                    else if (num >= 15000000)
                    {
                        sb.Append(" quinze");
                        num -= 15000000;

                    }
                    else if (num >= 14000000)
                    {
                        sb.Append(" quatorze");
                        num -= 14000000;

                    }
                    else if (num >= 13000000)
                    {
                        sb.Append(" treze");
                        num -= 13000000;

                    }
                    else if (num >= 12000000)
                    {
                        sb.Append(" doze");
                        num -= 12000000;

                    }
                    else if (num >= 11000000)
                    {
                        sb.Append(" onze");
                        num -= 11000000;

                    }
                    else if (num >= 10000000)
                    {
                        sb.Append(" dez");
                        num -= 10000000;

                    }

                }
                else if (num < 30000000)
                {
                    sb.Append(" vinte");
                    num -= 20000000;
                }
                else if (num < 40000000)
                {
                    sb.Append(" trinta");
                    num -= 30000000;
                }
                else if (num < 50000000)
                {
                    sb.Append(" quarenta");
                    num -= 40000000;
                }
                else if (num < 60000000)
                {
                    sb.Append(" cinquenta");
                    num -= 50000000;
                }
                else if (num < 70000000)
                {
                    sb.Append(" sessenta");
                    num -= 60000000;
                }
                else if (num < 80000000)
                {
                    sb.Append(" setenta");
                    num -= 70000000;
                }
                else if (num < 90000000)
                {
                    sb.Append(" oitenta");
                    num -= 80000000;
                }
                else if (num < 100000000)
                {
                    sb.Append(" noventa");
                    num -= 90000000;
                }
                milhao();

            }

            void milhao2()
            {
                if (num < 100000000)
                {
                    milhao1();
                }
                else if (num < 200000000)
                {
                    sb.Append(" cem");
                    num -= 100000000;
                }
                else if (num < 300000000)
                {
                    sb.Append(" duzentos");
                    num -= 200000000;
                }
                else if (num < 400000000)
                {
                    sb.Append(" trezentos");
                    num -= 300000000;
                }
                else if (num < 500000000)
                {
                    sb.Append(" quatrocentos");
                    num -= 400000000;
                }
                else if (num < 600000000)
                {
                    sb.Append(" quinhentos");
                    num -= 500000000;
                }
                else if (num < 700000000)
                {
                    sb.Append(" seiscentos");
                    num -= 600000000;
                }
                else if (num < 800000000)
                {
                    sb.Append(" setecentos");
                    num -= 700000000;
                }
                else if (num < 900000000)
                {
                    sb.Append(" oitocentos");
                    num -= 800000000;
                }
                else if (num < 1000000000)
                {
                    sb.Append(" novecentos");
                    num -= 900000000;
                }
                milhao1();

            }

            void bilhao()
            {
                if (num < 1000000000)
                {
                    milhao2();
                }
                else if (num < 2000000000)
                {
                    sb.Append(" um");
                    num -= 1000000000;

                }
                else if (num < 3000000000)
                {
                    sb.Append(" dois");
                    num -= 2000000000;

                }
                else if (num < 4000000000)
                {
                    sb.Append(" três");
                    num -= 3000000000;

                }
                else if (num < 5000000000)
                {
                    sb.Append(" quatro");
                    num -= 4000000000;

                }
                else if (num < 6000000000)
                {
                    sb.Append(" cinco");
                    num -= 5000000000;

                }
                else if (num < 7000000000)
                {
                    sb.Append(" seis");
                    num -= 6000000000;

                }
                else if (num < 8000000000)
                {
                    sb.Append(" sete");
                    num -= 7000000000;

                }
                else if (num < 9000000000)
                {
                    sb.Append(" oito");
                    num -= 8000000000;

                }
                else if (num < 10000000000)
                {
                    sb.Append(" nove");
                    num -= 9000000000;

                }
                milhao2();

            }

            void bilhao1()
            {
                if (num < 10000000000)
                {
                    bilhao();
                }
                else if (num < 20000000000)
                {
                    if (num >= 19000000000)
                    {
                        sb.Append(" dezenove");
                        num -= 19000000000;
                    }
                    else if (num >= 18000000000)
                    {
                        sb.Append(" dezoito");
                        num -= 18000000000;


                    }
                    else if (num >= 17000000000)
                    {
                        sb.Append(" dezessete");
                        num -= 17000000000;

                    }
                    else if (num >= 16000000000)
                    {
                        sb.Append(" dezesseis");
                        num -= 16000000000;

                    }
                    else if (num >= 15000000000)
                    {
                        sb.Append(" quinze");
                        num -= 15000000000;

                    }
                    else if (num >= 14000000000)
                    {
                        sb.Append(" quatorze");
                        num -= 14000000000;

                    }
                    else if (num >= 13000000000)
                    {
                        sb.Append(" treze");
                        num -= 13000000000;

                    }
                    else if (num >= 12000000000)
                    {
                        sb.Append(" doze");
                        num -= 12000000000;

                    }
                    else if (num >= 11000000000)
                    {
                        sb.Append(" onze");
                        num -= 11000000000;

                    }
                    else if (num >= 10000000000)
                    {
                        sb.Append(" dez");
                        num -= 10000000000;

                    }

                }
                else if (num < 30000000000)
                {
                    sb.Append(" vinte");
                    num -= 20000000000;
                }
                else if (num < 40000000000)
                {
                    sb.Append(" trinta");
                    num -= 30000000000;
                }
                else if (num < 50000000000)
                {
                    sb.Append(" quarenta");
                    num -= 40000000000;
                }
                else if (num < 60000000000)
                {
                    sb.Append(" cinquenta");
                    num -= 50000000000;
                }
                else if (num < 70000000000)
                {
                    sb.Append(" sessenta");
                    num -= 60000000000;
                }
                else if (num < 80000000000)
                {
                    sb.Append(" setenta");
                    num -= 70000000000;
                }
                else if (num < 90000000000)
                {
                    sb.Append(" oitenta");
                    num -= 80000000000;
                }
                else if (num < 100000000000)
                {
                    sb.Append(" noventa");
                    num -= 90000000000;
                }
                bilhao();

            }

            void bilhao2()
            {
                if (num < 100000000000)
                {
                    bilhao1();
                }
                else if (num < 200000000000)
                {
                    sb.Append(" cem");
                    num -= 100000000000;
                }
                else if (num < 300000000000)
                {
                    sb.Append(" duzentos");
                    num -= 200000000000;
                }
                else if (num < 400000000000)
                {
                    sb.Append(" trezentos");
                    num -= 300000000000;
                }
                else if (num < 500000000000)
                {
                    sb.Append(" quatrocentos");
                    num -= 400000000000;
                }
                else if (num < 600000000000)
                {
                    sb.Append(" quinhentos");
                    num -= 500000000000;
                }
                else if (num < 700000000000)
                {
                    sb.Append(" seiscentos");
                    num -= 600000000000;
                }
                else if (num < 800000000000)
                {
                    sb.Append(" setecentos");
                    num -= 700000000000;
                }
                else if (num < 900000000000)
                {
                    sb.Append(" oitocentos");
                    num -= 800000000000;
                }
                else if (num <= 999999999999.99m)
                {
                    sb.Append(" novecentos");
                    num -= 900000000000;
                }

                
                bilhao1();

            }

            if (num > 0)
            {
                bilhao2();
            }
            else
            {
                sb.Append("zero");
            }
            //string[] a = sb.ToString().Split();
            // Console.WriteLine("A: "+a);
            return sb;
        }
    }
}
