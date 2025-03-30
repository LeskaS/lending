using lending_skills_backend.DataAccess;
using lending_skills_backend.Models;

public class ProfessorsRepository
{
    private readonly ApplicationDbContext _context;

    public ProfessorsRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<DbProfessor>> GetProfessorsAsync()
    {
        return await _context.Professors.ToListAsync();
    }
}
