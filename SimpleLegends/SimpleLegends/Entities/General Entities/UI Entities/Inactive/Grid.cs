using SimpleLegends.Components;
using SimpleLegends.Components.General_Components.SubComponents;
using SimpleLegends.Entities.General_Entities;

using SimpleLegends.Systems.Content_System;
using SimpleLegends.Systems.Entity_System;
using SimpleLegends.Systems.Render_System;
using SimpleLegends.Systems.Utility_System;

using SimpleLegends.Managers.Graphics_Managers;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SimpleLegends.Entities.General_Entities.UI_Entities
{
    public class Grid : InActiveEntity
    {

        public Grid(GameTexture GridTexture, Position GridPosition, bool isInCameraWorld) : base(isInCameraWorld)
        {
            GamePosition = new Position(GridPosition.Location.X, GridPosition.Location.Y);

            Graphic = new Sprite(GridTexture, GamePosition, 1.0f);

            InActiveEntityDrawManager.AddToRenderQueue(this);
        }
    }
}