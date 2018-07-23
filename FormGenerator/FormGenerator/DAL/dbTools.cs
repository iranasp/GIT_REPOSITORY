using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dbTools : P_DLL.dbObject
    {
        public static string Global_FormGenerator_Connection { get; set; }
        public static string Global_FileForSaveMessage { get; set; }

        public dbTools()
        {
            this.dbConnection = Global_FormGenerator_Connection;
            this.FileForSaveMessage = Global_FormGenerator_Connection;
        }

        public dbTools(string iSqlStr, SqlSP iSqlSp)
        {
            this.dbConnection = Global_FormGenerator_Connection;
            this.FileForSaveMessage = Global_FileForSaveMessage;

            this.CommandText = iSqlStr;
            this.CommandType = iSqlSp;
        }

        public dbTools(string iSqlStr)
        {
            this.dbConnection = Global_FormGenerator_Connection;
            this.FileForSaveMessage = Global_FileForSaveMessage;

            this.CommandText = iSqlStr;

            if (iSqlStr.IndexOf(" ") == -1)
            {
                this.CommandType = P_DLL.dbObject.SqlSP.SP;
            }
            else
            {
                this.CommandType = P_DLL.dbObject.SqlSP.SQL;
            }
        }

    }
}
