using System;
using System.Collections.Generic;

using SimpleLegends.Components;
using SimpleLegends.Components.General_Components;
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

namespace SimpleLegends.Entities.General_Entities.Player_Entities
{
    public class Character : ActiveEntity
    {
        Hitbox CharacterHitbox;

        bool isMoveble;

        Rating BaseStrengh;


        public Character (GameTexture CharacterTexture, Position StartCaracterPosition,int BaseRating, bool IsClickable, bool isInCameraWorld) : base(IsClickable, isInCameraWorld)
        {
            GamePosition = new Position(StartCaracterPosition.Location.X, StartCaracterPosition.Location.Y);

            Graphic = new Sprite(CharacterTexture, GamePosition, 1.0f);

            BaseStrengh = new Rating(BaseRating);

            ActiveEntityDrawManager.AddToRenderQueue(this);
        }

        public override void Update(GameTime gameTime)
        {
            CharacterHitbox = HitboxUpdater.UpdateHitbox(GamePosition, 32, 32, this.InCameraWorld);

            bool Click = ClickSystem.IsClickedOn(CharacterHitbox, this.InCameraWorld);

            if (Click)
            {
                Graphic.GraphicColor = Color.Black;
            }

            PlaceGraphic(1, 5);
        }
    }
}