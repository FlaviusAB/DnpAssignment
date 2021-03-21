using System.Collections.Generic;
using Models;

namespace FileData
{
    public interface IFileContext
    {
        IList<Adult> Adults { get; }
        IList<Family> Families { get; }

        void SaveChanges();
    }
}