// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct TOUCH_HIT_TESTING_INPUT
    {
        [NativeTypeName("UINT32")]
        public uint pointerId;

        public POINT point;

        public RECT boundingBox;

        public RECT nonOccludedBoundingBox;

        [NativeTypeName("UINT32")]
        public uint orientation;
    }
}
