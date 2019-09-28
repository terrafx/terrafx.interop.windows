// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wingdi.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct TRIVERTEX
    {
        [NativeTypeName("LONG")]
        public int x;

        [NativeTypeName("LONG")]
        public int y;

        [NativeTypeName("COLOR16")]
        public ushort Red;

        [NativeTypeName("COLOR16")]
        public ushort Green;

        [NativeTypeName("COLOR16")]
        public ushort Blue;

        [NativeTypeName("COLOR16")]
        public ushort Alpha;
    }
}
