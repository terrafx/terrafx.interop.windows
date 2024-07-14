// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.display.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDisplayInformation5.xml' path='doc/member[@name="IDisplayInformation5"]/*' />
[Guid("3A5442DC-2CDE-4A8D-80D1-21DC5ADCC1AA")]
[NativeTypeName("struct IDisplayInformation5 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDisplayInformation5 : IDisplayInformation5.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDisplayInformation5));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformation5*, Guid*, void**, int>)(lpVtbl[0]))((IDisplayInformation5*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformation5*, uint>)(lpVtbl[1]))((IDisplayInformation5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformation5*, uint>)(lpVtbl[2]))((IDisplayInformation5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformation5*, uint*, Guid**, int>)(lpVtbl[3]))((IDisplayInformation5*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformation5*, HSTRING*, int>)(lpVtbl[4]))((IDisplayInformation5*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformation5*, TrustLevel*, int>)(lpVtbl[5]))((IDisplayInformation5*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDisplayInformation5.xml' path='doc/member[@name="IDisplayInformation5.GetAdvancedColorInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAdvancedColorInfo([NativeTypeName("ABI::Windows::Graphics::Display::IAdvancedColorInfo **")] IAdvancedColorInfo** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformation5*, IAdvancedColorInfo**, int>)(lpVtbl[6]))((IDisplayInformation5*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDisplayInformation5.xml' path='doc/member[@name="IDisplayInformation5.add_AdvancedColorInfoChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_AdvancedColorInfoChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayInformation_IInspectable_t *")] ITypedEventHandler<Pointer<IDisplayInformation>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformation5*, ITypedEventHandler<Pointer<IDisplayInformation>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[7]))((IDisplayInformation5*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IDisplayInformation5.xml' path='doc/member[@name="IDisplayInformation5.remove_AdvancedColorInfoChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_AdvancedColorInfoChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformation5*, EventRegistrationToken, int>)(lpVtbl[8]))((IDisplayInformation5*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetAdvancedColorInfo([NativeTypeName("ABI::Windows::Graphics::Display::IAdvancedColorInfo **")] IAdvancedColorInfo** value);

        [VtblIndex(7)]
        HRESULT add_AdvancedColorInfoChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayInformation_IInspectable_t *")] ITypedEventHandler<Pointer<IDisplayInformation>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(8)]
        HRESULT remove_AdvancedColorInfoChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::IAdvancedColorInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAdvancedColorInfo**, int> GetAdvancedColorInfo;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayInformation_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IDisplayInformation>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_AdvancedColorInfoChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_AdvancedColorInfoChanged;
    }
}
