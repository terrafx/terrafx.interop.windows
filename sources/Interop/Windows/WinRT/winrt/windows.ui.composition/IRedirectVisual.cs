// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRedirectVisual.xml' path='doc/member[@name="IRedirectVisual"]/*' />
[Guid("8CC6E340-8B75-5422-B06F-09FFE9F8617E")]
[NativeTypeName("struct IRedirectVisual : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRedirectVisual : IRedirectVisual.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRedirectVisual));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRedirectVisual*, Guid*, void**, int>)(lpVtbl[0]))((IRedirectVisual*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRedirectVisual*, uint>)(lpVtbl[1]))((IRedirectVisual*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRedirectVisual*, uint>)(lpVtbl[2]))((IRedirectVisual*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRedirectVisual*, uint*, Guid**, int>)(lpVtbl[3]))((IRedirectVisual*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRedirectVisual*, HSTRING*, int>)(lpVtbl[4]))((IRedirectVisual*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRedirectVisual*, TrustLevel*, int>)(lpVtbl[5]))((IRedirectVisual*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRedirectVisual.xml' path='doc/member[@name="IRedirectVisual.get_Source"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Source([NativeTypeName("ABI::Windows::UI::Composition::IVisual **")] IVisual** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRedirectVisual*, IVisual**, int>)(lpVtbl[6]))((IRedirectVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRedirectVisual.xml' path='doc/member[@name="IRedirectVisual.put_Source"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Source([NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRedirectVisual*, IVisual*, int>)(lpVtbl[7]))((IRedirectVisual*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Source([NativeTypeName("ABI::Windows::UI::Composition::IVisual **")] IVisual** value);

        [VtblIndex(7)]
        HRESULT put_Source([NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual* value);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IVisual **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVisual**, int> get_Source;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IVisual *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVisual*, int> put_Source;
    }
}
