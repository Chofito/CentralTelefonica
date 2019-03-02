using System;
using System.Collections.Generic;
using static System.Console;
using static System.Convert;
using CentralTelefonica.Entidades;

namespace CentralTelefonica.App
{
    public class MenuPrincipal
    {
        private const float PrecioUnoDepartamental = 0.65f;
        private const float PrecioDosDepartamental = 0.65f;
        private const float PrecioTresDepartamental = 0.65f;
        private const float PrecioLocal = 0.65f;
        public List<Llamada> ListaDeLlamadas { get; set; }
        private int entrada = 0;
        public void MostrarMenu()
        {
            do
            {
                WriteLine("1.- Registrar llamada local");
                WriteLine("2.- Registrar llamada departamental");
                WriteLine("3.- Costo total de las llamadas locales");
                WriteLine("4.- Costo total de las llamadas departamentales");
                WriteLine("5.- Costo total de las llamadas");
                WriteLine("0.- Salir");
                WriteLine("Ingrese su opción");
                Write("> ");
                entrada = Convert.ToInt32(ReadLine());
                RegistrarLlamada();
            } while(entrada != 0);
        }

        public void RegistrarLlamada()
        {
            Llamada llamada = null;
            WriteLine("Ingrese el numero de origen");
            var numeroOrigen = ReadLine();
            WriteLine("Ingrese el numero de destino");
            var numeroDestino = ReadLine();
            WriteLine("Ingrese la duracion de la llamada");
            var duracion = ReadLine();
            if (entrada == 1) llamada = new LlamadaLocal(numeroOrigen, numeroDestino, ToDouble(duracion));
            else if (entrada == 2) llamada = new LlamadaDepartamental(numeroOrigen, numeroDestino, ToDouble(duracion));
            else WriteLine("Tipo de llamada no reconocido");
        }

        ~MenuPrincipal() => WriteLine("Un destructor!");
    }
}