// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='INamedContextContainer.xml' path='doc/member[@name="INamedContextContainer"]/*' />
[Guid("16DB6F7C-1A94-47CA-A8E8-FEA6005FF3BA")]
public unsafe partial struct INamedContextContainer : INamedContextContainer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INamedContextContainer));

    public void** lpVtbl;

    /// <include file='INamedContextContainer.xml' path='doc/member[@name="INamedContextContainer.GetNamedContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public IHttpStoredContext* GetNamedContext([NativeTypeName("LPCWSTR")] char* szName)
    {
        return ((delegate* unmanaged[MemberFunction]<INamedContextContainer*, char*, IHttpStoredContext*>)(lpVtbl[0]))((INamedContextContainer*)Unsafe.AsPointer(ref this), szName);
    }

    /// <include file='INamedContextContainer.xml' path='doc/member[@name="INamedContextContainer.SetNamedContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public HRESULT SetNamedContext(IHttpStoredContext* ppStoredContext, [NativeTypeName("LPCWSTR")] char* szName)
    {
        return ((delegate* unmanaged[MemberFunction]<INamedContextContainer*, IHttpStoredContext*, char*, int>)(lpVtbl[1]))((INamedContextContainer*)Unsafe.AsPointer(ref this), ppStoredContext, szName);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        IHttpStoredContext* GetNamedContext([NativeTypeName("LPCWSTR")] char* szName);

        [VtblIndex(1)]
        HRESULT SetNamedContext(IHttpStoredContext* ppStoredContext, [NativeTypeName("LPCWSTR")] char* szName);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("IHttpStoredContext *(LPCWSTR)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, IHttpStoredContext*> GetNamedContext;

        [NativeTypeName("HRESULT (IHttpStoredContext *, LPCWSTR)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpStoredContext*, char*, int> SetNamedContext;
    }
}
