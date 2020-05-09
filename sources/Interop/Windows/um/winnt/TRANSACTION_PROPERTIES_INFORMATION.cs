// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct TRANSACTION_PROPERTIES_INFORMATION
    {
        [NativeTypeName("DWORD")]
        public uint IsolationLevel;

        [NativeTypeName("DWORD")]
        public uint IsolationFlags;

        public LARGE_INTEGER Timeout;

        [NativeTypeName("DWORD")]
        public uint Outcome;

        [NativeTypeName("DWORD")]
        public uint DescriptionLength;

        [NativeTypeName("WCHAR [1]")]
        public fixed ushort Description[1];
    }
}
