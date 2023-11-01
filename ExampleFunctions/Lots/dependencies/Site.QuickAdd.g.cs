using Lots;
using Newtonsoft.Json;
namespace Elements
{
    public partial class Site
    {
        [JsonProperty("Add Id")]
        public string AddId { get; set; }

        /// <summary>
        /// Set all properties of the element. Auto-generated from the schema.
        /// ⚠️ Do not edit this method: it will be overwritten automatically next
        /// time you run 'hypar init'.
        /// </summary>
        public bool Match(LotsIdentity identity)
        {
            return identity.AddId == this.AddId;
        }

        /// <summary>
        /// Set all properties of the element. Auto-generated from the schema.
        /// ⚠️ Do not edit this method: it will be overwritten automatically next
        /// time you run 'hypar init'.
        /// </summary>
        public void SetAllProperties(LotsOverrideAddition add)
        {
            // Identity
            this.AddId = add.Id;
            // Properties
            this.Perimeter = add.Value.Perimeter;

        }

        /// <summary>
        /// Set all properties of the element. Auto-generated from the schema.
        /// ⚠️ Do not edit this method: it will be overwritten automatically next
        /// time you run 'hypar init'.
        /// </summary>
        public void SetAllProperties(LotsOverride edit)
        {
            // Properties
            this.Perimeter = edit.Value.Perimeter;

        }
        
        public static List<Site> CreateElements(Overrides overrides, IEnumerable<Site> existingElements = null)
        {
            return overrides.Lots.CreateElements(
                overrides.Additions.Lots,
                overrides.Removals.Lots,
                (add) => new Site(add),
                (elem, identity) => elem.Match(identity),
                (elem, edit) => { elem.Update(edit); return elem; },
                existingElements
            );
        } 
    }
}