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
        /// What is everything I have stored in a bin, purchased before 2017, ordered by item number?
        /// </summary>
        public static readonly string q2 = "SELECT INo, Name, IType, Amount, Protocol, PDate\n" +
            "FROM ITEM\n" +
            "JOIN PURCHASE_INFO ON INum = INo\n" +
            "WHERE INo IN (\n" +
            "\t(SELECT INum\n" +
            "\tFROM STORAGE_AREA\n" +
            "\tJOIN STORED_IN ON (STORAGE_AREA.BLabel = STORED_IN.SISNum)\n" +
            "\tWHERE BFlag=1)\n" +
            ")\n" +
            "GROUP BY INo\n" +
            "HAVING year(PDate) < 2017\n" +
            "ORDER BY INo ASC";

        /// <summary>
        /// Do I have any three-foot USB cables, and when did I purchase them? Order the output by purchase date.
        /// </summary>
        public static readonly string q3 = "SELECT INo, Name, IType, Amount, Length, Protocol, PDate\n" +
            "FROM ITEM\n" +
            "JOIN PURCHASE_INFO ON INum=INo\n" +
            "WHERE LCFlag=1 AND Name='Cable' AND Length=3 AND Protocol='USB'\n" +
            "GROUP BY INo\n" +
            "HAVING Amount > 0\n" +
            "ORDER BY PDate";

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
        /// Where have I stored electrolytic capactitors that I purchased for less than $1.00 each?
        /// </summary>
        public static readonly string q7 = "select OLabel as Organizer, DNo, Cmpt " +
            "from ITEM " +
            "join PURCHASE_INFO on (INum = INo) " +
            "join STORED_IN on STORED_IN.INum=INo " +
            "join DRAWER on SISNum=DSNum " +
            "join STORAGE_AREA on StoNo=SISNum " +
            "where Name='Capacitor' and IType='Electrolytic' and Price < 1.00 ";

        /// <summary>
        /// Where have I stored all components that I purchased in 2015?
        /// </summary>
        public static readonly string q8 = "select OLabel as Organizer, DNo, Cmpt " +
            "from ITEM " +
            "join PURCHASE_INFO on (INum = INo) " +
            "join STORED_IN on STORED_IN.INum=INo " +
            "join DRAWER on SISNum=DSNum " +
            "join STORAGE_AREA on StoNo=SISNum " +
            "where year(PDate) = 2015 ";

        /// <summary>
        /// Where have I stored any tools with currently in "repair" status?
        /// </summary>
        public static readonly string q9 = "select PLabel as Pegboard, HNo " +
            "from ITEM  " +
            "join STORED_IN on STORED_IN.INum=INo " +
            "join HOOK on SISNum=HSNum " +
            "join STORAGE_AREA on StoNo=SISNum where Status='Repair' ";

        /// <summary>
        /// What kind of solder do I own, and where did I get it from?
        /// </summary>
        public static readonly string q10 = "select * " +
            "from ITEM " +
            "join PURCHASE_INFO on (INum = INo) " +
            "where Name='Solder' " +
            "group by INo " +
            "having Amount > 0 " +
            "order by Name desc";

        #endregion fields
    }
}