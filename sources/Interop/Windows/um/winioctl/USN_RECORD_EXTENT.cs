// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows8.1")]
    public partial struct USN_RECORD_EXTENT
    {
        [NativeTypeName("LONGLONG")]
        public long Offset;

        [NativeTypeName("LONGLONG")]
        public long Length;
    }
}
