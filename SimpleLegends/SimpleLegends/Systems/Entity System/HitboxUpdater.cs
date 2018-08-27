using System;
using System.Collections.Generic;

using SimpleLegends.Components;
using SimpleLegends.Entities;
using SimpleLegends.Entities.General_Entities;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SimpleLegends.Systems.Entity_System
{
    static public class HitboxUpdater
    {
        public static Hitbox UpdateHitbox (Position EntityPosition, int HitboxWidth, int HitboxHeight,bool InCamWorld)
        {
            Hitbox UpdatedHitbox = new Hitbox (new Rectangle ((int) EntityPosition.Location.X, (int) EntityPosition.Location.Y, HitboxWidth, HitboxHeight));

            return UpdatedHitbox;
        }
    }
}