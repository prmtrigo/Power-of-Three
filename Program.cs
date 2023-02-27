namespace Power_of_Three;
class Program
{
    static bool IsPowerOfThree(int numero){

        //entender o que vai retornar verdadeiro
        while(numero > 1){

            if(numero % 3 == 0){
                return true;
            }
            numero /= 3;
        }

        return false;
    }

    static void Main(string[] args)
    {

        //adicionando o número
        Console.WriteLine("Coloque um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        //levando o número para a função
        bool resultado = IsPowerOfThree(numero);

        if(resultado){
            Console.Write("O resultado é verdadeiro! É uma Potência de 3");
        }
        else{
            Console.Write("O resultado é falso! Não é uma Potência de 3");
        }
    }
}
