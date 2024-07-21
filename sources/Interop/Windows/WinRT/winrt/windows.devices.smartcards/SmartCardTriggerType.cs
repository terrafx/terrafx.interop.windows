// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SmartCardTriggerType.xml' path='doc/member[@name="SmartCardTriggerType"]/*' />
public enum SmartCardTriggerType
{
    /// <include file='SmartCardTriggerType.xml' path='doc/member[@name="SmartCardTriggerType.SmartCardTriggerType_EmulatorTransaction"]/*' />
    SmartCardTriggerType_EmulatorTransaction = 0,

    /// <include file='SmartCardTriggerType.xml' path='doc/member[@name="SmartCardTriggerType.SmartCardTriggerType_EmulatorNearFieldEntry"]/*' />
    SmartCardTriggerType_EmulatorNearFieldEntry = 1,

    /// <include file='SmartCardTriggerType.xml' path='doc/member[@name="SmartCardTriggerType.SmartCardTriggerType_EmulatorNearFieldExit"]/*' />
    SmartCardTriggerType_EmulatorNearFieldExit = 2,

    /// <include file='SmartCardTriggerType.xml' path='doc/member[@name="SmartCardTriggerType.SmartCardTriggerType_EmulatorHostApplicationActivated"]/*' />
    SmartCardTriggerType_EmulatorHostApplicationActivated = 3,

    /// <include file='SmartCardTriggerType.xml' path='doc/member[@name="SmartCardTriggerType.SmartCardTriggerType_EmulatorAppletIdGroupRegistrationChanged"]/*' />
    SmartCardTriggerType_EmulatorAppletIdGroupRegistrationChanged = 4,

    /// <include file='SmartCardTriggerType.xml' path='doc/member[@name="SmartCardTriggerType.SmartCardTriggerType_ReaderCardAdded"]/*' />
    SmartCardTriggerType_ReaderCardAdded = 5,
}
