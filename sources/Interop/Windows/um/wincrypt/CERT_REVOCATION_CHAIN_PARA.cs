// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct CERT_REVOCATION_CHAIN_PARA
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("HCERTCHAINENGINE")]
        public IntPtr hChainEngine;

        [NativeTypeName("HCERTSTORE")]
        public void* hAdditionalStore;

        [NativeTypeName("DWORD")]
        public uint dwChainFlags;

        [NativeTypeName("DWORD")]
        public uint dwUrlRetrievalTimeout;

        [NativeTypeName("LPFILETIME")]
        public FILETIME* pftCurrentTime;

        [NativeTypeName("LPFILETIME")]
        public FILETIME* pftCacheResync;

        [NativeTypeName("DWORD")]
        public uint cbMaxUrlRetrievalByteCount;
    }
}
