﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC.RolePermission.IDAL
{
    public partial interface IDbSession
    {
        //IUserInfoDal UserInfoDal
        //{
        //    get;
        //}
        //IOrderInfoDal OrderInfoDal
        //{
        //    get;
        //}
        int SaveChanges();

    }
}
