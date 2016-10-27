﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Assets.Scripts
{
    public class Campaign
    {
        private List<Hero> listParty;
        private List<Spell> listActiveSpells;
        private Dictionary<String, List<TextMessage>> dictChatLog;
        public Time currentTime;
        bool bInEncounter;
        public List<Dungeon> listDungeons;
        public Dungeon currentDungeon;
    }
}
