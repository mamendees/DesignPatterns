using FactoryMethod.C.Alçada;

namespace FactoryMethod.C.Factory;
public class AlcadaFactoryFaixaInferior : AlcadaLimiteFactory
{
    protected override Alcada CriarAlcada(decimal limite) => limite switch
    {
        <= 10000 => new AlcadaAnalista(),
        <= 100000 => new AlcadaGerente(),
        <= 300000 => new AlcadaDiretor(),
        _ => new AlcadaComite()
    };
}
