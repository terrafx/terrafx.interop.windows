// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHttpModuleFactory.xml' path='doc/member[@name="IHttpModuleFactory"]/*' />
[Guid("BA32D330-9EA8-4B9E-89F1-8C76A323277F")]
public unsafe partial struct IHttpModuleFactory : IHttpModuleFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IHttpModuleFactory);

    public void** lpVtbl;

    /// <include file='IHttpModuleFactory.xml' path='doc/member[@name="IHttpModuleFactory.GetHttpModule"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT GetHttpModule(CHttpModule** ppModule, IModuleAllocator* pAllocator)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpModuleFactory*, CHttpModule**, IModuleAllocator*, int>)(lpVtbl[0]))((IHttpModuleFactory*)Unsafe.AsPointer(ref this), ppModule, pAllocator);
    }

    /// <include file='IHttpModuleFactory.xml' path='doc/member[@name="IHttpModuleFactory.Terminate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public void Terminate()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpModuleFactory*, void>)(lpVtbl[1]))((IHttpModuleFactory*)Unsafe.AsPointer(ref this));
    }

    public interface Interface
    {
        [VtblIndex(0)]
        HRESULT GetHttpModule(CHttpModule** ppModule, IModuleAllocator* pAllocator);

        [VtblIndex(1)]
        void Terminate();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (CHttpModule **, IModuleAllocator *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CHttpModule**, IModuleAllocator*, int> GetHttpModule;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> Terminate;
    }
}
