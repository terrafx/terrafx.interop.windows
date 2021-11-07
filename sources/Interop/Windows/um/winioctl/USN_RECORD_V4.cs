// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows8.1")]
    public partial struct USN_RECORD_V4
    {
        public USN_RECORD_COMMON_HEADER Header;

        public FILE_ID_128 FileReferenceNumber;

        public FILE_ID_128 ParentFileReferenceNumber;

        [NativeTypeName("USN")]
        public long Usn;

        [NativeTypeName("DWORD")]
        public uint Reason;

        [NativeTypeName("DWORD")]
        public uint SourceInfo;

        [NativeTypeName("DWORD")]
        public uint RemainingExtents;

        [NativeTypeName("WORD")]
        public ushort NumberOfExtents;

        [NativeTypeName("WORD")]
        public ushort ExtentSize;

        [NativeTypeName("USN_RECORD_EXTENT [1]")]
        public _Extents_e__FixedBuffer Extents;

        public partial struct _Extents_e__FixedBuffer
        {
            public USN_RECORD_EXTENT e0;

            public ref USN_RECORD_EXTENT this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<USN_RECORD_EXTENT> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
