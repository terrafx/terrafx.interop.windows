// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct IP_INTERFACE_NAME_INFO_W2KSP1
    {
        [NativeTypeName("ULONG")]
        public uint Index;

        [NativeTypeName("ULONG")]
        public uint MediaType;

        [NativeTypeName("UCHAR")]
        public byte ConnectionType;

        [NativeTypeName("UCHAR")]
        public byte AccessType;

        [NativeTypeName("GUID")]
        public Guid DeviceGuid;

        [NativeTypeName("GUID")]
        public Guid InterfaceGuid;
    }
}
