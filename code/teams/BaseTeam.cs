﻿using Sandbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiddenGamemode
{
	public abstract class Team : Entity
	{
		protected List<Player> Players { get; set; } = new();

		public Team()
		{
			Transmit = TransmitType.Always;
		}

		public virtual void OnLeave( Player player  ) { }

		public virtual void OnJoin( Player player  ) { }

		public virtual void SupplyLoadout( Player player  ) { }
	}
}
