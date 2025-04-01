﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace LocadoraVeiculo
{
    class Carro : Veiculo
    {
        public Carro(string placa, string modelo, string marca, int ano, double aluguelDiario) : base(placa, modelo, marca, ano, aluguelDiario)
        {
        }

        public override double CalcularAluguel(double aluguelDiario, int dias)
        {
            return aluguelDiario * dias;
        }
    }
}
