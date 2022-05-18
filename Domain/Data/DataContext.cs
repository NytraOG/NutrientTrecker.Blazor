﻿using Microsoft.EntityFrameworkCore;

namespace Domain.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
}