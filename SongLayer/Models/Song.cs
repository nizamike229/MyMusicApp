﻿namespace MyMusicApp.Models;

public partial class Song
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string SongPath { get; set; } = null!;
    public string UserId { get; set; }
    public string CoverEncoded { get; set; } = null!;
}