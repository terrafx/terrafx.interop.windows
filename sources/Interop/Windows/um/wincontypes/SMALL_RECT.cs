// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincontypes.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct SMALL_RECT
    {
        [NativeTypeName("SHORT")]
        public short Left;

        [NativeTypeName("SHORT")]
        public short Top;

        [NativeTypeName("SHORT")]
        public short Right;

        [NativeTypeName("SHORT")]
        public short Bottom;
    }
}
