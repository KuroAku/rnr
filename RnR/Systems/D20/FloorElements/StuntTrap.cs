﻿using System;
using RnR.Systems.D20.Base.Actors;
using RnR.Systems.D20.Base.FloorElements;
using RnR.Systems.D20.Effects;

namespace RnR.Systems.D20.FloorElements
{
	public class StuntTrap : AbstractEffectTrap
	{
		public StuntTrap (int rate) 
			: base (SkillType.DETECT_MAGIC, new StuntEffect(null), rate)
		{
		}

		protected override GameActor ApplyEffect (GameActor target)
		{
			Effect.Target = target;
			return Effect;
		}
	}
}
