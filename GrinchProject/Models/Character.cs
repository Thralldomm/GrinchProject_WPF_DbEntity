using System;
using System.Collections.Generic;

namespace GrinchProject.Models;

public partial class Character
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Photo { get; set; } = null!;

    public int PlaceId { get; set; }

    public virtual ICollection<Friend> FriendCharacters { get; } = new List<Friend>();

    public virtual ICollection<Friend> FriendFriendCharacters { get; } = new List<Friend>();

    public virtual Place Place { get; set; } = null!;
}
