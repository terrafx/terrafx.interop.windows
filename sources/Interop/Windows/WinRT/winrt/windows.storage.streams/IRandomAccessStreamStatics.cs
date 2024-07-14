// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.streams.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRandomAccessStreamStatics.xml' path='doc/member[@name="IRandomAccessStreamStatics"]/*' />
[Guid("524CEDCF-6E29-4CE5-9573-6B753DB66C3A")]
[NativeTypeName("struct IRandomAccessStreamStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRandomAccessStreamStatics : IRandomAccessStreamStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRandomAccessStreamStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRandomAccessStreamStatics*, Guid*, void**, int>)(lpVtbl[0]))((IRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRandomAccessStreamStatics*, uint>)(lpVtbl[1]))((IRandomAccessStreamStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRandomAccessStreamStatics*, uint>)(lpVtbl[2]))((IRandomAccessStreamStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRandomAccessStreamStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRandomAccessStreamStatics*, HSTRING*, int>)(lpVtbl[4]))((IRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRandomAccessStreamStatics*, TrustLevel*, int>)(lpVtbl[5]))((IRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRandomAccessStreamStatics.xml' path='doc/member[@name="IRandomAccessStreamStatics.CopyAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CopyAsync([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* source, [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")] IOutputStream* destination, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT64_UINT64_t **")] IAsyncOperationWithProgress<ulong, ulong>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IRandomAccessStreamStatics*, IInputStream*, IOutputStream*, IAsyncOperationWithProgress<ulong, ulong>**, int>)(lpVtbl[6]))((IRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), source, destination, operation);
    }

    /// <include file='IRandomAccessStreamStatics.xml' path='doc/member[@name="IRandomAccessStreamStatics.CopySizeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CopySizeAsync([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* source, [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")] IOutputStream* destination, [NativeTypeName("UINT64")] ulong bytesToCopy, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT64_UINT64_t **")] IAsyncOperationWithProgress<ulong, ulong>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IRandomAccessStreamStatics*, IInputStream*, IOutputStream*, ulong, IAsyncOperationWithProgress<ulong, ulong>**, int>)(lpVtbl[7]))((IRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), source, destination, bytesToCopy, operation);
    }

    /// <include file='IRandomAccessStreamStatics.xml' path='doc/member[@name="IRandomAccessStreamStatics.CopyAndCloseAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CopyAndCloseAsync([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* source, [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")] IOutputStream* destination, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT64_UINT64_t **")] IAsyncOperationWithProgress<ulong, ulong>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IRandomAccessStreamStatics*, IInputStream*, IOutputStream*, IAsyncOperationWithProgress<ulong, ulong>**, int>)(lpVtbl[8]))((IRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), source, destination, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CopyAsync([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* source, [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")] IOutputStream* destination, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT64_UINT64_t **")] IAsyncOperationWithProgress<ulong, ulong>** operation);

        [VtblIndex(7)]
        HRESULT CopySizeAsync([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* source, [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")] IOutputStream* destination, [NativeTypeName("UINT64")] ulong bytesToCopy, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT64_UINT64_t **")] IAsyncOperationWithProgress<ulong, ulong>** operation);

        [VtblIndex(8)]
        HRESULT CopyAndCloseAsync([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* source, [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")] IOutputStream* destination, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT64_UINT64_t **")] IAsyncOperationWithProgress<ulong, ulong>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IInputStream *, ABI::Windows::Storage::Streams::IOutputStream *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT64_UINT64_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInputStream*, IOutputStream*, IAsyncOperationWithProgress<ulong, ulong>**, int> CopyAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IInputStream *, ABI::Windows::Storage::Streams::IOutputStream *, UINT64, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT64_UINT64_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInputStream*, IOutputStream*, ulong, IAsyncOperationWithProgress<ulong, ulong>**, int> CopySizeAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IInputStream *, ABI::Windows::Storage::Streams::IOutputStream *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT64_UINT64_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInputStream*, IOutputStream*, IAsyncOperationWithProgress<ulong, ulong>**, int> CopyAndCloseAsync;
    }
}
