namespace CentralTelefonica.Entidades
{
    public class LlamadaLocal : Llamada
    {
        private double precio;
        public double Precio
        {
            get { return precio;}
            set { precio = value;}
        }

        public LlamadaLocal(string numeroOrigen, string numeroDestino, double duracion)
            => (NumeroOrigen, NumeroDestino, Duracion) = (numeroOrigen, numeroDestino, duracion) ;

        public override double CalcularPrecio()
        {
            return this.Precio * this.Duracion;
        }
        
    }
}