// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct PRJ_VIRTUALIZATION_INSTANCE_INFO
    {
        [NativeTypeName("GUID")]
        public Guid InstanceID;

        [NativeTypeName("UINT32")]
        public uint WriteAlignment;
    }
}
