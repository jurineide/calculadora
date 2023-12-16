using csharpp.Models;

int num=5;
for(int contador=0;contador<=10;contador ++){
    Console.WriteLine(num*contador);
}

int n=6;
for(int i=0;i<=10;i++){
    Console.WriteLine(n*i);
}



Pessoa p = new Pessoa();

p.Nome = "Ju";
p.Idade = 37;
p.Apresentar();

Calculadora calc=new Calculadora();
calc.Somar(5,5);
calc.Multiplicar(5,5);
calc.Subtrair(10,50);
calc.Dividir(10,2);
calc.Potencia(3,3);