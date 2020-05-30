// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct MIDIOUTCAPS2A
    {
        [NativeTypeName("WORD")]
        public ushort wMid;

        [NativeTypeName("WORD")]
        public ushort wPid;

        [NativeTypeName("MMVERSION")]
        public uint vDriverVersion;

        [NativeTypeName("CHAR [32]")]
        public fixed sbyte szPname[32];

        [NativeTypeName("WORD")]
        public ushort wTechnology;

        [NativeTypeName("WORD")]
        public ushort wVoices;

        [NativeTypeName("WORD")]
        public ushort wNotes;

        [NativeTypeName("WORD")]
        public ushort wChannelMask;

        [NativeTypeName("DWORD")]
        public uint dwSupport;

        [NativeTypeName("GUID")]
        public Guid ManufacturerGuid;

        [NativeTypeName("GUID")]
        public Guid ProductGuid;

        [NativeTypeName("GUID")]
        public Guid NameGuid;
    }
}
