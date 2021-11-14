// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.WinRT
{
    [Flags]
    [NativeTypeName("uint32_t")]
    public enum MLOperatorKernelOptions : uint
    {
        None = 0,
        AllowDynamicInputShapes = 1,
    }
}
