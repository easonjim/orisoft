﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Maticsoft.DBUtility;//Please add references

namespace Maticsoft.DAL.Tao
{
    /// <summary>
    /// 数据访问类:Orders
    /// </summary>
    public partial class Orders
    {
        public Orders()
        { }

        #region Method

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("BuyerID", "Tao_Orders");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int BuyerID, int OrderID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Tao_Orders");
            strSql.Append(" where BuyerID=@BuyerID and OrderID=@OrderID ");
            SqlParameter[] parameters = {
					new SqlParameter("@BuyerID", SqlDbType.Int,4),
					new SqlParameter("@OrderID", SqlDbType.Int,4)};
            parameters[0].Value = BuyerID;
            parameters[1].Value = OrderID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Maticsoft.Model.Tao.Orders model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Tao_Orders(");
            strSql.Append("OrderDate,BuyerID,UserName,Email,Remark,Amount,Status,SellerID,PaymentTypeId,GatewayOrderId,PaymentType,CurrencyCode,CurrencyName)");
            strSql.Append(" values (");
            strSql.Append("@OrderDate,@BuyerID,@UserName,@Email,@Remark,@Amount,@Status,@SellerID,@PaymentTypeId,@GatewayOrderId,@PaymentType,@CurrencyCode,@CurrencyName)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@OrderDate", SqlDbType.DateTime),
					new SqlParameter("@BuyerID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.NVarChar,60),
					new SqlParameter("@Email", SqlDbType.VarChar,100),
					new SqlParameter("@Remark", SqlDbType.NVarChar,2000),
					new SqlParameter("@Amount", SqlDbType.Decimal,5),
					new SqlParameter("@Status", SqlDbType.SmallInt,2),
					new SqlParameter("@SellerID", SqlDbType.Int,4),
					new SqlParameter("@PaymentTypeId", SqlDbType.Int,4),
					new SqlParameter("@GatewayOrderId", SqlDbType.NVarChar,100),
					new SqlParameter("@PaymentType", SqlDbType.NVarChar,100),
					new SqlParameter("@CurrencyCode", SqlDbType.NVarChar,20),
					new SqlParameter("@CurrencyName", SqlDbType.NVarChar,20)};
            parameters[0].Value = model.OrderDate;
            parameters[1].Value = model.BuyerID;
            parameters[2].Value = model.UserName;
            parameters[3].Value = model.Email;
            parameters[4].Value = model.Remark;
            parameters[5].Value = model.Amount;
            parameters[6].Value = model.Status;
            parameters[7].Value = model.SellerID;
            parameters[8].Value = model.PaymentTypeId;
            parameters[9].Value = model.GatewayOrderId;
            parameters[10].Value = model.PaymentType;
            parameters[11].Value = model.CurrencyCode;
            parameters[12].Value = model.CurrencyName;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Maticsoft.Model.Tao.Orders model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Tao_Orders set ");
            strSql.Append("OrderDate=@OrderDate,");
            strSql.Append("UserName=@UserName,");
            strSql.Append("Email=@Email,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("Amount=@Amount,");
            strSql.Append("Status=@Status,");
            strSql.Append("SellerID=@SellerID,");
            strSql.Append("PaymentTypeId=@PaymentTypeId,");
            strSql.Append("GatewayOrderId=@GatewayOrderId,");
            strSql.Append("PaymentType=@PaymentType,");
            strSql.Append("CurrencyCode=@CurrencyCode,");
            strSql.Append("CurrencyName=@CurrencyName");
            strSql.Append(" where OrderID=@OrderID");
            SqlParameter[] parameters = {
					new SqlParameter("@OrderDate", SqlDbType.DateTime),
					new SqlParameter("@UserName", SqlDbType.NVarChar,60),
					new SqlParameter("@Email", SqlDbType.VarChar,100),
					new SqlParameter("@Remark", SqlDbType.NVarChar,2000),
					new SqlParameter("@Amount", SqlDbType.Decimal,5),
					new SqlParameter("@Status", SqlDbType.SmallInt,2),
					new SqlParameter("@SellerID", SqlDbType.Int,4),
					new SqlParameter("@PaymentTypeId", SqlDbType.Int,4),
					new SqlParameter("@GatewayOrderId", SqlDbType.NVarChar,100),
					new SqlParameter("@PaymentType", SqlDbType.NVarChar,100),
					new SqlParameter("@CurrencyCode", SqlDbType.NVarChar,20),
					new SqlParameter("@CurrencyName", SqlDbType.NVarChar,20),
					new SqlParameter("@OrderID", SqlDbType.Int,4),
					new SqlParameter("@BuyerID", SqlDbType.Int,4)};
            parameters[0].Value = model.OrderDate;
            parameters[1].Value = model.UserName;
            parameters[2].Value = model.Email;
            parameters[3].Value = model.Remark;
            parameters[4].Value = model.Amount;
            parameters[5].Value = model.Status;
            parameters[6].Value = model.SellerID;
            parameters[7].Value = model.PaymentTypeId;
            parameters[8].Value = model.GatewayOrderId;
            parameters[9].Value = model.PaymentType;
            parameters[10].Value = model.CurrencyCode;
            parameters[11].Value = model.CurrencyName;
            parameters[12].Value = model.OrderID;
            parameters[13].Value = model.BuyerID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int OrderID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Tao_Orders ");
            strSql.Append(" where OrderID=@OrderID");
            SqlParameter[] parameters = {
					new SqlParameter("@OrderID", SqlDbType.Int,4)
};
            parameters[0].Value = OrderID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int BuyerID, int OrderID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Tao_Orders ");
            strSql.Append(" where BuyerID=@BuyerID and OrderID=@OrderID ");
            SqlParameter[] parameters = {
					new SqlParameter("@BuyerID", SqlDbType.Int,4),
					new SqlParameter("@OrderID", SqlDbType.Int,4)};
            parameters[0].Value = BuyerID;
            parameters[1].Value = OrderID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string OrderIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Tao_Orders ");
            strSql.Append(" where OrderID in (" + OrderIDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Maticsoft.Model.Tao.Orders GetModel(int OrderID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 OrderID,OrderDate,BuyerID,UserName,Email,Remark,Amount,Status,SellerID,PaymentTypeId,GatewayOrderId,PaymentType,CurrencyCode,CurrencyName from Tao_Orders ");
            strSql.Append(" where OrderID=@OrderID");
            SqlParameter[] parameters = {
					new SqlParameter("@OrderID", SqlDbType.Int,4)
};
            parameters[0].Value = OrderID;

            Maticsoft.Model.Tao.Orders model = new Maticsoft.Model.Tao.Orders();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["OrderID"] != null && ds.Tables[0].Rows[0]["OrderID"].ToString() != "")
                {
                    model.OrderID = int.Parse(ds.Tables[0].Rows[0]["OrderID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["OrderDate"] != null && ds.Tables[0].Rows[0]["OrderDate"].ToString() != "")
                {
                    model.OrderDate = DateTime.Parse(ds.Tables[0].Rows[0]["OrderDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BuyerID"] != null && ds.Tables[0].Rows[0]["BuyerID"].ToString() != "")
                {
                    model.BuyerID = int.Parse(ds.Tables[0].Rows[0]["BuyerID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UserName"] != null && ds.Tables[0].Rows[0]["UserName"].ToString() != "")
                {
                    model.UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Email"] != null && ds.Tables[0].Rows[0]["Email"].ToString() != "")
                {
                    model.Email = ds.Tables[0].Rows[0]["Email"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Remark"] != null && ds.Tables[0].Rows[0]["Remark"].ToString() != "")
                {
                    model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Amount"] != null && ds.Tables[0].Rows[0]["Amount"].ToString() != "")
                {
                    model.Amount = decimal.Parse(ds.Tables[0].Rows[0]["Amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Status"] != null && ds.Tables[0].Rows[0]["Status"].ToString() != "")
                {
                    model.Status = int.Parse(ds.Tables[0].Rows[0]["Status"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SellerID"] != null && ds.Tables[0].Rows[0]["SellerID"].ToString() != "")
                {
                    model.SellerID = int.Parse(ds.Tables[0].Rows[0]["SellerID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PaymentTypeId"] != null && ds.Tables[0].Rows[0]["PaymentTypeId"].ToString() != "")
                {
                    model.PaymentTypeId = int.Parse(ds.Tables[0].Rows[0]["PaymentTypeId"].ToString());
                }
                if (ds.Tables[0].Rows[0]["GatewayOrderId"] != null && ds.Tables[0].Rows[0]["GatewayOrderId"].ToString() != "")
                {
                    model.GatewayOrderId = ds.Tables[0].Rows[0]["GatewayOrderId"].ToString();
                }
                if (ds.Tables[0].Rows[0]["PaymentType"] != null && ds.Tables[0].Rows[0]["PaymentType"].ToString() != "")
                {
                    model.PaymentType = ds.Tables[0].Rows[0]["PaymentType"].ToString();
                }
                if (ds.Tables[0].Rows[0]["CurrencyCode"] != null && ds.Tables[0].Rows[0]["CurrencyCode"].ToString() != "")
                {
                    model.CurrencyCode = ds.Tables[0].Rows[0]["CurrencyCode"].ToString();
                }
                if (ds.Tables[0].Rows[0]["CurrencyName"] != null && ds.Tables[0].Rows[0]["CurrencyName"].ToString() != "")
                {
                    model.CurrencyName = ds.Tables[0].Rows[0]["CurrencyName"].ToString();
                }
                return model;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select OrderID,OrderDate,BuyerID,UserName,Email,Remark,Amount,Status,SellerID,PaymentTypeId,GatewayOrderId,PaymentType,CurrencyCode,CurrencyName ");
            strSql.Append(" FROM Tao_Orders ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" OrderID,OrderDate,BuyerID,UserName,Email,Remark,Amount,Status,SellerID,PaymentTypeId,GatewayOrderId,PaymentType,CurrencyCode,CurrencyName ");
            strSql.Append(" FROM Tao_Orders ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "Tao_Orders";
            parameters[1].Value = "OrderID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion Method
    }
}