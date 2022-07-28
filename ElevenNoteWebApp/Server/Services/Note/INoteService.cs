﻿using System;
using ElevenNoteWebApp.Shared.Models;

namespace ElevenNoteWebApp.Server.Services.Note
{
    public interface INoteService
    {
        Task<IEnumerable<NoteListItem>> GetAllNotesAsync();
        Task<bool> CreateNoteAsync(NoteCreate model);
        Task<NoteDetail> GetNoteByIdAsync(int noteId);
        Task<bool> UpdateNoteAsync(NoteEdit model);
        Task<bool> DeleteNoteAsync(int noteId);
        Task<bool> DeleteNoteAsync(string userId);
        void SetUserId(string userId);
    }
}

