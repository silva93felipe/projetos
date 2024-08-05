namespace ApiProjetos.Models;

public class Projeto{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    private Projeto(){}
    public Projeto(string nome)
    {
        Nome = nome;
    }
    public bool IsValid(){
        if(string.IsNullOrEmpty(Nome) || string.IsNullOrWhiteSpace(Nome)){
            return false;
        }
        return true;
    }
}