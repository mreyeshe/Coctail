using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Interfaces;

namespace Repository.SqlServer
{
    public class CoctailRepositoryAdoNet : RepositoryAdoNet, ICoctailRepositoryAdoNet
    {
        public CoctailRepositoryAdoNet(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }

        public IEnumerable<Drinks> SearchDrinkByName(string name)
        {
            var command = CreateCommand("SELECT * FROM Drinks AS DR  WHERE DR.strDrink = @strDrink");

            command.Parameters.AddWithValue("@strDrink", name);

            var result = new List<Drinks>();

            using (var reader = command.ExecuteReader())
            {
                reader.Read();

                 while (reader.Read())
                {
                    result.Add(new Drinks
                    {
                        StrDrink = Convert.ToString(reader["strDrink"]),
                        strAlcoholic = Convert.ToString(reader["strAlcoholic"]),
                        StrTags = Convert.ToString(reader["strTags"]),
                        IdDrink = Convert.ToInt64(reader["idDrink"]),
                        strIBA = Convert.ToString(reader["strIBA"]),
                        strDrinkThumb= Convert.ToString(reader["strIBA"]),
                        strGlass= Convert.ToString(reader["strGlass"]),
                        strCategory= Convert.ToString(reader["strCategory"]),
                        strImageAttribution = Convert.ToString(reader["strImageAttribution"]),
                        strImageSource = Convert.ToString(reader["strImageSource"]),
                        strInstructions = Convert.ToString(reader["strInstructions"]),
                        strInstructionsES = Convert.ToString(reader["strInstructionsES"]),
                        strCreativeCommonsConfirmed=Convert.ToString(reader["strCreativeCommonsConfirmed"]),
                    });
                }
            }

            return result;
        }

        public IEnumerable<Drinks> SearchDrinkByCategory(string category)
        {
            var command = CreateCommand("SELECT * FROM Drinks AS DR  WHERE DR.strCategory = @strCategory");

            command.Parameters.AddWithValue("@strCategory", category);

            var result = new List<Drinks>();

            using (var reader = command.ExecuteReader())
            {
                reader.Read();

                while (reader.Read())
                {
                    result.Add(new Drinks
                    {
                        StrDrink = Convert.ToString(reader["strDrink"]),
                        strAlcoholic = Convert.ToString(reader["strAlcoholic"]),
                        StrTags = Convert.ToString(reader["strTags"]),
                        IdDrink = Convert.ToInt64(reader["idDrink"]),
                        strIBA = Convert.ToString(reader["strIBA"]),
                        strDrinkThumb = Convert.ToString(reader["strIBA"]),
                        strGlass = Convert.ToString(reader["strGlass"]),
                        strCategory = Convert.ToString(reader["strCategory"]),
                        strImageAttribution = Convert.ToString(reader["strImageAttribution"]),
                        strImageSource = Convert.ToString(reader["strImageSource"]),
                        strInstructions = Convert.ToString(reader["strInstructions"]),
                        strInstructionsES = Convert.ToString(reader["strInstructionsES"]),
                        strCreativeCommonsConfirmed = Convert.ToString(reader["strCreativeCommonsConfirmed"]),
                    });
                }
            }

            return result;
        }

    }
}
