// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Condition at the edges of inline object or text used to determine line-breaking behavior.</summary>
    public enum DWRITE_BREAK_CONDITION
    {
        /// <summary>Whether a break is allowed is determined by the condition of the neighboring text span or inline object.</summary>
        DWRITE_BREAK_CONDITION_NEUTRAL,

        /// <summary>A break is allowed, unless overruled by the condition of the neighboring text span or inline object, either prohibited by a May Not or forced by a Must.</summary>
        DWRITE_BREAK_CONDITION_CAN_BREAK,

        /// <summary>There should be no break, unless overruled by a Must condition from the neighboring text span or inline object.</summary>
        DWRITE_BREAK_CONDITION_MAY_NOT_BREAK,

        /// <summary>The break must happen, regardless of the condition of the adjacent text span or inline object.</summary>
        DWRITE_BREAK_CONDITION_MUST_BREAK
    }
}
