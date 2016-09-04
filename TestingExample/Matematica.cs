using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematica
{
    public class MatematicaClass //NOTA: CLASE PUBLICA
    {

        private MatematicaClass() //CONSTRUCTOR PRIVADO. NO SE PUEDE INSTANCIAR LA CLASE. SOLO USAMOS SUS METODOS PUBLICOS 
        {
        }

        public static double Dividir(int pDividendo, int pDivisor) //STATIC PERMITE LLAMAR AL METODO SIN INSTANCIAR LA CLASE
        {
            return pDividendo / pDivisor;
        }
    }
}
