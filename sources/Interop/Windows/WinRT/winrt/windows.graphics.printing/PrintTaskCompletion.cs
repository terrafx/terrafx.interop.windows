// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PrintTaskCompletion.xml' path='doc/member[@name="PrintTaskCompletion"]/*' />
public enum PrintTaskCompletion
{
    /// <include file='PrintTaskCompletion.xml' path='doc/member[@name="PrintTaskCompletion.PrintTaskCompletion_Abandoned"]/*' />
    PrintTaskCompletion_Abandoned = 0,

    /// <include file='PrintTaskCompletion.xml' path='doc/member[@name="PrintTaskCompletion.PrintTaskCompletion_Canceled"]/*' />
    PrintTaskCompletion_Canceled = 1,

    /// <include file='PrintTaskCompletion.xml' path='doc/member[@name="PrintTaskCompletion.PrintTaskCompletion_Failed"]/*' />
    PrintTaskCompletion_Failed = 2,

    /// <include file='PrintTaskCompletion.xml' path='doc/member[@name="PrintTaskCompletion.PrintTaskCompletion_Submitted"]/*' />
    PrintTaskCompletion_Submitted = 3,
}
