using System;
using System.Collections.Generic;

using SimpleLegends.Components;
using SimpleLegends.Entities;
using SimpleLegends.Entities.General_Entities;
using SimpleLegends.Systems.Content_System;
using SimpleLegends.Systems.Entity_System;
using SimpleLegends.Systems.Render_System;
using SimpleLegends.Systems.Utility_System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SimpleLegends.Entities.General_Entities
{
    public abstract class ActiveEntity : Entity
    {
        public Sprite Graphic;

        public Position GamePosition;

        public bool Clickable;

        public bool InCameraWorld;

        protected ClickSystem ClickSystem = new ClickSystem();

        public ActiveEntity(bool IsClickable, bool isInCameraWorld)
        {
            Clickable = IsClickable;

            InCameraWorld = isInCameraWorld;

            EntityUpdater.AddToEntityUpdater(this);
        }

        public abstract void Update(GameTime gameTime);

        protected void MoveGraphic(float x, float y)
        {
            GamePosition = new Position(GamePosition.Location.X + x, GamePosition.Location.Y + y);

            Graphic.Position = GamePosition;
        }

        protected void PlaceGraphic(float x, float y)
        {
            GamePosition = new Position(x, y);

            Graphic.Position = GamePosition;
        }
    }
}