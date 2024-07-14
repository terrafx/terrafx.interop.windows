// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/consoleapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='ALLOC_CONSOLE_OPTIONS.xml' path='doc/member[@name="ALLOC_CONSOLE_OPTIONS"]/*' />
public partial struct ALLOC_CONSOLE_OPTIONS
{
    /// <include file='ALLOC_CONSOLE_OPTIONS.xml' path='doc/member[@name="ALLOC_CONSOLE_OPTIONS.mode"]/*' />
    public ALLOC_CONSOLE_MODE mode;

    /// <include file='ALLOC_CONSOLE_OPTIONS.xml' path='doc/member[@name="ALLOC_CONSOLE_OPTIONS.useShowWindow"]/*' />
    public BOOL useShowWindow;

    /// <include file='ALLOC_CONSOLE_OPTIONS.xml' path='doc/member[@name="ALLOC_CONSOLE_OPTIONS.showWindow"]/*' />
    [NativeTypeName("WORD")]
    public ushort showWindow;
}
