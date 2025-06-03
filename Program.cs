using System;
using System.Threading;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Metadata;

class Program {
    static void Main() {
        //Program.count(0, 11);     //     loops      //
        //Program.yesToEvery();     //      com       //
        //Program.regressiveCount();//     while      //

        //Program.countWithFor(11);//   loops com for   //

        //Program.listOfFruits();//      loops com     //
        //Program.countNumbers();//      foreach       //

        ////////LISTAS////////
        
        //Program.listFruits();       //                    //
        //Program.listOfStudents();   //       Listas       //
        //Program.chekNumbersInList();//                    //

        //Program.dictionaryOfAge();//       Dicionário       //
    }
    public static void count(int x, int y) {
        int contador = x;
        while (contador < y) {
            Console.WriteLine($"{contador}");
            contador++;
        }
    }
    public static void yesToEvery() {
        string resposta = "";
        while (resposta != "sair") {
            Console.Write("Pergunte algo ou digite (sair): ");
            resposta = Console.ReadLine()!;
            Console.WriteLine("Sim");
        }
    }
    public static void regressiveCount() {
        Console.Write("Escreva um numero para contagem regressiva: ");
        int x = int.Parse(Console.ReadLine()!);
        while (x > 0) {
            Console.WriteLine($"{x}");
            Thread.Sleep(1000);
            x--;

            if (x == 0) {
                Console.Write("ACABOU!!");
            } else {
                continue;
            }
        }
    }
    public static void countWithFor(int x) {
        for (int i = 0; i < x; i++) {
            Console.WriteLine($"{i}");
        }
    }
    public static void listOfFruits() {
        string[] frutas = {"maça", "banana", "laranja"};

        foreach (string fruta in frutas) {
            Console.WriteLine($"frutas: {fruta}");
        }
    }
    public static void countNumbers() {
        int[] numeros = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        foreach (int numero in numeros) {
            Console.WriteLine($"✓ {numero}");
        }
    }

    //                      //
    //        LISTAS        //
    //                      //

    public static void listFruits() {
        List<string> frutas = new List<string>();
        frutas.Add("banana");
        frutas.Add("maça");
        frutas.Add("carambola");

        Console.WriteLine(frutas[0]);

        while (true){

            Thread.Sleep(2000);

            Console.Write("quer ver a lista de frutas? ");

            string resposta = Console.ReadLine()!;

            if (resposta == "sim"){
                foreach (string fruta in frutas) {
                    Console.WriteLine($"fruta: {fruta}");
                }
            } else {
                Console.WriteLine("Ok");
                break;
            }
        }
    }
    public static void listOfStudents() {
        List<string> alunos = new List<string>();

        while (true) {
            Console.Write("");
            Console.Write("Quer adicionar alguem na lista de alunos, ver a lista, remover ou parar?(view/add/remove/stop) ");
            string resposta = Console.ReadLine()!;
            Console.Write("");

            if (resposta == "add") {
                Console.Write("Quem voçe quer adicionar?: ");
                string x = Console.ReadLine()!;

                alunos.Add(x);

            } else if (resposta == "view") {
                foreach (string aluno in alunos) {
                    Console.WriteLine(aluno);
                }
            } else if (resposta == "remove") {
                foreach (string aluno_rm in alunos) {
                    Console.WriteLine(aluno_rm);
                }

                Console.WriteLine("");
                Console.Write("Quem voçe quer remover?: ");
                string respo = Console.ReadLine()!;

                alunos.Remove(respo);

            } else if (resposta == "stop") {
                break;
            } else {
                Console.WriteLine("Resposta invalida... Tente novamente com as respostas disponiveis");
            }
        }
    }
    public static void chekNumbersInList() {
        while (true){
            List<int> numeros = new List<int> {10, 20, 30, 40 , 50};

            Console.Write("Digite o numero que voce quer conferir se tem na lista: ");
            int numero = int.Parse(Console.ReadLine()!);

            bool confere = numeros.Contains(numero);
            Console.WriteLine(confere);

            if (confere == false) {
                continue;
            } else {
                break;
            }
        }
    }
    public static void dictionaryOfAge() {
        Dictionary<string, int> idades = new Dictionary<string, int>();

        while (true) {
            idades["Gabriel"] = 20;
            idades["Mariane"] = 30;
            idades["Jonas"] = 40;

            Console.Write("Confira se algum nome esta no dicionário de idades: ");
            string conferir = Console.ReadLine()!;

            if (idades.ContainsKey(conferir)) {
                Console.Write($"{conferir} está no dicionário e tem ");
                Console.WriteLine(idades[conferir]  + " anos");
                Thread.Sleep(2000);
                Console.Write("Quer remover algum dos nomes?(sim/nao) ");
                string respos = Console.ReadLine()!;
                Console.WriteLine("");

                if (respos == "sim") {
                    foreach (var name in idades) {
                        Console.WriteLine(name.Key + " tem " + name.Value + " anos");
                    }

                    Console.WriteLine("");
                    Console.Write("Qual? ");
                    string nome = Console.ReadLine()!;
                    Console.WriteLine("");

                    idades.Remove(nome);

                    foreach (var name in idades) {
                        Console.WriteLine(name.Key + " tem " + name.Value + " anos");
                    }
                    break;
                }

            } else {
                Console.WriteLine($"{conferir} não está no dicionário");
                continue;
            }
        }
    }
}