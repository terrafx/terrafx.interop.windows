// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ScreenCaptureDisabledBehavior.xml' path='doc/member[@name="ScreenCaptureDisabledBehavior"]/*' />
public enum ScreenCaptureDisabledBehavior
{
    /// <include file='ScreenCaptureDisabledBehavior.xml' path='doc/member[@name="ScreenCaptureDisabledBehavior.ScreenCaptureDisabledBehavior_DrawAsBlack"]/*' />
    ScreenCaptureDisabledBehavior_DrawAsBlack = 0,

    /// <include file='ScreenCaptureDisabledBehavior.xml' path='doc/member[@name="ScreenCaptureDisabledBehavior.ScreenCaptureDisabledBehavior_ExcludeFromCapture"]/*' />
    ScreenCaptureDisabledBehavior_ExcludeFromCapture = 1,
}
