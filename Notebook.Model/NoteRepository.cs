﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="" file="NoteRepository">
//  
// </copyright>
// <summary>
//   Date: 2017-09-05
//   The app.
// </summary>
// 
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace Notebook.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NoteRepository : INoteRepository
    {
        #region Private fields
        private NoteDbContext _context;
        #endregion

        #region Constructors
        public NoteRepository(NoteDbContext ctx)
        {
            _context = ctx;
        }
        #endregion

        #region Private implementation
        #endregion

        #region Properties
        public IQueryable<Note> Note => _context.Note;
        #endregion

        #region Public interface

        public void SaveNote(Note note)
        {
            _context.Note.Add(note);
            _context.SaveChanges();
        }
        #endregion
    }
}