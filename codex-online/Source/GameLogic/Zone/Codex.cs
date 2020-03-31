﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codex_online
{
    public class Codex : Zone
    {
        public Codex(string name) : base(name)
        {
            Cards = new HashSet<Card>();
        }

        public override ICollection<Card> GetCardsCopy()
        {
            return new HashSet<Card>(Cards);
        }
    }
}
