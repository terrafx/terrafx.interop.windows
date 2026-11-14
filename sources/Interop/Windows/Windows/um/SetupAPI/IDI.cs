// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class IDI
{
    /// <include file='IDI.xml' path='doc/member[@name="IDI.IDI_RESOURCEFIRST"]/*' />
    [NativeTypeName("#define IDI_RESOURCEFIRST 159")]
    public const int IDI_RESOURCEFIRST = 159;

    /// <include file='IDI.xml' path='doc/member[@name="IDI.IDI_RESOURCE"]/*' />
    [NativeTypeName("#define IDI_RESOURCE 159")]
    public const int IDI_RESOURCE = 159;

    /// <include file='IDI.xml' path='doc/member[@name="IDI.IDI_RESOURCELAST"]/*' />
    [NativeTypeName("#define IDI_RESOURCELAST 161")]
    public const int IDI_RESOURCELAST = 161;

    /// <include file='IDI.xml' path='doc/member[@name="IDI.IDI_RESOURCEOVERLAYFIRST"]/*' />
    [NativeTypeName("#define IDI_RESOURCEOVERLAYFIRST 161")]
    public const int IDI_RESOURCEOVERLAYFIRST = 161;

    /// <include file='IDI.xml' path='doc/member[@name="IDI.IDI_RESOURCEOVERLAYLAST"]/*' />
    [NativeTypeName("#define IDI_RESOURCEOVERLAYLAST 161")]
    public const int IDI_RESOURCEOVERLAYLAST = 161;

    /// <include file='IDI.xml' path='doc/member[@name="IDI.IDI_CONFLICT"]/*' />
    [NativeTypeName("#define IDI_CONFLICT 161")]
    public const int IDI_CONFLICT = 161;

    /// <include file='IDI.xml' path='doc/member[@name="IDI.IDI_CLASSICON_OVERLAYFIRST"]/*' />
    [NativeTypeName("#define IDI_CLASSICON_OVERLAYFIRST 500")]
    public const int IDI_CLASSICON_OVERLAYFIRST = 500;

    /// <include file='IDI.xml' path='doc/member[@name="IDI.IDI_CLASSICON_OVERLAYLAST"]/*' />
    [NativeTypeName("#define IDI_CLASSICON_OVERLAYLAST 502")]
    public const int IDI_CLASSICON_OVERLAYLAST = 502;

    /// <include file='IDI.xml' path='doc/member[@name="IDI.IDI_PROBLEM_OVL"]/*' />
    [NativeTypeName("#define IDI_PROBLEM_OVL 500")]
    public const int IDI_PROBLEM_OVL = 500;

    /// <include file='IDI.xml' path='doc/member[@name="IDI.IDI_DISABLED_OVL"]/*' />
    [NativeTypeName("#define IDI_DISABLED_OVL 501")]
    public const int IDI_DISABLED_OVL = 501;

    /// <include file='IDI.xml' path='doc/member[@name="IDI.IDI_FORCED_OVL"]/*' />
    [NativeTypeName("#define IDI_FORCED_OVL 502")]
    public const int IDI_FORCED_OVL = 502;
}
