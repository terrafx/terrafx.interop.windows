// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class VIEW
{
    /// <include file='VIEW.xml' path='doc/member[@name="VIEW.VIEW_PRIORITY_RESTRICTED"]/*' />
    [NativeTypeName("#define VIEW_PRIORITY_RESTRICTED 0x00000070")]
    public const int VIEW_PRIORITY_RESTRICTED = 0x00000070;

    /// <include file='VIEW.xml' path='doc/member[@name="VIEW.VIEW_PRIORITY_CACHEHIT"]/*' />
    [NativeTypeName("#define VIEW_PRIORITY_CACHEHIT 0x00000050")]
    public const int VIEW_PRIORITY_CACHEHIT = 0x00000050;

    /// <include file='VIEW.xml' path='doc/member[@name="VIEW.VIEW_PRIORITY_STALECACHEHIT"]/*' />
    [NativeTypeName("#define VIEW_PRIORITY_STALECACHEHIT 0x00000045")]
    public const int VIEW_PRIORITY_STALECACHEHIT = 0x00000045;

    /// <include file='VIEW.xml' path='doc/member[@name="VIEW.VIEW_PRIORITY_USEASDEFAULT"]/*' />
    [NativeTypeName("#define VIEW_PRIORITY_USEASDEFAULT 0x00000043")]
    public const int VIEW_PRIORITY_USEASDEFAULT = 0x00000043;

    /// <include file='VIEW.xml' path='doc/member[@name="VIEW.VIEW_PRIORITY_SHELLEXT"]/*' />
    [NativeTypeName("#define VIEW_PRIORITY_SHELLEXT 0x00000040")]
    public const int VIEW_PRIORITY_SHELLEXT = 0x00000040;

    /// <include file='VIEW.xml' path='doc/member[@name="VIEW.VIEW_PRIORITY_CACHEMISS"]/*' />
    [NativeTypeName("#define VIEW_PRIORITY_CACHEMISS 0x00000030")]
    public const int VIEW_PRIORITY_CACHEMISS = 0x00000030;

    /// <include file='VIEW.xml' path='doc/member[@name="VIEW.VIEW_PRIORITY_INHERIT"]/*' />
    [NativeTypeName("#define VIEW_PRIORITY_INHERIT 0x00000020")]
    public const int VIEW_PRIORITY_INHERIT = 0x00000020;

    /// <include file='VIEW.xml' path='doc/member[@name="VIEW.VIEW_PRIORITY_SHELLEXT_ASBACKUP"]/*' />
    [NativeTypeName("#define VIEW_PRIORITY_SHELLEXT_ASBACKUP 0x0015")]
    public const int VIEW_PRIORITY_SHELLEXT_ASBACKUP = 0x0015;

    /// <include file='VIEW.xml' path='doc/member[@name="VIEW.VIEW_PRIORITY_DESPERATE"]/*' />
    [NativeTypeName("#define VIEW_PRIORITY_DESPERATE 0x00000010")]
    public const int VIEW_PRIORITY_DESPERATE = 0x00000010;

    /// <include file='VIEW.xml' path='doc/member[@name="VIEW.VIEW_PRIORITY_NONE"]/*' />
    [NativeTypeName("#define VIEW_PRIORITY_NONE 0x00000000")]
    public const int VIEW_PRIORITY_NONE = 0x00000000;
}
