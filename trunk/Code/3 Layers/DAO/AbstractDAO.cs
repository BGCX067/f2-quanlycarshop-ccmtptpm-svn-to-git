using System;
using System.Collections.Generic;
using System.Text;

namespace Layers.DAO
{
    public abstract class AbstractDAO
    {
        //static protected string m_ConnectionString = "Persist Security Info=False;Integrated Security=SSPI;Initial Catalog=QUAN_LY_CAR_SHOP;server=LOVELY-AUTUMN\\SQLEXPRESS";
        static protected string m_ConnectionString = "Persist Security Info=False;Integrated Security=SSPI;Initial Catalog=QUAN_LY_CAR_SHOP;server=GREENDAY\\SQLEXPRESS";
        //static protected string m_ConnectionString = "Persist Security Info=False;Integrated Security=SSPI;Initial Catalog=QUAN_LY_CAR_SHOP;server=BLUE-SKY\\SQLEXPRESS";
        public static string ConnectionString
        {
            get { return m_ConnectionString; }
            set { m_ConnectionString = value; }
        }
    }
}
