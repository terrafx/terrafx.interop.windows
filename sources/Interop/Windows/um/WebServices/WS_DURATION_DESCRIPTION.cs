// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct WS_DURATION_DESCRIPTION
    {
        public WS_DURATION minValue;

        public WS_DURATION maxValue;

        [NativeTypeName("WS_DURATION_COMPARISON_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<WS_DURATION*, WS_DURATION*, int*, IntPtr, int> comparer;
#else
        public void* _comparer;

        public delegate* unmanaged[Stdcall]<WS_DURATION*, WS_DURATION*, int*, IntPtr, int> comparer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<WS_DURATION*, WS_DURATION*, int*, IntPtr, int>)_comparer;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _comparer = value;
            }
        }
#endif
    }
}
