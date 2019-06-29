﻿using System;
using System.Collections.Generic;
using System.Text;
using Marketplace.Framework;

namespace Marketplace.Domain
{
    public class UserId: Value<UserId>
    {
        private readonly Guid _value;

        public UserId(Guid value) => _value = value;
    }
}
