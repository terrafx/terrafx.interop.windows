// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SCHANNEL_CRED
    {
        [NativeTypeName("DWORD")]
        public uint dwVersion;

        [NativeTypeName("DWORD")]
        public uint cCreds;

        [NativeTypeName("PCCERT_CONTEXT *")]
        public CERT_CONTEXT** paCred;

        [NativeTypeName("HCERTSTORE")]
        public IntPtr hRootStore;

        [NativeTypeName("DWORD")]
        public uint cMappers;

        [NativeTypeName("struct _HMAPPER **")]
        public void** aphMappers;

        [NativeTypeName("DWORD")]
        public uint cSupportedAlgs;

        [NativeTypeName("ALG_ID *")]
        public uint* palgSupportedAlgs;

        [NativeTypeName("DWORD")]
        public uint grbitEnabledProtocols;

        [NativeTypeName("DWORD")]
        public uint dwMinimumCipherStrength;

        [NativeTypeName("DWORD")]
        public uint dwMaximumCipherStrength;

        [NativeTypeName("DWORD")]
        public uint dwSessionLifespan;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD")]
        public uint dwCredFormat;
    }
}
