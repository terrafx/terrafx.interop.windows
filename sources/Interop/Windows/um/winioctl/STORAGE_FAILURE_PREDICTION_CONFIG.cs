// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct STORAGE_FAILURE_PREDICTION_CONFIG
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("BOOLEAN")]
        public byte Set;

        [NativeTypeName("BOOLEAN")]
        public byte Enabled;

        [NativeTypeName("WORD")]
        public ushort Reserved;
    }
}
