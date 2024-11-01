using System;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace FishingApp.Models
{
    //Derived class:

    public class FreshwaterFish : Fish
    {
        public string LakeType {  get;} //e.g., "lake", "river"
        public FreshwaterFish(string name, int weight, string lakeType)
        :base(name, weight)
        {
            LakeType = lakeType;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - Habitat: Freshwater ({LakeType})";
        }
    }
}
