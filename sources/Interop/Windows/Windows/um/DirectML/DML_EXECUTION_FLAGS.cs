// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows
{
    [Flags]
    public enum DML_EXECUTION_FLAGS
    {
        DML_EXECUTION_FLAG_NONE = 0,
        DML_EXECUTION_FLAG_ALLOW_HALF_PRECISION_COMPUTATION = 0x1,
        DML_EXECUTION_FLAG_DISABLE_META_COMMANDS = 0x2,
        DML_EXECUTION_FLAG_DESCRIPTORS_VOLATILE = 0x4,
    }
}
