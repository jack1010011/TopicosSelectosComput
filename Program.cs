using System;
using Topicos.NetCore.ConsoleApp;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
        {
            HagaLaMagia();
        }

        private static void HagaLaMagia()
        {
            var laMagia = new LogicaPrincipal();
            laMagia.HagaLaMagia();
        }
    }
}
