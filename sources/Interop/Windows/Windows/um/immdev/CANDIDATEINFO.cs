// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/immdev.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='CANDIDATEINFO.xml' path='doc/member[@name="CANDIDATEINFO"]/*' />
public partial struct CANDIDATEINFO
{
    /// <include file='CANDIDATEINFO.xml' path='doc/member[@name="CANDIDATEINFO.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='CANDIDATEINFO.xml' path='doc/member[@name="CANDIDATEINFO.dwCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCount;

    /// <include file='CANDIDATEINFO.xml' path='doc/member[@name="CANDIDATEINFO.dwOffset"]/*' />
    [NativeTypeName("DWORD[32]")]
    public _dwOffset_e__FixedBuffer dwOffset;

    /// <include file='CANDIDATEINFO.xml' path='doc/member[@name="CANDIDATEINFO.dwPrivateSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwPrivateSize;

    /// <include file='CANDIDATEINFO.xml' path='doc/member[@name="CANDIDATEINFO.dwPrivateOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwPrivateOffset;

    /// <include file='_dwOffset_e__FixedBuffer.xml' path='doc/member[@name="_dwOffset_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    public partial struct _dwOffset_e__FixedBuffer
    {
        public uint e0;
    }
}
