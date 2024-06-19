using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DoAn.DTO
{
    public class Table
    {
        public int TableId { set; get; }
        public string TableName { set; get; }
        public int Status { set; get; } 

        public Table() { }

        public Table(DataRow row)
        {
            this.TableId = (int)row["TABLE_ID"];
            this.TableName = row["TABLE_NAME"].ToString();
            this.Status = (int)row["STATUS"];
        }
    }
}
