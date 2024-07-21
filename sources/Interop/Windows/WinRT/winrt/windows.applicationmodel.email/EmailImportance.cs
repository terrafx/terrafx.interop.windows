// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='EmailImportance.xml' path='doc/member[@name="EmailImportance"]/*' />
public enum EmailImportance
{
    /// <include file='EmailImportance.xml' path='doc/member[@name="EmailImportance.EmailImportance_Normal"]/*' />
    EmailImportance_Normal = 0,

    /// <include file='EmailImportance.xml' path='doc/member[@name="EmailImportance.EmailImportance_High"]/*' />
    EmailImportance_High = 1,

    /// <include file='EmailImportance.xml' path='doc/member[@name="EmailImportance.EmailImportance_Low"]/*' />
    EmailImportance_Low = 2,
}
