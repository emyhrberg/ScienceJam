﻿using Sunflowerology.Content.Tiles.SunflowerStagesOfGrowth;
using Terraria.ID;

namespace Sunflowerology.Content.Tiles.Sunflower
{
    internal class SporeflowerTile : FlowerTile
    {
        public override int RangeOfEffectInTiles => 20;

        public override int EffectBuffID => BuffID.TikiSpirit;

        public override int EffectDuration => 30;

        protected override TypeOfSunflower TypeOfSunflower => TypeOfSunflower.Sporeflower;
    }
}