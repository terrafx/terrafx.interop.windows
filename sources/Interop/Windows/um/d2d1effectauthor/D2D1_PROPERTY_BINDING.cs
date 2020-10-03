// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D2D1_PROPERTY_BINDING
    {
        [NativeTypeName("PCWSTR")]
        public ushort* propertyName;

        [NativeTypeName("PD2D1_PROPERTY_SET_FUNCTION")]
        public delegate* unmanaged<IUnknown*, byte*, uint, int> setFunction;

        [NativeTypeName("PD2D1_PROPERTY_GET_FUNCTION")]
        public delegate* unmanaged<IUnknown*, byte*, uint, uint*, int> getFunction;
    }
}
