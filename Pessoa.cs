using System;
using System.Collections.Generic;

class Pessoa {
  private string           nome;
  private int             idade;
  private string            cpf;
  
  public Pessoa(string nome, int idade, string cpf){
    this.nome  =            nome;
    this.idade =           idade;
    this.cpf   =             cpf;
  }

  public string GetNome(){
    return nome;
  }

  public void SetNome(string NovoNome){
    nome = NovoNome;
  }

  public int GetIdade(){
    return idade;
  }

  public void SetIdade(int NovaIdade){
    if(NovaIdade >= 18){
      idade = NovaIdade;
    }
    else{
      Console.WriteLine("Para Que esta ação seja valida a idade deve ser maior que zero ");
    }
  }

  public string GetCpf(){
    return cpf;
  }

  public void SetCpf(string NovoCpf){
    if(NovoCpf.Length == 11){
      cpf = NovoCpf;
    }
    else{
      Console.WriteLine("O seguinte CPF: {0} e invalido", NovoCpf);
    }
  }

  public bool MaiorDeIdade(){
    
  if(idade >= 18){
      return  true;
    }
    else{
      return false; 
    }
  }

  public double MediaDeIdades(List<Pessoa> historico_temp){

    double soma_das_idades = 0;
    
    for(int i = 0; i < historico_temp.Count; i++){
      
      Pessoa p = historico_temp[i];
      int nova_idade = p.GetIdade();
      soma_das_idades = idade + soma_das_idades;
    }
    return soma_das_idades / historico_temp.Count ;
  }

             
}