﻿

namespace DO;

public record Customer
    (int ID,
    string Name,
    string? Address,
    string? Phone)
{
    public Customer() : this(0, "", null, null)
    {

    }
}
