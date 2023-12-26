// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CustomSystemEventTriggerRecurrence.xml' path='doc/member[@name="CustomSystemEventTriggerRecurrence"]/*' />
public enum CustomSystemEventTriggerRecurrence
{
    /// <include file='CustomSystemEventTriggerRecurrence.xml' path='doc/member[@name="CustomSystemEventTriggerRecurrence.CustomSystemEventTriggerRecurrence_Once"]/*' />
    CustomSystemEventTriggerRecurrence_Once = 0,

    /// <include file='CustomSystemEventTriggerRecurrence.xml' path='doc/member[@name="CustomSystemEventTriggerRecurrence.CustomSystemEventTriggerRecurrence_Always"]/*' />
    CustomSystemEventTriggerRecurrence_Always = 1,
}
