// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ole2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='OLESTREAMVTBL.xml' path='doc/member[@name="OLESTREAMVTBL"]/*' />
public unsafe partial struct OLESTREAMVTBL
{
    /// <include file='OLESTREAMVTBL.xml' path='doc/member[@name="OLESTREAMVTBL.Get"]/*' />
    [NativeTypeName("DWORD (*)(LPOLESTREAM, void *, DWORD) __attribute__((stdcall))")]
    public delegate* unmanaged<OLESTREAM*, void*, uint, uint> Get;

    /// <include file='OLESTREAMVTBL.xml' path='doc/member[@name="OLESTREAMVTBL.Put"]/*' />
    [NativeTypeName("DWORD (*)(LPOLESTREAM, const void *, DWORD) __attribute__((stdcall))")]
    public delegate* unmanaged<OLESTREAM*, void*, uint, uint> Put;
}
