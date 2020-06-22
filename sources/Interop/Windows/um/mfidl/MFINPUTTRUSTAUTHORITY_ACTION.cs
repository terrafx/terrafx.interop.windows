// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct MFINPUTTRUSTAUTHORITY_ACTION
    {
        public MFPOLICYMANAGER_ACTION Action;

        [NativeTypeName("BYTE *")]
        public byte* pbTicket;

        [NativeTypeName("DWORD")]
        public uint cbTicket;
    }
}
