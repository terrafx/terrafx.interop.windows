// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.enterprisedata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IProtectedFileCreateResult.xml' path='doc/member[@name="IProtectedFileCreateResult"]/*' />
[Guid("28E3ED6A-E9E7-4A03-9F53-BDB16172699B")]
[NativeTypeName("struct IProtectedFileCreateResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProtectedFileCreateResult : IProtectedFileCreateResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IProtectedFileCreateResult);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectedFileCreateResult*, Guid*, void**, int>)(lpVtbl[0]))((IProtectedFileCreateResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectedFileCreateResult*, uint>)(lpVtbl[1]))((IProtectedFileCreateResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectedFileCreateResult*, uint>)(lpVtbl[2]))((IProtectedFileCreateResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectedFileCreateResult*, uint*, Guid**, int>)(lpVtbl[3]))((IProtectedFileCreateResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectedFileCreateResult*, HSTRING*, int>)(lpVtbl[4]))((IProtectedFileCreateResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectedFileCreateResult*, TrustLevel*, int>)(lpVtbl[5]))((IProtectedFileCreateResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IProtectedFileCreateResult.xml' path='doc/member[@name="IProtectedFileCreateResult.get_File"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_File([NativeTypeName("ABI::Windows::Storage::IStorageFile **")] IStorageFile** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectedFileCreateResult*, IStorageFile**, int>)(lpVtbl[6]))((IProtectedFileCreateResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProtectedFileCreateResult.xml' path='doc/member[@name="IProtectedFileCreateResult.get_Stream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Stream([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream **")] IRandomAccessStream** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectedFileCreateResult*, IRandomAccessStream**, int>)(lpVtbl[7]))((IProtectedFileCreateResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProtectedFileCreateResult.xml' path='doc/member[@name="IProtectedFileCreateResult.get_ProtectionInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ProtectionInfo([NativeTypeName("ABI::Windows::Security::EnterpriseData::IFileProtectionInfo **")] IFileProtectionInfo** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectedFileCreateResult*, IFileProtectionInfo**, int>)(lpVtbl[8]))((IProtectedFileCreateResult*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_File([NativeTypeName("ABI::Windows::Storage::IStorageFile **")] IStorageFile** value);

        [VtblIndex(7)]
        HRESULT get_Stream([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream **")] IRandomAccessStream** value);

        [VtblIndex(8)]
        HRESULT get_ProtectionInfo([NativeTypeName("ABI::Windows::Security::EnterpriseData::IFileProtectionInfo **")] IFileProtectionInfo** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile**, int> get_File;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStream **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStream**, int> get_Stream;

        [NativeTypeName("HRESULT (ABI::Windows::Security::EnterpriseData::IFileProtectionInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IFileProtectionInfo**, int> get_ProtectionInfo;
    }
}
