// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.display.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDisplayInformationStatics.xml' path='doc/member[@name="IDisplayInformationStatics"]/*' />
[Guid("C6A02A6C-D452-44DC-BA07-96F3C6ADF9D1")]
[NativeTypeName("struct IDisplayInformationStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDisplayInformationStatics : IDisplayInformationStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDisplayInformationStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformationStatics*, Guid*, void**, int>)(lpVtbl[0]))((IDisplayInformationStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformationStatics*, uint>)(lpVtbl[1]))((IDisplayInformationStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformationStatics*, uint>)(lpVtbl[2]))((IDisplayInformationStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformationStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IDisplayInformationStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformationStatics*, HSTRING*, int>)(lpVtbl[4]))((IDisplayInformationStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformationStatics*, TrustLevel*, int>)(lpVtbl[5]))((IDisplayInformationStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDisplayInformationStatics.xml' path='doc/member[@name="IDisplayInformationStatics.GetForCurrentView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetForCurrentView([NativeTypeName("ABI::Windows::Graphics::Display::IDisplayInformation **")] IDisplayInformation** current)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformationStatics*, IDisplayInformation**, int>)(lpVtbl[6]))((IDisplayInformationStatics*)Unsafe.AsPointer(ref this), current);
    }

    /// <include file='IDisplayInformationStatics.xml' path='doc/member[@name="IDisplayInformationStatics.get_AutoRotationPreferences"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AutoRotationPreferences([NativeTypeName("ABI::Windows::Graphics::Display::DisplayOrientations *")] DisplayOrientations* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformationStatics*, DisplayOrientations*, int>)(lpVtbl[7]))((IDisplayInformationStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDisplayInformationStatics.xml' path='doc/member[@name="IDisplayInformationStatics.put_AutoRotationPreferences"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_AutoRotationPreferences([NativeTypeName("ABI::Windows::Graphics::Display::DisplayOrientations")] DisplayOrientations value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformationStatics*, DisplayOrientations, int>)(lpVtbl[8]))((IDisplayInformationStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDisplayInformationStatics.xml' path='doc/member[@name="IDisplayInformationStatics.add_DisplayContentsInvalidated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_DisplayContentsInvalidated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayInformation_IInspectable_t *")] ITypedEventHandler<Pointer<IDisplayInformation>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformationStatics*, ITypedEventHandler<Pointer<IDisplayInformation>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[9]))((IDisplayInformationStatics*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IDisplayInformationStatics.xml' path='doc/member[@name="IDisplayInformationStatics.remove_DisplayContentsInvalidated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_DisplayContentsInvalidated(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformationStatics*, EventRegistrationToken, int>)(lpVtbl[10]))((IDisplayInformationStatics*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetForCurrentView([NativeTypeName("ABI::Windows::Graphics::Display::IDisplayInformation **")] IDisplayInformation** current);

        [VtblIndex(7)]
        HRESULT get_AutoRotationPreferences([NativeTypeName("ABI::Windows::Graphics::Display::DisplayOrientations *")] DisplayOrientations* value);

        [VtblIndex(8)]
        HRESULT put_AutoRotationPreferences([NativeTypeName("ABI::Windows::Graphics::Display::DisplayOrientations")] DisplayOrientations value);

        [VtblIndex(9)]
        HRESULT add_DisplayContentsInvalidated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayInformation_IInspectable_t *")] ITypedEventHandler<Pointer<IDisplayInformation>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(10)]
        HRESULT remove_DisplayContentsInvalidated(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::IDisplayInformation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDisplayInformation**, int> GetForCurrentView;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::DisplayOrientations *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DisplayOrientations*, int> get_AutoRotationPreferences;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::DisplayOrientations) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DisplayOrientations, int> put_AutoRotationPreferences;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayInformation_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IDisplayInformation>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_DisplayContentsInvalidated;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_DisplayContentsInvalidated;
    }
}
