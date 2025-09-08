// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ole2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='OLESTREAM.xml' path='doc/member[@name="OLESTREAM"]/*' />
public unsafe partial struct OLESTREAM
{
    /// <include file='OLESTREAM.xml' path='doc/member[@name="OLESTREAM.lpstbl"]/*' />
    [NativeTypeName("LPOLESTREAMVTBL")]
    public OLESTREAMVTBL* lpstbl;
}
