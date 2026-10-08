
namespace CalculadoraOracle19C.Models
{
    public class Operacion
    {
        public int Id { get; set; }
        public decimal Numero1 { get; set; }
        public decimal Numero2 { get; set; }
        public string Operador { get; set; } = string.Empty;
        public decimal Resulado { get; set; }
        public DateTime FechaOperacion { get; set; } 
    }   
}
