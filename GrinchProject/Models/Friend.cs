using System;
using System.Collections.Generic;

namespace GrinchProject.Models;

public partial class Friend
{
    public int Id { get; set; }

    public int FriendCharacterId { get; set; }

    public int CharacterId { get; set; }

    public virtual Character Character { get; set; } = null!;

    public virtual Character FriendCharacter { get; set; } = null!;
}
