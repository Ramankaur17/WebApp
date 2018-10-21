using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StructureMap;
using StructureMap.Configuration.DSL;
using Mvc.Business.Interface;
using Mvc.Business;
using StructureMap.Graph;

namespace MvcAppMVC
{
    public class MyRegistry : Registry
    {
        public MyRegistry() {  
            Scan(  
                scan => {
                    scan.TheCallingAssembly();  
                    scan.WithDefaultConventions(); 
                   
                });  
            For<IStringGenerator>().Use<StringGenerator>();               
        }  
    }
}