﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//ATIVIDADE 1 - SALA

Console.WriteLine("ATIVIDADE1");

float valor1 = 1000;
float valor_dia1 = -3.4f;
float valor_dia2 = 2.8f;
float valor_dia3 = 14f;
float valor_dia4 = -8.5f;

float dia1 = valor1 * (1 + valor_dia1 / 100);
float dia2 = dia1 * (1 + valor_dia2 / 100);
float dia3 = dia2 * (1 + valor_dia3 / 100);
float dia4 = dia3 * (valor_dia4 / 100);
Console.WriteLine(" O valor atual dos investimentos de Marquesito é R$ {0} ", dia4);

//ATIVIDADE 2 - SALA

Console.WriteLine("ATIVIDADE 2");

int salario2, novo_salario, aumento;

Console.WriteLine("Qual é o seu salário atual? ");
salario2 = int.Parse(Console.ReadLine());

aumento = (25 / 100) * salario2;
novo_salario = salario2 + aumento;

Console.WriteLine("Novo salário: {0} ", novo_salario);


//ATIVIDADE 3 - SALA

Console.WriteLine("ATIVIDADE 3");

int n, ant_d, suce_t, soma;

Console.WriteLine("Escreva um número: ");
n = int.Parse(Console.ReadLine());

ant_d = (n * 2) - 1;
suce_t = (n * 3) + 1;
soma = ant_d + suce_t;

Console.WriteLine("Soma: {0} ", soma);


//EXERCÍCIO 1 - LISTA

float valor_metros, cm, mm;

Console.WriteLine("Insira um valor em metros: ");
valor_metros = int.Parse(Console.ReadLine());

cm = valor_metros * 100;
mm = valor_metros * 1000;

Console.WriteLine("Essa medida em cm é \n CM - {0} \n MM - {1}", cm, mm);

// EXERCÍCIO 2 - LISTA

float graus_f, graus_c;
int f, c;

Console.WriteLine("Insira o valor em graus fahrenheit: ");
graus_f = float.Parse(Console.ReadLine());
f = int.Parse(Console.ReadLine());

graus_c = (graus_f - 32.0f) * (5.0f / 9.0f);
c = (f - 32) * (5 / 9);

Console.WriteLine("graus celcius com float - {0} \n graus celcius com int - {1}", graus_c, c);
//O resultado dá 0 pois, a divisão 5/9 é inteira o que daria a dizima 0,5. como a variavel int não aceita números com virgulas seria igual a 0 e  quando se multiplica por 0 o resultado é 0.

//EXERCÍCIO 3 - LISTA

float peso, altura, imc;

Console.WriteLine("Insira a sua altura em metros: ");
altura = float.Parse(Console.ReadLine());
Console.WriteLine("Insira o seu peso em kilos: ");
peso = float.Parse(Console.ReadLine());

imc = peso / (altura * altura);

Console.WriteLine("Seu IMC é:{0} ", imc);

//EXERCÍCIO 4 - LISTA

float p1, p2, p3, media;

Console.WriteLine("Vamos calcular a média dos pesos");
Console.WriteLine("Insira o valor de p1: ");
p1 = float.Parse(Console.ReadLine());
Console.WriteLine("Insira o valor de p2: ");
p2 = float.Parse(Console.ReadLine());
Console.WriteLine("Insira o valor de p3: ");
p3 = float.Parse(Console.ReadLine());

media = (p1 + p2 + p3) / 3;

Console.WriteLine("A média dos pesos é: {0} ", media);


//EXERCÍCIO 5 - LISTA

float fel, k, x;

Console.WriteLine("Vamos calcular a força elástica de uma mola?");
Console.WriteLine("Digite a constante elástica da mola: ");
k = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor da deformação da mola: ");
x = float.Parse(Console.ReadLine());

fel = k * x;

Console.WriteLine("O valor da força elástica da sua mola é de {0} N.", fel);

//EXERCÍCIO 6 - LISTA

Console.WriteLine("ATIVIDADE 2");
int salario3, novo_salario1, aumento1;

Console.WriteLine("Qual é o seu salário atual? ");
salario3 = int.Parse(Console.ReadLine());

aumento1 = (25 / 100) * salario3;
novo_salario1 = salario3 + aumento1;

Console.WriteLine("Novo salário: {0} ", novo_salario1);

//EXERCÍCIO 7 - LISTA

float real, dolar, cotacao;

Console.WriteLine("Digite um valor em reais: ");
real = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a cotação do dólar: ");
cotacao = float.Parse(Console.ReadLine());

dolar = real / cotacao;

Console.WriteLine("Esse valor em reais, equivale a {0} dólares.", dolar);
*/
//EXERCÍCIO 8 - LISTA

Console.WriteLine("ATIVIDADE 3");

int n5, ant_d5, suce_t5, soma5;

Console.WriteLine("Escreva um número: ");
n5 = int.Parse(Console.ReadLine());

ant_d5 = (n5 * 2) - 1;
suce_t5 = (n5 * 3) + 1;
soma5 = ant_d5 + suce_t5;

Console.WriteLine("Soma: {0} ", soma5);

//EXERCÍCIO 9 - LISTA

int valor, milhar, milhar1, centena, centena1, dezena, dezena1, unidade, valor1, valor2;

Console.WriteLine("Escreva um número: ");
valor = int.Parse(Console.ReadLine());
milhar = valor / 1000;
milhar1 = milhar * 1000;
centena = (valor - milhar) / 100;
centena1 = centena * 100;
valor1 = milhar1 + centena1;
dezena = (valor - valor1) / 10;
dezena1 = dezena * 10;
valor2 = milhar1 + centena1 + dezena1;
unidade = valor - valor2;

Console.WriteLine("{0{\n{1}\n{2}\n{3}", milhar, centena, dezena, unidade);


//EXERCÍCIO 10 - LISTA

Console.WriteLine("ATIVIDADE1");

float valor01 = 1000;
float valor_dia01 = -3.4f;
float valor_dia02 = 2.8f;
float valor_dia03 = 14f;
float valor_dia04 = -8.5f;

float dia01 = valor01 * (1 + valor_dia01 / 100);
float dia02 = dia01 * (1 + valor_dia02 / 100);
float dia03 = dia02 * (1 + valor_dia03 / 100);
float dia04 = dia03 * (valor_dia04 / 100);

Console.WriteLine(" O valor atual dos investimentos de Marquesito é R$ {0}", dia04);

//EXERCÍCIO 11 - LISTA

int n, n2, n3;

Console.WriteLine("Digite um número inteiro:");
n = int.Parse(Console.ReadLine());

n2 = n * n;
n3 = n * n * n;

Console.WriteLine("Esse número ao quadrado é igual a {0} e esse número ao cubo é igual a {1}", n2, n3);

//EXERCÍCIO 12 - LISTA

float h, p_h, p_m;

Console.WriteLine("Digite o valor da sua altura: ");
h = float.Parse(Console.ReadLine());

p_h = (72.7f * h) - 58f;
p_m = (62.1f * h) - 44.7f;

Console.WriteLine(" Seu peso ideal é \nPeso ideal para homens com essa altura: {0} \nPeso ideal para mulheres com essa altura: {1}", p_h, p_m);
