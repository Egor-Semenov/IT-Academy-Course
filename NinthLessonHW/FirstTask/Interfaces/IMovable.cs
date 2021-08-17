using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask.Interfaces
{
    public interface IMovable
    {
        string Name { get; set; }
        int maxSpeed { get; set; }

        void GetCollectionInformation();
        
    }
}
