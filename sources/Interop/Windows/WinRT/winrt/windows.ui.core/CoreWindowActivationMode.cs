// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CoreWindowActivationMode.xml' path='doc/member[@name="CoreWindowActivationMode"]/*' />
public enum CoreWindowActivationMode
{
    /// <include file='CoreWindowActivationMode.xml' path='doc/member[@name="CoreWindowActivationMode.CoreWindowActivationMode_None"]/*' />
    CoreWindowActivationMode_None = 0,

    /// <include file='CoreWindowActivationMode.xml' path='doc/member[@name="CoreWindowActivationMode.CoreWindowActivationMode_Deactivated"]/*' />
    CoreWindowActivationMode_Deactivated = 1,

    /// <include file='CoreWindowActivationMode.xml' path='doc/member[@name="CoreWindowActivationMode.CoreWindowActivationMode_ActivatedNotForeground"]/*' />
    CoreWindowActivationMode_ActivatedNotForeground = 2,

    /// <include file='CoreWindowActivationMode.xml' path='doc/member[@name="CoreWindowActivationMode.CoreWindowActivationMode_ActivatedInForeground"]/*' />
    CoreWindowActivationMode_ActivatedInForeground = 3,
}
