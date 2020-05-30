// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct WAVEFORMATEXTENSIBLE
    {
        public WAVEFORMATEX Format;

        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared/mmreg.h:2524:5)")]
        public _Samples_e__Union Samples;

        [NativeTypeName("DWORD")]
        public uint dwChannelMask;

        [NativeTypeName("GUID")]
        public Guid SubFormat;

        [StructLayout(LayoutKind.Explicit, Pack = 1)]
        public partial struct _Samples_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("WORD")]
            public ushort wValidBitsPerSample;

            [FieldOffset(0)]
            [NativeTypeName("WORD")]
            public ushort wSamplesPerBlock;

            [FieldOffset(0)]
            [NativeTypeName("WORD")]
            public ushort wReserved;
        }
    }
}
