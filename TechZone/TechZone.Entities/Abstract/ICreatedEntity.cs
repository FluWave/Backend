using System;

namespace TechZone.Entities.Abstract;

public interface ICreatedEntity
{
    public int CreatedUserId { get; set; }
    public DateTime CreatedDate { get; set; }

    

}
