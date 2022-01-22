namespace modelo_rico_encapsulamento
{
    public class Client
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Address { get; private set; }

        public Client(int id, string name, string address)
        {
            DomainExceptionValidation.When(id < 0, "O id não pode ser negativo");
            DomainExceptionValidation.When(string.IsNullOrEmpty(name),"É necessário preencher o nome");
            DomainExceptionValidation.When(string.IsNullOrEmpty(address),"Informe o indereço");

            Id = id;
            Name = name;
            Address = address;
        }
    }
}
