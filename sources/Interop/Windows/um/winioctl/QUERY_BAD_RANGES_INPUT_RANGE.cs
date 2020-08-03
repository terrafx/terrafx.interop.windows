// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct QUERY_BAD_RANGES_INPUT_RANGE
    {
        [NativeTypeName("DWORDLONG")]
        public ulong StartOffset;

        [NativeTypeName("DWORDLONG")]
        public ulong LengthInBytes;
    }
}
