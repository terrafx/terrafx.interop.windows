// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct MIXERLINECONTROLSW
    {
        [NativeTypeName("DWORD")]
        public uint cbStruct;

        [NativeTypeName("DWORD")]
        public uint dwLineID;

        [NativeTypeName("tagMIXERLINECONTROLSW::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/mmeapi.h:2266:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref uint dwControlID => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.dwControlID, 1));

        public ref uint dwControlType => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.dwControlType, 1));

        [NativeTypeName("DWORD")]
        public uint cControls;

        [NativeTypeName("DWORD")]
        public uint cbmxctrl;

        [NativeTypeName("LPMIXERCONTROLW")]
        public MIXERCONTROLW* pamxctrl;

        [StructLayout(LayoutKind.Explicit, Pack = 1)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwControlID;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwControlType;
        }
    }
}
