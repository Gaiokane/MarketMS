#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：MarketMS.BaseClass
* 项目描述 ：
* 类 名 称 ：DBConn
* 类 描 述 ：
* 命名空间 ：MarketMS.BaseClass
* 机器名称 ：TOM-LENOVOPC
* CLR 版本 ：4.0.30319.42000
* 作    者 ：Gaiokane
* 创建时间 ：2018/3/24 星期六 21:48:42
* 更新时间 ：2018/3/24 星期六 21:48:42
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Gaiokane 2018. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MarketMS.BaseClass
{
    class DBConn
    {
        public static MySqlConnection MyConn()
        {
            return new MySqlConnection("Host=127.0.0.1;Database=MarketMS;Username=qk;Password=11111");
        }
    }
}