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
    public static class EntityUpdater
    {
        public static List<Entity> Entities = new List<Entity>();

        public static void AddToEntityUpdater(Entity EntitytoAdd)
        {
            Entities.Add(EntitytoAdd);
        }

        public static void Update(GameTime gameTime)
        {
            foreach (ActiveEntity e in Entities)
            {
                e.Update(gameTime);
            }
        }
    }
}