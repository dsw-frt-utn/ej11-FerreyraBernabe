namespace Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private static Dictionary<int, Alumno> Alumnos { get; } = new Dictionary<int, Alumno>();

    public static void Add(Alumno alu) => Alumnos.Add(alu.Id,alu);
    public static Alumno? FindAlumno(int clave) => Alumnos.GetValueOrDefault(clave);
    public static Dictionary<int, Alumno> GetAlumnos() => Alumnos;
    public static void RemoveAlumno(int clave) => Alumnos.Remove(clave);

 }
