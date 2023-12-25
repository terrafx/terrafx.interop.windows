// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IKeyboardDeliveryInterceptorStatics.xml' path='doc/member[@name="IKeyboardDeliveryInterceptorStatics"]/*' />
[Guid("F9F63BA2-CEBA-4755-8A7E-14C0FFECD239")]
[NativeTypeName("struct IKeyboardDeliveryInterceptorStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKeyboardDeliveryInterceptorStatics : IKeyboardDeliveryInterceptorStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IKeyboardDeliveryInterceptorStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyboardDeliveryInterceptorStatics*, Guid*, void**, int>)(lpVtbl[0]))((IKeyboardDeliveryInterceptorStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyboardDeliveryInterceptorStatics*, uint>)(lpVtbl[1]))((IKeyboardDeliveryInterceptorStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyboardDeliveryInterceptorStatics*, uint>)(lpVtbl[2]))((IKeyboardDeliveryInterceptorStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyboardDeliveryInterceptorStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IKeyboardDeliveryInterceptorStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyboardDeliveryInterceptorStatics*, HSTRING*, int>)(lpVtbl[4]))((IKeyboardDeliveryInterceptorStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyboardDeliveryInterceptorStatics*, TrustLevel*, int>)(lpVtbl[5]))((IKeyboardDeliveryInterceptorStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IKeyboardDeliveryInterceptorStatics.xml' path='doc/member[@name="IKeyboardDeliveryInterceptorStatics.GetForCurrentView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetForCurrentView([NativeTypeName("ABI::Windows::UI::Input::IKeyboardDeliveryInterceptor **")] IKeyboardDeliveryInterceptor** keyboardDeliverySettings)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyboardDeliveryInterceptorStatics*, IKeyboardDeliveryInterceptor**, int>)(lpVtbl[6]))((IKeyboardDeliveryInterceptorStatics*)Unsafe.AsPointer(ref this), keyboardDeliverySettings);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetForCurrentView([NativeTypeName("ABI::Windows::UI::Input::IKeyboardDeliveryInterceptor **")] IKeyboardDeliveryInterceptor** keyboardDeliverySettings);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Input::IKeyboardDeliveryInterceptor **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IKeyboardDeliveryInterceptor**, int> GetForCurrentView;
    }
}
