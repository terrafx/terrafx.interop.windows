// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct SE_SID
    {
        [FieldOffset(0)]
        public SID Sid;

        [FieldOffset(0)]
        [NativeTypeName("BYTE [68]")]
        public fixed byte Buffer[68];
    }
}
