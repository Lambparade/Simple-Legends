using System;
using System.Collections.Generic;

using SimpleLegends.Components;
using SimpleLegends.Entities;
using SimpleLegends.Entities.General_Entities;

using SimpleLegends.Systems.Content_System;
using SimpleLegends.Systems.Render_System;
using SimpleLegends.Systems.Entity_System;
using SimpleLegends.Systems.Utility_System;

using SimpleLegends.Managers.Graphics_Managers;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SimpleLegends.Entities.General_Entities
{
    public abstract class InActiveEntity : Entity
    {
        public Sprite Graphic;

        public Position GamePosition;

        public bool InCameraWorld;

        protected ClickSystem ClickSystem = new ClickSystem();

        public InActiveEntity(bool isInCameraWorld)
        {
            InCameraWorld = isInCameraWorld;
        }
    }
}