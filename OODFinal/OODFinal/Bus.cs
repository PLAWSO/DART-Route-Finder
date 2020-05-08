using System;
using System.Collections.Generic;

namespace OODFinal
{
    class Bus
    {
        private readonly Stop startLoc;
        private readonly Route route;

        public Bus(Stop startLoc, Route route)
        {
            this.startLoc = startLoc;
            this.route = route;
        }
    }
}
