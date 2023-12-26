// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CoreDispatcherPriority.xml' path='doc/member[@name="CoreDispatcherPriority"]/*' />
public enum CoreDispatcherPriority
{
    /// <include file='CoreDispatcherPriority.xml' path='doc/member[@name="CoreDispatcherPriority.CoreDispatcherPriority_Idle"]/*' />
    CoreDispatcherPriority_Idle = -2,

    /// <include file='CoreDispatcherPriority.xml' path='doc/member[@name="CoreDispatcherPriority.CoreDispatcherPriority_Low"]/*' />
    CoreDispatcherPriority_Low = -1,

    /// <include file='CoreDispatcherPriority.xml' path='doc/member[@name="CoreDispatcherPriority.CoreDispatcherPriority_Normal"]/*' />
    CoreDispatcherPriority_Normal = 0,

    /// <include file='CoreDispatcherPriority.xml' path='doc/member[@name="CoreDispatcherPriority.CoreDispatcherPriority_High"]/*' />
    CoreDispatcherPriority_High = 1,
}
