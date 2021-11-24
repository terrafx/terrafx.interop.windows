// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsiQuery.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum MSICONDITION
{
    MSICONDITION_FALSE = 0,
    MSICONDITION_TRUE = 1,
    MSICONDITION_NONE = 2,
    MSICONDITION_ERROR = 3,
}
