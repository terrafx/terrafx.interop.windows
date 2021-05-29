// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum DML_CREATE_DEVICE_FLAGS
    {
        DML_CREATE_DEVICE_FLAG_NONE = 0,
        DML_CREATE_DEVICE_FLAG_DEBUG = 0x1,
    }
}
