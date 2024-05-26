using System.Collections.Generic;

namespace CalculadoraDio
{
    public class Calculadora
    {
        private readonly List<string> _historico;
        private readonly string data;
        public Calculadora(string data)
        { 
            this.data = data;
            _historico = new List<string>();
        }
        public int Somar(int val1, int val2)
        {
            var res = val1 + val2;
            _historico.Insert(0, $"Res: {res} - {data}");
            return res;
        }
        public int Subtrair(int val1, int val2)
        {
            var res = val1 - val2;
            _historico.Insert(0, $"Res: {res} - {data}");
            return res;
        }
        public int Multiplicar(int val1, int val2)
        {
            var res = val1 * val2;
            _historico.Insert(0, $"Res: {res} - {data}");
            return res;
        }
        public int Dividir(int val1, int val2)
        {
            var res = val1 / val2;
            _historico.Insert(0, $"Res: {res} - {data}");
            return res;
        }
        public List<string> Historico()
        {
            _historico.RemoveRange(3, _historico.Count - 3);
            return _historico;
        }
    }
}