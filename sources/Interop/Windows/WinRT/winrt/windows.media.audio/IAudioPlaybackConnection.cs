// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioPlaybackConnection.xml' path='doc/member[@name="IAudioPlaybackConnection"]/*' />
[Guid("1A4C1DEA-CAFC-50E7-8718-EA3F81CBFA51")]
[NativeTypeName("struct IAudioPlaybackConnection : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioPlaybackConnection : IAudioPlaybackConnection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioPlaybackConnection));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioPlaybackConnection*, Guid*, void**, int>)(lpVtbl[0]))((IAudioPlaybackConnection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioPlaybackConnection*, uint>)(lpVtbl[1]))((IAudioPlaybackConnection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioPlaybackConnection*, uint>)(lpVtbl[2]))((IAudioPlaybackConnection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioPlaybackConnection*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioPlaybackConnection*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioPlaybackConnection*, HSTRING*, int>)(lpVtbl[4]))((IAudioPlaybackConnection*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioPlaybackConnection*, TrustLevel*, int>)(lpVtbl[5]))((IAudioPlaybackConnection*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioPlaybackConnection.xml' path='doc/member[@name="IAudioPlaybackConnection.Start"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioPlaybackConnection*, int>)(lpVtbl[6]))((IAudioPlaybackConnection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAudioPlaybackConnection.xml' path='doc/member[@name="IAudioPlaybackConnection.StartAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT StartAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioPlaybackConnection*, IAsyncAction**, int>)(lpVtbl[7]))((IAudioPlaybackConnection*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IAudioPlaybackConnection.xml' path='doc/member[@name="IAudioPlaybackConnection.get_DeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioPlaybackConnection*, HSTRING*, int>)(lpVtbl[8]))((IAudioPlaybackConnection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioPlaybackConnection.xml' path='doc/member[@name="IAudioPlaybackConnection.get_State"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_State([NativeTypeName("ABI::Windows::Media::Audio::AudioPlaybackConnectionState *")] AudioPlaybackConnectionState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioPlaybackConnection*, AudioPlaybackConnectionState*, int>)(lpVtbl[9]))((IAudioPlaybackConnection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioPlaybackConnection.xml' path='doc/member[@name="IAudioPlaybackConnection.Open"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Open([NativeTypeName("ABI::Windows::Media::Audio::IAudioPlaybackConnectionOpenResult **")] IAudioPlaybackConnectionOpenResult** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioPlaybackConnection*, IAudioPlaybackConnectionOpenResult**, int>)(lpVtbl[10]))((IAudioPlaybackConnection*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IAudioPlaybackConnection.xml' path='doc/member[@name="IAudioPlaybackConnection.OpenAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT OpenAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CAudioPlaybackConnectionOpenResult_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioPlaybackConnection*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[11]))((IAudioPlaybackConnection*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IAudioPlaybackConnection.xml' path='doc/member[@name="IAudioPlaybackConnection.add_StateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_StateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioPlaybackConnection_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioPlaybackConnection*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[12]))((IAudioPlaybackConnection*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAudioPlaybackConnection.xml' path='doc/member[@name="IAudioPlaybackConnection.remove_StateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_StateChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioPlaybackConnection*, EventRegistrationToken, int>)(lpVtbl[13]))((IAudioPlaybackConnection*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Start();

        [VtblIndex(7)]
        HRESULT StartAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(8)]
        HRESULT get_DeviceId(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_State([NativeTypeName("ABI::Windows::Media::Audio::AudioPlaybackConnectionState *")] AudioPlaybackConnectionState* value);

        [VtblIndex(10)]
        HRESULT Open([NativeTypeName("ABI::Windows::Media::Audio::IAudioPlaybackConnectionOpenResult **")] IAudioPlaybackConnectionOpenResult** result);

        [VtblIndex(11)]
        HRESULT OpenAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CAudioPlaybackConnectionOpenResult_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(12)]
        HRESULT add_StateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioPlaybackConnection_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(13)]
        HRESULT remove_StateChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Start;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> StartAsync;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DeviceId;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Audio::AudioPlaybackConnectionState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AudioPlaybackConnectionState*, int> get_State;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Audio::IAudioPlaybackConnectionOpenResult **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioPlaybackConnectionOpenResult**, int> Open;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CAudioPlaybackConnectionOpenResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<IntPtr>**, int> OpenAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioPlaybackConnection_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_StateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_StateChanged;
    }
}
