// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mssip.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SIP_DISPATCH_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("HANDLE")]
        public IntPtr hSIP;

        [NativeTypeName("pCryptSIPGetSignedDataMsg")]
        public delegate* unmanaged<SIP_SUBJECTINFO*, uint*, uint, uint*, byte*, int> pfGet;

        [NativeTypeName("pCryptSIPPutSignedDataMsg")]
        public delegate* unmanaged<SIP_SUBJECTINFO*, uint, uint*, uint, byte*, int> pfPut;

        [NativeTypeName("pCryptSIPCreateIndirectData")]
        public delegate* unmanaged<SIP_SUBJECTINFO*, uint*, SIP_INDIRECT_DATA*, int> pfCreate;

        [NativeTypeName("pCryptSIPVerifyIndirectData")]
        public delegate* unmanaged<SIP_SUBJECTINFO*, SIP_INDIRECT_DATA*, int> pfVerify;

        [NativeTypeName("pCryptSIPRemoveSignedDataMsg")]
        public delegate* unmanaged<SIP_SUBJECTINFO*, uint, int> pfRemove;
    }
}
