﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Galaga
{
    class Enemy
    {
        public Rectangle pos;
        public Rectangle spritePos;
        public int health;
        public int value;
        public bool alive;

        public Enemy(Rectangle p, Rectangle sp)
        {
            pos = p;
            spritePos = sp;
            health = 1;
            alive = true;
            if (spritePos.Y == 172)
                value = 100;
            if (spritePos.Y == 152)
                value = 50;
        }
    }
}