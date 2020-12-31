// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct TA_TRANSFORM
    {
        public TA_TRANSFORM_TYPE eTransformType;

        [NativeTypeName("DWORD")]
        public uint dwTimingFunctionId;

        [NativeTypeName("DWORD")]
        public uint dwStartTime;

        [NativeTypeName("DWORD")]
        public uint dwDurationTime;

        public TA_TRANSFORM_FLAG eFlags;
    }
}
