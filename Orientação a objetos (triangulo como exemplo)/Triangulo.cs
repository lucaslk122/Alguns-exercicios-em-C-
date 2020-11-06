using System;

namespace Orientação_a_objetos__triangulo_como_exemplo
{
    class Triangulo //Como padrão de programação orientada a objetos, nome de classe sempre com a inicial em maiuscula.
    {
        public double A; // o public significa que essas variaveis podem ser acessadads em outro arquivo,nome de atribuito como padrão,comoeça com letra maiuscula.
        public double B;
        public double C;
        public double Area(){
            double p = (A + B + C) / 2.0;
            return  Math.Sqrt (p*(p - A)*(p - B)*(p - C));
        }
    }
}