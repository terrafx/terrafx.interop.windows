// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum DML_TENSOR_FLAGS
    {
        DML_TENSOR_FLAG_NONE = 0x0,
        DML_TENSOR_FLAG_OWNED_BY_DML = 0x1,
    }
}
