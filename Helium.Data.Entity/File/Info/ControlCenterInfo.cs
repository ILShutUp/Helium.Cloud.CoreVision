using System;

namespace Helium.Data.Entity.File.Info
{
    public class ControlCenterInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }        
        public string Keeper { get; set; }       
        public string Mobile { get; set; }        
        public int CenterLevelId  { get; set; }
    }

    public class CenterLevelInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class CenterManageInfo
    {
        public Guid Id { get; set; }
        public int HCenterId { get; set; }
        public int LCenterId { get; set; }
    }
}
