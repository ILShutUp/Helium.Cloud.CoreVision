using Helium.Tools;
using System;
using System.ComponentModel.DataAnnotations;

namespace Helium.Data.Entity.File.Entity
{
    //控制中心
    public class ControlCenter : EntityBaseClass<int>
    {
        //名称
        [Required]
        public string Name { get; set; }
        //负责人
        public string Keeper { get; set; }
        //电话
        public string Mobile { get; set; }
        //级别
        [Required]
        public virtual CenterLevel CenterLevel { get; set; }
    }

    //控制中心级别
    public class CenterLevel : EntityBaseClass<int>
    {
        //名称
        [Required]
        public string Name { get; set; }
    }

    //中心从属关系
    public class CenterManage : EntityBaseClass<Guid>
    {
        //上级机构
        [Required]
        public virtual ControlCenter HCenter { get; set; }

        //下属机构
        [Required]
        public virtual ControlCenter LCenter { get; set; }
    }

}
