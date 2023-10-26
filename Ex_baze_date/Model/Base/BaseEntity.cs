using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ex_baze_date.Model.Base
{
    public class BaseEntity : IBaseEntity
    {
        [Key]
        ///generates a value when a row is inserted
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        ///[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        ///


        public Guid Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? DateTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? LastModified { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
