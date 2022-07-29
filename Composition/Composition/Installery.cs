using System;
using System.Collections.Generic;
using System.Text;

namespace Composition
{
    public class Installery
    {
        private Logger _logger;

        public Installery(Logger logger)
        {
            _logger = logger;
        }

        public void Install()
        {
            _logger.Log("We are installing application");
        }
    }
}
