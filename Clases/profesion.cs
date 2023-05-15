using static Program;

public abstract class Profesion
{
    protected string nombre;
    protected string area;
    public Profesion(string nombre, string area)
    {
        this.nombre = nombre;
        this.area = area;
    }

    public abstract string Descripcion();
}

// public class Ingeniero : Profesion
// {
//     private string sector;
//     public Ingeniero(string nombre, string area, string sector) : base(nombre, area)
//     {
//         this.sector = sector;
//     }

//     public override string Descripcion()
//     {
//         return $"El {nombre} trabaja en el sector {sector}, dentro del área de {area}.";
//     }

// }
// public class Medico : Profesion
// {
//     private string especialidad;
//     public Medico(string nombre, string area, string especialidad) : base(nombre, area)
//     {
//         this.especialidad = especialidad;
//     }

//     public override string Descripcion()
//     {
//         return $"El {nombre} es especialista en {especialidad}, dentro del área de {area}.";
//     }
// }
// public class Abogado : Profesion
// {
//     private string rama;
//     public Abogado(string nombre, string area, string rama) : base(nombre, area)
//     {
//         this.rama = rama;
//     }

//     public override string Descripcion()
//     {
//         return $"El {nombre} esta en la rama {rama}, dentro del área de {area}.";
//     }
// }