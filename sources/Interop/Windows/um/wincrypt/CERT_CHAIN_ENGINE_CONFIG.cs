// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct CERT_CHAIN_ENGINE_CONFIG
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("HCERTSTORE")]
        public IntPtr hRestrictedRoot;

        [NativeTypeName("HCERTSTORE")]
        public IntPtr hRestrictedTrust;

        [NativeTypeName("HCERTSTORE")]
        public IntPtr hRestrictedOther;

        [NativeTypeName("DWORD")]
        public uint cAdditionalStore;

        [NativeTypeName("HCERTSTORE *")]
        public IntPtr* rghAdditionalStore;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD")]
        public uint dwUrlRetrievalTimeout;

        [NativeTypeName("DWORD")]
        public uint MaximumCachedCertificates;

        [NativeTypeName("DWORD")]
        public uint CycleDetectionModulus;

        [NativeTypeName("HCERTSTORE")]
        public IntPtr hExclusiveRoot;

        [NativeTypeName("HCERTSTORE")]
        public IntPtr hExclusiveTrustedPeople;

        [NativeTypeName("DWORD")]
        public uint dwExclusiveFlags;
    }
}
