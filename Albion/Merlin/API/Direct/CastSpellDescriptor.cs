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
    /* Internal type: g0 */
    public partial class CastSpellDescriptor : ActiveSpellDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        
        private g0 _internal;
        
        #region Properties
        
        public g0 CastSpellDescriptor_Internal => _internal;
        public SpellCategory Category => _internal.d4.ToWrapped();
        public SpellTarget Target => _internal.d1.ToWrapped();
        public int Cost => _internal.dv;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public CastSpellDescriptor(g0 instance) : base(instance)
        {
            _internal = instance;
        }
        
        static CastSpellDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator g0(CastSpellDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator CastSpellDescriptor(g0 instance)
        {
            return new CastSpellDescriptor(instance);
        }
        
        public static implicit operator bool(CastSpellDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
