using System;

namespace Ecommerce.Domain.Entities
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool Actived { get; set; }
        public bool Deleted { get; set; }
    }
}
