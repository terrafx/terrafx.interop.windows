// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ILauncherOptions2.xml' path='doc/member[@name="ILauncherOptions2"]/*' />
[Guid("3BA08EB4-6E40-4DCE-A1A3-2F53950AFB49")]
[NativeTypeName("struct ILauncherOptions2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ILauncherOptions2 : ILauncherOptions2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILauncherOptions2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherOptions2*, Guid*, void**, int>)(lpVtbl[0]))((ILauncherOptions2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherOptions2*, uint>)(lpVtbl[1]))((ILauncherOptions2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherOptions2*, uint>)(lpVtbl[2]))((ILauncherOptions2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherOptions2*, uint*, Guid**, int>)(lpVtbl[3]))((ILauncherOptions2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherOptions2*, HSTRING*, int>)(lpVtbl[4]))((ILauncherOptions2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherOptions2*, TrustLevel*, int>)(lpVtbl[5]))((ILauncherOptions2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ILauncherOptions2.xml' path='doc/member[@name="ILauncherOptions2.get_TargetApplicationPackageFamilyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_TargetApplicationPackageFamilyName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherOptions2*, HSTRING*, int>)(lpVtbl[6]))((ILauncherOptions2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILauncherOptions2.xml' path='doc/member[@name="ILauncherOptions2.put_TargetApplicationPackageFamilyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_TargetApplicationPackageFamilyName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherOptions2*, HSTRING, int>)(lpVtbl[7]))((ILauncherOptions2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILauncherOptions2.xml' path='doc/member[@name="ILauncherOptions2.get_NeighboringFilesQuery"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_NeighboringFilesQuery([NativeTypeName("ABI::Windows::Storage::Search::IStorageFileQueryResult **")] IStorageFileQueryResult** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherOptions2*, IStorageFileQueryResult**, int>)(lpVtbl[8]))((ILauncherOptions2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILauncherOptions2.xml' path='doc/member[@name="ILauncherOptions2.put_NeighboringFilesQuery"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_NeighboringFilesQuery([NativeTypeName("ABI::Windows::Storage::Search::IStorageFileQueryResult *")] IStorageFileQueryResult* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherOptions2*, IStorageFileQueryResult*, int>)(lpVtbl[9]))((ILauncherOptions2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_TargetApplicationPackageFamilyName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_TargetApplicationPackageFamilyName(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_NeighboringFilesQuery([NativeTypeName("ABI::Windows::Storage::Search::IStorageFileQueryResult **")] IStorageFileQueryResult** value);

        [VtblIndex(9)]
        HRESULT put_NeighboringFilesQuery([NativeTypeName("ABI::Windows::Storage::Search::IStorageFileQueryResult *")] IStorageFileQueryResult* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_TargetApplicationPackageFamilyName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_TargetApplicationPackageFamilyName;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Search::IStorageFileQueryResult **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFileQueryResult**, int> get_NeighboringFilesQuery;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Search::IStorageFileQueryResult *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFileQueryResult*, int> put_NeighboringFilesQuery;
    }
}
