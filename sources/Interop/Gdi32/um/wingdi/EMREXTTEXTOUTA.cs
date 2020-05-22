// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct EMREXTTEXTOUTA
    {
        public EMR emr;

        public RECTL rclBounds;

        [NativeTypeName("DWORD")]
        public uint iGraphicsMode;

        [NativeTypeName("FLOAT")]
        public float exScale;

        [NativeTypeName("FLOAT")]
        public float eyScale;

        public EMRTEXT emrtext;
    }
}
