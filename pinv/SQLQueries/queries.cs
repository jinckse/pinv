using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINV.SQLQueries
{
    public static class Queries
    {
        #region fields 

        /// <summary>
        /// How many 1 Ohm, 0.25 watt resistors do I have, and what's their total
        /// cost?
        /// </summary>
        public static readonly string q1 = "SELECT Amount, (Price * Amount) AS Total_Price\n" +
            "FROM ITEM\n" +
            "INNER JOIN PURCHASE_INFO ON INum=INo\n" +
            "WHERE CFlag=1 AND NAME='Resistor' AND Power=0.25";


        /// <summary>
        /// 
        /// </summary>
        public static readonly string q2 = "SELECT INo, Name, IType, Amount, Length, Protocol, PDate\n" +
            "FROM ITEM\n" +
            "JOIN PURCHASE_INFO ON INum=INo\n" +
            "WHERE LCFlag=1 AND Name='Cable' AND Length=3 AND Protocol='USB'\n" +
            "GROUP BY INo\n" +
            "HAVING Amount > 0\n" +
            "ORDER BY PDate";

        /// <summary>
        /// What is everything I have stored in a bin, purchased before 2017?
        /// </summary>
        public static readonly string q3 = "SELECT INo, Name, IType, Amount, Protocol, PDate\n" +
            "FROM ITEM\n" +
            "JOIN PURCHASE_INFO ON INum = INo\n" +
            "WHERE INo IN (\n" +
            "\t(SELECT INum\n" +
            "\tFROM STORAGE_AREA\n" +
            "\tJOIN STORED_IN ON (STORAGE_AREA.StoNo = STORED_IN.SISNum)\n" +
            "\tWHERE BFlag=1)\n" +
            ")\n" +
            "GROUP BY INo\n" +
            "HAVING PDate < '2017-01-10'\n" +
            "ORDER BY INo ASC";

        /// <summary>
        /// Where can I find a 3 foot USB type-C calbe?
        /// </summary>
        public static readonly string q4 = "SELECT SISNum AS Bin_No\n" +
            "FROM ITEM\n" +
            "JOIN STORED_IN ON INum = INo\n" +
            "WHERE LCFlag=1 AND Name='Cable' AND Length=3 AND Protocol='USB'\n" +
            "AND IType='Type-C'";

        /// <summary>
        /// Where have I stored the least expensive capacitors I own?"
        /// </summary>
        public static readonly string q5 = "SELECT DSNum AS StoNo, DNo, CAST(Cmpt AS UNSIGNED) AS Cmpt\n" +
            "FROM (\n" +
            "\tSELECT SISNum\n" +
            "\tFROM (\n" +
            "\t\tSELECT INo, MIN(Price)\n" +
            "\t\tFROM (\n" +
            "\t\t\tSELECT *\n" +
            "\t\t\tFROM ITEM\n" +
            "\t\t\tWHERE Name='Capacitor' AND CFlag=1\n" +
            "\t\t) AS CAP_ITEMS\n" +
            "\t\tJOIN PURCHASE_INFO ON (CAP_ITEMS.INo = PURCHASE_INFO.INum)\n" +
            "\t) AS MIN_CAP_ITEMS\n" +
            "\tJOIN STORED_IN ON (MIN_CAP_ITEMS.INo = STORED_IN.INum)\n" +
            ") AS MIN_CAP_ITEMS_STORE\n" +
            "JOIN DRAWER ON (MIN_CAP_ITEMS_STORE.SISNum = DRAWER.DSNum)";

        /// <summary>
        /// How many resistors do I have stored in the system?
        /// </summary>
        public static readonly string q6 = "SELECT SUM(Amount) AS Qty\n" +
            "FROM ITEM\n" +
            "JOIN STORED_IN ON INum = INo\n" +
            "WHERE Name = 'Resistor'";

        /// <summary>
        /// List of all example queries
        /// </summary>
        public static readonly List<string> queryList = new List<string>{ q1, q2, q3, q4, q5, q6 };

        #endregion fields
    }
}