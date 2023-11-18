using FactoryMethod.C.Alçada;

namespace FactoryMethod.C.Factory;
public abstract class AlcadaLimiteFactory
{
    public Alcada MontarAlcada(decimal limite) => CriarAlcada(limite);

    protected abstract Alcada CriarAlcada(decimal limite);
}
