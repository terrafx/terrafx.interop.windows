// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHttpModuleContextContainer.xml' path='doc/member[@name="IHttpModuleContextContainer"]/*' />
[Guid("D7FAD7C9-AA27-4AB9-BD60-E55CCBA3F5DC")]
public unsafe partial struct IHttpModuleContextContainer : IHttpModuleContextContainer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IHttpModuleContextContainer);

    public void** lpVtbl;

    /// <include file='IHttpModuleContextContainer.xml' path='doc/member[@name="IHttpModuleContextContainer.GetModuleContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public IHttpStoredContext* GetModuleContext([NativeTypeName("HTTP_MODULE_ID")] void* moduleId)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpModuleContextContainer*, void*, IHttpStoredContext*>)(lpVtbl[0]))((IHttpModuleContextContainer*)Unsafe.AsPointer(ref this), moduleId);
    }

    /// <include file='IHttpModuleContextContainer.xml' path='doc/member[@name="IHttpModuleContextContainer.SetModuleContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public HRESULT SetModuleContext(IHttpStoredContext* ppStoredContext, [NativeTypeName("HTTP_MODULE_ID")] void* moduleId)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpModuleContextContainer*, IHttpStoredContext*, void*, int>)(lpVtbl[1]))((IHttpModuleContextContainer*)Unsafe.AsPointer(ref this), ppStoredContext, moduleId);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        IHttpStoredContext* GetModuleContext([NativeTypeName("HTTP_MODULE_ID")] void* moduleId);

        [VtblIndex(1)]
        HRESULT SetModuleContext(IHttpStoredContext* ppStoredContext, [NativeTypeName("HTTP_MODULE_ID")] void* moduleId);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("IHttpStoredContext *(HTTP_MODULE_ID)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, IHttpStoredContext*> GetModuleContext;

        [NativeTypeName("HRESULT (IHttpStoredContext *, HTTP_MODULE_ID)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpStoredContext*, void*, int> SetModuleContext;
    }
}
