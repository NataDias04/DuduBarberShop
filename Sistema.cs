using System;

using System.Collections.Generic;

class Sistema {
  private float  valor_do_corte;
  private int          cadeiras;
  private float  valor_no_caixa;
  private int cont_atendimentos;
  private Pessoa[ ]    clientes;

  private List<Pessoa> historico;  

  
  public Sistema(float valor_do_corte, int cadeiras){
    this.valor_do_corte =       valor_do_corte;
    this.cadeiras       =             cadeiras;

    this.clientes       = new Pessoa[cadeiras];

    this.historico      =   new List<Pessoa>();  
  }

  public float GetValorDoCorte(){
    return valor_do_corte;
  }

  public void SetValorDoCorte(float NovoValorDoCorte){
    valor_do_corte = NovoValorDoCorte;  
  }

  public int GetCadeiras(){
    return cadeiras;
  }

  public void SetCadeiras(int NovoValorCadeiras){
    cadeiras = NovoValorCadeiras;    
  }

  public float GetValorNoCaixa(){
    return valor_no_caixa;
  }

  public void SetValorNoCaixa(float NovoValor){
    valor_no_caixa = NovoValor;
  }

  public int GetContAtendimentos(){
    return cont_atendimentos;
  }

  public bool AtenderCliente(Pessoa p){
    for(int i = 0; i < clientes.Length; i++){
      if(clientes[i] == null) {
        clientes[i] = p;
        PagamentoCorte();
        ContAtendimentos();
        AddPessoaNoHistorico(p);
        return true;
      }
    }
    return false;
  }

  public List<Pessoa> GetHistorico(){
    return historico;
    }  

  public Pessoa ClienteAtendido(string cpf){
    for(int i =0; i < clientes.Length; i++){
      if(clientes[i].GetCpf() == cpf){
        Pessoa cliente_temporario = clientes[i];
        clientes[i] = null;
        return               cliente_temporario; 
      }
    }
    return null;
  }

  public void PagamentoCorte(){
    valor_no_caixa = valor_no_caixa + valor_do_corte; 
  }

  public void ContAtendimentos(){
    cont_atendimentos = cont_atendimentos + 1;  
  }

  public void AddPessoaNoHistorico(Pessoa p){
      historico.Add(p);
  }  

  public void ImprimeRelatorioDoCaixa(){

      Console.WriteLine("------------------------------------  X  ------------------------------------");
      Console.WriteLine("--------------------------------  RELATORIO  --------------------------------");
      Console.WriteLine("-----------------------------------------------------------------------------");
      Console.WriteLine();
      Console.WriteLine("A QUANTIDADE DE ATENDIMENTOS FOI: {0}", cont_atendimentos);
      Console.WriteLine("O VALOR DO CORTE E: {0}", valor_do_corte);
      Console.WriteLine("O VALOR PRESENTE NO CAIXA E DE: {0}", valor_no_caixa);
      Console.WriteLine("-----------------------------------------------------------------------------");
      Console.WriteLine();
    
      for(int i = 0; i < clientes.Length; i++){
        Pessoa p = clientes[i];
        if(p != null){
          Console.Write("    [{0}]        ", p.GetNome());
        }
        else{
          Console.Write("    [CADEIRA LIVRE]        ");
                    
        }
      }
      Console.WriteLine();
      Console.WriteLine("--------------------------- HISTÓRICO DE CLIENTES ---------------------------");
      Console.WriteLine();
      for(int i = 0; i < historico.Count; i++){
        Pessoa p = historico[i];
        Console.WriteLine("CLIENTE NUMERO {0}: \nNOME: {1} \nIDADE: {2}", i +1 , p.GetNome(), p.GetIdade());
        if(p.MaiorDeIdade() == true){
          Console.WriteLine("ESTA PESSOA E: MAIOR DE IDADE");
        }
        else{
          Console.WriteLine("ESTA PESSOA E: MENOR DE IDADE");
        }
        Console.WriteLine();
      }
      Console.WriteLine("-----------------------------------------------------------------------------");
      //private Double media_de_idades = MediaDeIdades(historico); não consegui puxar este metodo da classe pessoa para a classe sistema
    
    this.valor_no_caixa =        GetValorNoCaixa();
    this.valor_do_corte =        GetValorDoCorte();
    this.cont_atendimentos = GetContAtendimentos(); 
  }   
}   

  
    