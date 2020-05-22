// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mssip.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct SIP_DISPATCH_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("HANDLE")]
        public IntPtr hSIP;

        [NativeTypeName("pCryptSIPGetSignedDataMsg")]
        public IntPtr pfGet;

        [NativeTypeName("pCryptSIPPutSignedDataMsg")]
        public IntPtr pfPut;

        [NativeTypeName("pCryptSIPCreateIndirectData")]
        public IntPtr pfCreate;

        [NativeTypeName("pCryptSIPVerifyIndirectData")]
        public IntPtr pfVerify;

        [NativeTypeName("pCryptSIPRemoveSignedDataMsg")]
        public IntPtr pfRemove;
    }
}
