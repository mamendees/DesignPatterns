using FactoryMethod.C.Model;

namespace FactoryMethod.C.Alçada;
public class AlcadaComite: Alcada
{
    public AlcadaComite()
    {
        Nome = "Alcada Comite";
        Aprovadores.Add(new Aprovadores("Matheus Gerente", Cargo.Gerente));
        Aprovadores.Add(new Aprovadores("Matheus SuperIntendente", Cargo.SuperIntendente));
    }
}
