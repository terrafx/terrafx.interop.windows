// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnetwk.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class RESOURCEDISPLAYTYPE
{
    /// <include file='RESOURCEDISPLAYTYPE.xml' path='doc/member[@name="RESOURCEDISPLAYTYPE.RESOURCEDISPLAYTYPE_GENERIC"]/*' />
    [NativeTypeName("#define RESOURCEDISPLAYTYPE_GENERIC 0x00000000")]
    public const int RESOURCEDISPLAYTYPE_GENERIC = 0x00000000;

    /// <include file='RESOURCEDISPLAYTYPE.xml' path='doc/member[@name="RESOURCEDISPLAYTYPE.RESOURCEDISPLAYTYPE_DOMAIN"]/*' />
    [NativeTypeName("#define RESOURCEDISPLAYTYPE_DOMAIN 0x00000001")]
    public const int RESOURCEDISPLAYTYPE_DOMAIN = 0x00000001;

    /// <include file='RESOURCEDISPLAYTYPE.xml' path='doc/member[@name="RESOURCEDISPLAYTYPE.RESOURCEDISPLAYTYPE_SERVER"]/*' />
    [NativeTypeName("#define RESOURCEDISPLAYTYPE_SERVER 0x00000002")]
    public const int RESOURCEDISPLAYTYPE_SERVER = 0x00000002;

    /// <include file='RESOURCEDISPLAYTYPE.xml' path='doc/member[@name="RESOURCEDISPLAYTYPE.RESOURCEDISPLAYTYPE_SHARE"]/*' />
    [NativeTypeName("#define RESOURCEDISPLAYTYPE_SHARE 0x00000003")]
    public const int RESOURCEDISPLAYTYPE_SHARE = 0x00000003;

    /// <include file='RESOURCEDISPLAYTYPE.xml' path='doc/member[@name="RESOURCEDISPLAYTYPE.RESOURCEDISPLAYTYPE_FILE"]/*' />
    [NativeTypeName("#define RESOURCEDISPLAYTYPE_FILE 0x00000004")]
    public const int RESOURCEDISPLAYTYPE_FILE = 0x00000004;

    /// <include file='RESOURCEDISPLAYTYPE.xml' path='doc/member[@name="RESOURCEDISPLAYTYPE.RESOURCEDISPLAYTYPE_GROUP"]/*' />
    [NativeTypeName("#define RESOURCEDISPLAYTYPE_GROUP 0x00000005")]
    public const int RESOURCEDISPLAYTYPE_GROUP = 0x00000005;

    /// <include file='RESOURCEDISPLAYTYPE.xml' path='doc/member[@name="RESOURCEDISPLAYTYPE.RESOURCEDISPLAYTYPE_NETWORK"]/*' />
    [NativeTypeName("#define RESOURCEDISPLAYTYPE_NETWORK 0x00000006")]
    public const int RESOURCEDISPLAYTYPE_NETWORK = 0x00000006;

    /// <include file='RESOURCEDISPLAYTYPE.xml' path='doc/member[@name="RESOURCEDISPLAYTYPE.RESOURCEDISPLAYTYPE_ROOT"]/*' />
    [NativeTypeName("#define RESOURCEDISPLAYTYPE_ROOT 0x00000007")]
    public const int RESOURCEDISPLAYTYPE_ROOT = 0x00000007;

    /// <include file='RESOURCEDISPLAYTYPE.xml' path='doc/member[@name="RESOURCEDISPLAYTYPE.RESOURCEDISPLAYTYPE_SHAREADMIN"]/*' />
    [NativeTypeName("#define RESOURCEDISPLAYTYPE_SHAREADMIN 0x00000008")]
    public const int RESOURCEDISPLAYTYPE_SHAREADMIN = 0x00000008;

    /// <include file='RESOURCEDISPLAYTYPE.xml' path='doc/member[@name="RESOURCEDISPLAYTYPE.RESOURCEDISPLAYTYPE_DIRECTORY"]/*' />
    [NativeTypeName("#define RESOURCEDISPLAYTYPE_DIRECTORY 0x00000009")]
    public const int RESOURCEDISPLAYTYPE_DIRECTORY = 0x00000009;

    /// <include file='RESOURCEDISPLAYTYPE.xml' path='doc/member[@name="RESOURCEDISPLAYTYPE.RESOURCEDISPLAYTYPE_TREE"]/*' />
    [NativeTypeName("#define RESOURCEDISPLAYTYPE_TREE 0x0000000A")]
    public const int RESOURCEDISPLAYTYPE_TREE = 0x0000000A;

    /// <include file='RESOURCEDISPLAYTYPE.xml' path='doc/member[@name="RESOURCEDISPLAYTYPE.RESOURCEDISPLAYTYPE_NDSCONTAINER"]/*' />
    [NativeTypeName("#define RESOURCEDISPLAYTYPE_NDSCONTAINER 0x0000000B")]
    public const int RESOURCEDISPLAYTYPE_NDSCONTAINER = 0x0000000B;
}
