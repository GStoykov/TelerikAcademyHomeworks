using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public interface ICommentable
    {
        List<string> Comments { get;  }
        void AddComment(string comment);
        void RemoveComment(string comment);
    }
}
