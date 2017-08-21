////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.0.327.94396-live
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

using UnityEngine;

using Albion.Common.Time;

namespace Merlin.API.Direct
{
    /* Internal type: ar1 */
    public partial class FarmableItemObject : SimpleItemObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        
        private ar1 _internal;
        
        #region Properties
        
        public ar1 FarmableItemObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public FarmableItemObject(ar1 instance) : base(instance)
        {
            _internal = instance;
        }
        
        static FarmableItemObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator ar1(FarmableItemObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator FarmableItemObject(ar1 instance)
        {
            return new FarmableItemObject(instance);
        }
        
        public static implicit operator bool(FarmableItemObject instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
