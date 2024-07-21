// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/consoleapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='ALLOC_CONSOLE_RESULT.xml' path='doc/member[@name="ALLOC_CONSOLE_RESULT"]/*' />
public enum ALLOC_CONSOLE_RESULT
{
    /// <include file='ALLOC_CONSOLE_RESULT.xml' path='doc/member[@name="ALLOC_CONSOLE_RESULT.ALLOC_CONSOLE_RESULT_NO_CONSOLE"]/*' />
    ALLOC_CONSOLE_RESULT_NO_CONSOLE = 0,

    /// <include file='ALLOC_CONSOLE_RESULT.xml' path='doc/member[@name="ALLOC_CONSOLE_RESULT.ALLOC_CONSOLE_RESULT_NEW_CONSOLE"]/*' />
    ALLOC_CONSOLE_RESULT_NEW_CONSOLE = 1,

    /// <include file='ALLOC_CONSOLE_RESULT.xml' path='doc/member[@name="ALLOC_CONSOLE_RESULT.ALLOC_CONSOLE_RESULT_EXISTING_CONSOLE"]/*' />
    ALLOC_CONSOLE_RESULT_EXISTING_CONSOLE = 2,
}
