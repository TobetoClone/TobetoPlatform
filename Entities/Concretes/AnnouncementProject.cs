﻿using Core.Entities;

namespace Entities.Concretes;

public class AnnouncementProject : Entity<Guid>
{
    public Guid AnnouncementId { get; set; }
    public Guid ProjectId { get; set; }
}
