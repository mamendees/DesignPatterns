//Define uma interface para criar um objeto, mas deixa as subclasses decidirem qual classe
//a ser instanciada. Permite a uma classe postergar a instanciação às subclasses.

//Permitir que o Cliente não precise saber quais tipos de objetos serão criados.
//Herança + Subclasses
using FactoryMethod.B.Factory;
using FactoryMethod.B.Product;
using FactoryMethod.C.Factory;
using FactoryMethod.C.Model;

Console.WriteLine("Factory Method!");
Console.WriteLine("--------------------");

var brasil = PizzariaLocal.Brasil;
var mussarela = TipoPizza.Mussarela;
var pizzariaA = PizzaSimpleFactory.CriarPizzaria(brasil);
var pizzaA = pizzariaA.MontarPizza(mussarela);
Console.WriteLine(pizzaA.Preparar());
Console.WriteLine("--------------------");

var italia = PizzariaLocal.Italia;
var frango = TipoPizza.Frango;
var pizzariaB = PizzaSimpleFactory.CriarPizzaria(italia);
var pizzaB = pizzariaB.MontarPizza(frango);
Console.WriteLine(pizzaB.Preparar());
Console.WriteLine("--------------------");

var faixaA = FaixaDeRisco.A;
var faixaF = FaixaDeRisco.F;
var limite = 225000;

var limiteInferior = AlcadaFaixaFactory.CriarAlcadaLimiteFactory(faixaA);
var alcadax = limiteInferior.MontarAlcada(limite);
Console.WriteLine("FaixaDeRisco.A - 225000");
Console.WriteLine($"Faixa: {alcadax.NomeAlcada()} - {alcadax.AprovadorPor()}");
Console.WriteLine("--------------------");

var limiteSuperior = AlcadaFaixaFactory.CriarAlcadaLimiteFactory(faixaF);
var alcadaY = limiteSuperior.MontarAlcada(limite);
Console.WriteLine("FaixaDeRisco.F - 225000");
Console.WriteLine($"Faixa: {alcadaY.NomeAlcada()} - {alcadaY.AprovadorPor()}");

Console.Read();


