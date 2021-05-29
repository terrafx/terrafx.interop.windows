// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct QUOTA_LIMITS
    {
        [NativeTypeName("SIZE_T")]
        public nuint PagedPoolLimit;

        [NativeTypeName("SIZE_T")]
        public nuint NonPagedPoolLimit;

        [NativeTypeName("SIZE_T")]
        public nuint MinimumWorkingSetSize;

        [NativeTypeName("SIZE_T")]
        public nuint MaximumWorkingSetSize;

        [NativeTypeName("SIZE_T")]
        public nuint PagefileLimit;

        public LARGE_INTEGER TimeLimit;
    }
}
