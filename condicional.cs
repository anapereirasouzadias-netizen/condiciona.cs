using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		//Declaração de variáveis
		String nome;
		String sobrenome;
		int idade;
		
		//Coleta das variáveis
	Console.WriteLine("insira o nome");
	 nome= Console.ReadLine();
	 Console.WriteLine("insira o sobrenome");
	 sobrenome= Console.ReadLine();
	 idade = Convert.ToInt16(Console. ReadLine());
							
							
												 
	 //Exibição e tratamento de dados
							
							Console.WriteLine("OLá" + " " + sobrenome);
							Console.WriteLine(" SUA IDADE È; " + idade);
							
							
							//Coleta das variàveis
							Console.WriteLine("INSIRA O NOME");
							nome= Console.ReadLine();
							Console .WriteLine("INSIRA O SOBRENOME");
							sobrenome = Console.ReadLine();
							idade = Convert.ToInt16(Console.ReadLine() );
												  
							  //Exibição e tratamento de dados
							 Console.WriteLine("OLÀ" + nome + sobrenome);
							 Console.WriteLine("SUA IDADE È: " + idade);
							 if (idade >= 18){
							Console.WriteLine("VOÊ È MAIOR DE IDADE");
							 }
																							 															
							 else {
							 Console.WriteLine("VOCÊ È MENOR DE IDADE");
							 }
}
}
							 
																									 
																				