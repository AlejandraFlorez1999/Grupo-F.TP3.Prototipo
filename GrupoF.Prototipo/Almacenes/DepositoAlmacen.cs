﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GrupoF.Prototipo.Almacenes
{
    internal static class DepositoAlmacen
    {

        private static List<DepositoEnt> depositos = new List<DepositoEnt>();

        public static IReadOnlyCollection<DepositoEnt> Depositos => depositos.AsReadOnly();

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(depositos);
            File.WriteAllText(@"Depositos.json", datos);
        }

        public static void Leer()
        {
            if (!File.Exists("Depositos.json"))
            {
                return;
            }

            var datos = File.ReadAllText("Depositos.json");
            depositos = JsonSerializer.Deserialize<List<DepositoEnt>>(datos)!;
        }
    }
}