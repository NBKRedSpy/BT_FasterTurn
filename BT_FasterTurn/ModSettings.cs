using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_FasterTurn
{
    public class ModSettings
    {

    /// <summary>
    /// The number of seconds to delay the start of turn banner.
    /// The game default is 1.5 seconds
    /// </summary>
    public float StartTurnDelaySeconds { get; set; } = .1f;

    }
}
