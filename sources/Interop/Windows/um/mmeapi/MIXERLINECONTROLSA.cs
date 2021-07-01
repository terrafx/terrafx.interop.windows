// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct MIXERLINECONTROLSA
    {
        [NativeTypeName("DWORD")]
        public uint cbStruct;

        [NativeTypeName("DWORD")]
        public uint dwLineID;

        [NativeTypeName("tagMIXERLINECONTROLSA::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/mmeapi.h:2223:5)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("DWORD")]
        public uint cControls;

        [NativeTypeName("DWORD")]
        public uint cbmxctrl;

        [NativeTypeName("LPMIXERCONTROLA")]
        public MIXERCONTROLA* pamxctrl;

        public ref uint dwControlID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.dwControlID, 1));
            }
        }

        public ref uint dwControlType
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.dwControlType, 1));
            }
        }

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
