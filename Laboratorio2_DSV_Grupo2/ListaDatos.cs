
using System;
using System.Collections.Generic;
using System.Threading;

public class ListaDatos
{
    List<double> montos = new List<double>();

    public void agregarDato(double entradaCant)
    {
        montos.Add(entradaCant);
    }
    public (int mayMil, int menMil, int menQuin) CategorizarMontos() {
        int mayMil = 0;
        int menMil = 0;
        int menQuin = 0;
        foreach (double monto in montos)
        {
            if (monto > 1000)
            {
                mayMil++;
            }
            else if (monto > 500 & monto <= 1000)
            {
                menMil++;
            }
            else if (monto <= 500)
                menQuin++;
            }

            return (mayMil, menMil, menQuin);
    }
}


