using HpsApi.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HpsApi.Domain.Entities;

public class Brand : EntityBase
{
    public Brand()
    {
        
    }
    public Brand(string name)
    {
        Name = name;
    }
    public string Name { get; set; }
}
