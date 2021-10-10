// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct POINTER_PEN_INFO
    {
        public POINTER_INFO pointerInfo;

        [NativeTypeName("PEN_FLAGS")]
        public uint penFlags;

        [NativeTypeName("PEN_MASK")]
        public uint penMask;

        [NativeTypeName("UINT32")]
        public uint pressure;

        [NativeTypeName("UINT32")]
        public uint rotation;

        [NativeTypeName("INT32")]
        public int tiltX;

        [NativeTypeName("INT32")]
        public int tiltY;
    }
}
