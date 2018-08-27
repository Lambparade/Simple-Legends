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
    public class BasicButton : ActiveEntity
    {
        Hitbox ButtonHitbox;

        public bool IsClicked;

        public BasicButton(GameTexture ButtonTexture, Position ButtonPosition, bool IsClickable, bool isInCameraWorld) : base (IsClickable, isInCameraWorld)
        {
            IsClicked = false;
            
            GamePosition = new Position (ButtonPosition.Location.X, ButtonPosition.Location.Y);

            Graphic = new Sprite (ButtonTexture, GamePosition, 1.0f);

            ActiveEntityDrawManager.AddToRenderQueue(this);
        }

        public override void Update(GameTime GameTime)
        {
            ButtonHitbox = HitboxUpdater.UpdateHitbox(GamePosition,32,32,this.InCameraWorld);

            IsClicked = ClickSystem.IsClickedOn(ButtonHitbox,this.InCameraWorld);

            if(IsClicked){
                Graphic.GraphicColor = new Color(Color.OrangeRed,255);
            }
        }
    }
}