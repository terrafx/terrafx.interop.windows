// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CHANGER_SEND_VOLUME_TAG_INFORMATION
    {
        public CHANGER_ELEMENT StartingElement;

        [NativeTypeName("DWORD")]
        public uint ActionCode;

        [NativeTypeName("BYTE [40]")]
        public fixed byte VolumeIDTemplate[40];
    }
}
