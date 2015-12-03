﻿namespace Relink.Entities
{
	public class Gateway
	{
		public Gateway(string name)
		{
			this.Name = name;
		}

		public string Name { get; set; }

		public override string ToString()
		{
			return this.Name;
		}
	}
}