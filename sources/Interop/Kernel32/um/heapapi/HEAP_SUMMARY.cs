// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/heapapi.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct HEAP_SUMMARY
    {
        [NativeTypeName("DWORD")]
        public uint cb;

        [NativeTypeName("SIZE_T")]
        public UIntPtr cbAllocated;

        [NativeTypeName("SIZE_T")]
        public UIntPtr cbCommitted;

        [NativeTypeName("SIZE_T")]
        public UIntPtr cbReserved;

        [NativeTypeName("SIZE_T")]
        public UIntPtr cbMaxReserve;
    }
}
