// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHttpConnectionModuleContextContainer.xml' path='doc/member[@name="IHttpConnectionModuleContextContainer"]/*' />
[Guid("F3DD2FB3-4D11-4295-B8AB-4CB667ADD1FE")]
[NativeTypeName("struct IHttpConnectionModuleContextContainer : IHttpModuleContextContainer")]
[NativeInheritance("IHttpModuleContextContainer")]
public unsafe partial struct IHttpConnectionModuleContextContainer : IHttpConnectionModuleContextContainer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IHttpConnectionModuleContextContainer);

    public void** lpVtbl;

    /// <inheritdoc cref="IHttpModuleContextContainer.GetModuleContext" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public IHttpStoredContext* GetModuleContext([NativeTypeName("HTTP_MODULE_ID")] void* moduleId)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpConnectionModuleContextContainer*, void*, IHttpStoredContext*>)(lpVtbl[0]))((IHttpConnectionModuleContextContainer*)Unsafe.AsPointer(ref this), moduleId);
    }

    /// <inheritdoc cref="IHttpModuleContextContainer.SetModuleContext" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public HRESULT SetModuleContext(IHttpStoredContext* ppStoredContext, [NativeTypeName("HTTP_MODULE_ID")] void* moduleId)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpConnectionModuleContextContainer*, IHttpStoredContext*, void*, int>)(lpVtbl[1]))((IHttpConnectionModuleContextContainer*)Unsafe.AsPointer(ref this), ppStoredContext, moduleId);
    }

    /// <include file='IHttpConnectionModuleContextContainer.xml' path='doc/member[@name="IHttpConnectionModuleContextContainer.GetConnectionModuleContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public IHttpConnectionStoredContext* GetConnectionModuleContext([NativeTypeName("HTTP_MODULE_ID")] void* moduleId)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpConnectionModuleContextContainer*, void*, IHttpConnectionStoredContext*>)(lpVtbl[2]))((IHttpConnectionModuleContextContainer*)Unsafe.AsPointer(ref this), moduleId);
    }

    /// <include file='IHttpConnectionModuleContextContainer.xml' path='doc/member[@name="IHttpConnectionModuleContextContainer.SetConnectionModuleContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetConnectionModuleContext(IHttpConnectionStoredContext* ppStoredContext, [NativeTypeName("HTTP_MODULE_ID")] void* moduleId)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpConnectionModuleContextContainer*, IHttpConnectionStoredContext*, void*, int>)(lpVtbl[3]))((IHttpConnectionModuleContextContainer*)Unsafe.AsPointer(ref this), ppStoredContext, moduleId);
    }

    public interface Interface : IHttpModuleContextContainer.Interface
    {
        [VtblIndex(2)]
        IHttpConnectionStoredContext* GetConnectionModuleContext([NativeTypeName("HTTP_MODULE_ID")] void* moduleId);

        [VtblIndex(3)]
        HRESULT SetConnectionModuleContext(IHttpConnectionStoredContext* ppStoredContext, [NativeTypeName("HTTP_MODULE_ID")] void* moduleId);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("IHttpStoredContext *(HTTP_MODULE_ID)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, IHttpStoredContext*> GetModuleContext;

        [NativeTypeName("HRESULT (IHttpStoredContext *, HTTP_MODULE_ID)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpStoredContext*, void*, int> SetModuleContext;

        [NativeTypeName("IHttpConnectionStoredContext *(HTTP_MODULE_ID)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, IHttpConnectionStoredContext*> GetConnectionModuleContext;

        [NativeTypeName("HRESULT (IHttpConnectionStoredContext *, HTTP_MODULE_ID)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpConnectionStoredContext*, void*, int> SetConnectionModuleContext;
    }
}
