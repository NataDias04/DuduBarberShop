using System;


class CentralDeComando {

  Sistema meu_sistema;
  Pessoa  nova_pessoa;

  public CentralDeComando(){
    meu_sistema = new Sistema(15, 3);
  }

  public void MenuInicial(){
    string escolha = "";

    while(escolha != "0"){
      Console.Clear();
      Console.WriteLine("------------------------------------  X  ------------------------------------");
      Console.WriteLine("----------------------------  OPÇÔES DO SISTEMA  ----------------------------");
      Console.WriteLine("-----------------------------------------------------------------------------");
      Console.WriteLine();
      Console.WriteLine("DIGITE 0 PARA : SAIR");
      Console.WriteLine("DIGITE 1 PARA : ATENDER O CLIENTE");
      Console.WriteLine("DIGITE 2 PARA : APRESENTAR RELATORIO DO CAIXA");
      Console.WriteLine();
      Console.WriteLine("-----------------------------------------------------------------------------");
      Console.WriteLine();
      Console.WriteLine("INFORME A OPÇÂO DESEJADA:");
      escolha = Console.ReadLine();


      switch(escolha){
        case "0":
          return;
        case "1":
          Console.WriteLine("INFORME SEU NOME:");
          string nome = Console.ReadLine();
          Console.WriteLine("INFORME SUA IDADE:");
          int idade = int.Parse(Console.ReadLine());
          Console.WriteLine("INFORME SEU CPF:");
          string cpf = Console.ReadLine();
          nova_pessoa = new Pessoa(nome, idade, cpf);
          meu_sistema.AtenderCliente(nova_pessoa);
          Console.WriteLine("A AÇÃO FOI REALIZADA APERTE QUALQUER BOTÃO PARA CONTINUAR");
          Console.ReadKey();
          break;
        case "2":
          meu_sistema.ImprimeRelatorioDoCaixa();
          Console.WriteLine();
          Console.WriteLine("A AÇÃO FOI REALIZADA APERTE QUALQUER BOTÃO PARA CONTINUAR");
          Console.ReadKey();
          break;
      }
    }
  }
  
  public static void Main (string[] args) {
    CentralDeComando minha_CentralDeComando = new CentralDeComando();

    minha_CentralDeComando.MenuInicial();
  }
}