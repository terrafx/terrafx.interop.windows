// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct MIXERLINEA
    {
        [NativeTypeName("DWORD")]
        public uint cbStruct;

        [NativeTypeName("DWORD")]
        public uint dwDestination;

        [NativeTypeName("DWORD")]
        public uint dwSource;

        [NativeTypeName("DWORD")]
        public uint dwLineID;

        [NativeTypeName("DWORD")]
        public uint fdwLine;

        [NativeTypeName("DWORD_PTR")]
        public nuint dwUser;

        [NativeTypeName("DWORD")]
        public uint dwComponentType;

        [NativeTypeName("DWORD")]
        public uint cChannels;

        [NativeTypeName("DWORD")]
        public uint cConnections;

        [NativeTypeName("DWORD")]
        public uint cControls;

        [NativeTypeName("CHAR [16]")]
        public fixed sbyte szShortName[16];

        [NativeTypeName("CHAR [64]")]
        public fixed sbyte szName[64];

        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/mmeapi.h:1879:5)")]
        public _Target_e__Struct Target;

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe partial struct _Target_e__Struct
        {
            [NativeTypeName("DWORD")]
            public uint dwType;

            [NativeTypeName("DWORD")]
            public uint dwDeviceID;

            [NativeTypeName("WORD")]
            public ushort wMid;

            [NativeTypeName("WORD")]
            public ushort wPid;

            [NativeTypeName("MMVERSION")]
            public uint vDriverVersion;

            [NativeTypeName("CHAR [32]")]
            public fixed sbyte szPname[32];
        }
    }
}
