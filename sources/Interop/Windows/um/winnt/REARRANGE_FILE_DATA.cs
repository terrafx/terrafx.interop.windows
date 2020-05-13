// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct REARRANGE_FILE_DATA
    {
        [NativeTypeName("ULONGLONG")]
        public ulong SourceStartingOffset;

        [NativeTypeName("ULONGLONG")]
        public ulong TargetOffset;

        [NativeTypeName("HANDLE")]
        public IntPtr SourceFileHandle;

        [NativeTypeName("DWORD")]
        public uint Length;

        [NativeTypeName("DWORD")]
        public uint Flags;
    }
}
