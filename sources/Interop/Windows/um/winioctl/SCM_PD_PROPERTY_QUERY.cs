// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SCM_PD_PROPERTY_QUERY
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        public SCM_PD_PROPERTY_ID PropertyId;

        public SCM_PD_QUERY_TYPE QueryType;

        [NativeTypeName("BYTE [1]")]
        public fixed byte AdditionalParameters[1];
    }
}
