// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CERT_SERVER_OCSP_RESPONSE_OPEN_PARA
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD *")]
        public uint* pcbUsedSize;

        [NativeTypeName("PWSTR")]
        public ushort* pwszOcspDirectory;

        [NativeTypeName("PFN_CERT_SERVER_OCSP_RESPONSE_UPDATE_CALLBACK")]
        public delegate* unmanaged<CERT_CHAIN_CONTEXT*, CERT_SERVER_OCSP_RESPONSE_CONTEXT*, CRL_CONTEXT*, CRL_CONTEXT*, void*, uint, void> pfnUpdateCallback;

        [NativeTypeName("PVOID")]
        public void* pvUpdateCallbackArg;
    }
}
