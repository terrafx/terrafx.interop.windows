// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winreg.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct VALENTW
    {
        [NativeTypeName("LPWSTR")]
        public ushort* ve_valuename;

        [NativeTypeName("DWORD")]
        public uint ve_valuelen;

        [NativeTypeName("DWORD_PTR")]
        public nuint ve_valueptr;

        [NativeTypeName("DWORD")]
        public uint ve_type;
    }
}
