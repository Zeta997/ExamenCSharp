
//using static Program; 
class Ingeniero : Profesion
{
    private string sector;
    public Ingeniero(string nombre, string area, string sector) : base(nombre, area)
    {
        this.sector = sector;
    }

    public override string Descripcion()
    {
        return $"El {nombre} trabaja en el sector {sector}, dentro del área de {area}.";
    }

}