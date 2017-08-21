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
    /* Internal type: asd */
    public partial class MovingObject : WorldObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        
        private asd _internal;
        
        #region Properties
        
        public asd MovingObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public MovingObject(asd instance) : base(instance)
        {
            _internal = instance;
        }
        
        static MovingObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator asd(MovingObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator MovingObject(asd instance)
        {
            return new MovingObject(instance);
        }
        
        public static implicit operator bool(MovingObject instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
