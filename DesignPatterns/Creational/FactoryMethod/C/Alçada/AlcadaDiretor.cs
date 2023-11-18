using FactoryMethod.C.Model;

namespace FactoryMethod.C.Alçada;
public class AlcadaDiretor: Alcada
{
    public AlcadaDiretor()
    {
        Nome = "Alcada Gerente";
        Aprovadores.Add(new Aprovadores("Matheus Diretor", Cargo.Diretor));
        Aprovadores.Add(new Aprovadores("Matheus Gestor", Cargo.Gestor));
    }
}
