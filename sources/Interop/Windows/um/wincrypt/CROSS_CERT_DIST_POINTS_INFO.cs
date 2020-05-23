// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CROSS_CERT_DIST_POINTS_INFO
    {
        [NativeTypeName("DWORD")]
        public uint dwSyncDeltaTime;

        [NativeTypeName("DWORD")]
        public uint cDistPoint;

        [NativeTypeName("PCERT_ALT_NAME_INFO")]
        public CERT_ALT_NAME_INFO* rgDistPoint;
    }
}
