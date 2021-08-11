using System.Collections.Generic;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public interface INoteRepo
    {
        IEnumerable<Note> GetNotesByIncomeId(int userId, int incomeId);
        Note GetNoteById(int id);
        void AddNote(Note newNote);
    }
}