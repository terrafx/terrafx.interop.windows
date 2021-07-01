// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct IDEREGS
    {
        [NativeTypeName("BYTE")]
        public byte bFeaturesReg;

        [NativeTypeName("BYTE")]
        public byte bSectorCountReg;

        [NativeTypeName("BYTE")]
        public byte bSectorNumberReg;

        [NativeTypeName("BYTE")]
        public byte bCylLowReg;

        [NativeTypeName("BYTE")]
        public byte bCylHighReg;

        [NativeTypeName("BYTE")]
        public byte bDriveHeadReg;

        [NativeTypeName("BYTE")]
        public byte bCommandReg;

        [NativeTypeName("BYTE")]
        public byte bReserved;
    }
}
