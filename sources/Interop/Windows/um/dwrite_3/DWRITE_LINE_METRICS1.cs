// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    [NativeTypeName("struct DWRITE_LINE_METRICS1 : DWRITE_LINE_METRICS")]
    [NativeInheritance("DWRITE_LINE_METRICS")]
    public partial struct DWRITE_LINE_METRICS1
    {
        public DWRITE_LINE_METRICS Base;

        [NativeTypeName("FLOAT")]
        public float leadingBefore;

        [NativeTypeName("FLOAT")]
        public float leadingAfter;
    }
}
