// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SDC
{
    /// <include file='SDC.xml' path='doc/member[@name="SDC.SDC_TOPOLOGY_INTERNAL"]/*' />
    [NativeTypeName("#define SDC_TOPOLOGY_INTERNAL 0x00000001")]
    public const int SDC_TOPOLOGY_INTERNAL = 0x00000001;

    /// <include file='SDC.xml' path='doc/member[@name="SDC.SDC_TOPOLOGY_CLONE"]/*' />
    [NativeTypeName("#define SDC_TOPOLOGY_CLONE 0x00000002")]
    public const int SDC_TOPOLOGY_CLONE = 0x00000002;

    /// <include file='SDC.xml' path='doc/member[@name="SDC.SDC_TOPOLOGY_EXTEND"]/*' />
    [NativeTypeName("#define SDC_TOPOLOGY_EXTEND 0x00000004")]
    public const int SDC_TOPOLOGY_EXTEND = 0x00000004;

    /// <include file='SDC.xml' path='doc/member[@name="SDC.SDC_TOPOLOGY_EXTERNAL"]/*' />
    [NativeTypeName("#define SDC_TOPOLOGY_EXTERNAL 0x00000008")]
    public const int SDC_TOPOLOGY_EXTERNAL = 0x00000008;

    /// <include file='SDC.xml' path='doc/member[@name="SDC.SDC_TOPOLOGY_SUPPLIED"]/*' />
    [NativeTypeName("#define SDC_TOPOLOGY_SUPPLIED 0x00000010")]
    public const int SDC_TOPOLOGY_SUPPLIED = 0x00000010;

    /// <include file='SDC.xml' path='doc/member[@name="SDC.SDC_USE_DATABASE_CURRENT"]/*' />
    [NativeTypeName("#define SDC_USE_DATABASE_CURRENT (SDC_TOPOLOGY_INTERNAL | SDC_TOPOLOGY_CLONE | SDC_TOPOLOGY_EXTEND | SDC_TOPOLOGY_EXTERNAL)")]
    public const int SDC_USE_DATABASE_CURRENT = (0x00000001 | 0x00000002 | 0x00000004 | 0x00000008);

    /// <include file='SDC.xml' path='doc/member[@name="SDC.SDC_USE_SUPPLIED_DISPLAY_CONFIG"]/*' />
    [NativeTypeName("#define SDC_USE_SUPPLIED_DISPLAY_CONFIG 0x00000020")]
    public const int SDC_USE_SUPPLIED_DISPLAY_CONFIG = 0x00000020;

    /// <include file='SDC.xml' path='doc/member[@name="SDC.SDC_VALIDATE"]/*' />
    [NativeTypeName("#define SDC_VALIDATE 0x00000040")]
    public const int SDC_VALIDATE = 0x00000040;

    /// <include file='SDC.xml' path='doc/member[@name="SDC.SDC_APPLY"]/*' />
    [NativeTypeName("#define SDC_APPLY 0x00000080")]
    public const int SDC_APPLY = 0x00000080;

    /// <include file='SDC.xml' path='doc/member[@name="SDC.SDC_NO_OPTIMIZATION"]/*' />
    [NativeTypeName("#define SDC_NO_OPTIMIZATION 0x00000100")]
    public const int SDC_NO_OPTIMIZATION = 0x00000100;

    /// <include file='SDC.xml' path='doc/member[@name="SDC.SDC_SAVE_TO_DATABASE"]/*' />
    [NativeTypeName("#define SDC_SAVE_TO_DATABASE 0x00000200")]
    public const int SDC_SAVE_TO_DATABASE = 0x00000200;

    /// <include file='SDC.xml' path='doc/member[@name="SDC.SDC_ALLOW_CHANGES"]/*' />
    [NativeTypeName("#define SDC_ALLOW_CHANGES 0x00000400")]
    public const int SDC_ALLOW_CHANGES = 0x00000400;

    /// <include file='SDC.xml' path='doc/member[@name="SDC.SDC_PATH_PERSIST_IF_REQUIRED"]/*' />
    [NativeTypeName("#define SDC_PATH_PERSIST_IF_REQUIRED 0x00000800")]
    public const int SDC_PATH_PERSIST_IF_REQUIRED = 0x00000800;

    /// <include file='SDC.xml' path='doc/member[@name="SDC.SDC_FORCE_MODE_ENUMERATION"]/*' />
    [NativeTypeName("#define SDC_FORCE_MODE_ENUMERATION 0x00001000")]
    public const int SDC_FORCE_MODE_ENUMERATION = 0x00001000;

    /// <include file='SDC.xml' path='doc/member[@name="SDC.SDC_ALLOW_PATH_ORDER_CHANGES"]/*' />
    [NativeTypeName("#define SDC_ALLOW_PATH_ORDER_CHANGES 0x00002000")]
    public const int SDC_ALLOW_PATH_ORDER_CHANGES = 0x00002000;

    /// <include file='SDC.xml' path='doc/member[@name="SDC.SDC_VIRTUAL_MODE_AWARE"]/*' />
    [NativeTypeName("#define SDC_VIRTUAL_MODE_AWARE 0x00008000")]
    public const int SDC_VIRTUAL_MODE_AWARE = 0x00008000;

    /// <include file='SDC.xml' path='doc/member[@name="SDC.SDC_VIRTUAL_REFRESH_RATE_AWARE"]/*' />
    [NativeTypeName("#define SDC_VIRTUAL_REFRESH_RATE_AWARE 0x00020000")]
    public const int SDC_VIRTUAL_REFRESH_RATE_AWARE = 0x00020000;
}
