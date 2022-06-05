
namespace Ponteiros;

class Program
{
    static void Main(string[] args)
    {
        unsafe
        {
            int variavel = 5;

            int* ponteiro; //declarado o ponteiro

            //ponteiro recebe o endereço de 'variavel'
            ponteiro = &variavel;

            Console.WriteLine("O endereço " + (int)ponteiro + " possui o valor " + *ponteiro);

            variavel = 10;

            Console.WriteLine("O endereço " + (int)ponteiro + " possui o valor " + *ponteiro);

            Console.WriteLine("Digite um valor:");
            variavel = int.Parse(Console.ReadLine());

            Console.WriteLine("O endereço " + (int)ponteiro + " possui o valor "  + *ponteiro);
        }

    }
}