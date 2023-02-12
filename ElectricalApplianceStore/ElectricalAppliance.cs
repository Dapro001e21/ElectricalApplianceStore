using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalApplianceStore
{
    public enum ElectricalApplianceType
    {
        Fridge,
        VacuumCleaner,
        WashingMachine,
        CoffeeMaker,
        Iron
    }

    public class ElectricalAppliance
    {
        public int Id;
        public string Name;
        public DateTime DateOfRelease;
        public string Supplier;
        public double Price;
        public double Weight;
        public int Amount;
        public ElectricalApplianceType Type;

        public ElectricalAppliance(int id, string name, DateTime dateOfRelease, string supplier, double price, double weight, int amount, ElectricalApplianceType type)
        {
            Id = id;
            Name = name;
            DateOfRelease = dateOfRelease;
            Supplier = supplier;
            Price = price;
            Weight = weight;
            Amount = amount;
            Type = type;
        }

        public override string ToString()
        {
            return $"{Name}, {DateOfRelease.Date.ToShortDateString()}, {Supplier}, {Price} ₽, {Weight} кг, {Amount}x, {Type}";
        }

        public static Comparison<ElectricalAppliance> SortAscDateOfRelease = delegate (ElectricalAppliance x, ElectricalAppliance y)
        {
            return x.DateOfRelease.CompareTo(y.DateOfRelease);
        };

        public static Comparison<ElectricalAppliance> SortAscSupplier = delegate (ElectricalAppliance x, ElectricalAppliance y)
        {
            return x.Supplier.CompareTo(y.Supplier);
        };

        public static Comparison<ElectricalAppliance> SortAscWeight = delegate (ElectricalAppliance x, ElectricalAppliance y)
        {
            return x.Weight.CompareTo(y.Weight);
        };

        public static Comparison<ElectricalAppliance> SortAscPrice = delegate (ElectricalAppliance x, ElectricalAppliance y)
        {
            return x.Price.CompareTo(y.Price);
        };

        public static Comparison<ElectricalAppliance> SortDescDateOfRelease = delegate (ElectricalAppliance x, ElectricalAppliance y)
        {
            return y.DateOfRelease.CompareTo(x.DateOfRelease);
        };

        public static Comparison<ElectricalAppliance> SortDescSupplier = delegate (ElectricalAppliance x, ElectricalAppliance y)
        {
            return y.Supplier.CompareTo(x.Supplier);
        };

        public static Comparison<ElectricalAppliance> SortDescWeight = delegate (ElectricalAppliance x, ElectricalAppliance y)
        {
            return y.Weight.CompareTo(x.Weight);
        };

        public static Comparison<ElectricalAppliance> SortDescPrice = delegate (ElectricalAppliance x, ElectricalAppliance y)
        {
            return y.Price.CompareTo(x.Price);
        };
    }
}
