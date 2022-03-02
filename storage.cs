using System;

namespace Dotnet_learn
{
    public class storage
    {
         public int _weight{get;set;}
         public string _type{get;set;}
    
        public storage(int weight, string type)
        {
            _weight = weight;
            _type = type;
        }
        
    }   
}
