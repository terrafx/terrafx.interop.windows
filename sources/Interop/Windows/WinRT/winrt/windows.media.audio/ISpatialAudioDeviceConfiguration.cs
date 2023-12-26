// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpatialAudioDeviceConfiguration.xml' path='doc/member[@name="ISpatialAudioDeviceConfiguration"]/*' />
[Guid("EE830034-61CF-5749-9DA4-10F0FE028199")]
[NativeTypeName("struct ISpatialAudioDeviceConfiguration : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpatialAudioDeviceConfiguration : ISpatialAudioDeviceConfiguration.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAudioDeviceConfiguration));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioDeviceConfiguration*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioDeviceConfiguration*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioDeviceConfiguration*, uint>)(lpVtbl[1]))((ISpatialAudioDeviceConfiguration*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioDeviceConfiguration*, uint>)(lpVtbl[2]))((ISpatialAudioDeviceConfiguration*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioDeviceConfiguration*, uint*, Guid**, int>)(lpVtbl[3]))((ISpatialAudioDeviceConfiguration*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioDeviceConfiguration*, HSTRING*, int>)(lpVtbl[4]))((ISpatialAudioDeviceConfiguration*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioDeviceConfiguration*, TrustLevel*, int>)(lpVtbl[5]))((ISpatialAudioDeviceConfiguration*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpatialAudioDeviceConfiguration.xml' path='doc/member[@name="ISpatialAudioDeviceConfiguration.get_DeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioDeviceConfiguration*, HSTRING*, int>)(lpVtbl[6]))((ISpatialAudioDeviceConfiguration*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpatialAudioDeviceConfiguration.xml' path='doc/member[@name="ISpatialAudioDeviceConfiguration.get_IsSpatialAudioSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsSpatialAudioSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioDeviceConfiguration*, byte*, int>)(lpVtbl[7]))((ISpatialAudioDeviceConfiguration*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpatialAudioDeviceConfiguration.xml' path='doc/member[@name="ISpatialAudioDeviceConfiguration.IsSpatialAudioFormatSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT IsSpatialAudioFormatSupported(HSTRING subtype, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioDeviceConfiguration*, HSTRING, byte*, int>)(lpVtbl[8]))((ISpatialAudioDeviceConfiguration*)Unsafe.AsPointer(ref this), subtype, result);
    }

    /// <include file='ISpatialAudioDeviceConfiguration.xml' path='doc/member[@name="ISpatialAudioDeviceConfiguration.get_ActiveSpatialAudioFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ActiveSpatialAudioFormat(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioDeviceConfiguration*, HSTRING*, int>)(lpVtbl[9]))((ISpatialAudioDeviceConfiguration*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpatialAudioDeviceConfiguration.xml' path='doc/member[@name="ISpatialAudioDeviceConfiguration.get_DefaultSpatialAudioFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_DefaultSpatialAudioFormat(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioDeviceConfiguration*, HSTRING*, int>)(lpVtbl[10]))((ISpatialAudioDeviceConfiguration*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpatialAudioDeviceConfiguration.xml' path='doc/member[@name="ISpatialAudioDeviceConfiguration.SetDefaultSpatialAudioFormatAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetDefaultSpatialAudioFormatAsync(HSTRING subtype, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CSetDefaultSpatialAudioFormatResult_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioDeviceConfiguration*, HSTRING, IAsyncOperation<IntPtr>**, int>)(lpVtbl[11]))((ISpatialAudioDeviceConfiguration*)Unsafe.AsPointer(ref this), subtype, operation);
    }

    /// <include file='ISpatialAudioDeviceConfiguration.xml' path='doc/member[@name="ISpatialAudioDeviceConfiguration.add_ConfigurationChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_ConfigurationChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CSpatialAudioDeviceConfiguration_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioDeviceConfiguration*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[12]))((ISpatialAudioDeviceConfiguration*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ISpatialAudioDeviceConfiguration.xml' path='doc/member[@name="ISpatialAudioDeviceConfiguration.remove_ConfigurationChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_ConfigurationChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioDeviceConfiguration*, EventRegistrationToken, int>)(lpVtbl[13]))((ISpatialAudioDeviceConfiguration*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DeviceId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_IsSpatialAudioSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT IsSpatialAudioFormatSupported(HSTRING subtype, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(9)]
        HRESULT get_ActiveSpatialAudioFormat(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_DefaultSpatialAudioFormat(HSTRING* value);

        [VtblIndex(11)]
        HRESULT SetDefaultSpatialAudioFormatAsync(HSTRING subtype, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CSetDefaultSpatialAudioFormatResult_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(12)]
        HRESULT add_ConfigurationChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CSpatialAudioDeviceConfiguration_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(13)]
        HRESULT remove_ConfigurationChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DeviceId;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsSpatialAudioSupported;

        [NativeTypeName("HRESULT (HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, byte*, int> IsSpatialAudioFormatSupported;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ActiveSpatialAudioFormat;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DefaultSpatialAudioFormat;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CSetDefaultSpatialAudioFormatResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<IntPtr>**, int> SetDefaultSpatialAudioFormatAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CSpatialAudioDeviceConfiguration_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_ConfigurationChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ConfigurationChanged;
    }
}
