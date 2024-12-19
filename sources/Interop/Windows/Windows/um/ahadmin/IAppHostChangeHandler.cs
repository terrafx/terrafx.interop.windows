// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppHostChangeHandler.xml' path='doc/member[@name="IAppHostChangeHandler"]/*' />
[Guid("09829352-87C2-418D-8D79-4133969A489D")]
[NativeTypeName("struct IAppHostChangeHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostChangeHandler : IAppHostChangeHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostChangeHandler));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostChangeHandler*, Guid*, void**, int>)(lpVtbl[0]))((IAppHostChangeHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostChangeHandler*, uint>)(lpVtbl[1]))((IAppHostChangeHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostChangeHandler*, uint>)(lpVtbl[2]))((IAppHostChangeHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppHostChangeHandler.xml' path='doc/member[@name="IAppHostChangeHandler.OnSectionChanges"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnSectionChanges([NativeTypeName("BSTR")] char* bstrSectionName, [NativeTypeName("BSTR")] char* bstrConfigPath)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostChangeHandler*, char*, char*, int>)(lpVtbl[3]))((IAppHostChangeHandler*)Unsafe.AsPointer(ref this), bstrSectionName, bstrConfigPath);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnSectionChanges([NativeTypeName("BSTR")] char* bstrSectionName, [NativeTypeName("BSTR")] char* bstrConfigPath);
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

        [NativeTypeName("HRESULT (BSTR, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, int> OnSectionChanges;
    }
}
