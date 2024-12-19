// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IPreBeginRequestProvider.xml' path='doc/member[@name="IPreBeginRequestProvider"]/*' />
[Guid("FB715D26-AFF9-476A-8FC0-6B1ACB3D1098")]
[NativeTypeName("struct IPreBeginRequestProvider : IHttpEventProvider")]
[NativeInheritance("IHttpEventProvider")]
public unsafe partial struct IPreBeginRequestProvider : IPreBeginRequestProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPreBeginRequestProvider));

    public void** lpVtbl;

    /// <inheritdoc cref="IHttpEventProvider.SetErrorStatus" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void SetErrorStatus(HRESULT hrError)
    {
        ((delegate* unmanaged[MemberFunction]<IPreBeginRequestProvider*, HRESULT, void>)(lpVtbl[0]))((IPreBeginRequestProvider*)Unsafe.AsPointer(ref this), hrError);
    }

    /// <include file='IPreBeginRequestProvider.xml' path='doc/member[@name="IPreBeginRequestProvider.GetHttpContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public IHttpContext* GetHttpContext()
    {
        return ((delegate* unmanaged[MemberFunction]<IPreBeginRequestProvider*, IHttpContext*>)(lpVtbl[1]))((IPreBeginRequestProvider*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IHttpEventProvider.Interface
    {
        [VtblIndex(1)]
        IHttpContext* GetHttpContext();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("void (HRESULT)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HRESULT, void> SetErrorStatus;

        [NativeTypeName("IHttpContext *()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpContext*> GetHttpContext;
    }
}
