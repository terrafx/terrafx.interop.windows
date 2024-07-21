// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRadialControllerMenuItemStatics.xml' path='doc/member[@name="IRadialControllerMenuItemStatics"]/*' />
[Guid("249E0887-D842-4524-9DF8-E0D647EDC887")]
[NativeTypeName("struct IRadialControllerMenuItemStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRadialControllerMenuItemStatics : IRadialControllerMenuItemStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRadialControllerMenuItemStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenuItemStatics*, Guid*, void**, int>)(lpVtbl[0]))((IRadialControllerMenuItemStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenuItemStatics*, uint>)(lpVtbl[1]))((IRadialControllerMenuItemStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenuItemStatics*, uint>)(lpVtbl[2]))((IRadialControllerMenuItemStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenuItemStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IRadialControllerMenuItemStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenuItemStatics*, HSTRING*, int>)(lpVtbl[4]))((IRadialControllerMenuItemStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenuItemStatics*, TrustLevel*, int>)(lpVtbl[5]))((IRadialControllerMenuItemStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRadialControllerMenuItemStatics.xml' path='doc/member[@name="IRadialControllerMenuItemStatics.CreateFromIcon"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromIcon(HSTRING displayText, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* icon, [NativeTypeName("ABI::Windows::UI::Input::IRadialControllerMenuItem **")] IRadialControllerMenuItem** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenuItemStatics*, HSTRING, IRandomAccessStreamReference*, IRadialControllerMenuItem**, int>)(lpVtbl[6]))((IRadialControllerMenuItemStatics*)Unsafe.AsPointer(ref this), displayText, icon, result);
    }

    /// <include file='IRadialControllerMenuItemStatics.xml' path='doc/member[@name="IRadialControllerMenuItemStatics.CreateFromKnownIcon"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromKnownIcon(HSTRING displayText, [NativeTypeName("ABI::Windows::UI::Input::RadialControllerMenuKnownIcon")] RadialControllerMenuKnownIcon value, [NativeTypeName("ABI::Windows::UI::Input::IRadialControllerMenuItem **")] IRadialControllerMenuItem** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenuItemStatics*, HSTRING, RadialControllerMenuKnownIcon, IRadialControllerMenuItem**, int>)(lpVtbl[7]))((IRadialControllerMenuItemStatics*)Unsafe.AsPointer(ref this), displayText, value, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromIcon(HSTRING displayText, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* icon, [NativeTypeName("ABI::Windows::UI::Input::IRadialControllerMenuItem **")] IRadialControllerMenuItem** result);

        [VtblIndex(7)]
        HRESULT CreateFromKnownIcon(HSTRING displayText, [NativeTypeName("ABI::Windows::UI::Input::RadialControllerMenuKnownIcon")] RadialControllerMenuKnownIcon value, [NativeTypeName("ABI::Windows::UI::Input::IRadialControllerMenuItem **")] IRadialControllerMenuItem** result);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Storage::Streams::IRandomAccessStreamReference *, ABI::Windows::UI::Input::IRadialControllerMenuItem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IRandomAccessStreamReference*, IRadialControllerMenuItem**, int> CreateFromIcon;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::UI::Input::RadialControllerMenuKnownIcon, ABI::Windows::UI::Input::IRadialControllerMenuItem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, RadialControllerMenuKnownIcon, IRadialControllerMenuItem**, int> CreateFromKnownIcon;
    }
}
