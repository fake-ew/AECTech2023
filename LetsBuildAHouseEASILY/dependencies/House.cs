using Elements;
using System;
using System.Linq;
using System.Collections.Generic;
using Elements.Geometry;
using Newtonsoft.Json;
using Elements.Geometry.Solids;
using LetsBuildAHouseEASILY;

namespace Elements
{
    // This portion of the House class is yours to edit with your own element behaviors.
    public partial class House
    {
        public House(Profile perimeter, double height, Color color)
        {
            Perimeter = perimeter;
            Height = height;
            Color = color;

            SetMaterial();
        }

        // Access properties of the element and construct a representation.
        public override void UpdateRepresentations()
        {
            // Replace this with your own representation logic.
            this.Representation = new Extrude(Perimeter, Height, Vector3.ZAxis, false);
        }

        /// <summary>
        /// Construct a new instance of the element.
        /// </summary>
        /// <param name="add">User input at add time.</param>
        public House(HouseOverrideAddition add)
        {
            // Optionally customize this method.
            this.SetAllProperties(add);
            SetMaterial();
        }

        private void SetMaterial()
        {
            if (Color.HasValue)
            {
                this.Material = new Material("House-" + AddId, Color.Value);
            }
        }

        /// <summary>
        /// Update the element on a subsequent change.
        /// </summary>
        /// <param name="edit">User input at edit time.</param>
        public void Update(HouseOverride edit)
        {
            // Optionally customize this method.
            this.SetAllProperties(edit);
        }
    }
}