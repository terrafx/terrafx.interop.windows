// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.enterprisedata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDataProtectionManagerStatics.xml' path='doc/member[@name="IDataProtectionManagerStatics"]/*' />
[Guid("B6149B74-9144-4EE4-8A8A-30B5F361430E")]
[NativeTypeName("struct IDataProtectionManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDataProtectionManagerStatics : IDataProtectionManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDataProtectionManagerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataProtectionManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IDataProtectionManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDataProtectionManagerStatics*, uint>)(lpVtbl[1]))((IDataProtectionManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDataProtectionManagerStatics*, uint>)(lpVtbl[2]))((IDataProtectionManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataProtectionManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IDataProtectionManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataProtectionManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((IDataProtectionManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataProtectionManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IDataProtectionManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDataProtectionManagerStatics.xml' path='doc/member[@name="IDataProtectionManagerStatics.ProtectAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ProtectAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, HSTRING identity, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CBufferProtectUnprotectResult_t **")] IAsyncOperation<Pointer<IBufferProtectUnprotectResult>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataProtectionManagerStatics*, IBuffer*, HSTRING, IAsyncOperation<Pointer<IBufferProtectUnprotectResult>>**, int>)(lpVtbl[6]))((IDataProtectionManagerStatics*)Unsafe.AsPointer(ref this), data, identity, result);
    }

    /// <include file='IDataProtectionManagerStatics.xml' path='doc/member[@name="IDataProtectionManagerStatics.UnprotectAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT UnprotectAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CBufferProtectUnprotectResult_t **")] IAsyncOperation<Pointer<IBufferProtectUnprotectResult>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataProtectionManagerStatics*, IBuffer*, IAsyncOperation<Pointer<IBufferProtectUnprotectResult>>**, int>)(lpVtbl[7]))((IDataProtectionManagerStatics*)Unsafe.AsPointer(ref this), data, result);
    }

    /// <include file='IDataProtectionManagerStatics.xml' path='doc/member[@name="IDataProtectionManagerStatics.ProtectStreamAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ProtectStreamAsync([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* unprotectedStream, HSTRING identity, [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")] IOutputStream* protectedStream, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CDataProtectionInfo_t **")] IAsyncOperation<Pointer<IDataProtectionInfo>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataProtectionManagerStatics*, IInputStream*, HSTRING, IOutputStream*, IAsyncOperation<Pointer<IDataProtectionInfo>>**, int>)(lpVtbl[8]))((IDataProtectionManagerStatics*)Unsafe.AsPointer(ref this), unprotectedStream, identity, protectedStream, result);
    }

    /// <include file='IDataProtectionManagerStatics.xml' path='doc/member[@name="IDataProtectionManagerStatics.UnprotectStreamAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT UnprotectStreamAsync([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* protectedStream, [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")] IOutputStream* unprotectedStream, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CDataProtectionInfo_t **")] IAsyncOperation<Pointer<IDataProtectionInfo>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataProtectionManagerStatics*, IInputStream*, IOutputStream*, IAsyncOperation<Pointer<IDataProtectionInfo>>**, int>)(lpVtbl[9]))((IDataProtectionManagerStatics*)Unsafe.AsPointer(ref this), protectedStream, unprotectedStream, result);
    }

    /// <include file='IDataProtectionManagerStatics.xml' path='doc/member[@name="IDataProtectionManagerStatics.GetProtectionInfoAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetProtectionInfoAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* protectedData, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CDataProtectionInfo_t **")] IAsyncOperation<Pointer<IDataProtectionInfo>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataProtectionManagerStatics*, IBuffer*, IAsyncOperation<Pointer<IDataProtectionInfo>>**, int>)(lpVtbl[10]))((IDataProtectionManagerStatics*)Unsafe.AsPointer(ref this), protectedData, result);
    }

    /// <include file='IDataProtectionManagerStatics.xml' path='doc/member[@name="IDataProtectionManagerStatics.GetStreamProtectionInfoAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetStreamProtectionInfoAsync([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* protectedStream, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CDataProtectionInfo_t **")] IAsyncOperation<Pointer<IDataProtectionInfo>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataProtectionManagerStatics*, IInputStream*, IAsyncOperation<Pointer<IDataProtectionInfo>>**, int>)(lpVtbl[11]))((IDataProtectionManagerStatics*)Unsafe.AsPointer(ref this), protectedStream, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ProtectAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, HSTRING identity, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CBufferProtectUnprotectResult_t **")] IAsyncOperation<Pointer<IBufferProtectUnprotectResult>>** result);

        [VtblIndex(7)]
        HRESULT UnprotectAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CBufferProtectUnprotectResult_t **")] IAsyncOperation<Pointer<IBufferProtectUnprotectResult>>** result);

        [VtblIndex(8)]
        HRESULT ProtectStreamAsync([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* unprotectedStream, HSTRING identity, [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")] IOutputStream* protectedStream, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CDataProtectionInfo_t **")] IAsyncOperation<Pointer<IDataProtectionInfo>>** result);

        [VtblIndex(9)]
        HRESULT UnprotectStreamAsync([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* protectedStream, [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")] IOutputStream* unprotectedStream, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CDataProtectionInfo_t **")] IAsyncOperation<Pointer<IDataProtectionInfo>>** result);

        [VtblIndex(10)]
        HRESULT GetProtectionInfoAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* protectedData, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CDataProtectionInfo_t **")] IAsyncOperation<Pointer<IDataProtectionInfo>>** result);

        [VtblIndex(11)]
        HRESULT GetStreamProtectionInfoAsync([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* protectedStream, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CDataProtectionInfo_t **")] IAsyncOperation<Pointer<IDataProtectionInfo>>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CBufferProtectUnprotectResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, HSTRING, IAsyncOperation<Pointer<IBufferProtectUnprotectResult>>**, int> ProtectAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CBufferProtectUnprotectResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, IAsyncOperation<Pointer<IBufferProtectUnprotectResult>>**, int> UnprotectAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IInputStream *, HSTRING, ABI::Windows::Storage::Streams::IOutputStream *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CDataProtectionInfo_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInputStream*, HSTRING, IOutputStream*, IAsyncOperation<Pointer<IDataProtectionInfo>>**, int> ProtectStreamAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IInputStream *, ABI::Windows::Storage::Streams::IOutputStream *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CDataProtectionInfo_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInputStream*, IOutputStream*, IAsyncOperation<Pointer<IDataProtectionInfo>>**, int> UnprotectStreamAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CDataProtectionInfo_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, IAsyncOperation<Pointer<IDataProtectionInfo>>**, int> GetProtectionInfoAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IInputStream *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CDataProtectionInfo_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInputStream*, IAsyncOperation<Pointer<IDataProtectionInfo>>**, int> GetStreamProtectionInfoAsync;
    }
}
