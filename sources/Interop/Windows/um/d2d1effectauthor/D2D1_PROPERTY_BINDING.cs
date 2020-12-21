// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct D2D1_PROPERTY_BINDING
    {
        [NativeTypeName("PCWSTR")]
        public ushort* propertyName;

        [NativeTypeName("PD2D1_PROPERTY_SET_FUNCTION")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<IUnknown*, byte*, uint, int> setFunction;
#else
        public void* _setFunction;

        public delegate* unmanaged[Stdcall]<IUnknown*, byte*, uint, int> setFunction
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<IUnknown*, byte*, uint, int>)_setFunction;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _setFunction = value;
            }
        }
#endif

        [NativeTypeName("PD2D1_PROPERTY_GET_FUNCTION")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<IUnknown*, byte*, uint, uint*, int> getFunction;
#else
        public void* _getFunction;

        public delegate* unmanaged[Stdcall]<IUnknown*, byte*, uint, uint*, int> getFunction
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<IUnknown*, byte*, uint, uint*, int>)_getFunction;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _getFunction = value;
            }
        }
#endif
    }
}
