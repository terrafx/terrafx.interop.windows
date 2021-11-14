// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmsyscom.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct MMTIME
    {
        public uint wType;

        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/mmsyscom.h:110:5)")]
        public _u_e__Union u;

        [StructLayout(LayoutKind.Explicit, Pack = 1)]
        public partial struct _u_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint ms;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint sample;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint cb;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint ticks;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/mmsyscom.h:118:9)")]
            public _smpte_e__Struct smpte;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/mmsyscom.h:132:9)")]
            public _midi_e__Struct midi;

            public unsafe partial struct _smpte_e__Struct
            {
                public byte hour;

                public byte min;

                public byte sec;

                public byte frame;

                public byte fps;

                public byte dummy;

                [NativeTypeName("BYTE [2]")]
                public fixed byte pad[2];
            }

            [StructLayout(LayoutKind.Sequential, Pack = 1)]
            public partial struct _midi_e__Struct
            {
                [NativeTypeName("DWORD")]
                public uint songptrpos;
            }
        }
    }
}
