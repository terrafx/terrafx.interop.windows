// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/consoleapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='ALLOC_CONSOLE_MODE.xml' path='doc/member[@name="ALLOC_CONSOLE_MODE"]/*' />
public enum ALLOC_CONSOLE_MODE
{
    /// <include file='ALLOC_CONSOLE_MODE.xml' path='doc/member[@name="ALLOC_CONSOLE_MODE.ALLOC_CONSOLE_MODE_DEFAULT"]/*' />
    ALLOC_CONSOLE_MODE_DEFAULT = 0,

    /// <include file='ALLOC_CONSOLE_MODE.xml' path='doc/member[@name="ALLOC_CONSOLE_MODE.ALLOC_CONSOLE_MODE_NEW_WINDOW"]/*' />
    ALLOC_CONSOLE_MODE_NEW_WINDOW = 1,

    /// <include file='ALLOC_CONSOLE_MODE.xml' path='doc/member[@name="ALLOC_CONSOLE_MODE.ALLOC_CONSOLE_MODE_NO_WINDOW"]/*' />
    ALLOC_CONSOLE_MODE_NO_WINDOW = 2,
}
