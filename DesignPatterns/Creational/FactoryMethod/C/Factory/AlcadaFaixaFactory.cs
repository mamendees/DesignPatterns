using FactoryMethod.C.Model;

namespace FactoryMethod.C.Factory;
public static class AlcadaFaixaFactory
{
    public static AlcadaLimiteFactory CriarAlcadaLimiteFactory(FaixaDeRisco faixaDeRisco) => faixaDeRisco switch
    {
        FaixaDeRisco.A or FaixaDeRisco.B or FaixaDeRisco.C => new AlcadaFactoryFaixaInferior(),
        _ => new AlcadaFactoryFaixaSuperior(),
    };
}
