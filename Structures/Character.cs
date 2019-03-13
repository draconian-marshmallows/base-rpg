﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace DraconianMarshmallows.RpgFramework.Structures
{
    [Serializable] public class Character
    {
        private const int LEVEL_RANGE = 100;

        public enum Class { Mage, Warrior }

        public Class ChosenClass;
        public int Experience;
        public int Health;
        public int Mana;
        public int Stamina;

        public int Level { get => Experience / LEVEL_RANGE; }
    }
}