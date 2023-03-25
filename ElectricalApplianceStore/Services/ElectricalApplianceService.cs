using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricalApplianceStore.Services
{
    public class ElectricalApplianceService
    {
        public static async Task<IEnumerable<ElectricalAppliance>> GetElectricalAppliancesAsync()
        {
            SqlDataReader reader = await new SqlCommand("select * from ElectricalAppliances", SqlDataBase.Instance()).ExecuteReaderAsync();
            List<ElectricalAppliance> result = new List<ElectricalAppliance>();
            while (await reader.ReadAsync())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                DateTime dateOfRelease = reader.GetDateTime(2);
                string supplier = reader.GetString(3);
                double price = reader.GetDouble(4);
                double weight = reader.GetDouble(5);
                int amount = reader.GetInt32(6);
                ElectricalApplianceType type = (ElectricalApplianceType)Enum.Parse(typeof(ElectricalApplianceType), reader.GetString(7));
                result.Add(new ElectricalAppliance(id, name, dateOfRelease, supplier, price, weight, amount, type));
            }
            return result;
        }

        public static string GetInfoElectricalAppliances()
        {
            string result = "";
            SqlDataReader maxReader = new SqlCommand("select Type from ElectricalAppliances where Price = (select max(Price) from ElectricalAppliances)", SqlDataBase.Instance()).ExecuteReader();
            if (maxReader.Read())
            {
                result += $"Самый дорогой вид: {maxReader.GetString(0)}\n";
            }

            SqlDataReader minReader = new SqlCommand("select Type from ElectricalAppliances where Price = (select min(Price) from ElectricalAppliances)", SqlDataBase.Instance()).ExecuteReader();
            if (minReader.Read())
            {
                result += $"Самый дешевый вид: {minReader.GetString(0)}\n";
            }

            result += "Средняя стоимость по каждому виду:\n";
            SqlDataReader averageReader = new SqlCommand("select Type, (sum(Price) / count(Type)) as Average from ElectricalAppliances group by Type", SqlDataBase.Instance()).ExecuteReader();
            while (averageReader.Read())
            {
                result += $"{averageReader.GetString(0)} - {averageReader.GetDouble(1)}\n";
            }

            SqlDataReader popularReader = new SqlCommand("select top 1 Type, sum(Amount) as Sum from SellElectricalAppliances group by Type order by Sum desc", SqlDataBase.Instance()).ExecuteReader();
            if (popularReader.Read())
            {
                result += $"Самый популярный вид: {popularReader.GetString(0)}\n";
            }
            return result;
        }

        public static async Task<bool> BuyElectricalAppliance(ElectricalAppliance appliance, int count, User user)
        {
            if (count > appliance.Amount)
            {
                MessageBox.Show("Такого количества товара нету!!!");
                return false;
            }

            if (appliance.Amount > 0)
            {
                appliance.Amount -= count;
                await new SqlCommand($"update ElectricalAppliances set Amount = {appliance.Amount} where Id = {appliance.Id}", SqlDataBase.Instance()).ExecuteNonQueryAsync();
                await new SqlCommand($"insert into SellElectricalAppliances values ('{appliance.Name}', '{DateTime.Now.ToShortDateString()}', {appliance.Price}, {count}, {user.Id}, '{appliance.Type}')", SqlDataBase.Instance()).ExecuteNonQueryAsync();
                return true;
            }
            else
            {
                MessageBox.Show("Товар отсутствует в магазине!!!");
            }
            return false;
        }
    }
}
