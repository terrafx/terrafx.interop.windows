// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IVideoStabilizationEffect.xml' path='doc/member[@name="IVideoStabilizationEffect"]/*' />
[Guid("0808A650-9698-4E57-877B-BD7CB2EE0F8A")]
[NativeTypeName("struct IVideoStabilizationEffect : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVideoStabilizationEffect : IVideoStabilizationEffect.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IVideoStabilizationEffect);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoStabilizationEffect*, Guid*, void**, int>)(lpVtbl[0]))((IVideoStabilizationEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoStabilizationEffect*, uint>)(lpVtbl[1]))((IVideoStabilizationEffect*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoStabilizationEffect*, uint>)(lpVtbl[2]))((IVideoStabilizationEffect*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoStabilizationEffect*, uint*, Guid**, int>)(lpVtbl[3]))((IVideoStabilizationEffect*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoStabilizationEffect*, HSTRING*, int>)(lpVtbl[4]))((IVideoStabilizationEffect*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoStabilizationEffect*, TrustLevel*, int>)(lpVtbl[5]))((IVideoStabilizationEffect*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVideoStabilizationEffect.xml' path='doc/member[@name="IVideoStabilizationEffect.put_Enabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_Enabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoStabilizationEffect*, byte, int>)(lpVtbl[6]))((IVideoStabilizationEffect*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoStabilizationEffect.xml' path='doc/member[@name="IVideoStabilizationEffect.get_Enabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Enabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoStabilizationEffect*, byte*, int>)(lpVtbl[7]))((IVideoStabilizationEffect*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoStabilizationEffect.xml' path='doc/member[@name="IVideoStabilizationEffect.add_EnabledChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_EnabledChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CVideoStabilizationEffect_Windows__CMedia__CCore__CVideoStabilizationEffectEnabledChangedEventArgs_t *")] ITypedEventHandler<Pointer<IVideoStabilizationEffect>, Pointer<IVideoStabilizationEffectEnabledChangedEventArgs>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoStabilizationEffect*, ITypedEventHandler<Pointer<IVideoStabilizationEffect>, Pointer<IVideoStabilizationEffectEnabledChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IVideoStabilizationEffect*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='IVideoStabilizationEffect.xml' path='doc/member[@name="IVideoStabilizationEffect.remove_EnabledChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_EnabledChanged(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoStabilizationEffect*, EventRegistrationToken, int>)(lpVtbl[9]))((IVideoStabilizationEffect*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='IVideoStabilizationEffect.xml' path='doc/member[@name="IVideoStabilizationEffect.GetRecommendedStreamConfiguration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetRecommendedStreamConfiguration([NativeTypeName("ABI::Windows::Media::Devices::IVideoDeviceController *")] IVideoDeviceController* controller, [NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties *")] IVideoEncodingProperties* desiredProperties, [NativeTypeName("ABI::Windows::Media::Capture::IVideoStreamConfiguration **")] IVideoStreamConfiguration** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoStabilizationEffect*, IVideoDeviceController*, IVideoEncodingProperties*, IVideoStreamConfiguration**, int>)(lpVtbl[10]))((IVideoStabilizationEffect*)Unsafe.AsPointer(ref this), controller, desiredProperties, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_Enabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(7)]
        HRESULT get_Enabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT add_EnabledChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CVideoStabilizationEffect_Windows__CMedia__CCore__CVideoStabilizationEffectEnabledChangedEventArgs_t *")] ITypedEventHandler<Pointer<IVideoStabilizationEffect>, Pointer<IVideoStabilizationEffectEnabledChangedEventArgs>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(9)]
        HRESULT remove_EnabledChanged(EventRegistrationToken cookie);

        [VtblIndex(10)]
        HRESULT GetRecommendedStreamConfiguration([NativeTypeName("ABI::Windows::Media::Devices::IVideoDeviceController *")] IVideoDeviceController* controller, [NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties *")] IVideoEncodingProperties* desiredProperties, [NativeTypeName("ABI::Windows::Media::Capture::IVideoStreamConfiguration **")] IVideoStreamConfiguration** value);
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

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_Enabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Enabled;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CVideoStabilizationEffect_Windows__CMedia__CCore__CVideoStabilizationEffectEnabledChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IVideoStabilizationEffect>, Pointer<IVideoStabilizationEffectEnabledChangedEventArgs>>*, EventRegistrationToken*, int> add_EnabledChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_EnabledChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::IVideoDeviceController *, ABI::Windows::Media::MediaProperties::IVideoEncodingProperties *, ABI::Windows::Media::Capture::IVideoStreamConfiguration **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVideoDeviceController*, IVideoEncodingProperties*, IVideoStreamConfiguration**, int> GetRecommendedStreamConfiguration;
    }
}
