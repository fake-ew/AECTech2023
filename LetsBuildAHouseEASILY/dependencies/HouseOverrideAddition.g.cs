using Elements;
using System.Collections.Generic;
using System;
using System.Linq;

namespace LetsBuildAHouseEASILY
{
	/// <summary>
	/// Override metadata for HouseOverrideAddition
	/// </summary>
	public partial class HouseOverrideAddition : IOverride
	{
        public static string Name = "House Addition";
        public static string Dependency = null;
        public static string Context = "[*discriminator=Elements.House]";
		public static string Paradigm = "Edit";

        /// <summary>
        /// Get the override name for this override.
        /// </summary>
        public string GetName() {
			return Name;
		}

		public object GetIdentity() {

			return Identity;
		}

	}

}