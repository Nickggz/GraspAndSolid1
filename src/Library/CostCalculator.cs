using System;
using System.Collections;


namespace Full_GRASP_And_SOLID.Library;

public class CostCalculator
{
    public static double CalculateProduct(ArrayList pasos)
    {
        double precioTotProducto = 0;

        foreach (Step producto in pasos)
        {
            double precioUnitario = producto.Input.UnitCost;

            double cantidad = producto.Quantity;

            precioTotProducto = precioTotProducto + (precioUnitario*cantidad);
        }
        return precioTotProducto;
    }

    public static double CalculateEquipmentCost(ArrayList pasos)
    {

        double precioTotPasos= 0;
        foreach(Step paso in pasos)
        {
            double pasoTiempo = paso.Time/3600;

            double precioPorPaso = paso.Equipment.HourlyCost;

            precioTotPasos = precioTotPasos+(pasoTiempo * precioPorPaso);
        }
        return (precioTotPasos);
    }

    public static double GetProductionCost(ArrayList pasos)
    {
        return (CostCalculator.CalculateEquipmentCost(pasos) + CostCalculator.CalculateProduct(pasos));
    }
}