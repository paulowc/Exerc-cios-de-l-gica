static void Main(string[] args)
        {	
            while (true)
            {
                Console.Write("Digite um numero inteiro e positivo:");
                int numero = Convert.ToInt32(Console.ReadLine());
				
				//Condição para para o laço de repetição caso o número digitado seja ZERO.
                if (numero == 0)
                {
					//Instrução que faz com que saia do laço mais interno.
                    break;
                }

                Console.WriteLine(numero*numero);

            }
        }
