// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct STORAGE_RPMB_DATA_FRAME
    {
        [NativeTypeName("BYTE [196]")]
        public fixed byte Stuff[196];

        [NativeTypeName("BYTE [32]")]
        public fixed byte KeyOrMAC[32];

        [NativeTypeName("BYTE [256]")]
        public fixed byte Data[256];

        [NativeTypeName("BYTE [16]")]
        public fixed byte Nonce[16];

        [NativeTypeName("BYTE [4]")]
        public fixed byte WriteCounter[4];

        [NativeTypeName("BYTE [2]")]
        public fixed byte Address[2];

        [NativeTypeName("BYTE [2]")]
        public fixed byte BlockCount[2];

        [NativeTypeName("BYTE [2]")]
        public fixed byte OperationResult[2];

        [NativeTypeName("BYTE [2]")]
        public fixed byte RequestOrResponseType[2];
    }
}
