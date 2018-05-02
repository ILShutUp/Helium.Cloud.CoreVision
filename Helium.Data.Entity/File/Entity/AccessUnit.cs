using Helium.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Helium.Data.Entity.File.Entity
{

    /// <summary>
    ///     客户信息
    /// </summary>
    [Description("客户信息")]
    public class AccessUnit : EntityBaseClass<int>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        //用户编号
        public string Code { get; set; }

        //消防主机型号
        public string EquipmentModel { get; set; }

        public virtual AccessUnitDetail AccessUnitDetail { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }
    }

    /// <summary>
    ///     客户详细信息
    /// </summary>
    [Description("客户详细信息")]
    public class AccessUnitDetail : EntityBaseClass<Guid>
    {
        public AccessUnitDetail()
        {
            ID = CombHelper.NewComb();
        }

        //电子邮箱
        public string Email { get; set; }

        //探测器数量
        public int DetectorNum { get; set; }

        //邮政编码
        public string PostalCode { get; set; }

        //职工人数
        public int EmpNumber { get; set; }

        //占地面积
        public float Area { get; set; }

        //建筑面积
        public float FloorArea { get; set; }

        //建筑地上层数
        public int GroundFloor { get; set; }

        //建筑地下层数
        public int UnderGroundFloor { get; set; }

        //所属管理机构(消防队OR消防公司)
        public virtual MaintenanceUnit MaintenanceUnit { get; set; }

        //所属控制中心
        public virtual ControlCenter ControlCenter { get; set; }

        //防火等级
        public virtual FireContorlLevel FireContorlLevel { get; set; }

        //建筑用途
        public virtual Purpose Purpose { get; set; }

        //建筑结构
        public virtual Structurecs Structurecs { get; set; }

        public virtual AccessUnit AccessUnit { get; set; }
    }

    /// <summary>
    ///     联系人级别
    /// </summary>
    [Description("联系人级别")]
    public class ContactLevel : EntityBaseClass<int>
    {
        //级别名称
        public string Name { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }
    }

    /// <summary>
    ///     联系人信息
    /// </summary>
    [Description("联系人信息")]
    public class Contact : EntityBaseClass<Guid>
    {
        public Contact()
        {
            ID = CombHelper.NewComb();
        }
        //姓名
        public string Name { get; set; }

        //身份证
        public string IdCode { get; set; }

        //电话号码
        public string Tel { get; set; }

        public virtual ContactLevel ContactLevel { get; set; }

        public virtual AccessUnit AccessUnit { get; set; }
    }

    /// <summary>
    ///     防火等级
    /// </summary>
    [Description("防火等级")]
    public class FireContorlLevel : EntityBaseClass<int>
    {
        public string Name { get; set; }

        public virtual ICollection<AccessUnit> AccessUnits { get; set; }
    }

    /// <summary>
    ///     建筑用途
    /// </summary>
    [Description("建筑用途")]
    public class Purpose : EntityBaseClass<int>
    {
        public string Name { get; set; }
        public virtual ICollection<AccessUnit> AccessUnits { get; set; }
    }

    /// <summary>
    ///     建筑结构
    /// </summary>
    [Description("建筑结构")]
    public class Structurecs : EntityBaseClass<int>
    {
        public string Name { get; set; }
        public virtual ICollection<AccessUnit> AccessUnits { get; set; }
    }
}
