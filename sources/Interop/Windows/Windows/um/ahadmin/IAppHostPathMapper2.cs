// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppHostPathMapper2.xml' path='doc/member[@name="IAppHostPathMapper2"]/*' />
[Guid("0F80E901-8F4C-449A-BF90-13D5D082F187")]
[NativeTypeName("struct IAppHostPathMapper2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostPathMapper2 : IAppHostPathMapper2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppHostPathMapper2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPathMapper2*, Guid*, void**, int>)(lpVtbl[0]))((IAppHostPathMapper2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPathMapper2*, uint>)(lpVtbl[1]))((IAppHostPathMapper2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPathMapper2*, uint>)(lpVtbl[2]))((IAppHostPathMapper2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppHostPathMapper2.xml' path='doc/member[@name="IAppHostPathMapper2.MapPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT MapPath([NativeTypeName("BSTR")] char* bstrConfigPath, [NativeTypeName("BSTR")] char* bstrMappedPhysicalPath, [NativeTypeName("BSTR *")] char** pbstrNewPhysicalPath, HANDLE* phImpersonationToken)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPathMapper2*, char*, char*, char**, HANDLE*, int>)(lpVtbl[3]))((IAppHostPathMapper2*)Unsafe.AsPointer(ref this), bstrConfigPath, bstrMappedPhysicalPath, pbstrNewPhysicalPath, phImpersonationToken);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT MapPath([NativeTypeName("BSTR")] char* bstrConfigPath, [NativeTypeName("BSTR")] char* bstrMappedPhysicalPath, [NativeTypeName("BSTR *")] char** pbstrNewPhysicalPath, HANDLE* phImpersonationToken);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (BSTR, BSTR, BSTR *, HANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, char**, HANDLE*, int> MapPath;
    }
}
