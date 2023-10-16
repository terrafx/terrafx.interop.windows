// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IActionProgressDialog.xml' path='doc/member[@name="IActionProgressDialog"]/*' />
[Guid("49FF1172-EADC-446D-9285-156453A6431C")]
[NativeTypeName("struct IActionProgressDialog : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IActionProgressDialog : IActionProgressDialog.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IActionProgressDialog));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IActionProgressDialog*, Guid*, void**, int>)(lpVtbl[0]))((IActionProgressDialog*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IActionProgressDialog*, uint>)(lpVtbl[1]))((IActionProgressDialog*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IActionProgressDialog*, uint>)(lpVtbl[2]))((IActionProgressDialog*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IActionProgressDialog.xml' path='doc/member[@name="IActionProgressDialog.Initialize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize([NativeTypeName("SPINITF")] uint flags, [NativeTypeName("LPCWSTR")] char* pszTitle, [NativeTypeName("LPCWSTR")] char* pszCancel)
    {
        return ((delegate* unmanaged[MemberFunction]<IActionProgressDialog*, uint, char*, char*, int>)(lpVtbl[3]))((IActionProgressDialog*)Unsafe.AsPointer(ref this), flags, pszTitle, pszCancel);
    }

    /// <include file='IActionProgressDialog.xml' path='doc/member[@name="IActionProgressDialog.Stop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged[MemberFunction]<IActionProgressDialog*, int>)(lpVtbl[4]))((IActionProgressDialog*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize([NativeTypeName("SPINITF")] uint flags, [NativeTypeName("LPCWSTR")] char* pszTitle, [NativeTypeName("LPCWSTR")] char* pszCancel);

        [VtblIndex(4)]
        HRESULT Stop();
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

        [NativeTypeName("HRESULT (SPINITF, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, char*, int> Initialize;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Stop;
    }
}
