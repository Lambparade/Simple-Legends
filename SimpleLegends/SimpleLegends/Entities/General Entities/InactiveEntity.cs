using System;
using System.Collections.Generic;

using SimpleLegends.Components;
using SimpleLegends.Entities;
using SimpleLegends.Entities.General_Entities;

using SimpleLegends.Systems.Content_System;
using SimpleLegends.Systems.Render_System;
using SimpleLegends.Systems.Entity_System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SimpleLegends.Entities.General_Entities
{
    public abstract class InActiveEntity : Entity
    {
        public abstract Sprite Graphic {get;set;}

        public Position GamePosition;

        public InActiveEntity()
        {
            //EntityUpdater.AddToEntityUpdater(this);
        }
    }
}