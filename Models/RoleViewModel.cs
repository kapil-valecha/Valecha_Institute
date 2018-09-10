using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Institute.Models
{
    public class RoleViewModel
    {
        public RoleViewModel() { }

        public RoleViewModel(ApplicationRole role)
        {
            RoleId = role.Id;
            Name = role.Name;
       }
        public string RoleId { get; set; }
        public string Name { get; set; }
    }
}