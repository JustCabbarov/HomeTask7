﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMETASK11_
{
    public interface IAccount
    {
        public bool PasswordChecker(string password);

        public void ShowInfo();
    }
}
