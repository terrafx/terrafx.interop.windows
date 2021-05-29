// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct CONTROLINFO
    {
        [NativeTypeName("ULONG")]
        public uint cb;

        [NativeTypeName("HACCEL")]
        public IntPtr hAccel;

        [NativeTypeName("USHORT")]
        public ushort cAccel;

        [NativeTypeName("DWORD")]
        public uint dwFlags;
    }
}
