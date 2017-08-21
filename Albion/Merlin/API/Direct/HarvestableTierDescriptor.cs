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
    /* Internal type: hn.b */
    public partial class HarvestableTierDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        
        private hn.b _internal;
        
        #region Properties
        
        public hn.b HarvestableTierDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public HarvestableChargeDescriptor[] GetCharges() => _internal.a2().Select(x =>(HarvestableChargeDescriptor)x).ToArray();
        public bool RequiresTool() => _internal.ak();
        public HarvestableRareStateDescriptor[] GetRareStates() => _internal.ax().Select(x =>(HarvestableRareStateDescriptor)x).ToArray();
        
        #endregion
        
        #region Constructor
        
        public HarvestableTierDescriptor(hn.b instance)
        {
            _internal = instance;
        }
        
        static HarvestableTierDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator hn.b(HarvestableTierDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator HarvestableTierDescriptor(hn.b instance)
        {
            return new HarvestableTierDescriptor(instance);
        }
        
        public static implicit operator bool(HarvestableTierDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
