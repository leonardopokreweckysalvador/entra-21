﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio03
    {
        public void Executar()
        {
            var quantidadeProdutos = 2;
            var nomesProdutos = new string[quantidadeProdutos];
            var valoresProdutos = new double[quantidadeProdutos];

            for (var i = 0; nomesProdutos.Length > i; i = i + 1)
            {
                var validar = false;
                while (validar == false)
                {
                    try
                    {
                        Console.Clear();
                        Console.Write($"Infome o nome do {i + 1 }° produto; ");
                        nomesProdutos[i] = Console.ReadLine();
                        validar = true;
                    }
                    catch (Exception ex )
                    {
                        Console
                    }

                }
            }
        }
    }
}