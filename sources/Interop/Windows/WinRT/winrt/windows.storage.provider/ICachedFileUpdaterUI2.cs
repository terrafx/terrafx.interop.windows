// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICachedFileUpdaterUI2.xml' path='doc/member[@name="ICachedFileUpdaterUI2"]/*' />
[Guid("8856A21C-8699-4340-9F49-F7CAD7FE8991")]
[NativeTypeName("struct ICachedFileUpdaterUI2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICachedFileUpdaterUI2 : ICachedFileUpdaterUI2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICachedFileUpdaterUI2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterUI2*, Guid*, void**, int>)(lpVtbl[0]))((ICachedFileUpdaterUI2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterUI2*, uint>)(lpVtbl[1]))((ICachedFileUpdaterUI2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterUI2*, uint>)(lpVtbl[2]))((ICachedFileUpdaterUI2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterUI2*, uint*, Guid**, int>)(lpVtbl[3]))((ICachedFileUpdaterUI2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterUI2*, HSTRING*, int>)(lpVtbl[4]))((ICachedFileUpdaterUI2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterUI2*, TrustLevel*, int>)(lpVtbl[5]))((ICachedFileUpdaterUI2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICachedFileUpdaterUI2.xml' path='doc/member[@name="ICachedFileUpdaterUI2.get_UpdateRequest"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_UpdateRequest([NativeTypeName("ABI::Windows::Storage::Provider::IFileUpdateRequest **")] IFileUpdateRequest** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterUI2*, IFileUpdateRequest**, int>)(lpVtbl[6]))((ICachedFileUpdaterUI2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICachedFileUpdaterUI2.xml' path='doc/member[@name="ICachedFileUpdaterUI2.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::Storage::Provider::IFileUpdateRequestDeferral **")] IFileUpdateRequestDeferral** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterUI2*, IFileUpdateRequestDeferral**, int>)(lpVtbl[7]))((ICachedFileUpdaterUI2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_UpdateRequest([NativeTypeName("ABI::Windows::Storage::Provider::IFileUpdateRequest **")] IFileUpdateRequest** value);

        [VtblIndex(7)]
        HRESULT GetDeferral([NativeTypeName("ABI::Windows::Storage::Provider::IFileUpdateRequestDeferral **")] IFileUpdateRequestDeferral** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::IFileUpdateRequest **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IFileUpdateRequest**, int> get_UpdateRequest;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::IFileUpdateRequestDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IFileUpdateRequestDeferral**, int> GetDeferral;
    }
}
