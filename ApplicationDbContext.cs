namespace Zad_6;
// Импорт пространства имен Entity Framework Core, которое предоставляет функциональность ORM (Object-Relational Mapping).
using Microsoft.EntityFrameworkCore;

// Определение класса ApplicationDbContext, который является производным от DbContext.
public class ApplicationDbContext : DbContext
{
    // Объявление свойства DbSet<Animal>, которое представляет коллекцию сущностей Animal в контексте базы данных.
    // Entity Framework Core будет использовать этот DbSet для выполнения операций с таблицей Animals в базе данных.
    public DbSet<Animal> Animals { get; set; }

    // Конструктор класса ApplicationDbContext. Он принимает объект DbContextOptions<ApplicationDbContext>,
    // который содержит конфигурацию для контекста, такую как строка подключения и другие параметры базы данных.
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        // Вызов базового конструктора класса DbContext с предоставленными настройками.
    }
}
