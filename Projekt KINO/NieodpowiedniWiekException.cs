﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_KINO
{
    [Serializable]
    public class NieodpowiedniWiekException:Exception
    {
        public NieodpowiedniWiekException(string m)
        {
            Console.WriteLine(m);
        }
    }
}
