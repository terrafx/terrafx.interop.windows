// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct WINTRUST_CERT_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbStruct;

        [NativeTypeName("LPCWSTR")]
        public ushort* pcwszDisplayName;

        public CERT_CONTEXT* psCertContext;

        [NativeTypeName("DWORD")]
        public uint chStores;

        public HCERTSTORE* pahStores;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        public FILETIME* psftVerifyAsOf;
    }
}
