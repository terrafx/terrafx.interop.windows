// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct DWRITE_CARET_METRICS
    {
        [NativeTypeName("INT16")]
        public short slopeRise;

        [NativeTypeName("INT16")]
        public short slopeRun;

        [NativeTypeName("INT16")]
        public short offset;
    }
}
