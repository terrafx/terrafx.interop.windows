// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows10.0.17763.0")]
    public unsafe partial struct PRJ_PLACEHOLDER_INFO
    {
        public PRJ_FILE_BASIC_INFO FileBasicInfo;

        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/projectedfslib.h:212:5)")]
        public _EaInformation_e__Struct EaInformation;

        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/projectedfslib.h:218:5)")]
        public _SecurityInformation_e__Struct SecurityInformation;

        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/projectedfslib.h:224:5)")]
        public _StreamsInformation_e__Struct StreamsInformation;

        public PRJ_PLACEHOLDER_VERSION_INFO VersionInfo;

        [NativeTypeName("UINT8 [1]")]
        public fixed byte VariableData[1];

        public partial struct _EaInformation_e__Struct
        {
            [NativeTypeName("UINT32")]
            public uint EaBufferSize;

            [NativeTypeName("UINT32")]
            public uint OffsetToFirstEa;
        }

        public partial struct _SecurityInformation_e__Struct
        {
            [NativeTypeName("UINT32")]
            public uint SecurityBufferSize;

            [NativeTypeName("UINT32")]
            public uint OffsetToSecurityDescriptor;
        }

        public partial struct _StreamsInformation_e__Struct
        {
            [NativeTypeName("UINT32")]
            public uint StreamsInfoBufferSize;

            [NativeTypeName("UINT32")]
            public uint OffsetToFirstStreamInfo;
        }
    }
}
