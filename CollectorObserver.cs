using System;
using System.Collections.Generic;
using System.Text;

namespace ThisNonsenseMustStop
{
    interface CollectorObserver
    {

        void batch_complete(List<uint> pids);

    }
}
