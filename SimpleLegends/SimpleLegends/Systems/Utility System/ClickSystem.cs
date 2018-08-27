using System;
using System.Collections.Generic;

using SimpleLegends.Components;
using SimpleLegends.Components.General_Components.SubComponents;
using SimpleLegends.Entities.General_Entities;
using SimpleLegends.Systems.Content_System;
using SimpleLegends.Systems.Entity_System;
using SimpleLegends.Systems.Render_System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SimpleLegends.Systems.Utility_System
{
    public class ClickSystem
    {
        private static int HitboxWidth = 1;
        private static int HitboxHeight = 1;
        private MouseState OldMouseState;

        public ClickSystem()
        {

        }
        public bool IsClickedOn(Hitbox EntityHitbox, bool InCamWorld)
        {
            MouseState currentMousestate = Mouse.GetState();

            bool Clicked = false;

            if (currentMousestate.LeftButton == ButtonState.Pressed && OldMouseState.LeftButton == ButtonState.Released)
            {
                Vector2 MousePosition;

                if (InCamWorld)
                {
                    //Apply Mouse Camera Transform
                    MousePosition = Vector2.Transform(new Vector2(currentMousestate.X, currentMousestate.Y), Matrix.Invert(CameraSystem.CameraTransform));
                }
                else
                {
                    MousePosition = new Vector2(currentMousestate.X, currentMousestate.Y);
                }

                Hitbox MouseHitbox = new Hitbox(new Rectangle((int)MousePosition.X, currentMousestate.Y, HitboxWidth, HitboxHeight));

                if (EntityHitbox.Bounds.Intersects(MouseHitbox.Bounds))
                {
                    Clicked = true;
                }
            }

            OldMouseState = currentMousestate;

            return Clicked;
        }

        public bool IsHoveredOver(Hitbox EntityHitbox, bool InCamWorld)
        {
            MouseState currentMousestate = Mouse.GetState();

            bool HoveredOver = false;

            Vector2 MousePosition;

            if (InCamWorld)
            {
                //Apply Mouse Camera Transform
                MousePosition = Vector2.Transform(new Vector2(currentMousestate.X, currentMousestate.Y), Matrix.Invert(CameraSystem.CameraTransform));
            }
            else
            {
                MousePosition = new Vector2(currentMousestate.X, currentMousestate.Y);
            }

            Hitbox MouseHitbox = new Hitbox(new Rectangle((int)MousePosition.X, currentMousestate.Y, HitboxWidth, HitboxHeight));

            if (EntityHitbox.Bounds.Intersects(MouseHitbox.Bounds))
            {
                HoveredOver = true;
            }

            OldMouseState = currentMousestate;

            return HoveredOver;
        }
    }
}