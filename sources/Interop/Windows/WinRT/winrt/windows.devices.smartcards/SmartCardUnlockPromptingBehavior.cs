// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SmartCardUnlockPromptingBehavior.xml' path='doc/member[@name="SmartCardUnlockPromptingBehavior"]/*' />
public enum SmartCardUnlockPromptingBehavior
{
    /// <include file='SmartCardUnlockPromptingBehavior.xml' path='doc/member[@name="SmartCardUnlockPromptingBehavior.SmartCardUnlockPromptingBehavior_AllowUnlockPrompt"]/*' />
    SmartCardUnlockPromptingBehavior_AllowUnlockPrompt = 0,

    /// <include file='SmartCardUnlockPromptingBehavior.xml' path='doc/member[@name="SmartCardUnlockPromptingBehavior.SmartCardUnlockPromptingBehavior_RequireUnlockPrompt"]/*' />
    SmartCardUnlockPromptingBehavior_RequireUnlockPrompt = 1,

    /// <include file='SmartCardUnlockPromptingBehavior.xml' path='doc/member[@name="SmartCardUnlockPromptingBehavior.SmartCardUnlockPromptingBehavior_PreventUnlockPrompt"]/*' />
    SmartCardUnlockPromptingBehavior_PreventUnlockPrompt = 2,
}
