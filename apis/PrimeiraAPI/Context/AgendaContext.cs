using Microsoft.EntityFrameworkCore;
using PrimeiraAPI.Entities;

namespace PrimeiraAPI.Context;
public class AgendaContext(DbContextOptions<AgendaContext> options) : DbContext(options)
{
    public DbSet<Contato> Contatos { get; set; }
}