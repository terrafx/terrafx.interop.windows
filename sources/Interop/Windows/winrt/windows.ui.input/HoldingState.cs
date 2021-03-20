// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum HoldingState
    {
        HoldingState_Started = 0,
        HoldingState_Completed = 1,
        HoldingState_Canceled = 2,
    }
}
