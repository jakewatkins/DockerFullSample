///***************************************************************************
///     FileName: INoteRepository 
///       Author: Jake Watkins
///      Version: 1.0.0.0
///         Date: 2017-09-05
///
///     Description:
///
///***************************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace Notebook.Model
{
    public interface INoteRepository
    {
        IQueryable<Note> Notes { get; }
        void SaveNote(Note note);
    }
}