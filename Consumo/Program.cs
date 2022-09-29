namespace Consumo
{
    class Program
    {
        public static async Task Main(string[] args)
        {

            FuncionarioService funcionarioService = new ();
            IEnumerable<Funcionario>? funcionarios = await funcionarioService.Integracao();

            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.Nome.ToString().Length);
            }

            //Funcionario funcEncontrado = await funcionarioService.Integracao();

            //if (!funcEncontrado.Verificacao)
            //{
            //    Console.WriteLine("Nome: " + funcEncontrado.Nome);
            //    Console.WriteLine("cpf: " + funcEncontrado.CPF);
            //    Console.WriteLine("Funcao: " + funcEncontrado.FuncaoTitular);
            //}
            //else
            //{
            //    Console.WriteLine("Funcionario nao encontrado!");
            //}
        }
    }
}
