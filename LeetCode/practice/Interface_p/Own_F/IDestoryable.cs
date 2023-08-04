using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.practice.Interface_p.Own_F
{
    internal interface IDestoryable
    {
        string DestructionSound { get; set; }

        void Destory();
    }
}
