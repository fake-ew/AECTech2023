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
            
            var lots = lotsModel.AllElementsOfType<Site>();

            // foreach(var lot in lots) {
            //   var perimeter = lot.Perimeter.Offset(-offsetFromBoundary).First();
            //   var h = new House(perimeter, heightOfTheHouse, material );
            //   output.Model.AddElement(h);
            // }

            // Look in the dependencies folder for the code for each of the classes — edit the class to change element behavior. Modify UpdateRepresentations to control geometry / appearance.
            // Create House elements
            var houseElements = House.CreateElements(input.Overrides);
            output.Model.AddElements(houseElements);
            
            return output;
        }
      }
}