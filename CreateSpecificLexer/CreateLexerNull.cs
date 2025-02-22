﻿#region License
/*
MIT License

Copyright(c) 2019 Petteri Kautonen

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
#endregion

using ScintillaNET;

namespace VPKSoft.ScintillaLexers.CreateSpecificLexer
{
    /// <summary>
    /// A class for plain text.
    /// Implements the <see cref="VPKSoft.ScintillaLexers.CreateSpecificLexer.CreateLexerCommon" />
    /// </summary>
    /// <seealso cref="VPKSoft.ScintillaLexers.CreateSpecificLexer.CreateLexerCommon" />
    class CreateLexerNull: CreateLexerCommon
    {
        /// <summary>
        /// Creates the lexer for a given Scintilla class instance for a plain text file.
        /// </summary>
        /// <param name="scintilla">A Scintilla class instance to set the lexer style for.</param>
        /// <returns>True if the operation was successful; otherwise false.</returns>
        public static bool CreateNullLexer(Scintilla scintilla)
        {
            ClearStyle(scintilla);

            scintilla.Lexer = Lexer.Null;
            return true;
        }
    }
}
