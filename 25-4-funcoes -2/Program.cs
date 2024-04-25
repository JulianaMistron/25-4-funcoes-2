int qtdlinhas = 3, qtdcolunas = 3;

float[,] matriz1 = new float[qtdlinhas, qtdcolunas];
float[,] matriz2 = new float[qtdlinhas, qtdcolunas];
float[,] matriz3 = new float[qtdlinhas, qtdcolunas];

void ImprimirMatriz(float[,] matriz, string titulo)
{
    Console.WriteLine(titulo);
    for (int linha = 0; linha < qtdlinhas; linha++)
    {
        Console.WriteLine();
        for (int coluna = 0; coluna < qtdcolunas; coluna++)
        {
            Console.Write(matriz[linha, coluna] + "  ");
        }
    }
}
void Switch(int escolha)
{
    switch (escolha)
    {
        case 1:
            SomarMatriz(matriz1, matriz2);
            break;
        case 2:
            SubtrairMatriz(matriz1, matriz2);
            break;
        case 3:
            MultiplicarMatriz(matriz1, matriz2);
            break;
        case 4:
            DividirMatriz(matriz1, matriz2);
            break;
        default:
            Console.WriteLine("Opção Inválida.");
            break;
    }
}
void Menu()
{
    Console.WriteLine("\nMENU PRINCIPAL");
    Console.WriteLine("1 - Adição");
    Console.WriteLine("2 - Subtração:");
    Console.WriteLine("3 - Multiplicação:");
    Console.WriteLine("4 - Divisão:");
    Console.WriteLine("Informe a opção desejada: ");
    int opcao = int.Parse(Console.ReadLine());

    Switch(opcao);


}
void SomarMatriz(float[,] m1, float[,] m2)
{
    float[,] matrizResultante = new float[qtdlinhas, qtdcolunas];

    for (int linha = 0; linha < qtdlinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdcolunas; coluna++)
        {
            matrizResultante[linha, coluna] = m1[linha, coluna] + m2[linha, coluna];
        }
    }
    ImprimirMatriz(matrizResultante, "Resultado da Matriz Somada...");
}
void SubtrairMatriz(float[,] m1, float[,] m2)
{
    float[,] matrizResultante = new float[qtdlinhas, qtdcolunas];

    for (int linha = 0; linha < qtdlinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdcolunas; coluna++)
        {
            matrizResultante[linha, coluna] = m1[linha, coluna] - m2[linha, coluna];
        }
    }
    ImprimirMatriz(matrizResultante, "Resultado da Matriz Subtraída...");
}
void MultiplicarMatriz(float[,] m1, float[,] m2)
{
    float[,] matrizResultante = new float[qtdlinhas, qtdcolunas];

    for (int linha = 0; linha < qtdlinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdcolunas; coluna++)
        {
            matrizResultante[linha, coluna] = m1[linha, coluna] * m2[linha, coluna];
        }
    }
    ImprimirMatriz(matrizResultante, "Resultado da Matriz Multiplicada...");
}
void DividirMatriz(float[,] m1, float[,] m2)
{
    float[,] matrizResultante = new float[qtdlinhas, qtdcolunas];

    for (int linha = 0; linha < qtdlinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdcolunas; coluna++)
        {
            if (matriz2[linha, coluna] != 0)
                matrizResultante[linha, coluna] = matriz1[linha, coluna] / matriz2[linha, coluna];
            else
                matrizResultante[linha, coluna] = float.NaN;
        }
    }
    ImprimirMatriz(matrizResultante, "Resultado da Matriz Dividida");
}
float[,] SortearMatriz()
{
    float[,] matrizPreenchida = new float[qtdlinhas, qtdcolunas];
    for (int linha = 0; linha < qtdlinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdcolunas; coluna++)
        {
            matrizPreenchida[linha, coluna] = new Random().Next(0, 10);
        }
    }
    return matrizPreenchida;
}

matriz1 = SortearMatriz();

ImprimirMatriz(matriz1, "Matriz 1");

matriz2 = SortearMatriz();

ImprimirMatriz(matriz2, "\nMatriz 2");

do
{
    Menu();
    Console.ReadKey();
    Console.Clear();
} while (true);