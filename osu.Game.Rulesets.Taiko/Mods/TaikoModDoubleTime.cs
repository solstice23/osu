﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

#nullable disable

using osu.Game.Rulesets.Mods;

namespace osu.Game.Rulesets.Taiko.Mods
{
    public class TaikoModDoubleTime : ModDoubleTime
    {
        public override double ScoreMultiplier => UsesDefaultConfiguration ? 1.12 : 1;
    }
}
