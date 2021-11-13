// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Psapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct ENUM_PAGE_FILE_INFORMATION
    {
        [NativeTypeName("DWORD")]
        public uint cb;

        [NativeTypeName("DWORD")]
        public uint Reserved;

        [NativeTypeName("SIZE_T")]
        public nuint TotalSize;

        [NativeTypeName("SIZE_T")]
        public nuint TotalInUse;

        [NativeTypeName("SIZE_T")]
        public nuint PeakUsage;
    }
}
