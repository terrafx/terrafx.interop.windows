// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct PSS_AUXILIARY_PAGE_ENTRY
    {
        [NativeTypeName("void *")]
        public void* Address;

        public MEMORY_BASIC_INFORMATION BasicInformation;

        public FILETIME CaptureTime;

        [NativeTypeName("void *")]
        public void* PageContents;

        [NativeTypeName("DWORD")]
        public uint PageSize;
    }
}
