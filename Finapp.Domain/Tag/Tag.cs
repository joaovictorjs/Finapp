using System;

namespace Finapp.Domain.Tag;

public class Tag
{
    public Guid Id { get; private set; }
    public Description Description { get; private set; }
    public DateTime CreatedAt { get; private set; }

    public Tag(Description description)
    {
        Id = Guid.NewGuid();
        Description =
            description
            ?? throw new ArgumentNullException(
                nameof(description),
                "Description can not be null or empty."
            );
        CreatedAt = DateTime.UtcNow;
    }

    // EF ctor
    private Tag() { }
}
