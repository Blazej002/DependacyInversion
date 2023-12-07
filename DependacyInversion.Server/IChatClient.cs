using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependacyInversion.Server
{
    public interface IChatClient
    {
        void Receive(string message);
    }
}
