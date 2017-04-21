using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINV.SQLQueries
{
    public static class Queries
    {
        /// <summary>
        /// How many 1 Ohm, 0.25 watt resistors do I have, and what's their total
        /// cost?
        /// </summary>
        public static readonly string q1 = " SELECT Amount, (Price * Amount) AS Total_Price " +
            "FROM ITEM " +
            "INNER JOIN PURCHASE_INFO ON INum=INo " +
            "WHERE CFlag=1 AND NAME='Resistor' AND Power=0.25";

        public static readonly string q2 = " SELECT INo, Name, IType, Amount, Length, Protocol, PDate \n" +
            "FROM ITEM \n" +
            "JOIN PURCHASE_INFO ON INum=INo \n" +
            "WHERE LCFlag=1 AND Name='Cable' AND Length=3 AND Protocol='USB' \n" +
            "GROUP BY IType \n" +
            "HAVING Amount > 0 \n" +
            "ORDER BY PDate";
    }
}