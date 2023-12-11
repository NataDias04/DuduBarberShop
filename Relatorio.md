## Relatório de Evolução do Projeto

Dia 4 de outubro:

Foi realizado a escolha do projeto realizado a escolha dos requisitos do sistema realizado o desenvolvimento das classes métodos construtores das classes pessoa e sistema.
E métodos de acesso da classe pessoa

Dia 5 de outubro:

Foi realizado os métodos de acesso da classe sistema e métodos diversos da mesma classe

Dia 07 de outubro:

Foi iniciado a construção do menu inicial do sistema

Foi iniciado a construção do método relatório, inicialmente foi encontrado uma falha na implementação do método relatório, já que quando era chamado no menu não era realizado a apresentação do relatório 

o erro foi encontra-se:

CentralDeComando.cs

Linha 46

case "2":
  
  meu_sistema.ImprimeRelatorioDoCaixa();
  Console.WriteLine();
  Console.WriteLine("A AÇÃO FOI REALIZADA APERTE QUALQUER BOTÃO PARA CONTINUAR");
  
  --Console.ReadKey();-- 
  
  a falta do consolereadkey resultava em um erro já que após executar o método o programa ja partia para a ação posterior mostrando só um frame do relatório
  ja com o consolereadkey para que o programa fosse capaz de passar para a próxima ação tornou-se necessário que o usuário apertasse qualquer botão apresentando o relatório ate que essa ação fosse realizada pelo usuário 

Dia 10 do 10:

Realizado a implementação do método do relatório que guarda todo o historico de clientes para apresentação no relatório 
