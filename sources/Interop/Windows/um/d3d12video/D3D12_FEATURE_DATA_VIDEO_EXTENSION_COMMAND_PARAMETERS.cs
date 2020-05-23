// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS
    {
        [NativeTypeName("GUID")]
        public Guid CommandId;

        public D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE Stage;

        [NativeTypeName("UINT")]
        public uint ParameterCount;

        [NativeTypeName("D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO *")]
        public D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO* pParameterInfos;
    }
}
