// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICachedFileUpdaterStatics.xml' path='doc/member[@name="ICachedFileUpdaterStatics"]/*' />
[Guid("9FC90920-7BCF-4888-A81E-102D7034D7CE")]
[NativeTypeName("struct ICachedFileUpdaterStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICachedFileUpdaterStatics : ICachedFileUpdaterStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICachedFileUpdaterStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterStatics*, Guid*, void**, int>)(lpVtbl[0]))((ICachedFileUpdaterStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterStatics*, uint>)(lpVtbl[1]))((ICachedFileUpdaterStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterStatics*, uint>)(lpVtbl[2]))((ICachedFileUpdaterStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ICachedFileUpdaterStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterStatics*, HSTRING*, int>)(lpVtbl[4]))((ICachedFileUpdaterStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterStatics*, TrustLevel*, int>)(lpVtbl[5]))((ICachedFileUpdaterStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICachedFileUpdaterStatics.xml' path='doc/member[@name="ICachedFileUpdaterStatics.SetUpdateInformation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetUpdateInformation([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, HSTRING contentId, [NativeTypeName("ABI::Windows::Storage::Provider::ReadActivationMode")] ReadActivationMode readMode, [NativeTypeName("ABI::Windows::Storage::Provider::WriteActivationMode")] WriteActivationMode writeMode, [NativeTypeName("ABI::Windows::Storage::Provider::CachedFileOptions")] CachedFileOptions options)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterStatics*, IStorageFile*, HSTRING, ReadActivationMode, WriteActivationMode, CachedFileOptions, int>)(lpVtbl[6]))((ICachedFileUpdaterStatics*)Unsafe.AsPointer(ref this), file, contentId, readMode, writeMode, options);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT SetUpdateInformation([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, HSTRING contentId, [NativeTypeName("ABI::Windows::Storage::Provider::ReadActivationMode")] ReadActivationMode readMode, [NativeTypeName("ABI::Windows::Storage::Provider::WriteActivationMode")] WriteActivationMode writeMode, [NativeTypeName("ABI::Windows::Storage::Provider::CachedFileOptions")] CachedFileOptions options);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, HSTRING, ABI::Windows::Storage::Provider::ReadActivationMode, ABI::Windows::Storage::Provider::WriteActivationMode, ABI::Windows::Storage::Provider::CachedFileOptions) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, HSTRING, ReadActivationMode, WriteActivationMode, CachedFileOptions, int> SetUpdateInformation;
    }
}
