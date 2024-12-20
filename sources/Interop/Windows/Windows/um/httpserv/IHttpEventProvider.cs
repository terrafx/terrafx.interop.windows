// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHttpEventProvider.xml' path='doc/member[@name="IHttpEventProvider"]/*' />
[Guid("6F3F657D-2FB8-43C6-A096-5064B41F0580")]
public unsafe partial struct IHttpEventProvider : IHttpEventProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpEventProvider));

    public void** lpVtbl;

    /// <include file='IHttpEventProvider.xml' path='doc/member[@name="IHttpEventProvider.SetErrorStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void SetErrorStatus(HRESULT hrError)
    {
        ((delegate* unmanaged[MemberFunction]<IHttpEventProvider*, HRESULT, void>)(lpVtbl[0]))((IHttpEventProvider*)Unsafe.AsPointer(ref this), hrError);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        void SetErrorStatus(HRESULT hrError);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("void (HRESULT)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HRESULT, void> SetErrorStatus;
    }
}
