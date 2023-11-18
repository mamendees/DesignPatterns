using FactoryMethod.C.Alçada;

namespace FactoryMethod.C.Factory;
public class AlcadaFactoryFaixaSuperior : AlcadaLimiteFactory
{
    protected override Alcada CriarAlcada(decimal limite) => limite switch
    {
        <= 50000 => new AlcadaGerente(),
        <= 100000 => new AlcadaDiretor(),
        _ => new AlcadaComite()
    };
}
