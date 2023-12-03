// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SE_SID.xml' path='doc/member[@name="SE_SID"]/*' />
[StructLayout(LayoutKind.Explicit)]
public partial struct SE_SID
{
    /// <include file='SE_SID.xml' path='doc/member[@name="SE_SID.Sid"]/*' />
    [FieldOffset(0)]
    public SID Sid;

    /// <include file='SE_SID.xml' path='doc/member[@name="SE_SID.Buffer"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("BYTE[68]")]
    public _Buffer_e__FixedBuffer Buffer;

    /// <include file='_Buffer_e__FixedBuffer.xml' path='doc/member[@name="_Buffer_e__FixedBuffer"]/*' />
    [InlineArray(68)]
    public partial struct _Buffer_e__FixedBuffer
    {
        public byte e0;
    }
}
