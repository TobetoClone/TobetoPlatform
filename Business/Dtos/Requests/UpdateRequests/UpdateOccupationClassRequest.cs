﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.UpdateRequests
{
    public class UpdateOccupationClassRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
