// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.pickers.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITargetFileRequest.xml' path='doc/member[@name="ITargetFileRequest"]/*' />
[Guid("42BD3355-7F88-478B-8E81-690B20340678")]
[NativeTypeName("struct ITargetFileRequest : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITargetFileRequest : ITargetFileRequest.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ITargetFileRequest);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITargetFileRequest*, Guid*, void**, int>)(lpVtbl[0]))((ITargetFileRequest*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITargetFileRequest*, uint>)(lpVtbl[1]))((ITargetFileRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITargetFileRequest*, uint>)(lpVtbl[2]))((ITargetFileRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITargetFileRequest*, uint*, Guid**, int>)(lpVtbl[3]))((ITargetFileRequest*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITargetFileRequest*, HSTRING*, int>)(lpVtbl[4]))((ITargetFileRequest*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITargetFileRequest*, TrustLevel*, int>)(lpVtbl[5]))((ITargetFileRequest*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITargetFileRequest.xml' path='doc/member[@name="ITargetFileRequest.get_TargetFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_TargetFile([NativeTypeName("ABI::Windows::Storage::IStorageFile **")] IStorageFile** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITargetFileRequest*, IStorageFile**, int>)(lpVtbl[6]))((ITargetFileRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITargetFileRequest.xml' path='doc/member[@name="ITargetFileRequest.put_TargetFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_TargetFile([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITargetFileRequest*, IStorageFile*, int>)(lpVtbl[7]))((ITargetFileRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITargetFileRequest.xml' path='doc/member[@name="ITargetFileRequest.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::Storage::Pickers::Provider::ITargetFileRequestDeferral **")] ITargetFileRequestDeferral** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITargetFileRequest*, ITargetFileRequestDeferral**, int>)(lpVtbl[8]))((ITargetFileRequest*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_TargetFile([NativeTypeName("ABI::Windows::Storage::IStorageFile **")] IStorageFile** value);

        [VtblIndex(7)]
        HRESULT put_TargetFile([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* value);

        [VtblIndex(8)]
        HRESULT GetDeferral([NativeTypeName("ABI::Windows::Storage::Pickers::Provider::ITargetFileRequestDeferral **")] ITargetFileRequestDeferral** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile**, int> get_TargetFile;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, int> put_TargetFile;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Pickers::Provider::ITargetFileRequestDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITargetFileRequestDeferral**, int> GetDeferral;
    }
}
