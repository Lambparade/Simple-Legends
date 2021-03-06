using System;
using System.Collections.Generic;

using SimpleLegends.Components;
using SimpleLegends.Entities.General_Entities;
using SimpleLegends.Systems.Render_System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SimpleLegends.Managers.Graphics_Managers
{
    public static class ActiveEntityDrawManager
    {
        static List<ActiveEntity> EntitiesToManage = new List<ActiveEntity>();

        public static void AddToRenderQueue(ActiveEntity EntityToRender)
        {
                EntitiesToManage.Add(EntityToRender);
        }

        public static void SendToRenderSystem()
        {
            foreach (ActiveEntity s in EntitiesToManage)
            {
                if (s.InCameraWorld)
                {
                    RenderSprites.AddToLayer(RenderSprites.CameraLayer1, s.Graphic);
                }
                else
                {
                    RenderSprites.AddToLayer(RenderSprites.HudLayer1, s.Graphic);
                }
            }
        }
    }
}