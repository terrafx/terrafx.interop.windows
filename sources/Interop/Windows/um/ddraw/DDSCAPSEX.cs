// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct DDSCAPSEX
    {
        [NativeTypeName("DWORD")]
        public uint dwCaps2;

        [NativeTypeName("DWORD")]
        public uint dwCaps3;

        [NativeTypeName("_DDSCAPSEX::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/ddraw.h:356:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref uint dwCaps4 => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.dwCaps4, 1));

        public ref uint dwVolumeDepth => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.dwVolumeDepth, 1));

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwCaps4;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwVolumeDepth;
        }
    }
}
