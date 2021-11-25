package crud;
public class Crud {

    public static void main(String[] args) {
        Cliente c = new Cliente("Jorge", "99349909");
        ClientePessoa cp = new ClientePessoa("Jorge", "99349909", "000000000","000000000");
        ClienteEmpresa ce = new ClienteEmpresa("Pastelaria do Zé", "70707070", "000000000","000000000");
        
        c.ler();
        c.editar();
        c.salvar();
        c.excluir();
    }
    
}
