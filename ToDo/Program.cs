using System.Data.Common;
using ToDO;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Console.WriteLine("Hello, World!");
        Console.WriteLine(" escribe un numero");
        string input = Console.ReadLine(); 
        int numero = int.Parse(input); // traformame en un numero string
        Console.WriteLine("numero es: " + numero);


        Console.WriteLine(" escribe un numero");
        string input1 = Console.ReadLine();
        int numero1 = 0;
        bool conversion = int.TryParse(input1,out numero1); // traformame en un numero string// si pongo un decimal no se me rompre el programa con tryparse
        Console.WriteLine("numero es: " + numero1);*/

        // LISTA DE TAREAS PENDIENTES VACIAS EXPLICITAS

        List<Tarea> tareasPendientes = new List<Tarea>();
       

        // lista de tareas realizadas vacias implicita

        List<Tarea> tareasRealizadas = [];

        Console.WriteLine("Ingrese la cantidad de Tareas:");

        string input = Console.ReadLine();

        int cantidadTareasPendientes = int.Parse(input);

        CargarTarea(tareasPendientes, cantidadTareasPendientes);

        

        Console.WriteLine(" Ingrese id de la tarea que desea marcar como realizada");

        string input2 = Console.ReadLine();

        int TareaID = int.Parse(input2);


        MarcarTareaComoRealizada(tareasPendientes, tareasRealizadas, TareaID);

        MostrarTarea(tareasPendientes, "Tarea pendientes");
        MostrarTarea(tareasRealizadas, "Tarea Realizadas");






    }

    private static void MarcarTareaComoRealizada(List<Tarea> tareasPendientes, List<Tarea> tareasRealizadas, int TareaID)
    {
        Tarea tarea = tareasPendientes.Find(t => t.TareaID== TareaID);


        if (tarea != null)
        {
            tareasPendientes.Remove(tarea);
            tareasRealizadas.Add(tarea);
            Console.WriteLine(" tarea maraca como realizada con existo");
        }
        else
        {
            Console.WriteLine($"no se encontro la tarea ID = {TareaID}");
        }

    }



    private static void MostrarTarea(Tarea tareaBuscada)
    {

        Console.WriteLine($"- Tarea ID:{tareaBuscada.TareaID}");
        Console.WriteLine($"\t - Descripcion : {tareaBuscada.Descripcion}");
        Console.WriteLine($"\t- Duracion: {tareaBuscada.Duracion}");
        Console.WriteLine();



    }

    private static void CargarTarea(List<Tarea> tareasPendientes, int cantidadTareasPendientes)
    {

        for (int i = 0; i < cantidadTareasPendientes; i++)
        {
            Console.WriteLine($" _ Ingrese la descripcion de la tareas {i + 1}:");
            string descripcion = Console.ReadLine();

            // UNA VARIABLE VAR DEBE SER INICIALIALIZADA EN LA MISMA LINEA DONDE SE DECLARA
            // NO PUEDES DECLARAR VAR TAREA ; Y LUEGO ASIGNARLE UN VALOR.
            var tarea = new Tarea
            {
                TareaID = i + 1,
                Descripcion = descripcion,
                Duracion = NumeroAleatorio(1, 5),


            };

            tareasPendientes.Add(tarea);


        }
    }




    private static void MostrarTarea(List<Tarea> tareasPendientes, String nombreLista)
    {

        Console.WriteLine($"****** Listado de :{nombreLista} *******");

        foreach (var item in tareasPendientes)
        {
            MostrarTarea(item);
        }

    }

    public static int NumeroAleatorio(int a, int b)
    {
        var random = new Random();
        int numero = random.Next(a, b);

        return numero;
    }


}

    



