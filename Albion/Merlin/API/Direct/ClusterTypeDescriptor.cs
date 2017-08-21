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
    /* Internal type: l5 */
    public partial class ClusterTypeDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        
        private l5 _internal;
        
        #region Properties
        
        public l5 ClusterTypeDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public PvpRules GetPvpRules() => _internal.ap().ToWrapped();
        
        #endregion
        
        #region Constructor
        
        public ClusterTypeDescriptor(l5 instance)
        {
            _internal = instance;
        }
        
        static ClusterTypeDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator l5(ClusterTypeDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator ClusterTypeDescriptor(l5 instance)
        {
            return new ClusterTypeDescriptor(instance);
        }
        
        public static implicit operator bool(ClusterTypeDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
