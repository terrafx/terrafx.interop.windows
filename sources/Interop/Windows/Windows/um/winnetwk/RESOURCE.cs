// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnetwk.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class RESOURCE
{
    /// <include file='RESOURCE.xml' path='doc/member[@name="RESOURCE.RESOURCE_CONNECTED"]/*' />
    [NativeTypeName("#define RESOURCE_CONNECTED 0x00000001")]
    public const int RESOURCE_CONNECTED = 0x00000001;

    /// <include file='RESOURCE.xml' path='doc/member[@name="RESOURCE.RESOURCE_GLOBALNET"]/*' />
    [NativeTypeName("#define RESOURCE_GLOBALNET 0x00000002")]
    public const int RESOURCE_GLOBALNET = 0x00000002;

    /// <include file='RESOURCE.xml' path='doc/member[@name="RESOURCE.RESOURCE_REMEMBERED"]/*' />
    [NativeTypeName("#define RESOURCE_REMEMBERED 0x00000003")]
    public const int RESOURCE_REMEMBERED = 0x00000003;

    /// <include file='RESOURCE.xml' path='doc/member[@name="RESOURCE.RESOURCE_RECENT"]/*' />
    [NativeTypeName("#define RESOURCE_RECENT 0x00000004")]
    public const int RESOURCE_RECENT = 0x00000004;

    /// <include file='RESOURCE.xml' path='doc/member[@name="RESOURCE.RESOURCE_CONTEXT"]/*' />
    [NativeTypeName("#define RESOURCE_CONTEXT 0x00000005")]
    public const int RESOURCE_CONTEXT = 0x00000005;
}
