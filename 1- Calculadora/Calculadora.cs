using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ProjetosEmC_.Models
{
    public class Calculadora
    {
        private int x;
        private int y;

        public Calculadora() { x = 0; y = 0; }
        public Calculadora(int x, int y) { this.x = x; this.y = y; }

        public void getX(int x) { this.x = x; }
        public void getY(int y) { this.y = y; }
        
        public string somar(int x, int y) { return $"{x} + {y} = {x+y}"; }
        public string subtrair(int x, int y) { return $"{x} - {y} = {x-y}"; }
        public string dividir(int x, int y) { return $"{x} / {y} = {x/y}"; }
        public string multiplicar(int x, int y) { return $"{x} * {y} = {x*y}"; }
        public string parOuImpar(int x) { if (x % 2 == 0) return $"{x} é par"; return $"{x} é ímpar"; }
        public bool par(int x) { if (x % 2 == 0) return true; return false; }
        public string potencia(int x, int y) {
            int resultado = 1;
            if (y < 0) {
                for (int i = 0; i < y*(-1); i++) {
                    resultado *= x;
                }
                if (!par(y)) resultado = -resultado;
            }

            else if (y == 0) resultado = 1;

            else {
                for (int i = 0; i < y; i++) {
                    resultado *= x;
                }
            }
            return $"{x}^{y} = {resultado}";
        }
    }
}