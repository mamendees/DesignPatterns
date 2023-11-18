using FactoryMethod.C.Model;

namespace FactoryMethod.C.Alçada;
public class AlcadaAnalista: Alcada
{
    public AlcadaAnalista()
    {
        Nome = "Alcada Analista";
        Aprovadores.Add(new Aprovadores("Matheus Analista", Cargo.Analista));
        Aprovadores.Add(new Aprovadores("Matheus Gerente", Cargo.Gerente));
    }
}
