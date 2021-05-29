// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct _SCM_BUS_PROPERTY_SET
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("SCM_BUS_PROPERTY_ID")]
        public _SCM_BUS_PROPERTY_ID PropertyId;

        [NativeTypeName("SCM_BUS_SET_TYPE")]
        public _SCM_BUS_SET_TYPE SetType;

        [NativeTypeName("BYTE [1]")]
        public fixed byte AdditionalParameters[1];
    }
}
