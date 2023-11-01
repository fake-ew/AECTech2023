using LetsBuildAHouseEASILY;
using Newtonsoft.Json;
namespace Elements
{
    public partial class House
    {
        [JsonProperty("Add Id")]
        public string AddId { get; set; }

        /// <summary>
        /// Determine whether the provided identity is a match for this object. Auto-generated from the schema.
        /// ⚠️ Do not edit this method: it will be overwritten automatically next
        /// time you run 'hypar init'.
        /// </summary>
        public bool Match(HouseIdentity identity)
        {
            return identity.AddId == this.AddId;
        }

        /// <summary>
        /// Set all properties of the element. Auto-generated from the schema.
        /// ⚠️ Do not edit this method: it will be overwritten automatically next
        /// time you run 'hypar init'.
        /// </summary>
        public void SetAllProperties(HouseOverrideAddition add)
        {
            // Identity
            this.AddId = add.Id;
            // Properties
            this.Perimeter = add.Value.Perimeter;
            this.SiteOffset = add.Value.SiteOffset;
            this.Height = add.Value.Height;
            this.Color = add.Value.Color;

        }

        /// <summary>
        /// Set all properties of the element. Auto-generated from the schema.
        /// ⚠️ Do not edit this method: it will be overwritten automatically next
        /// time you run 'hypar init'.
        /// </summary>
        public void SetAllProperties(HouseOverride edit)
        {
            // Properties
            this.Perimeter = edit.Value.Perimeter;
            this.SiteOffset = edit.Value.SiteOffset;
            this.Height = edit.Value.Height;
            this.Color = edit.Value.Color;

        }
        
        public static List<House> CreateElements(Overrides overrides, IEnumerable<House> existingElements = null)
        {
            return overrides.House.CreateElements(
                overrides.Additions.House,
                overrides.Removals.House,
                (add) => new House(add),
                (elem, identity) => elem.Match(identity),
                (elem, edit) => { elem.Update(edit); return elem; },
                existingElements
            );
        } 
    }
}