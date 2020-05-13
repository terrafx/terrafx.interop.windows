// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct JOBOBJECT_EXTENDED_LIMIT_INFORMATION
    {
        public JOBOBJECT_BASIC_LIMIT_INFORMATION BasicLimitInformation;

        public IO_COUNTERS IoInfo;

        [NativeTypeName("SIZE_T")]
        public UIntPtr ProcessMemoryLimit;

        [NativeTypeName("SIZE_T")]
        public UIntPtr JobMemoryLimit;

        [NativeTypeName("SIZE_T")]
        public UIntPtr PeakProcessMemoryUsed;

        [NativeTypeName("SIZE_T")]
        public UIntPtr PeakJobMemoryUsed;
    }
}
