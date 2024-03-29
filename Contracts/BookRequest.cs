﻿namespace LectionServer.Contracts;

public record BookRequest
{
    public string? ImageUrl { get; set;}
    public required string Author { get; init; }
    public required string Name { get; init; }
}