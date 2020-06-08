using Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.BackgroundModels
{
    public class BackgroundUpdateModel : EntityUpdateModel
    {
        public string UpdatedDescription { get; set; }
    }
}
