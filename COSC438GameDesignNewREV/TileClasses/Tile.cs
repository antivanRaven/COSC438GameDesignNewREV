﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Class Layout from tutorial
//https://www.youtube.com/watch?v=PKlHcxFAEk0&list=PL667AC2BF84D85779&index=42
namespace COSC438GameDesignNewREV
{   
    public class Tile
    {
<<<<<<< HEAD:COSC438GameDesignNewREV/TileClasses/Tile.cs
        protected int pixelShow;
=======
        protected String tileType;
>>>>>>> origin/master:COSC438GameDesignNewREV/TileClasses/Tile.cs
        protected int colour;
        protected Game1 game;
        protected Texture2D image;
        protected Rectangle box;
        protected bool active;
        public int Colour
        {
            get
            {
                return colour;
            }
            set
            {
                colour = value;
            }
        }
<<<<<<< HEAD:COSC438GameDesignNewREV/TileClasses/Tile.cs
        public bool Active
        {
            get
            {
                return active;
            }
            set
            {
                active = value;
            }
        }
        public int PixelShow
        {
            get
            {
                return pixelShow;
            }
            set
            {
                pixelShow = value;
=======
        public String TileType
        {
            get
            {
                return tileType;
            }
            set
            {
                tileType = value;
>>>>>>> origin/master:COSC438GameDesignNewREV/TileClasses/Tile.cs
            }
        }
        public Tile(Game1 game)
        {
            this.game = game;
        }
        public Rectangle Box
        {
            get
            {
                return box;
            }
            set
            {
                box = value;
            }
        }
        public Texture2D Image
        {
            get
            {
                return image;
            }
        }
    }
}