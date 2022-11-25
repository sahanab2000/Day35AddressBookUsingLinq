using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35AddressBook
{
    public class UC2AddressBookColumn
    {
        public void addColoumn()
        {
            //create data table
            DataTable addressBookDT = new DataTable();

            //add column
            addressBookDT.Columns.Add("firstName", typeof(string));
            addressBookDT.Columns.Add("lastName", typeof (string));
            addressBookDT.Columns.Add("address", typeof (string));
            addressBookDT.Columns.Add("city",typeof(string));
            addressBookDT.Columns.Add("state", typeof(string));
            addressBookDT.Columns.Add("zip", typeof(int));
            addressBookDT.Columns.Add("phoneNumber", typeof(long));
            addressBookDT.Columns.Add("email",typeof(string));
        }
    }
}