// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/tbs.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct TPM_DEVICE_INFO
    {
        [NativeTypeName("UINT32")]
        public uint structVersion;

        [NativeTypeName("UINT32")]
        public uint tpmVersion;

        [NativeTypeName("UINT32")]
        public uint tpmInterfaceType;

        [NativeTypeName("UINT32")]
        public uint tpmImpRevision;
    }
}
