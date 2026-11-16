// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class ABM
{
    /// <include file='ABM.xml' path='doc/member[@name="ABM.ABM_NEW"]/*' />
    [NativeTypeName("#define ABM_NEW 0x00000000")]
    public const int ABM_NEW = 0x00000000;

    /// <include file='ABM.xml' path='doc/member[@name="ABM.ABM_REMOVE"]/*' />
    [NativeTypeName("#define ABM_REMOVE 0x00000001")]
    public const int ABM_REMOVE = 0x00000001;

    /// <include file='ABM.xml' path='doc/member[@name="ABM.ABM_QUERYPOS"]/*' />
    [NativeTypeName("#define ABM_QUERYPOS 0x00000002")]
    public const int ABM_QUERYPOS = 0x00000002;

    /// <include file='ABM.xml' path='doc/member[@name="ABM.ABM_SETPOS"]/*' />
    [NativeTypeName("#define ABM_SETPOS 0x00000003")]
    public const int ABM_SETPOS = 0x00000003;

    /// <include file='ABM.xml' path='doc/member[@name="ABM.ABM_GETSTATE"]/*' />
    [NativeTypeName("#define ABM_GETSTATE 0x00000004")]
    public const int ABM_GETSTATE = 0x00000004;

    /// <include file='ABM.xml' path='doc/member[@name="ABM.ABM_GETTASKBARPOS"]/*' />
    [NativeTypeName("#define ABM_GETTASKBARPOS 0x00000005")]
    public const int ABM_GETTASKBARPOS = 0x00000005;

    /// <include file='ABM.xml' path='doc/member[@name="ABM.ABM_ACTIVATE"]/*' />
    [NativeTypeName("#define ABM_ACTIVATE 0x00000006")]
    public const int ABM_ACTIVATE = 0x00000006;

    /// <include file='ABM.xml' path='doc/member[@name="ABM.ABM_GETAUTOHIDEBAR"]/*' />
    [NativeTypeName("#define ABM_GETAUTOHIDEBAR 0x00000007")]
    public const int ABM_GETAUTOHIDEBAR = 0x00000007;

    /// <include file='ABM.xml' path='doc/member[@name="ABM.ABM_SETAUTOHIDEBAR"]/*' />
    [NativeTypeName("#define ABM_SETAUTOHIDEBAR 0x00000008")]
    public const int ABM_SETAUTOHIDEBAR = 0x00000008;

    /// <include file='ABM.xml' path='doc/member[@name="ABM.ABM_WINDOWPOSCHANGED"]/*' />
    [NativeTypeName("#define ABM_WINDOWPOSCHANGED 0x0000009")]
    public const int ABM_WINDOWPOSCHANGED = 0x0000009;

    /// <include file='ABM.xml' path='doc/member[@name="ABM.ABM_SETSTATE"]/*' />
    [NativeTypeName("#define ABM_SETSTATE 0x0000000a")]
    public const int ABM_SETSTATE = 0x0000000a;

    /// <include file='ABM.xml' path='doc/member[@name="ABM.ABM_GETAUTOHIDEBAREX"]/*' />
    [NativeTypeName("#define ABM_GETAUTOHIDEBAREX 0x0000000b")]
    public const int ABM_GETAUTOHIDEBAREX = 0x0000000b;

    /// <include file='ABM.xml' path='doc/member[@name="ABM.ABM_SETAUTOHIDEBAREX"]/*' />
    [NativeTypeName("#define ABM_SETAUTOHIDEBAREX 0x0000000c")]
    public const int ABM_SETAUTOHIDEBAREX = 0x0000000c;
}
