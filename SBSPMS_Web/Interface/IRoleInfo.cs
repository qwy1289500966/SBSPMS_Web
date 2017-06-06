using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SBSPMS_Web.DAO.Common;

namespace SBSPMS_Web.Interface
{
    interface IRoleInfo
    {
        /// <summary>
        /// 获得用户所拥有权限的菜单列表
        /// </summary>
        /// <param name="userCode"></param>
        /// <returns></returns>
        List<MenuInfo> GetPurviewByUser(string userCode);
    }
}
