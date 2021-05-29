// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct DWRITE_SCRIPT_ANALYSIS
    {
        [NativeTypeName("UINT16")]
        public ushort script;

        public DWRITE_SCRIPT_SHAPES shapes;
    }
}
