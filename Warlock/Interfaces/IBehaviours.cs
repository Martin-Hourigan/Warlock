using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warlock.Core;
using Warlock.Systems;

namespace Warlock.Interfaces
{
    public interface IBehaviour
    {
        bool Act(Monster monster, CommandSystem commandSystem);
    }
}
