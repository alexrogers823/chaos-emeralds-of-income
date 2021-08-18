using System.Collections.Generic;
using ChaosEmeraldsOfIncome.Models;

namespace ChaosEmeraldsOfIncome.Data
{
    public interface INoteRepo
    {
        IEnumerable<Note> GetNotesByIncomeId(int userId, int incomeId);
        Note GetNoteById(int id);
        void AddNote(Note newNote);
    }
}