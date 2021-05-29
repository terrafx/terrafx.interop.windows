// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct ENCRYPTION_BUFFER
    {
        [NativeTypeName("DWORD")]
        public uint EncryptionOperation;

        [NativeTypeName("BYTE [1]")]
        public fixed byte Private[1];
    }
}
