using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Maticsoft.Model.SysManage;
namespace Maticsoft.BLL.SysManage
{
    
    /// <summary>
    /// 
    /// </summary>
    public class UserLog
    {
        private static Maticsoft.DAL.SysManage.UserLog dal = new DAL.SysManage.UserLog();
               
        #region 
        
        /// <summary>
        /// 增加日志
        /// </summary>
        /// <param name="model">要增加的日志实体对象</param>
        public static void LogUserAdd(Maticsoft.Model.SysManage.UserLog model)
        {
            dal.LogUserAdd(model);
        }

        public static DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 根据查询条件获取日志列表
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <returns>返回的数据集</returns>
        public static DataSet GetAllList()
        {
            return dal.GetList("");
        }

        /// <summary>
        /// 删除一条日志记录
        /// </summary>
        /// <param name="iID">要删除的日志编号</param>
        public static void Delete(int iID)
        {
            dal.LogUserDelete(iID);
        }
        public static void Delete(string IdList)
        {
            dal.LogUserDelete(IdList);
        }
        /// <summary>
        /// 删除某一日期之前的数据
        /// </summary>
        /// <param name="dtDateBefore">日期</param>
        public static void Delete(DateTime dtDateBefore)
        {
            dal.LogUserDelete(dtDateBefore);
        }
                
        #endregion

    
    }
    
}
