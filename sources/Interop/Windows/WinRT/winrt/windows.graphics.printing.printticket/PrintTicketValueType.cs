// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.printticket.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PrintTicketValueType.xml' path='doc/member[@name="PrintTicketValueType"]/*' />
public enum PrintTicketValueType
{
    /// <include file='PrintTicketValueType.xml' path='doc/member[@name="PrintTicketValueType.PrintTicketValueType_Integer"]/*' />
    PrintTicketValueType_Integer = 0,

    /// <include file='PrintTicketValueType.xml' path='doc/member[@name="PrintTicketValueType.PrintTicketValueType_String"]/*' />
    PrintTicketValueType_String = 1,

    /// <include file='PrintTicketValueType.xml' path='doc/member[@name="PrintTicketValueType.PrintTicketValueType_Unknown"]/*' />
    PrintTicketValueType_Unknown = 2,
}
