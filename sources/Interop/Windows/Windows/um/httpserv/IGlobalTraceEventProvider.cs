// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IGlobalTraceEventProvider.xml' path='doc/member[@name="IGlobalTraceEventProvider"]/*' />
[Guid("7C6BB150-0310-4718-A01F-6FACEB62DC1D")]
[NativeTypeName("struct IGlobalTraceEventProvider : IHttpEventProvider")]
[NativeInheritance("IHttpEventProvider")]
public unsafe partial struct IGlobalTraceEventProvider : IGlobalTraceEventProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGlobalTraceEventProvider));

    public void** lpVtbl;

    /// <inheritdoc cref="IHttpEventProvider.SetErrorStatus" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void SetErrorStatus(HRESULT hrError)
    {
        ((delegate* unmanaged[MemberFunction]<IGlobalTraceEventProvider*, HRESULT, void>)(lpVtbl[0]))((IGlobalTraceEventProvider*)Unsafe.AsPointer(ref this), hrError);
    }

    /// <include file='IGlobalTraceEventProvider.xml' path='doc/member[@name="IGlobalTraceEventProvider.GetTraceEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public HRESULT GetTraceEvent(HTTP_TRACE_EVENT** ppTraceEvent)
    {
        return ((delegate* unmanaged[MemberFunction]<IGlobalTraceEventProvider*, HTTP_TRACE_EVENT**, int>)(lpVtbl[1]))((IGlobalTraceEventProvider*)Unsafe.AsPointer(ref this), ppTraceEvent);
    }

    /// <include file='IGlobalTraceEventProvider.xml' path='doc/member[@name="IGlobalTraceEventProvider.CheckSubscription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public BOOL CheckSubscription([NativeTypeName("HTTP_MODULE_ID")] void* ModuleId)
    {
        return ((delegate* unmanaged[MemberFunction]<IGlobalTraceEventProvider*, void*, int>)(lpVtbl[2]))((IGlobalTraceEventProvider*)Unsafe.AsPointer(ref this), ModuleId);
    }

    /// <include file='IGlobalTraceEventProvider.xml' path='doc/member[@name="IGlobalTraceEventProvider.GetCurrentHttpRequestContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCurrentHttpRequestContext(IHttpContext** ppHttpContext)
    {
        return ((delegate* unmanaged[MemberFunction]<IGlobalTraceEventProvider*, IHttpContext**, int>)(lpVtbl[3]))((IGlobalTraceEventProvider*)Unsafe.AsPointer(ref this), ppHttpContext);
    }

    public interface Interface : IHttpEventProvider.Interface
    {
        [VtblIndex(1)]
        HRESULT GetTraceEvent(HTTP_TRACE_EVENT** ppTraceEvent);

        [VtblIndex(2)]
        BOOL CheckSubscription([NativeTypeName("HTTP_MODULE_ID")] void* ModuleId);

        [VtblIndex(3)]
        HRESULT GetCurrentHttpRequestContext(IHttpContext** ppHttpContext);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("void (HRESULT)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HRESULT, void> SetErrorStatus;

        [NativeTypeName("HRESULT (HTTP_TRACE_EVENT **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HTTP_TRACE_EVENT**, int> GetTraceEvent;

        [NativeTypeName("BOOL (HTTP_MODULE_ID)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, int> CheckSubscription;

        [NativeTypeName("HRESULT (IHttpContext **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpContext**, int> GetCurrentHttpRequestContext;
    }
}
