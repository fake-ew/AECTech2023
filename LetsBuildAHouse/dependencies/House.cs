using Elements.Geometry;
using Elements.Geometry.Solids;

namespace Elements {
    public partial class House {

        public House(Profile perimeter, double height, Material color) {
            Perimeter = perimeter;
            Height = height;
            Material = color;
        }
        
        public override void UpdateRepresentations() {
            Representation= new Representation(new List<SolidOperation>{
                new Extrude(Perimeter, Height, Vector3.ZAxis)
            });
        }
    }
}