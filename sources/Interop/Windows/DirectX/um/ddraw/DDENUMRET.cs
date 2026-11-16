// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DDENUMRET
{
    /// <include file='DDENUMRET.xml' path='doc/member[@name="DDENUMRET.DDENUMRET_CANCEL"]/*' />
    [NativeTypeName("#define DDENUMRET_CANCEL 0")]
    public const int DDENUMRET_CANCEL = 0;

    /// <include file='DDENUMRET.xml' path='doc/member[@name="DDENUMRET.DDENUMRET_OK"]/*' />
    [NativeTypeName("#define DDENUMRET_OK 1")]
    public const int DDENUMRET_OK = 1;
}
