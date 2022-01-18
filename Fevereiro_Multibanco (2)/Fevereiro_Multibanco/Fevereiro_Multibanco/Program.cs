using System;

namespace Fevereiro_Multibanco
{
    class Program
    {

        static double pagamento = 0.01, deposito = 0.02, levantamento = 0.05, quantia;
        static string user1 = "fevereiro", pass1 = "teste123", duser, dpass;
        static int transictions;

        static void Main(string[] args)
        {
            
            Console.WriteLine("Bem-vindo ao fevereiro bank");
            System.Threading.Thread.Sleep(3000); //tempo de espera de 1.0s
            Console.Clear();
            Console.WriteLine("Insere o nome de utilizador");
            duser = Console.ReadLine();
            System.Threading.Thread.Sleep(1000); //tempo de espera de 1.0s
            Console.Clear();
            Console.WriteLine("Insere a tua password");
            dpass = Console.ReadLine();
            System.Threading.Thread.Sleep(1000); //tempo de espera de 1.0s
            Console.Clear();

            if (user1 == duser && pass1 == dpass)
            {
                System.Threading.Thread.Sleep(2000); //tempo de espera de 2.0s
                Console.Clear();

                double saldo = 150;
                int a = 1;


                while (a != 4)
                {
                    Console.WriteLine("Escolha o movimento que desja realizar \n 1 - Pagamento \n 2 - Depósito \n 3 - Levantamento \n 4 - Sair  \n Dinheiro " + Math.Round(saldo, 2));
                    a = int.Parse(Console.ReadLine());/* opcão*/
                    if (a == 1)
                    {
                        
                        Console.Clear(); //apagar no que esta na consola
                        Console.WriteLine("A carregar...");
                        System.Threading.Thread.Sleep(1000); //tempo de espera de 1.0s
                        Console.Clear();
                        Fpagamento(ref saldo, ref transictions);
                    }
                    else if (a == 2)
                    {
                        Console.Clear(); //apagar no que esta na consola
                        Console.WriteLine("A carregar...");
                        System.Threading.Thread.Sleep(1000); //tempo de espera de 1.0s
                        Console.Clear();
                        Fdeposito(ref saldo);

                    }
                    else if (a == 3)
                    {
                        Console.Clear(); //apagar no que esta na consola
                        Console.WriteLine("A carregar...");
                        System.Threading.Thread.Sleep(1000); //tempo de espera de 1.0s
                        Console.Clear();
                        Flevantamento(ref saldo);

                    }
                    else if (a == 4)
                    {
                        Console.Clear(); //apagar no que esta na consola
                        Console.WriteLine("A sessão sera encerrada");
                        System.Threading.Thread.Sleep(1000); //tempo de espera de 1.0s
                        Console.Clear();
                        Environment.Exit(0); //sair dirretamente da consola
                    }

                    else
                    {
                        Console.Clear(); //apagar no que esta na consola
                        Console.WriteLine("Valor indefenido");
                        System.Threading.Thread.Sleep(1000); //tempo de espera de 1.0s
                        Console.Clear();
                    }
                }

            }
            else if (user1 == duser || pass1 == dpass) ;
            {
                Console.WriteLine("Usuario não defenido. Tente outra vez mais tarde!");
                Environment.Exit(0); //sair dirretamente da consola
            }
        }


        public static void Fpagamento(ref double saldo, ref int transictions)
        {
            
            Console.WriteLine("Insira a entidade da transação");
            transictions = int.Parse(Console.ReadLine());
            if (transictions >= 100000 && transictions <= 999999)
            {
                Console.WriteLine("Insira o valor do pagamento");
                quantia = double.Parse(Console.ReadLine());
                if (quantia * pagamento + quantia > 0)
                {
                    if (quantia * pagamento + quantia <= saldo)
                    {
                        Console.WriteLine("O valor a pagar é de " + (quantia * pagamento + quantia) + " para a entidade " +transictions);
                        System.Threading.Thread.Sleep(4000); //tempo de espera de 4.0s
                        saldo -= (quantia * pagamento) + quantia;
                        quantia = 0;
                        Console.Clear();


                    }
                    else if (quantia * pagamento + quantia > saldo)
                    {
                        Console.WriteLine("Não ten dinheio suficiente para esta transação");
                        quantia = 0;
                        System.Threading.Thread.Sleep(3000); //tempo de espera de 1.0s
                        Console.Clear();
                    }

                    else if (quantia * pagamento + quantia <= 0)
                    {
                        Console.WriteLine("Não ten dinheio suficiente para esta transação");
                        System.Threading.Thread.Sleep(3000); //tempo de espera de 1.0s
                        quantia = 0;
                        Console.Clear();
                    }
                }
            }
            else if (transictions <= 100000 || transictions >= 999999)
            {
                Console.WriteLine("Valor incorreto a entidade da transação");
                System.Threading.Thread.Sleep(3000); //tempo de espera de 1.0s
                Console.Clear();
            }

        }
        public static void Fdeposito( ref double saldo)
        {

            Console.WriteLine("Insira o valor do deposito");
            quantia = double.Parse(Console.ReadLine());
             
            Console.WriteLine("Deposito feito com sucesso num valo de: " + (quantia - quantia * deposito )+  " euros");
            saldo += (quantia - quantia * deposito);
            quantia = 0;
            System.Threading.Thread.Sleep(4000); //tempo de espera de 1.0s
            Console.Clear();

        }
        public static  void Flevantamento(ref double saldo)
        {
            Console.WriteLine("Insira o valor do levantamento");
            quantia = double.Parse(Console.ReadLine());
            if (quantia * levantamento + quantia > 0)
            {
                if (quantia * levantamento + quantia <= saldo)
                {
                    Console.WriteLine("O valor a levantar é de " + (quantia * levantamento + quantia));
                    System.Threading.Thread.Sleep(4000); //tempo de espera de 4.0s
                    saldo -= (quantia * levantamento) + quantia;
                    quantia = 0;
                    Console.Clear();
                    


                }
                else if (quantia * levantamento + quantia >= saldo)
                {
                    Console.WriteLine("Não ten dinheio suficiente para esta transação");
                    System.Threading.Thread.Sleep(4000); //tempo de espera de 4.0s
                    quantia = 0;
                    Console.Clear();  
                }
            }

            else if (quantia * levantamento + quantia <= 0)
            {
                Console.WriteLine("Não ten dinheio suficiente para esta transação");
                System.Threading.Thread.Sleep(4000); //tempo de espera de 4.0s
                quantia = 0;
                Console.Clear();
            }

        }
    }
}
