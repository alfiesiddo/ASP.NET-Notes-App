using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using NotesApp.Models;

public class NotesContext : DbContext
{
    public NotesContext(DbContextOptions<NotesContext> options) : base(options)
    {
    }

    public DbSet<Note> Notes { get; set; } // Represents the Notes table
}
