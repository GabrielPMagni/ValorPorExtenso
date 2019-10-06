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
            string sResultado = paraExtenso(num);
            Console.WriteLine(sResultado);
            trabalharString(sResultado, num);
        }
        
        private static void trabalharString(string bruto, decimal num)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sb1 = new StringBuilder();

            string[] valoresPlural = {"bilhões", "milhões", "mil" };
            string[] valoresSingular = { "bilhão", "milhão", "mil" };

            string[] reais = { "real", "reais", "centavo", "centavos" };
            Int64 iNum = Decimal.ToInt64(num);
            string sNum = num.ToString();
            string siNum = iNum.ToString();
            int contador = -1;
            bool porTres = false;
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            if (sNum.Contains(',') | sNum.Contains('.'))
            {
                if (siNum.Length % 3 == 0)
                {
                    contador = 0;
                    porTres = true;
                } else if ((sNum.Length) == 11 | (sNum.Length) == 8 | (sNum.Length) == 5) 
                {
                    contador = 1;
                } else
                {
                    contador = -1;
                }
            } else {

                if (((sNum.Length) % 3 == 0)) // se tiver separação a cada 3 espaços
                {
                    contador = 0;
                    porTres = true;
                } else if ((sNum.Length) == 11 | (sNum.Length) == 8 | (sNum.Length) == 5) // se tiver separação a cada 2 espaços
                {
                    contador = 1;
                } else
                {
                    contador = 2;
                }
            }
            foreach (string s in bruto.Trim().Split())
            {

                if (contador % 3 == 0 & contador > 0)
                {
                    sb.Append($"{','}{' '}{s}");
                }
                else if (contador % 1 == 0 & contador > 0)
                {
                    sb.Append(" e " + s);
                }
                else
                {
                    sb.Append(s);
                }
                
                contador++;
            }

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            string temp = sb.ToString().Trim();
            Console.WriteLine(temp);
            string[] temp2 = temp.Split().Reverse().ToArray();

            foreach (string s in temp2)
            {
                sb1.Append(" "+s+" ");
            }

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            Console.WriteLine(sb1.ToString());


            //------------------------------

            /*
            string[] splitBruto = bruto.Split();
            Int64 iNum = Decimal.ToInt64(num);
            string sNum = iNum.ToString();
            int tamanhoNum = sNum.Length;
            int contador = -1;
            for (int i = 0; i < splitBruto.Length; i++)
            {
                for (int j = 0; j < splitBruto.Length; j++)
                {
                    string[] valores = { "bilhão", "bilhões", "milhão", "milhões", "mil" };
                    string[] reais = { "real", "reais", "centavo", "centavos" };
                    if (contador % 3 == 0 & contador != 0 & contador < 4)
                    {

                        if (iNum >= 2000000000) // se par
                        {
                            sb.Append($"{valores[1]}{','}");
                        }
                        else                  // se impar
                        {
                            sb.Append($"{valores[0]}{','}");
                        }
                        contador++;
                        break;
                    }
                    else if (contador % 3 == 0 & contador != 0 & contador < 8)
                    {
                        if (iNum % 2000000 == 0)
                        {
                            sb.Append($"{valores[2]}{','}");
                        }
                        else
                        {
                            sb.Append($"{valores[3]}{','}");
                        }
                    }
                    else if (contador % 3 == 0 & contador != 0 & contador < 12)
                    {
                        sb.Append($"{valores[4]}{','}");

                    }
                    contador++;

                    break;
                }
                sb.Append(splitBruto[i]);
                if (i % 3 != 0)
                {
                    sb.Append("e");
                }
                Console.WriteLine();
                

            }
            */

            //------------------------------





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

        private static string paraExtenso(decimal num)
        {
            string sNum;
            sNum = num.ToString();
            string sResultado ="";

            void unidades_decimal()
            {
                if (num == 0.01m)
                {
                    sResultado +=" um";
                    num -= 0.01m;

                }
                else if (num == 0.02m)
                {
                    sResultado +=" dois";
                    num -= 0.02m;

                }
                else if (num == 0.03m)
                {
                    sResultado +=" três";
                    num -= 0.03m;

                }
                else if (num == 0.04m)
                {
                    sResultado +=" quatro";
                    num -= 0.04m;

                }
                else if (num == 0.05m)
                {
                    sResultado +=" cinco";
                    num -= 0.05m;

                }
                else if (num == 0.06m)
                {
                    sResultado +=" seis";
                    num -= 0.06m;

                }
                else if (num == 0.07m)
                {
                    sResultado +=" sete";
                    num -= 0.07m;

                }
                else if (num == 0.08m)
                {
                    sResultado +=" oito";
                    num -= 0.08m;

                }
                else if (num == 0.09m)
                {
                    sResultado +=" nove";
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
                        sResultado +=" dez";
                        num -= 0.10m;

                    }
                    else if (num == 0.11m)
                    {
                        sResultado +=" onze";
                        num -= 0.11m;

                    }
                    else if (num == 0.12m)
                    {
                        sResultado +=" doze";
                        num -= 0.12m;

                    }
                    else if (num == 0.13m)
                    {
                        sResultado +=" treze";
                        num -= 0.13m;

                    }
                    else if (num == 0.14m)
                    {
                        sResultado +=" quatorze";
                        num -= 0.14m;

                    }
                    else if (num == 0.15m)
                    {
                        sResultado +=" quinze";
                        num -= 0.15m;

                    }
                    else if (num == 0.16m)
                    {
                        sResultado +=" dezesseis";
                        num -= 0.16m;

                    }
                    else if (num == 0.17m)
                    {
                        sResultado +=" dezessete";
                        num -= 0.17m;

                    }
                    else if (num == 0.18m)
                    {
                        sResultado +=" dezoito";
                        num -= 0.18m;

                    }
                    else if (num == 0.19m)
                    {
                        sResultado +=" dezenove";
                        num -= 0.19m;

                    }
                }
                else if (num < 0.30m)
                {

                    num -= 0.20m;
                    sResultado +=" vinte";


                }
                else if (num < 0.40m)
                {
                    num -= 0.30m;
                    sResultado +=" trinta";

                }
                else if (num < 0.50m)
                {
                    num -= 0.40m;

                    sResultado +=" quarenta";

                }
                else if (num < 0.60m)
                {
                    num -= 0.50m;

                    sResultado +=" cinquenta";

                }
                else if (num < 0.70m)
                {
                    num -= 0.60m;

                    sResultado +=" sessenta";

                }
                else if (num < 0.80m)
                {
                    num -= 0.70m;

                    sResultado +=" setenta";

                }
                else if (num < 0.90m)
                {
                    num -= 0.80m;

                    sResultado +=" oitenta";

                }
                else if (num < 1)
                {
                    num -= 0.90m;
                    sResultado +=" noventa";

                }
                unidades_decimal();
            }

            void unidades()
            {
                if (num >= 9)
                {
                    num -= 9;
                    sResultado +=" nove";

                }
                else if (num >= 8)
                {
                    num -= 8;
                    sResultado +=" oito";

                }
                else if (num >= 7)
                {
                    num -= 7;
                    sResultado +=" sete";

                }
                else if (num >= 6)
                {
                    num -= 6;
                    sResultado +=" seis";

                }
                else if (num >= 5)
                {
                    num -= 5;
                    sResultado +=" cinco";

                }
                else if (num >= 4)
                {
                    num -= 4;
                    sResultado +=" quatro";

                }
                else if (num >= 3)
                {
                    num -= 3;
                    sResultado +=" três";

                }
                else if (num >= 2)
                {
                    num -= 2;
                    sResultado +=" dois";

                }
                else if (num >= 1)
                {
                    num -= 1;
                    sResultado +=" um";

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
                        sResultado +=" dezenove";

                    }
                    else if (num >= 18)
                    {
                        num -= 18;
                        sResultado +=" dezoito";

                    }
                    else if (num >= 17)
                    {
                        num -= 17;
                        sResultado +=" dezessete";

                    }
                    else if (num >= 16)
                    {
                        num -= 16;
                        sResultado +=" dezesseis";

                    }
                    else if (num >= 15)
                    {
                        num -= 15;
                        sResultado +=" quinze";

                    }
                    else if (num >= 14)
                    {
                        num -= 14;
                        sResultado +=" quatorze";

                    }
                    else if (num >= 13)
                    {
                        num -= 13;
                        sResultado +=" treze";

                    }
                    else if (num >= 12)
                    {
                        num -= 12;
                        sResultado +=" doze";

                    }
                    else if (num >= 11)
                    {
                        num -= 11;
                        sResultado +=" onze";

                    }
                    else if (num >= 10)
                    {
                        num -= 10;
                        sResultado +=" dez";


                    }
                }
                else if (num < 30)
                {
                    num -= 20;

                    sResultado +=" vinte";

                }
                else if (num < 40)
                {
                    num -= 30;

                    sResultado +=" trinta";

                }
                else if (num < 50)
                {
                    num -= 40;

                    sResultado +=" quarenta";

                }
                else if (num < 60)
                {
                    num -= 50;

                    sResultado +=" cinquenta";

                }
                else if (num < 70)
                {
                    num -= 60;

                    sResultado +=" seis";

                }
                else if (num < 80)
                {
                    num -= 70;

                    sResultado +=" setenta";

                }
                else if (num < 90)
                {
                    num -= 80;

                    sResultado +=" oitenta";

                }
                else if (num < 100)
                {
                    num -= 90;
                    sResultado +=" noventa";

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
                        sResultado +=" cem";
                    }
                    else if (num < 1)
                    {
                        sResultado +=" cem";
                        dezenas_decimal();
                    } else if (num >= 1)
                    {
                        sResultado +=" cento";
                        dezenas();
                    }

                }
                else if (num < 300)
                {
                    num -= 200;
                    sResultado +=" duzentos";


                }
                else if (num < 400)
                {
                    num -= 300;

                    sResultado +=" trezentos";

                }
                else if (num < 500)
                {
                    num -= 400;

                    sResultado +=" quatrocentos";

                }
                else if (num < 600)
                {
                    num -= 500;

                    sResultado +=" quinhentos";

                }
                else if (num < 700)
                {
                    num -= 600;

                    sResultado +=" seiscentos";

                }
                else if (num < 800)
                {
                    num -= 700;

                    sResultado +=" setecentos";

                }
                else if (num < 900)
                {
                    num -= 800;

                    sResultado +=" oitocentos";

                }
                else if (num < 1000)
                {
                    num -= 900;

                    sResultado +=" novecentos";

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
                    sResultado +=" um";

                }
                else if (num < 3000)
                {
                    num -= 2000;
                    sResultado +=" dois";

                }
                else if (num < 4000)
                {
                    num -= 3000;
                    sResultado +=" três";

                }
                else if (num < 5000)
                {
                    num -= 4000;
                    sResultado +=" quatro";

                }
                else if (num < 6000)
                {
                    num -= 5000;
                    sResultado +=" cinco";

                }
                else if (num < 7000)
                {
                    num -= 6000;
                    sResultado +=" seis";

                }
                else if (num < 8000)
                {
                    num -= 7000;
                    sResultado +=" sete";

                }
                else if (num < 9000)
                {
                    num -= 8000;
                    sResultado +=" oito";

                }
                else if (num < 10000)
                {
                    num -= 9000;
                    sResultado +=" nove";

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
                        sResultado +=" dezenove";

                    }
                    else if (num >= 18000)
                    {
                        num -= 18000;

                        sResultado +=" dezoito";

                    }
                    else if (num >= 17000)
                    {
                        num -= 17000;

                        sResultado +=" dezessete";

                    }
                    else if (num >= 16000)
                    {
                        num -= 16000;

                        sResultado +=" dezesseis";

                    }
                    else if (num >= 15000)
                    {
                        num -= 15000;

                        sResultado +=" quinze";

                    }
                    else if (num >= 14000)
                    {
                        num -= 14000;

                        sResultado +=" quatorze";

                    }
                    else if (num >= 13000)
                    {
                        num -= 13000;

                        sResultado +=" treze";

                    }
                    else if (num >= 12000)
                    {
                        num -= 12000;

                        sResultado +=" doze";

                    }
                    else if (num >= 11000)
                    {
                        num -= 11000;

                        sResultado +=" onze";

                    }
                    else if (num >= 10000)
                    {
                        num -= 10000;
                        sResultado +=" dez";

                    }
                }
                else if (num < 30000)
                {
                    num -= 20000;
                    sResultado +=" vinte";

                }
                else if (num < 40000)
                {
                    num -= 30000;
                    sResultado +=" trinta";

                }
                else if (num < 50000)
                {
                    num -= 40000;
                    sResultado +=" quarenta";

                }
                else if (num < 60000)
                {
                    num -= 50000;
                    sResultado +=" cinquenta";

                }
                else if (num < 70000)
                {
                    num -= 60000;
                    sResultado +=" sessenta";

                }
                else if (num < 80000)
                {
                    num -= 70000;
                    sResultado +=" setenta";

                }
                else if (num < 90000)
                {
                    num -= 80000;
                    sResultado +=" oitenta";

                }
                else if (num < 100000)
                {
                    num -= 90000;
                    sResultado +=" noventa";

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
                    sResultado +=" cem";

                }
                else if (num < 300000)
                {
                    num -= 200000;
                    sResultado +=" duzentos";

                }
                else if (num < 400000)
                {
                    num -= 300000;
                    sResultado +=" trezentos";

                }
                else if (num < 500000)
                {
                    num -= 400000;
                    sResultado +=" quatrocentos";

                }
                else if (num < 600000)
                {
                    num -= 500000;
                    sResultado +=" quinhentos";

                }
                else if (num < 700000)
                {
                    num -= 600000;
                    sResultado +=" seiscentos";

                }
                else if (num < 800000)
                {
                    num -= 700000;
                    sResultado +=" setecentos";

                }
                else if (num < 900000)
                {
                    num -= 800000;
                    sResultado +=" oitocentos";

                }
                else if (num < 1000000)
                {
                    num -= 900000;
                    sResultado +=" novecentos";

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

                    sResultado +=" um";

                }
                else if (num < 3000000)
                {
                    sResultado +=" dois";
                    num -= 2000000;

                }
                else if (num < 4000000)
                {
                    sResultado +=" três";
                    num -= 3000000;

                }
                else if (num < 5000000)
                {
                    sResultado +=" quatro";
                    num -= 4000000;

                }
                else if (num < 6000000)
                {
                    sResultado +=" cinco";
                    num -= 5000000;

                }
                else if (num < 7000000)
                {
                    sResultado +=" seis";
                    num -= 6000000;

                }
                else if (num < 8000000)
                {
                    sResultado +=" sete";
                    num -= 7000000000;

                }
                else if (num < 9000000)
                {
                    sResultado +=" oito";
                    num -= 8000000;

                }
                else if (num < 10000000)
                {
                    sResultado +=" nove";
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
                        sResultado +=" dezenove";
                        num -= 19000000;
                    }
                    else if (num >= 18000000)
                    {
                        sResultado +=" dezoito";
                        num -= 18000000;


                    }
                    else if (num >= 17000000)
                    {
                        sResultado +=" dezessete";
                        num -= 17000000;

                    }
                    else if (num >= 16000000)
                    {
                        sResultado +=" dezesseis";
                        num -= 16000000;

                    }
                    else if (num >= 15000000)
                    {
                        sResultado +=" quinze";
                        num -= 15000000;

                    }
                    else if (num >= 14000000)
                    {
                        sResultado +=" quatorze";
                        num -= 14000000;

                    }
                    else if (num >= 13000000)
                    {
                        sResultado +=" treze";
                        num -= 13000000;

                    }
                    else if (num >= 12000000)
                    {
                        sResultado +=" doze";
                        num -= 12000000;

                    }
                    else if (num >= 11000000)
                    {
                        sResultado +=" onze";
                        num -= 11000000;

                    }
                    else if (num >= 10000000)
                    {
                        sResultado +=" dez";
                        num -= 10000000;

                    }

                }
                else if (num < 30000000)
                {
                    sResultado +=" vinte";
                    num -= 20000000;
                }
                else if (num < 40000000)
                {
                    sResultado +=" trinta";
                    num -= 30000000;
                }
                else if (num < 50000000)
                {
                    sResultado +=" quarenta";
                    num -= 40000000;
                }
                else if (num < 60000000)
                {
                    sResultado +=" cinquenta";
                    num -= 50000000;
                }
                else if (num < 70000000)
                {
                    sResultado +=" sessenta";
                    num -= 60000000;
                }
                else if (num < 80000000)
                {
                    sResultado +=" setenta";
                    num -= 70000000;
                }
                else if (num < 90000000)
                {
                    sResultado +=" oitenta";
                    num -= 80000000;
                }
                else if (num < 100000000)
                {
                    sResultado +=" noventa";
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
                    sResultado +=" cem";
                    num -= 100000000;
                }
                else if (num < 300000000)
                {
                    sResultado +=" duzentos";
                    num -= 200000000;
                }
                else if (num < 400000000)
                {
                    sResultado +=" trezentos";
                    num -= 300000000;
                }
                else if (num < 500000000)
                {
                    sResultado +=" quatrocentos";
                    num -= 400000000;
                }
                else if (num < 600000000)
                {
                    sResultado +=" quinhentos";
                    num -= 500000000;
                }
                else if (num < 700000000)
                {
                    sResultado +=" seiscentos";
                    num -= 600000000;
                }
                else if (num < 800000000)
                {
                    sResultado +=" setecentos";
                    num -= 700000000;
                }
                else if (num < 900000000)
                {
                    sResultado +=" oitocentos";
                    num -= 800000000;
                }
                else if (num < 1000000000)
                {
                    sResultado +=" novecentos";
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
                    sResultado +=" um";
                    num -= 1000000000;

                }
                else if (num < 3000000000)
                {
                    sResultado +=" dois";
                    num -= 2000000000;

                }
                else if (num < 4000000000)
                {
                    sResultado +=" três";
                    num -= 3000000000;

                }
                else if (num < 5000000000)
                {
                    sResultado +=" quatro";
                    num -= 4000000000;

                }
                else if (num < 6000000000)
                {
                    sResultado +=" cinco";
                    num -= 5000000000;

                }
                else if (num < 7000000000)
                {
                    sResultado +=" seis";
                    num -= 6000000000;

                }
                else if (num < 8000000000)
                {
                    sResultado +=" sete";
                    num -= 7000000000;

                }
                else if (num < 9000000000)
                {
                    sResultado +=" oito";
                    num -= 8000000000;

                }
                else if (num < 10000000000)
                {
                    sResultado +=" nove";
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
                        sResultado +=" dezenove";
                        num -= 19000000000;
                    }
                    else if (num >= 18000000000)
                    {
                        sResultado +=" dezoito";
                        num -= 18000000000;


                    }
                    else if (num >= 17000000000)
                    {
                        sResultado +=" dezessete";
                        num -= 17000000000;

                    }
                    else if (num >= 16000000000)
                    {
                        sResultado +=" dezesseis";
                        num -= 16000000000;

                    }
                    else if (num >= 15000000000)
                    {
                        sResultado +=" quinze";
                        num -= 15000000000;

                    }
                    else if (num >= 14000000000)
                    {
                        sResultado +=" quatorze";
                        num -= 14000000000;

                    }
                    else if (num >= 13000000000)
                    {
                        sResultado +=" treze";
                        num -= 13000000000;

                    }
                    else if (num >= 12000000000)
                    {
                        sResultado +=" doze";
                        num -= 12000000000;

                    }
                    else if (num >= 11000000000)
                    {
                        sResultado +=" onze";
                        num -= 11000000000;

                    }
                    else if (num >= 10000000000)
                    {
                        sResultado +=" dez";
                        num -= 10000000000;

                    }

                }
                else if (num < 30000000000)
                {
                    sResultado +=" vinte";
                    num -= 20000000000;
                }
                else if (num < 40000000000)
                {
                    sResultado +=" trinta";
                    num -= 30000000000;
                }
                else if (num < 50000000000)
                {
                    sResultado +=" quarenta";
                    num -= 40000000000;
                }
                else if (num < 60000000000)
                {
                    sResultado +=" cinquenta";
                    num -= 50000000000;
                }
                else if (num < 70000000000)
                {
                    sResultado +=" sessenta";
                    num -= 60000000000;
                }
                else if (num < 80000000000)
                {
                    sResultado +=" setenta";
                    num -= 70000000000;
                }
                else if (num < 90000000000)
                {
                    sResultado +=" oitenta";
                    num -= 80000000000;
                }
                else if (num < 100000000000)
                {
                    sResultado +=" noventa";
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
                    sResultado +=" cem";
                    num -= 100000000000;
                }
                else if (num < 300000000000)
                {
                    sResultado +=" duzentos";
                    num -= 200000000000;
                }
                else if (num < 400000000000)
                {
                    sResultado +=" trezentos";
                    num -= 300000000000;
                }
                else if (num < 500000000000)
                {
                    sResultado +=" quatrocentos";
                    num -= 400000000000;
                }
                else if (num < 600000000000)
                {
                    sResultado +=" quinhentos";
                    num -= 500000000000;
                }
                else if (num < 700000000000)
                {
                    sResultado +=" seiscentos";
                    num -= 600000000000;
                }
                else if (num < 800000000000)
                {
                    sResultado +=" setecentos";
                    num -= 700000000000;
                }
                else if (num < 900000000000)
                {
                    sResultado +=" oitocentos";
                    num -= 800000000000;
                }
                else if (num <= 999999999999.99m)
                {
                    sResultado +=" novecentos";
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
                sResultado ="zero";
            }
            return sResultado;
        }
    }
}
