// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    /// <summary>Defines a property binding to a function. The name must match the property defined in the registration schema.</summary>
    public unsafe struct D2D1_PROPERTY_BINDING
    {
        /// <summary>The name of the property.</summary>
        [NativeTypeName("PCWSTR")]
        public char* propertyName;

        /// <summary>The function that will receive the data to set.</summary>
        [NativeTypeName("PD2D1_PROPERTY_SET_FUNCTION")]
        public IntPtr setFunction;

        /// <summary>The function that will be asked to write the output data.</summary>
        [NativeTypeName("PD2D1_PROPERTY_GET_FUNCTION")]
        public IntPtr getFunction;
    }
}
