﻿//===============================================================================================================
// System  : Visual Studio Spell Checker Definitions
// File    : IMisspellingTag.cs
// Author  : Noah Richards, Roman Golovin, Michael Lehenbauer
// Updated : 04/14/2013
// Note    : Copyright 2010-2013, Microsoft Corporation, All rights reserved
// Compiler: Microsoft Visual C#
//
// This file contains a class used to implement a misspelling tag
//
// This code is published under the Microsoft Public License (Ms-PL).  A copy of the license should be
// distributed with the code.  It can also be found at the project website: http://VSSpellChecker.CodePlex.com.
// This notice, the author's name, and all copyright notices must remain intact in all applications,
// documentation, and source files.
//
// Version     Date     Who  Comments
//===============================================================================================================
// 1.0.0.0  04/14/2013  EFW  Imported the code into the project
//===============================================================================================================

using System.Collections.Generic;

using Microsoft.VisualStudio.Text.Tagging;

namespace VisualStudio.SpellChecker.Definitions
{
    /// <summary>
    /// This is used to implement a misspelling tag
    /// </summary>
    public interface IMisspellingTag : ITag
    {
        /// <summary>
        /// Returns an enumerable list of suggestions for the misspelling
        /// </summary>
        IEnumerable<string> Suggestions { get; }
    }
}