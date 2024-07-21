// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.datatransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISharedStorageAccessManagerStatics.xml' path='doc/member[@name="ISharedStorageAccessManagerStatics"]/*' />
[Guid("C6132ADA-34B1-4849-BD5F-D09FEE3158C5")]
[NativeTypeName("struct ISharedStorageAccessManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISharedStorageAccessManagerStatics : ISharedStorageAccessManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISharedStorageAccessManagerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISharedStorageAccessManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((ISharedStorageAccessManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISharedStorageAccessManagerStatics*, uint>)(lpVtbl[1]))((ISharedStorageAccessManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISharedStorageAccessManagerStatics*, uint>)(lpVtbl[2]))((ISharedStorageAccessManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISharedStorageAccessManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ISharedStorageAccessManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISharedStorageAccessManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((ISharedStorageAccessManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISharedStorageAccessManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((ISharedStorageAccessManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISharedStorageAccessManagerStatics.xml' path='doc/member[@name="ISharedStorageAccessManagerStatics.AddFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddFile([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, HSTRING* outToken)
    {
        return ((delegate* unmanaged[MemberFunction]<ISharedStorageAccessManagerStatics*, IStorageFile*, HSTRING*, int>)(lpVtbl[6]))((ISharedStorageAccessManagerStatics*)Unsafe.AsPointer(ref this), file, outToken);
    }

    /// <include file='ISharedStorageAccessManagerStatics.xml' path='doc/member[@name="ISharedStorageAccessManagerStatics.RedeemTokenForFileAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RedeemTokenForFileAsync(HSTRING token, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ISharedStorageAccessManagerStatics*, HSTRING, IAsyncOperation<Pointer<IStorageFile>>**, int>)(lpVtbl[7]))((ISharedStorageAccessManagerStatics*)Unsafe.AsPointer(ref this), token, operation);
    }

    /// <include file='ISharedStorageAccessManagerStatics.xml' path='doc/member[@name="ISharedStorageAccessManagerStatics.RemoveFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RemoveFile(HSTRING token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISharedStorageAccessManagerStatics*, HSTRING, int>)(lpVtbl[8]))((ISharedStorageAccessManagerStatics*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT AddFile([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, HSTRING* outToken);

        [VtblIndex(7)]
        HRESULT RedeemTokenForFileAsync(HSTRING token, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation);

        [VtblIndex(8)]
        HRESULT RemoveFile(HSTRING token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, HSTRING*, int> AddFile;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IStorageFile>>**, int> RedeemTokenForFileAsync;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> RemoveFile;
    }
}
