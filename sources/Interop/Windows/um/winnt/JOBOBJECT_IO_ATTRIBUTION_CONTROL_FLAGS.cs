// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum JOBOBJECT_IO_ATTRIBUTION_CONTROL_FLAGS
    {
        JOBOBJECT_IO_ATTRIBUTION_CONTROL_ENABLE = 0x1,
        JOBOBJECT_IO_ATTRIBUTION_CONTROL_DISABLE = 0x2,
        JOBOBJECT_IO_ATTRIBUTION_CONTROL_VALID_FLAGS = 0x3,
    }
}
