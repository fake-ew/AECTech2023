using Elements;
using System.Collections.Generic;
using System;
using System.Linq;

namespace LetsBuildAHouseEASILY
{
	/// <summary>
	/// Override metadata for HouseOverrideRemoval
	/// </summary>
	public partial class HouseOverrideRemoval : IOverride
	{
        public static string Name = "House Removal";
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