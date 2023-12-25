// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmsDeviceMessageStore.xml' path='doc/member[@name="ISmsDeviceMessageStore"]/*' />
[Guid("9889F253-F188-4427-8D54-CE0C2423C5C1")]
[NativeTypeName("struct ISmsDeviceMessageStore : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("SmsDeviceMessageStore may be altered or unavailable for releases after Windows 10.")]
public unsafe partial struct ISmsDeviceMessageStore : ISmsDeviceMessageStore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmsDeviceMessageStore));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDeviceMessageStore*, Guid*, void**, int>)(lpVtbl[0]))((ISmsDeviceMessageStore*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDeviceMessageStore*, uint>)(lpVtbl[1]))((ISmsDeviceMessageStore*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDeviceMessageStore*, uint>)(lpVtbl[2]))((ISmsDeviceMessageStore*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDeviceMessageStore*, uint*, Guid**, int>)(lpVtbl[3]))((ISmsDeviceMessageStore*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDeviceMessageStore*, HSTRING*, int>)(lpVtbl[4]))((ISmsDeviceMessageStore*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDeviceMessageStore*, TrustLevel*, int>)(lpVtbl[5]))((ISmsDeviceMessageStore*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmsDeviceMessageStore.xml' path='doc/member[@name="ISmsDeviceMessageStore.DeleteMessageAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("SmsDeviceMessageStore may be altered or unavailable for releases after Windows 10.")]
    public HRESULT DeleteMessageAsync([NativeTypeName("UINT32")] uint messageId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDeviceMessageStore*, uint, IAsyncAction**, int>)(lpVtbl[6]))((ISmsDeviceMessageStore*)Unsafe.AsPointer(ref this), messageId, asyncInfo);
    }

    /// <include file='ISmsDeviceMessageStore.xml' path='doc/member[@name="ISmsDeviceMessageStore.DeleteMessagesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("SmsDeviceMessageStore may be altered or unavailable for releases after Windows 10.")]
    public HRESULT DeleteMessagesAsync([NativeTypeName("ABI::Windows::Devices::Sms::SmsMessageFilter")] SmsMessageFilter messageFilter, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDeviceMessageStore*, SmsMessageFilter, IAsyncAction**, int>)(lpVtbl[7]))((ISmsDeviceMessageStore*)Unsafe.AsPointer(ref this), messageFilter, asyncInfo);
    }

    /// <include file='ISmsDeviceMessageStore.xml' path='doc/member[@name="ISmsDeviceMessageStore.GetMessageAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("SmsDeviceMessageStore may be altered or unavailable for releases after Windows 10.")]
    public HRESULT GetMessageAsync([NativeTypeName("UINT32")] uint messageId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSms__CISmsMessage_t **")] IAsyncOperation<IntPtr>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDeviceMessageStore*, uint, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((ISmsDeviceMessageStore*)Unsafe.AsPointer(ref this), messageId, asyncInfo);
    }

    /// <include file='ISmsDeviceMessageStore.xml' path='doc/member[@name="ISmsDeviceMessageStore.GetMessagesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete("SmsDeviceMessageStore may be altered or unavailable for releases after Windows 10.")]
    public HRESULT GetMessagesAsync([NativeTypeName("ABI::Windows::Devices::Sms::SmsMessageFilter")] SmsMessageFilter messageFilter, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2___FIVectorView_1_Windows__CDevices__CSms__CISmsMessage_int_t **")] IAsyncOperationWithProgress<IntPtr, int>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDeviceMessageStore*, SmsMessageFilter, IAsyncOperationWithProgress<IntPtr, int>**, int>)(lpVtbl[9]))((ISmsDeviceMessageStore*)Unsafe.AsPointer(ref this), messageFilter, asyncInfo);
    }

    /// <include file='ISmsDeviceMessageStore.xml' path='doc/member[@name="ISmsDeviceMessageStore.get_MaxMessages"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete("SmsDeviceMessageStore may be altered or unavailable for releases after Windows 10.")]
    public HRESULT get_MaxMessages([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDeviceMessageStore*, uint*, int>)(lpVtbl[10]))((ISmsDeviceMessageStore*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("SmsDeviceMessageStore may be altered or unavailable for releases after Windows 10.")]
        HRESULT DeleteMessageAsync([NativeTypeName("UINT32")] uint messageId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);

        [VtblIndex(7)]
        [Obsolete("SmsDeviceMessageStore may be altered or unavailable for releases after Windows 10.")]
        HRESULT DeleteMessagesAsync([NativeTypeName("ABI::Windows::Devices::Sms::SmsMessageFilter")] SmsMessageFilter messageFilter, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);

        [VtblIndex(8)]
        [Obsolete("SmsDeviceMessageStore may be altered or unavailable for releases after Windows 10.")]
        HRESULT GetMessageAsync([NativeTypeName("UINT32")] uint messageId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSms__CISmsMessage_t **")] IAsyncOperation<IntPtr>** asyncInfo);

        [VtblIndex(9)]
        [Obsolete("SmsDeviceMessageStore may be altered or unavailable for releases after Windows 10.")]
        HRESULT GetMessagesAsync([NativeTypeName("ABI::Windows::Devices::Sms::SmsMessageFilter")] SmsMessageFilter messageFilter, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2___FIVectorView_1_Windows__CDevices__CSms__CISmsMessage_int_t **")] IAsyncOperationWithProgress<IntPtr, int>** asyncInfo);

        [VtblIndex(10)]
        [Obsolete("SmsDeviceMessageStore may be altered or unavailable for releases after Windows 10.")]
        HRESULT get_MaxMessages([NativeTypeName("UINT32 *")] uint* value);
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

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        [Obsolete("SmsDeviceMessageStore may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IAsyncAction**, int> DeleteMessageAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::SmsMessageFilter, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        [Obsolete("SmsDeviceMessageStore may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmsMessageFilter, IAsyncAction**, int> DeleteMessagesAsync;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSms__CISmsMessage_t **) __attribute__((stdcall))")]
        [Obsolete("SmsDeviceMessageStore may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IAsyncOperation<IntPtr>**, int> GetMessageAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::SmsMessageFilter, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2___FIVectorView_1_Windows__CDevices__CSms__CISmsMessage_int_t **) __attribute__((stdcall))")]
        [Obsolete("SmsDeviceMessageStore may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmsMessageFilter, IAsyncOperationWithProgress<IntPtr, int>**, int> GetMessagesAsync;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        [Obsolete("SmsDeviceMessageStore may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_MaxMessages;
    }
}
