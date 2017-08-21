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
    /* Internal type: arn */
    public partial class ConsumableItemObject : SimpleItemObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        
        private arn _internal;
        
        #region Properties
        
        public arn ConsumableItemObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public ConsumableItemObject(arn instance) : base(instance)
        {
            _internal = instance;
        }
        
        static ConsumableItemObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator arn(ConsumableItemObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator ConsumableItemObject(arn instance)
        {
            return new ConsumableItemObject(instance);
        }
        
        public static implicit operator bool(ConsumableItemObject instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
