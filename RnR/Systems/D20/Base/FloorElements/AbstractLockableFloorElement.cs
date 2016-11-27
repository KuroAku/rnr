﻿using System;
using RnR.Systems.D20.Base.Actors;

namespace RnR.Systems.D20.Base.FloorElements
{
	public abstract class AbstractLockableFloorElement : Lockable
	{
		bool locked;
		int challengeRate;

		public AbstractLockableFloorElement (int challengeRate)
		{
			this.challengeRate = challengeRate;
			Lock ();
		}

		public bool IsLocked {
			get {
				return locked;
			}
		}

		public bool CanParticipate (Challenger challenger)
		{
			return true;
		}

		public void ContestFinished (Challenger challenger, bool challengerWon)
		{
			if (challengerWon)
				UnLock ();
		}

		public int GetChallengeRate ()
		{
			return challengeRate;
		}

		public SkillType GetSkill ()
		{
			return SkillType.PINLOCK;
		}

		public void Lock ()
		{
			locked = true;
		}

		public void UnLock ()
		{
			locked = false;
		}
	}
}
