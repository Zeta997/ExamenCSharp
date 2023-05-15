public class Abogado : Profesion
{
    private string rama;
    public Abogado(string nombre, string area, string rama) : base(nombre, area)
    {
        this.rama = rama;
    }

    public override string Descripcion()
    {
        return $"El {nombre} esta en la rama {rama}, dentro del área de {area}.";
    }
}