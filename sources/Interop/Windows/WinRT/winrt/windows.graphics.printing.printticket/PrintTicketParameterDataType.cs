// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.printticket.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PrintTicketParameterDataType.xml' path='doc/member[@name="PrintTicketParameterDataType"]/*' />
public enum PrintTicketParameterDataType
{
    /// <include file='PrintTicketParameterDataType.xml' path='doc/member[@name="PrintTicketParameterDataType.PrintTicketParameterDataType_Integer"]/*' />
    PrintTicketParameterDataType_Integer = 0,

    /// <include file='PrintTicketParameterDataType.xml' path='doc/member[@name="PrintTicketParameterDataType.PrintTicketParameterDataType_NumericString"]/*' />
    PrintTicketParameterDataType_NumericString = 1,

    /// <include file='PrintTicketParameterDataType.xml' path='doc/member[@name="PrintTicketParameterDataType.PrintTicketParameterDataType_String"]/*' />
    PrintTicketParameterDataType_String = 2,
}
