using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35AddressBook
{
    internal class UC3InsertRecordDataTable
    {
        public void InsertRow()
        {
            //create data table
            DataTable addressBookDT = new DataTable();

            //add column
            addressBookDT.Columns.Add("firstName", typeof(string));
            addressBookDT.Columns.Add("lastName", typeof(string));
            addressBookDT.Columns.Add("address", typeof(string));
            addressBookDT.Columns.Add("city", typeof(string));
            addressBookDT.Columns.Add("state", typeof(string));
            addressBookDT.Columns.Add("zip", typeof(int));
            addressBookDT.Columns.Add("phoneNumber", typeof(long));
            addressBookDT.Columns.Add("email", typeof(string));

            //insert row
            addressBookDT.Rows.Add("Sarvesh","Rathour", "NIT","Faridabad","Haryana",121001,9876543210,"sarvatra@gmail.com");
            addressBookDT.Rows.Add("sarv", "athour", "IMT", "Faridabad", "Haryana", 121009, 876543210, "arvatra@gmail.com");
            addressBookDT.Rows.Add("harv", "thour", "GreenField", "Faridabad", "Haryana", 121003, 76543210, "harvatra@gmail.com");
            addressBookDT.Rows.Add("parv", "hour", "OMAXE", "Faridabad", "Haryana", 121010, 6543210, "parvatra@gmail.com");
            addressBookDT.Rows.Add("karv", "our", "World street", "Faridabad", "Haryana", 121011, 6876543210, "karvatra@gmail.com");
            addressBookDT.Rows.Add("narv", "Rath", "vatika mindscape", "Faridabad", "Haryana", 121003, 8976543210, "narvatra@gmail.com");
            addressBookDT.Rows.Add("tarv", "Rathou", "SRS", "Faridabad", "Haryana", 121002, 7676543210, "tarvatra@gmail.com");
        }
    }
}