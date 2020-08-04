// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct MIXERCONTROLDETAILS
    {
        [NativeTypeName("DWORD")]
        public uint cbStruct;

        [NativeTypeName("DWORD")]
        public uint dwControlID;

        [NativeTypeName("DWORD")]
        public uint cChannels;

        [NativeTypeName("tMIXERCONTROLDETAILS::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/mmeapi.h:2341:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref IntPtr hwndOwner => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.hwndOwner, 1));

        public ref uint cMultipleItems => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.cMultipleItems, 1));

        [NativeTypeName("DWORD")]
        public uint cbDetails;

        [NativeTypeName("LPVOID")]
        public void* paDetails;

        [StructLayout(LayoutKind.Explicit, Pack = 1)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("HWND")]
            public IntPtr hwndOwner;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint cMultipleItems;
        }
    }
}
