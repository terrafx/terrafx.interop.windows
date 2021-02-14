// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum PSS_DUPLICATE_FLAGS
    {
        PSS_DUPLICATE_NONE = 0x00,
        PSS_DUPLICATE_CLOSE_SOURCE = 0x01,
    }
}
