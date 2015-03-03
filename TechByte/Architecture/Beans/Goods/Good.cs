using Guitar32;
using Guitar32.Database;
using Guitar32.Utilities;
using Guitar32.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechByte.Architecture.Beans.Business;

namespace TechByte.Architecture.Beans.Goods
{
    public class Good : Guitar32.Model, Guitar32.Common.IDatabaseEntity
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
        private String
            name,
            description;
        private float price;
        private Company vendor;
        private GoodsCategory goodsCategory;

        public Good(int id = -1) {
            this.setId(id);
            if (this.exists()) {
                QueryBuilder query = new QueryBuilder();
                query.Select()
                    .From("tblgoods")
                    .Where("id", this.getId());
                QueryResultRow row = dbConn.QuerySingle(query);
                if (row != null && row.Count > 0) {
                    this.setName(new MultiWord(row["name"].ToString()));
                    this.setDescription(new MultiWord(row["description"].ToString()));
                    this.setPrice(new Currency(row["price"].ToString()));
                    this.setVendor(new Company(Integer.Parse(row["vendor_id"])));
                    this.setGoodsCategory(new GoodsCategory(Integer.Parse(row["category_id"])));
                }
                else {
                    throw new Guitar32.Exceptions.BeanDataNotFoundException();
                }
            }
        }
        
        public String getDescription() {
            return this.description;
        }
        public GoodsCategory getGoodsCategory() {
            return this.goodsCategory;
        }
        public String getName() {
            return this.name;
        }
        public float getPrice() {
            return this.price;
        }
        public Company getVendor() {
            return this.vendor;
        }

        public void setDescription(MultiWord description) {
            this.description = description.getValue();
        }
        public void setGoodsCategory(GoodsCategory goodsCategory) {
            this.goodsCategory = goodsCategory;
        }
        public void setName(MultiWord name) {
            this.name = name.getValue();
        }
        public void setPrice(Currency price) {
            this.price = price.getValue();
        }
        public void setVendor(Company vendor) {
            this.vendor = vendor;
        }




        public bool CreateData() {
            if (!this.exists() && this.getVendor().exists() && this.getGoodsCategory().exists()) {
                QueryBuilder query = new QueryBuilder();
                query.InsertInto("tblgoods", new string[] {
                    "category_id", "vendor_id",
                    "name",
                    "description",
                    "price"
                })
                    .Values(new object[] {
                        this.getGoodsCategory().getId(), this.getVendor().getId(),
                        Strings.Surround(this.getName()),
                        Strings.Surround(this.getDescription()),
                        this.getPrice()
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
                query.DeleteFrom("tblgoods")
                    .Where("id", this.getId());
                return dbConn.Execute(query);
            }
            return false;
        }

        public bool Update() {
            if (this.exists()) {
                QueryBuilder query = new QueryBuilder();
                Dictionary<string, string> setPairs = new Dictionary<string, string>();
                setPairs.Add("category_id", this.getGoodsCategory().getId().ToString());
                setPairs.Add("vendor_id", this.getVendor().getId().ToString());
                setPairs.Add("name", Strings.Surround(this.getName()));
                setPairs.Add("description", Strings.Surround(this.getDescription()));
                setPairs.Add("price", this.getPrice().ToString());
                query.Update("tblgoods")
                    .Set(setPairs)
                    .Where("id", this.getId());
                return dbConn.Execute(query);
            }
            return false;
        }
    }
}
