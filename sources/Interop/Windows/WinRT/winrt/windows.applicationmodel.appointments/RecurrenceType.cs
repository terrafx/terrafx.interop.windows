// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appointments.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='RecurrenceType.xml' path='doc/member[@name="RecurrenceType"]/*' />
public enum RecurrenceType
{
    /// <include file='RecurrenceType.xml' path='doc/member[@name="RecurrenceType.RecurrenceType_Master"]/*' />
    RecurrenceType_Master = 0,

    /// <include file='RecurrenceType.xml' path='doc/member[@name="RecurrenceType.RecurrenceType_Instance"]/*' />
    RecurrenceType_Instance = 1,

    /// <include file='RecurrenceType.xml' path='doc/member[@name="RecurrenceType.RecurrenceType_ExceptionInstance"]/*' />
    RecurrenceType_ExceptionInstance = 2,
}
