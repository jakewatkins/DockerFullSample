// --------------------------------------------------------------------------------------------------------------------
// <copyright company="" file="SetupDb">
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
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Notebook.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SetupDb
    {
        #region Private fields

        private NoteDbContext _context;
        #endregion

        #region Constructors

        public SetupDb(NoteDbContext ctx)
        {
            _context = ctx;
        }

        #endregion

        #region Private implementation

        #endregion

        #region Properties

        #endregion

        #region Public interface
        public void Setup()
        {
            //make sure everything is ready
            //_context.Database.Migrate();

            //Add a few notes
            //_context.Notes.AddRange(
            //    new Note() {Created = DateTime.Now, NoteText = "Seed noted 1"},
            //    new Note() { Created = DateTime.Now, NoteText = "Seed noted 2" },
            //    new Note() { Created = DateTime.Now, NoteText = "Seed noted 3" },
            //    new Note() { Created = DateTime.Now, NoteText = "Seed noted 4" },
            //    new Note() { Created = DateTime.Now, NoteText = "Seed noted 5" }
            //);
            //_context.SaveChanges();
        }
        #endregion
    }
}