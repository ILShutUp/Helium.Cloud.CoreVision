using Helium.Tools;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Helium.Data.Entity.File.Entity
{
    /// <summary>
    ///     维保单位
    /// </summary>
    /// 
    [Description("维保单位信息")]
    public class MaintenanceUnit : EntityBaseClass<int>
    {
        //名称
        [Required]
        public string Name { get; set; }

        //联系人        
        public string Contact { get; set; }

        //联系人电话        
        public string ContactTel { get; set; }
    }
}
