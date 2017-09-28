using System;

namespace ConsoleApplication12
{
    internal class TextFieldParser
    {
        internal string[] CommentTokens;
        internal bool EndOfData;
        private string path;

        public TextFieldParser(string path)
        {
            this.path = path;
        }

        public bool HasFieldsEnclosedInQuotes { get; internal set; }
        public object TextFieldType { get; internal set; }

        internal void ReadLine()
        {
            throw new NotImplementedException();
        }

        internal void SetDelimiters(string[] v)
        {
            throw new NotImplementedException();
        }

        internal string[] ReadFields()
        {
            throw new NotImplementedException();
        }

        internal void SetDelimiters(string v)
        {
            throw new NotImplementedException();
        }
    }
}