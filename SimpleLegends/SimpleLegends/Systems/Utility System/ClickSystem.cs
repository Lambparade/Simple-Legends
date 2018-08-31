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

        //MouseStates for each system. Must be different for each system to work in combination with each other
        private MouseState IsClickedOldMouseState;
        private MouseState IsClickedToggledOldMouseState;
        private MouseState IsInFocusOldMouseState;
        private MouseState IsHoveredOldMouseState;

        public ClickSystem()
        {

        }
        public bool IsClickedOn(Hitbox EntityHitbox, bool InCamWorld)
        {
            MouseState currentMousestate = Mouse.GetState();

            bool Clicked = false;

            if (currentMousestate.LeftButton == ButtonState.Pressed && IsClickedOldMouseState.LeftButton == ButtonState.Released)
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

            IsClickedOldMouseState = currentMousestate;

            return Clicked;
        }
        public bool IsClickedOnToggle(Hitbox EntityHitbox, bool InCamWorld, bool WasClicked)
        {
            MouseState currentMousestate = Mouse.GetState();

            bool Clicked = WasClicked;

            if (currentMousestate.LeftButton == ButtonState.Pressed && IsClickedToggledOldMouseState.LeftButton == ButtonState.Released)
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
                    if (WasClicked == true)
                    {
                        Clicked = false;
                    }
                    else
                    {
                        Clicked = true;
                    }
                }
            }

            IsClickedToggledOldMouseState = currentMousestate;

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

            IsHoveredOldMouseState = currentMousestate;

            return HoveredOver;
        }

        public bool IsInFocus(Hitbox EntityHitbox, bool InCamWorld, bool IsCurrentlyFocused)
        {
            MouseState currentMousestate = Mouse.GetState();

            bool inFocus = IsCurrentlyFocused;

            if (currentMousestate.LeftButton == ButtonState.Pressed && IsInFocusOldMouseState.LeftButton == ButtonState.Released)
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
                    inFocus = true;
                }
                else
                {
                    if (IsCurrentlyFocused == true)
                    {
                        inFocus = false;
                    }
                }
            }

            IsInFocusOldMouseState = currentMousestate;

            return inFocus;
        }
    }
}