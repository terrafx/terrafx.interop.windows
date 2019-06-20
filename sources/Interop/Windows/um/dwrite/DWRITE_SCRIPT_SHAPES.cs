// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum DWRITE_SCRIPT_SHAPES
    {
        /// <summary>No additional shaping requirement. Text is shaped with the writing system default behavior.</summary>
        DWRITE_SCRIPT_SHAPES_DEFAULT = 0,

        /// <summary>Text should leave no visual on display i.e. control or format control characters.</summary>
        DWRITE_SCRIPT_SHAPES_NO_VISUAL = 1
    }
}
