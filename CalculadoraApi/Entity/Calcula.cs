

namespace CalculadoraApi.Entity
{
    public  class Calcula
    {
        public int Numero1 { get; set; }
       public int Numero2 { get; set; }
       public  int Resultado { get; set; }
        public string TipoOperacao { get; set; }

          
        public int Calculado(Calcula calcula)
        {
            switch (TipoOperacao)
            {
                case "A":
                    {
                        Resultado = Numero1 + Numero2;
                        break;
                    }
                case "S":
                    {
                        Resultado = Numero1 - Numero2;

                        break;
                    }
                case "M":
                    {
                        Resultado = Numero1 * Numero2;
                        break;
                    }
                case "D":
                    {
                        Resultado = Numero1 / Numero2;
                        break;
                    }
            }
            return Resultado;

        }

    }
}

