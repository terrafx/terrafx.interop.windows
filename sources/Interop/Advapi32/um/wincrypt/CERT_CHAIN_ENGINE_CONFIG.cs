// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CERT_CHAIN_ENGINE_CONFIG
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("HCERTSTORE")]
        public void* hRestrictedRoot;

        [NativeTypeName("HCERTSTORE")]
        public void* hRestrictedTrust;

        [NativeTypeName("HCERTSTORE")]
        public void* hRestrictedOther;

        [NativeTypeName("DWORD")]
        public uint cAdditionalStore;

        [NativeTypeName("HCERTSTORE *")]
        public void** rghAdditionalStore;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD")]
        public uint dwUrlRetrievalTimeout;

        [NativeTypeName("DWORD")]
        public uint MaximumCachedCertificates;

        [NativeTypeName("DWORD")]
        public uint CycleDetectionModulus;

        [NativeTypeName("HCERTSTORE")]
        public void* hExclusiveRoot;

        [NativeTypeName("HCERTSTORE")]
        public void* hExclusiveTrustedPeople;

        [NativeTypeName("DWORD")]
        public uint dwExclusiveFlags;
    }
}
