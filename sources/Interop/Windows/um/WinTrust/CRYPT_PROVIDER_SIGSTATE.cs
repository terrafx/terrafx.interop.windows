// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPT_PROVIDER_SIGSTATE
    {
        [NativeTypeName("DWORD")]
        public uint cbStruct;

        [NativeTypeName("HCRYPTMSG *")]
        public IntPtr* rhSecondarySigs;

        [NativeTypeName("HCRYPTMSG")]
        public IntPtr hPrimarySig;

        public BOOL fFirstAttemptMade;

        public BOOL fNoMoreSigs;

        [NativeTypeName("DWORD")]
        public uint cSecondarySigs;

        [NativeTypeName("DWORD")]
        public uint dwCurrentIndex;

        public BOOL fSupportMultiSig;

        [NativeTypeName("DWORD")]
        public uint dwCryptoPolicySupport;

        [NativeTypeName("DWORD")]
        public uint iAttemptCount;

        public BOOL fCheckedSealing;

        [NativeTypeName("struct _SEALING_SIGNATURE_ATTRIBUTE *")]
        public SEALING_SIGNATURE_ATTRIBUTE* pSealingSignature;
    }
}
