using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgram
{
    public interface IFileReader
    {
        string ReadFile(string fileName);
    }

    public class FileReader : IFileReader
    {
        public string ReadFile(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
