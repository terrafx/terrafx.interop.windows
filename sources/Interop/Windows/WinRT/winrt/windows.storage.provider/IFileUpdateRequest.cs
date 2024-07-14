// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFileUpdateRequest.xml' path='doc/member[@name="IFileUpdateRequest"]/*' />
[Guid("40C82536-C1FE-4D93-A792-1E736BC70837")]
[NativeTypeName("struct IFileUpdateRequest : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFileUpdateRequest : IFileUpdateRequest.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileUpdateRequest));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileUpdateRequest*, Guid*, void**, int>)(lpVtbl[0]))((IFileUpdateRequest*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileUpdateRequest*, uint>)(lpVtbl[1]))((IFileUpdateRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileUpdateRequest*, uint>)(lpVtbl[2]))((IFileUpdateRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileUpdateRequest*, uint*, Guid**, int>)(lpVtbl[3]))((IFileUpdateRequest*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileUpdateRequest*, HSTRING*, int>)(lpVtbl[4]))((IFileUpdateRequest*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileUpdateRequest*, TrustLevel*, int>)(lpVtbl[5]))((IFileUpdateRequest*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFileUpdateRequest.xml' path='doc/member[@name="IFileUpdateRequest.get_ContentId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ContentId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileUpdateRequest*, HSTRING*, int>)(lpVtbl[6]))((IFileUpdateRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileUpdateRequest.xml' path='doc/member[@name="IFileUpdateRequest.get_File"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_File([NativeTypeName("ABI::Windows::Storage::IStorageFile **")] IStorageFile** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileUpdateRequest*, IStorageFile**, int>)(lpVtbl[7]))((IFileUpdateRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileUpdateRequest.xml' path='doc/member[@name="IFileUpdateRequest.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::Storage::Provider::FileUpdateStatus *")] FileUpdateStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileUpdateRequest*, FileUpdateStatus*, int>)(lpVtbl[8]))((IFileUpdateRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileUpdateRequest.xml' path='doc/member[@name="IFileUpdateRequest.put_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Status([NativeTypeName("ABI::Windows::Storage::Provider::FileUpdateStatus")] FileUpdateStatus value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileUpdateRequest*, FileUpdateStatus, int>)(lpVtbl[9]))((IFileUpdateRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileUpdateRequest.xml' path='doc/member[@name="IFileUpdateRequest.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::Storage::Provider::IFileUpdateRequestDeferral **")] IFileUpdateRequestDeferral** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileUpdateRequest*, IFileUpdateRequestDeferral**, int>)(lpVtbl[10]))((IFileUpdateRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileUpdateRequest.xml' path='doc/member[@name="IFileUpdateRequest.UpdateLocalFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT UpdateLocalFile([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileUpdateRequest*, IStorageFile*, int>)(lpVtbl[11]))((IFileUpdateRequest*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ContentId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_File([NativeTypeName("ABI::Windows::Storage::IStorageFile **")] IStorageFile** value);

        [VtblIndex(8)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::Storage::Provider::FileUpdateStatus *")] FileUpdateStatus* value);

        [VtblIndex(9)]
        HRESULT put_Status([NativeTypeName("ABI::Windows::Storage::Provider::FileUpdateStatus")] FileUpdateStatus value);

        [VtblIndex(10)]
        HRESULT GetDeferral([NativeTypeName("ABI::Windows::Storage::Provider::IFileUpdateRequestDeferral **")] IFileUpdateRequestDeferral** value);

        [VtblIndex(11)]
        HRESULT UpdateLocalFile([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ContentId;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile**, int> get_File;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::FileUpdateStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FileUpdateStatus*, int> get_Status;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::FileUpdateStatus) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FileUpdateStatus, int> put_Status;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::IFileUpdateRequestDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IFileUpdateRequestDeferral**, int> GetDeferral;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, int> UpdateLocalFile;
    }
}
