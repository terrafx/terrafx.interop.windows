// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct WINTRUST_SGNR_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbStruct;

        [NativeTypeName("LPCWSTR")]
        public ushort* pcwszDisplayName;

        public CMSG_SIGNER_INFO* psSignerInfo;

        [NativeTypeName("DWORD")]
        public uint chStores;

        [NativeTypeName("HCERTSTORE *")]
        public IntPtr* pahStores;
    }
}
