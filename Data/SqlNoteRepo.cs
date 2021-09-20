using System.Collections.Generic;
using System.Linq;
using ChaosEmeraldsOfIncome.Models;

namespace ChaosEmeraldsOfIncome.Data
{
    public class SqlNoteRepo : INoteRepo
    {
        private readonly CEOIContext _context;

        public SqlNoteRepo(CEOIContext context)
        {
            _context = context;
        }
        public void AddNote(Note newNote)
        {
            throw new System.NotImplementedException();
        }

        public Note GetNoteById(int id)
        {
            return _context.Notes.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Note> GetNotesByIncomeId(int userId, int incomeId)
        {
            return _context.Notes.Where(p => p.UserId == userId);
        }
    }
}