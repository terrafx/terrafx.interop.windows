// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct DVD_MultichannelAudioAttributes
    {
        [NativeTypeName("DVD_MUA_MixingInfo [8]")]
        public _Info_e__FixedBuffer Info;

        [NativeTypeName("DVD_MUA_Coeff [8]")]
        public _Coeff_e__FixedBuffer Coeff;

        public partial struct _Info_e__FixedBuffer
        {
            public DVD_MUA_MixingInfo e0;
            public DVD_MUA_MixingInfo e1;
            public DVD_MUA_MixingInfo e2;
            public DVD_MUA_MixingInfo e3;
            public DVD_MUA_MixingInfo e4;
            public DVD_MUA_MixingInfo e5;
            public DVD_MUA_MixingInfo e6;
            public DVD_MUA_MixingInfo e7;

            public ref DVD_MUA_MixingInfo this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<DVD_MUA_MixingInfo> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 8);
        }

        public partial struct _Coeff_e__FixedBuffer
        {
            public DVD_MUA_Coeff e0;
            public DVD_MUA_Coeff e1;
            public DVD_MUA_Coeff e2;
            public DVD_MUA_Coeff e3;
            public DVD_MUA_Coeff e4;
            public DVD_MUA_Coeff e5;
            public DVD_MUA_Coeff e6;
            public DVD_MUA_Coeff e7;

            public ref DVD_MUA_Coeff this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<DVD_MUA_Coeff> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 8);
        }
    }
}
