using System;

namespace Helium.Data.Entity.File.Info
{
    public class AccessUnitInfo
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string  Code { get; set; }

        public string Address { get; set; }

        public string EquipmentModel { get; set; }
    }

    public class AccessUnitDetailInfo
    {
        public Guid Id { get; set; }

        public string Email { get; set; }

        public int DetectorNum { get; set; }

        public string PostalCode { get; set; }

        public int EmpNumber { get; set; }

        public float Area { get; set; }

        public float FloorArea { get; set; }

        public int GroundFloor { get; set; }

        public int UnderGroundFloor { get; set; }

        public int MaintenanceUnitId { get; set; }

        public int ControlCenterId { get; set; }

        public int FireContorlLevelId { get; set; }

        public int PurposeId { get; set; }

        public int StructurecsId { get; set; }

        public int AccessUnitId { get; set; }
    }

    public class ContactInfo
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string IdCode { get; set; }

        public string Tel { get; set; }

        public int ContactLevelId { get; set; }

        public int AccessUnitId { get; set; }
    }
}
