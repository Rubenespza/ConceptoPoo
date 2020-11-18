using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcionpoo
{
    class Program
    {
        
        static void Main(string[] args)

            
        {
            Console.WriteLine("Programa de Resta");

            Resta r1 = new Resta(5, 10);
            Console.WriteLine(r1.ResultadoResta());
            Console.ReadKey();
        }
    }
}

public class Resta
{
    //Especificacion propiedades
    #region propiedades
    public int var1 { get; set; }
    public int var2 { get; set; }
    #endregion
    //Constructor
    #region constructor
    public Resta(int n1, int n2)
    {
        var1 = n1;
        var2 = n2;
    }
    #endregion
    //Metodo
    #region Metodos
    public int ResultadoResta()
    {
        return var1 - var2;
    }
    #endregion

}
 