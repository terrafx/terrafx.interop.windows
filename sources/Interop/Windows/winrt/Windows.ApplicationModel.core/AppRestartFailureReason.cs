// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/Windows.ApplicationModel.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum AppRestartFailureReason
    {
        AppRestartFailureReason_RestartPending = 0,
        AppRestartFailureReason_NotInForeground = 1,
        AppRestartFailureReason_InvalidUser = 2,
        AppRestartFailureReason_Other = 3,
    }
}
