// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct XSTATE_CONFIG_FEATURE_MSC_INFO
    {
        [NativeTypeName("ULONG32")]
        public uint SizeOfInfo;

        [NativeTypeName("ULONG32")]
        public uint ContextSize;

        [NativeTypeName("ULONG64")]
        public ulong EnabledFeatures;

        [NativeTypeName("XSTATE_FEATURE [64]")]
        public _Features_e__FixedBuffer Features;

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public partial struct _Features_e__FixedBuffer
        {
            public XSTATE_FEATURE e0;
            public XSTATE_FEATURE e1;
            public XSTATE_FEATURE e2;
            public XSTATE_FEATURE e3;
            public XSTATE_FEATURE e4;
            public XSTATE_FEATURE e5;
            public XSTATE_FEATURE e6;
            public XSTATE_FEATURE e7;
            public XSTATE_FEATURE e8;
            public XSTATE_FEATURE e9;
            public XSTATE_FEATURE e10;
            public XSTATE_FEATURE e11;
            public XSTATE_FEATURE e12;
            public XSTATE_FEATURE e13;
            public XSTATE_FEATURE e14;
            public XSTATE_FEATURE e15;
            public XSTATE_FEATURE e16;
            public XSTATE_FEATURE e17;
            public XSTATE_FEATURE e18;
            public XSTATE_FEATURE e19;
            public XSTATE_FEATURE e20;
            public XSTATE_FEATURE e21;
            public XSTATE_FEATURE e22;
            public XSTATE_FEATURE e23;
            public XSTATE_FEATURE e24;
            public XSTATE_FEATURE e25;
            public XSTATE_FEATURE e26;
            public XSTATE_FEATURE e27;
            public XSTATE_FEATURE e28;
            public XSTATE_FEATURE e29;
            public XSTATE_FEATURE e30;
            public XSTATE_FEATURE e31;
            public XSTATE_FEATURE e32;
            public XSTATE_FEATURE e33;
            public XSTATE_FEATURE e34;
            public XSTATE_FEATURE e35;
            public XSTATE_FEATURE e36;
            public XSTATE_FEATURE e37;
            public XSTATE_FEATURE e38;
            public XSTATE_FEATURE e39;
            public XSTATE_FEATURE e40;
            public XSTATE_FEATURE e41;
            public XSTATE_FEATURE e42;
            public XSTATE_FEATURE e43;
            public XSTATE_FEATURE e44;
            public XSTATE_FEATURE e45;
            public XSTATE_FEATURE e46;
            public XSTATE_FEATURE e47;
            public XSTATE_FEATURE e48;
            public XSTATE_FEATURE e49;
            public XSTATE_FEATURE e50;
            public XSTATE_FEATURE e51;
            public XSTATE_FEATURE e52;
            public XSTATE_FEATURE e53;
            public XSTATE_FEATURE e54;
            public XSTATE_FEATURE e55;
            public XSTATE_FEATURE e56;
            public XSTATE_FEATURE e57;
            public XSTATE_FEATURE e58;
            public XSTATE_FEATURE e59;
            public XSTATE_FEATURE e60;
            public XSTATE_FEATURE e61;
            public XSTATE_FEATURE e62;
            public XSTATE_FEATURE e63;

            public ref XSTATE_FEATURE this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<XSTATE_FEATURE> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 64);
        }
    }
}
