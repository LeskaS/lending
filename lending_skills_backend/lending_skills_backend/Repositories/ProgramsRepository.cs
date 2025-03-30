using lending_skills_backend.DataAccess;
using lending_skills_backend.Models;
using Microsoft.EntityFrameworkCore;

public class ProgramsRepository
{
    private readonly ApplicationDbContext _context;

    public ProgramsRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<DbProgram>> GetProgramsAsync()
    {
        return await _context.Programs.ToListAsync();
    }
}