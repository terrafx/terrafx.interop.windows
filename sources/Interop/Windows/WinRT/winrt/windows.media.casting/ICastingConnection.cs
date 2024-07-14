// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.casting.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICastingConnection.xml' path='doc/member[@name="ICastingConnection"]/*' />
[Guid("CD951653-C2F1-4498-8B78-5FB4CD3640DD")]
[NativeTypeName("struct ICastingConnection : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICastingConnection : ICastingConnection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICastingConnection));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingConnection*, Guid*, void**, int>)(lpVtbl[0]))((ICastingConnection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingConnection*, uint>)(lpVtbl[1]))((ICastingConnection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingConnection*, uint>)(lpVtbl[2]))((ICastingConnection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingConnection*, uint*, Guid**, int>)(lpVtbl[3]))((ICastingConnection*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingConnection*, HSTRING*, int>)(lpVtbl[4]))((ICastingConnection*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingConnection*, TrustLevel*, int>)(lpVtbl[5]))((ICastingConnection*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICastingConnection.xml' path='doc/member[@name="ICastingConnection.get_State"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_State([NativeTypeName("ABI::Windows::Media::Casting::CastingConnectionState *")] CastingConnectionState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingConnection*, CastingConnectionState*, int>)(lpVtbl[6]))((ICastingConnection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICastingConnection.xml' path='doc/member[@name="ICastingConnection.get_Device"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Device([NativeTypeName("ABI::Windows::Media::Casting::ICastingDevice **")] ICastingDevice** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingConnection*, ICastingDevice**, int>)(lpVtbl[7]))((ICastingConnection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICastingConnection.xml' path='doc/member[@name="ICastingConnection.get_Source"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Source([NativeTypeName("ABI::Windows::Media::Casting::ICastingSource **")] ICastingSource** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingConnection*, ICastingSource**, int>)(lpVtbl[8]))((ICastingConnection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICastingConnection.xml' path='doc/member[@name="ICastingConnection.put_Source"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Source([NativeTypeName("ABI::Windows::Media::Casting::ICastingSource *")] ICastingSource* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingConnection*, ICastingSource*, int>)(lpVtbl[9]))((ICastingConnection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICastingConnection.xml' path='doc/member[@name="ICastingConnection.add_StateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_StateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCasting__CCastingConnection_IInspectable_t *")] ITypedEventHandler<Pointer<ICastingConnection>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingConnection*, ITypedEventHandler<Pointer<ICastingConnection>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((ICastingConnection*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ICastingConnection.xml' path='doc/member[@name="ICastingConnection.remove_StateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_StateChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingConnection*, EventRegistrationToken, int>)(lpVtbl[11]))((ICastingConnection*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ICastingConnection.xml' path='doc/member[@name="ICastingConnection.add_ErrorOccurred"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_ErrorOccurred([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCasting__CCastingConnection_Windows__CMedia__CCasting__CCastingConnectionErrorOccurredEventArgs_t *")] ITypedEventHandler<Pointer<ICastingConnection>, Pointer<ICastingConnectionErrorOccurredEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingConnection*, ITypedEventHandler<Pointer<ICastingConnection>, Pointer<ICastingConnectionErrorOccurredEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[12]))((ICastingConnection*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ICastingConnection.xml' path='doc/member[@name="ICastingConnection.remove_ErrorOccurred"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_ErrorOccurred(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingConnection*, EventRegistrationToken, int>)(lpVtbl[13]))((ICastingConnection*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ICastingConnection.xml' path='doc/member[@name="ICastingConnection.RequestStartCastingAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT RequestStartCastingAsync([NativeTypeName("ABI::Windows::Media::Casting::ICastingSource *")] ICastingSource* value, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCasting__CCastingConnectionErrorStatus_t **")] IAsyncOperation<CastingConnectionErrorStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingConnection*, ICastingSource*, IAsyncOperation<CastingConnectionErrorStatus>**, int>)(lpVtbl[14]))((ICastingConnection*)Unsafe.AsPointer(ref this), value, operation);
    }

    /// <include file='ICastingConnection.xml' path='doc/member[@name="ICastingConnection.DisconnectAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT DisconnectAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCasting__CCastingConnectionErrorStatus_t **")] IAsyncOperation<CastingConnectionErrorStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingConnection*, IAsyncOperation<CastingConnectionErrorStatus>**, int>)(lpVtbl[15]))((ICastingConnection*)Unsafe.AsPointer(ref this), operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_State([NativeTypeName("ABI::Windows::Media::Casting::CastingConnectionState *")] CastingConnectionState* value);

        [VtblIndex(7)]
        HRESULT get_Device([NativeTypeName("ABI::Windows::Media::Casting::ICastingDevice **")] ICastingDevice** value);

        [VtblIndex(8)]
        HRESULT get_Source([NativeTypeName("ABI::Windows::Media::Casting::ICastingSource **")] ICastingSource** value);

        [VtblIndex(9)]
        HRESULT put_Source([NativeTypeName("ABI::Windows::Media::Casting::ICastingSource *")] ICastingSource* value);

        [VtblIndex(10)]
        HRESULT add_StateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCasting__CCastingConnection_IInspectable_t *")] ITypedEventHandler<Pointer<ICastingConnection>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_StateChanged(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT add_ErrorOccurred([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCasting__CCastingConnection_Windows__CMedia__CCasting__CCastingConnectionErrorOccurredEventArgs_t *")] ITypedEventHandler<Pointer<ICastingConnection>, Pointer<ICastingConnectionErrorOccurredEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(13)]
        HRESULT remove_ErrorOccurred(EventRegistrationToken token);

        [VtblIndex(14)]
        HRESULT RequestStartCastingAsync([NativeTypeName("ABI::Windows::Media::Casting::ICastingSource *")] ICastingSource* value, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCasting__CCastingConnectionErrorStatus_t **")] IAsyncOperation<CastingConnectionErrorStatus>** operation);

        [VtblIndex(15)]
        HRESULT DisconnectAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCasting__CCastingConnectionErrorStatus_t **")] IAsyncOperation<CastingConnectionErrorStatus>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Casting::CastingConnectionState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CastingConnectionState*, int> get_State;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Casting::ICastingDevice **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICastingDevice**, int> get_Device;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Casting::ICastingSource **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICastingSource**, int> get_Source;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Casting::ICastingSource *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICastingSource*, int> put_Source;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCasting__CCastingConnection_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICastingConnection>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_StateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_StateChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCasting__CCastingConnection_Windows__CMedia__CCasting__CCastingConnectionErrorOccurredEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICastingConnection>, Pointer<ICastingConnectionErrorOccurredEventArgs>>*, EventRegistrationToken*, int> add_ErrorOccurred;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ErrorOccurred;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Casting::ICastingSource *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCasting__CCastingConnectionErrorStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICastingSource*, IAsyncOperation<CastingConnectionErrorStatus>**, int> RequestStartCastingAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCasting__CCastingConnectionErrorStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<CastingConnectionErrorStatus>**, int> DisconnectAsync;
    }
}
