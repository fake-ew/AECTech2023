using Elements;
using Elements.Geometry;
using System.Collections.Generic;

namespace LetsBuildAHouseEASILY
{
    public static class LetsBuildAHouseEASILY
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="model">The input model.</param>
        /// <param name="input">The arguments to the execution.</param>
        /// <returns>A LetsBuildAHouseEASILYOutputs instance containing computed results and the model with any new elements.</returns>
        public static LetsBuildAHouseEASILYOutputs Execute(Dictionary<string, Model> inputModels, LetsBuildAHouseEASILYInputs input)
        {
            // Your code here.
            var output = new LetsBuildAHouseEASILYOutputs();

            // Load model dependencies.
            var lotsModel = inputModels["Lots"];

            // Gather inputs.
            var siteOffset = input.SiteOffset;

            var lots = lotsModel.AllElementsOfType<Site>();
            var generateHouses = new List<House>();
            var random = new Random(11);
            foreach (var lot in lots)
            {
                var perimeter = lot.Perimeter.Offset(-siteOffset).FirstOrDefault();
                if (perimeter == null)
                {
                    continue;
                }
                var randomHeight = random.NextDouble() * 30;
                var h = new House(perimeter, randomHeight, random.NextColor());
                generateHouses.Add(h);
            }

            // Look in the dependencies folder for the code for each of the classes — edit the class to change element behavior. Modify UpdateRepresentations to control geometry / appearance.
            // Create House elements
            var houseElements = House.CreateElements(input.Overrides, generateHouses);
            output.Model.AddElements(houseElements);

            return output;
        }
    }
}