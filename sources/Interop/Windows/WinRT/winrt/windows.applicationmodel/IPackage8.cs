// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPackage8.xml' path='doc/member[@name="IPackage8"]/*' />
[Guid("2C584F7B-CE2A-4BE6-A093-77CFBB2A7EA1")]
[NativeTypeName("struct IPackage8 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPackage8 : IPackage8.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPackage8));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage8*, Guid*, void**, int>)(lpVtbl[0]))((IPackage8*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage8*, uint>)(lpVtbl[1]))((IPackage8*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage8*, uint>)(lpVtbl[2]))((IPackage8*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage8*, uint*, Guid**, int>)(lpVtbl[3]))((IPackage8*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage8*, HSTRING*, int>)(lpVtbl[4]))((IPackage8*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage8*, TrustLevel*, int>)(lpVtbl[5]))((IPackage8*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPackage8.xml' path='doc/member[@name="IPackage8.get_EffectiveExternalLocation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_EffectiveExternalLocation([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage8*, IStorageFolder**, int>)(lpVtbl[6]))((IPackage8*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackage8.xml' path='doc/member[@name="IPackage8.get_MachineExternalLocation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MachineExternalLocation([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage8*, IStorageFolder**, int>)(lpVtbl[7]))((IPackage8*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackage8.xml' path='doc/member[@name="IPackage8.get_UserExternalLocation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_UserExternalLocation([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage8*, IStorageFolder**, int>)(lpVtbl[8]))((IPackage8*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackage8.xml' path='doc/member[@name="IPackage8.get_InstalledPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_InstalledPath(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage8*, HSTRING*, int>)(lpVtbl[9]))((IPackage8*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackage8.xml' path='doc/member[@name="IPackage8.get_MutablePath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MutablePath(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage8*, HSTRING*, int>)(lpVtbl[10]))((IPackage8*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackage8.xml' path='doc/member[@name="IPackage8.get_EffectivePath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_EffectivePath(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage8*, HSTRING*, int>)(lpVtbl[11]))((IPackage8*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackage8.xml' path='doc/member[@name="IPackage8.get_EffectiveExternalPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_EffectiveExternalPath(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage8*, HSTRING*, int>)(lpVtbl[12]))((IPackage8*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackage8.xml' path='doc/member[@name="IPackage8.get_MachineExternalPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_MachineExternalPath(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage8*, HSTRING*, int>)(lpVtbl[13]))((IPackage8*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackage8.xml' path='doc/member[@name="IPackage8.get_UserExternalPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_UserExternalPath(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage8*, HSTRING*, int>)(lpVtbl[14]))((IPackage8*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackage8.xml' path='doc/member[@name="IPackage8.GetLogoAsRandomAccessStreamReference"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetLogoAsRandomAccessStreamReference([NativeTypeName("ABI::Windows::Foundation::Size")] Size size, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage8*, Size, IRandomAccessStreamReference**, int>)(lpVtbl[15]))((IPackage8*)Unsafe.AsPointer(ref this), size, result);
    }

    /// <include file='IPackage8.xml' path='doc/member[@name="IPackage8.GetAppListEntries"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetAppListEntries([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CCore__CAppListEntry_t **")] IVectorView<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage8*, IVectorView<IntPtr>**, int>)(lpVtbl[16]))((IPackage8*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPackage8.xml' path='doc/member[@name="IPackage8.get_IsStub"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_IsStub([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage8*, byte*, int>)(lpVtbl[17]))((IPackage8*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_EffectiveExternalLocation([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value);

        [VtblIndex(7)]
        HRESULT get_MachineExternalLocation([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value);

        [VtblIndex(8)]
        HRESULT get_UserExternalLocation([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value);

        [VtblIndex(9)]
        HRESULT get_InstalledPath(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_MutablePath(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_EffectivePath(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_EffectiveExternalPath(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_MachineExternalPath(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_UserExternalPath(HSTRING* value);

        [VtblIndex(15)]
        HRESULT GetLogoAsRandomAccessStreamReference([NativeTypeName("ABI::Windows::Foundation::Size")] Size size, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** result);

        [VtblIndex(16)]
        HRESULT GetAppListEntries([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CCore__CAppListEntry_t **")] IVectorView<IntPtr>** result);

        [VtblIndex(17)]
        HRESULT get_IsStub([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFolder**, int> get_EffectiveExternalLocation;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFolder**, int> get_MachineExternalLocation;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFolder**, int> get_UserExternalLocation;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_InstalledPath;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MutablePath;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_EffectivePath;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_EffectiveExternalPath;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MachineExternalPath;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_UserExternalPath;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size, ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Size, IRandomAccessStreamReference**, int> GetLogoAsRandomAccessStreamReference;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CCore__CAppListEntry_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<IntPtr>**, int> GetAppListEntries;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsStub;
    }
}
