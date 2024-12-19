// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppHostPathMapper.xml' path='doc/member[@name="IAppHostPathMapper"]/*' />
[Guid("E7927575-5CC3-403B-822E-328A6B904BEE")]
[NativeTypeName("struct IAppHostPathMapper : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostPathMapper : IAppHostPathMapper.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostPathMapper));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPathMapper*, Guid*, void**, int>)(lpVtbl[0]))((IAppHostPathMapper*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPathMapper*, uint>)(lpVtbl[1]))((IAppHostPathMapper*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPathMapper*, uint>)(lpVtbl[2]))((IAppHostPathMapper*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppHostPathMapper.xml' path='doc/member[@name="IAppHostPathMapper.MapPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT MapPath([NativeTypeName("BSTR")] char* bstrConfigPath, [NativeTypeName("BSTR")] char* bstrMappedPhysicalPath, [NativeTypeName("BSTR *")] char** pbstrNewPhysicalPath)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPathMapper*, char*, char*, char**, int>)(lpVtbl[3]))((IAppHostPathMapper*)Unsafe.AsPointer(ref this), bstrConfigPath, bstrMappedPhysicalPath, pbstrNewPhysicalPath);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT MapPath([NativeTypeName("BSTR")] char* bstrConfigPath, [NativeTypeName("BSTR")] char* bstrMappedPhysicalPath, [NativeTypeName("BSTR *")] char** pbstrNewPhysicalPath);
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

        [NativeTypeName("HRESULT (BSTR, BSTR, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, char**, int> MapPath;
    }
}
