// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CoreTextInputPaneDisplayPolicy.xml' path='doc/member[@name="CoreTextInputPaneDisplayPolicy"]/*' />
public enum CoreTextInputPaneDisplayPolicy
{
    /// <include file='CoreTextInputPaneDisplayPolicy.xml' path='doc/member[@name="CoreTextInputPaneDisplayPolicy.CoreTextInputPaneDisplayPolicy_Automatic"]/*' />
    CoreTextInputPaneDisplayPolicy_Automatic = 0,

    /// <include file='CoreTextInputPaneDisplayPolicy.xml' path='doc/member[@name="CoreTextInputPaneDisplayPolicy.CoreTextInputPaneDisplayPolicy_Manual"]/*' />
    CoreTextInputPaneDisplayPolicy_Manual = 1,
}
