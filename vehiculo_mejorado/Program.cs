using System;

namespace vehiculos
{
    class Program
    {
        class Vehiculo
        {
            public string Marca { get; set; }
            public string Modelo { get; set; }
            public int Año { get; set; }

            public Vehiculo(string marca, string modelo, int año)
            {
                Marca = marca;
                Modelo = modelo;
                Año = año;
            }

            public virtual void MostrarInformacion()
            {
                Console.WriteLine($"Marca: {Marca} \nModelo: {Modelo} \nAño: {Año}");
            }
        }

        class Bicicleta : Vehiculo
        {
            public int NumeroMarchas { get; set; }

            public Bicicleta(string marca, string modelo, int año, int numeroMarchas) : base(marca, modelo, año)
            {
                NumeroMarchas = numeroMarchas;
            }

            public override void MostrarInformacion()
            {
                base.MostrarInformacion();
                Console.WriteLine($"Tipo: Bicicleta \nNúmero de marchas: {NumeroMarchas}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("--------VEHICULOS--------");

            Console.Write("Ingrese la marca del vehículo: ");
            string marca = Console.ReadLine();
            Console.Write("Ingrese el modelo del vehículo: ");
            string modelo = Console.ReadLine();
            Console.Write("Ingrese el año del vehículo: ");
            int año = int.Parse(Console.ReadLine());

            Vehiculo vehiculo = new Vehiculo(marca, modelo, año);
            vehiculo.MostrarInformacion();

            Console.WriteLine("-----------------");

            Console.Write("Ingrese la marca de la bicicleta: ");
            marca = Console.ReadLine();
            Console.Write("Ingrese el modelo de la bicicleta: ");
            modelo = Console.ReadLine();
            Console.Write("Ingrese el año de la bicicleta: ");
            año = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el número de marchas de la bicicleta: ");
            int numeroMarchas = int.Parse(Console.ReadLine());

            Bicicleta bicicleta = new Bicicleta(marca, modelo, año, numeroMarchas);
            bicicleta.MostrarInformacion();
        }
    }
}