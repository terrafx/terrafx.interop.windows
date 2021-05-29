// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct CREATE_USN_JOURNAL_DATA
    {
        [NativeTypeName("DWORDLONG")]
        public ulong MaximumSize;

        [NativeTypeName("DWORDLONG")]
        public ulong AllocationDelta;
    }
}
