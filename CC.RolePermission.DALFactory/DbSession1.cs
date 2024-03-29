﻿ 

using CC.RolePermission.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CC.RolePermission.DALFactory;
using CC.RolePermission.EFDAL;

namespace CC.RolePermission.DALFactory
{
    public  partial class DbSession:IDbSession
    {
   
	 
 public  IActionInfoDal ActionInfoDal
        {
            get {
                return StaticDalFactory.GetActionInfoDal();
            }
        }
	 
 public  IOrderInfoDal OrderInfoDal
        {
            get {
                return StaticDalFactory.GetOrderInfoDal();
            }
        }
	 
 public  IR_UserInfo_ActionInfoDal R_UserInfo_ActionInfoDal
        {
            get {
                return StaticDalFactory.GetR_UserInfo_ActionInfoDal();
            }
        }
	 
 public  IRoleInfoDal RoleInfoDal
        {
            get {
                return StaticDalFactory.GetRoleInfoDal();
            }
        }
	 
 public  IUserInfoDal UserInfoDal
        {
            get {
                return StaticDalFactory.GetUserInfoDal();
            }
        }
	 
 public  IUserInfoExtDal UserInfoExtDal
        {
            get {
                return StaticDalFactory.GetUserInfoExtDal();
            }
        }
	}
}