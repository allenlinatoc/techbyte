using Guitar32.Database;
using Guitar32.Validations;
using Guitar32.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechByte.Architecture.Beans.Goods
{
    public class GoodsCategory : Guitar32.Model, Guitar32.Common.IDatabaseEntity
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
        private String
            name,
            description;

        public GoodsCategory(int id = -1) {
            this.setId(id);
            if (this.exists()) {
                QueryBuilder query = new QueryBuilder();
                query.Select()
                    .From("tblgoodscategories")
                    .Where("id", this.getId());
                QueryResultRow row = dbConn.QuerySingle(query);
                if (row != null && row.Count > 0) {
                    this.setName(new MultiWordAlphaNumeric(row["name"].ToString()));
                    this.setDescription(new MultiWordAlphaNumeric(row["description"].ToString()));
                }
                else {
                    throw new Guitar32.Exceptions.BeanDataNotFoundException();
                }
            }
        }

        public String getName() {
            return this.name;
        }

        public String getDescription() {
            return this.description;
        }

        public void setName(MultiWordAlphaNumeric name) {
            this.name = name.getValue();
        }

        public void setDescription(MultiWordAlphaNumeric description) {
            this.description = description.getValue();
        }


        public bool CreateData() {
            if (!this.exists()) {
                QueryBuilder query = new QueryBuilder();
                query.InsertInto("tblgoodscategories", new string[] { "name", "description" })
                    .Values(new object[] {
                        Strings.Surround(this.getName()),
                        Strings.Surround(this.getDescription())
                    });
                bool success = dbConn.Execute(query);
                if (success) {
                    this.setId(dbConn.GetLastInsertID());
                }
                return success;
            }
            return false;
        }

        public bool Delete() {
            if (this.exists()) {
                QueryBuilder query = new QueryBuilder();
                query.DeleteFrom("tblgoodscategories")
                    .Where("id", this.getId());
                if (dbConn.Execute(query)) {
                    this.setId(-1);
                    return true;
                }
                return false;
            }
            return false;
        }

        public bool Update() {
            if (this.exists()) {
                QueryBuilder query = new QueryBuilder();
                Dictionary<string, string> setPairs = new Dictionary<string, string>();
                setPairs.Add("name", Strings.Surround(this.getName()));
                setPairs.Add("description", Strings.Surround(this.getDescription()));
                query.Update("tblgoodscategories")
                    .Set(setPairs)
                    .Where("id", this.getId());
                return dbConn.Execute(query);
            }
            return false;
        }


        /// <summary>
        /// Check if a category name already exists
        /// </summary>
        /// <param name="name">The category name</param>
        /// <returns></returns>
        public static bool NameExists(MultiWordAlphaNumeric name) {
            DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
            String whatName = name.getValue();
            QueryBuilder query = new QueryBuilder();
            query.Select()
                .From("tblgoodscategories")
                .Where("lower(name)", Strings.Surround(whatName).ToLower(), true);
            QueryResult result = dbConn.Query(query);
            return result.RowCount() > 0;
        }
    }
}
