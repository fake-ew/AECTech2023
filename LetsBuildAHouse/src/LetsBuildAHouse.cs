using Elements;
using Elements.Geometry;
using System.Collections.Generic;

namespace LetsBuildAHouse
{
      public static class LetsBuildAHouse
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model">The input model.</param>
        /// <param name="input">The arguments to the execution.</param>
        /// <returns>A LetsBuildAHouseOutputs instance containing computed results and the model with any new elements.</returns>
        public static LetsBuildAHouseOutputs Execute(Dictionary<string, Model> inputModels, LetsBuildAHouseInputs input)
        {
            // Your code here.
            var output = new LetsBuildAHouseOutputs();

            // Load model dependencies.
            var lotsModel = inputModels["Lots"];

            // Gather inputs.
            var heightOfTheHouse = input.HeightOfTheHouse;
            var offsetFromBoundary = input.OffsetFromBoundary;
            var houseColor = input.HouseColor;
            var material = new Material("House Color", houseColor );

            var lots = lotsModel.AllElementsOfType<Site>();

            foreach(var lot in lots) {
              var perimeter = lot.Perimeter.Offset(-offsetFromBoundary).First();
              var h = new House(perimeter, heightOfTheHouse, material );
              output.Model.AddElement(h);
            }

            return output;
        }
      }
}