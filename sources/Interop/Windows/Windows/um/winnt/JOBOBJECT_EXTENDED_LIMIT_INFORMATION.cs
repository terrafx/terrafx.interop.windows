// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct JOBOBJECT_EXTENDED_LIMIT_INFORMATION
    {
        public JOBOBJECT_BASIC_LIMIT_INFORMATION BasicLimitInformation;

        public IO_COUNTERS IoInfo;

        [NativeTypeName("SIZE_T")]
        public nuint ProcessMemoryLimit;

        [NativeTypeName("SIZE_T")]
        public nuint JobMemoryLimit;

        [NativeTypeName("SIZE_T")]
        public nuint PeakProcessMemoryUsed;

        [NativeTypeName("SIZE_T")]
        public nuint PeakJobMemoryUsed;
    }
}
