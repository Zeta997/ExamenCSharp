public class Medico : Profesion
{
    private string especialidad;
    public Medico(string nombre, string area, string especialidad) : base(nombre, area)
    {
        this.especialidad = especialidad;
    }

    public override string Descripcion()
    {
        return $"El {nombre} es especialista en {especialidad}, dentro del área de {area}.";
    }
}