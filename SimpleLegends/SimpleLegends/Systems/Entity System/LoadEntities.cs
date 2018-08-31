using System;
using System.Collections.Generic;

using SimpleLegends.Components;

using SimpleLegends.Systems.Content_System;

using SimpleLegends.Managers.Graphics_Managers;

using SimpleLegends.Entities;
using SimpleLegends.Entities.General_Entities;
using SimpleLegends.Entities.General_Entities.Player_Entities;
using SimpleLegends.Entities.General_Entities.UI_Entities;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SimpleLegends.Systems.Entity_System
{
    public static class LoadEntities
    {
        public static void LoadPlayer()
        {
            Character Player1 = new Character(ContentTexture.RedBlock, new Position(0 ,200),5,true,true);

            BasicButton Button1 = new BasicButton(ContentTexture.BlueBlock,new Position(25,50),true,false);
            BasicButton Button2 = new BasicButton(ContentTexture.BlueBlock,new Position(25,118),true,false);

            ToggleButton ToggleButton = new ToggleButton(ContentTexture.BlueBlock,new Position(25,84),true,false);

            Grid GridEntity = new Grid(ContentTexture.Grid,new Position(512 / 2 - 128,512 /2 - 128),false);
        }

        public static void LoadEntity()
        {

        }
    }
}