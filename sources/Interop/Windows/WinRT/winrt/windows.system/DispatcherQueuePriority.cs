// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='DispatcherQueuePriority.xml' path='doc/member[@name="DispatcherQueuePriority"]/*' />
public enum DispatcherQueuePriority
{
    /// <include file='DispatcherQueuePriority.xml' path='doc/member[@name="DispatcherQueuePriority.DispatcherQueuePriority_Low"]/*' />
    DispatcherQueuePriority_Low = -10,

    /// <include file='DispatcherQueuePriority.xml' path='doc/member[@name="DispatcherQueuePriority.DispatcherQueuePriority_Normal"]/*' />
    DispatcherQueuePriority_Normal = 0,

    /// <include file='DispatcherQueuePriority.xml' path='doc/member[@name="DispatcherQueuePriority.DispatcherQueuePriority_High"]/*' />
    DispatcherQueuePriority_High = 10,
}
