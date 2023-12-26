// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.datatransfer.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDataPackagePropertySet.xml' path='doc/member[@name="IDataPackagePropertySet"]/*' />
[Guid("CD1C93EB-4C4C-443A-A8D3-F5C241E91689")]
[NativeTypeName("struct IDataPackagePropertySet : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDataPackagePropertySet : IDataPackagePropertySet.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDataPackagePropertySet));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySet*, Guid*, void**, int>)(lpVtbl[0]))((IDataPackagePropertySet*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySet*, uint>)(lpVtbl[1]))((IDataPackagePropertySet*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySet*, uint>)(lpVtbl[2]))((IDataPackagePropertySet*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySet*, uint*, Guid**, int>)(lpVtbl[3]))((IDataPackagePropertySet*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySet*, HSTRING*, int>)(lpVtbl[4]))((IDataPackagePropertySet*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySet*, TrustLevel*, int>)(lpVtbl[5]))((IDataPackagePropertySet*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDataPackagePropertySet.xml' path='doc/member[@name="IDataPackagePropertySet.get_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Title(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySet*, HSTRING*, int>)(lpVtbl[6]))((IDataPackagePropertySet*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataPackagePropertySet.xml' path='doc/member[@name="IDataPackagePropertySet.put_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Title(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySet*, HSTRING, int>)(lpVtbl[7]))((IDataPackagePropertySet*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataPackagePropertySet.xml' path='doc/member[@name="IDataPackagePropertySet.get_Description"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Description(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySet*, HSTRING*, int>)(lpVtbl[8]))((IDataPackagePropertySet*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataPackagePropertySet.xml' path='doc/member[@name="IDataPackagePropertySet.put_Description"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Description(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySet*, HSTRING, int>)(lpVtbl[9]))((IDataPackagePropertySet*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataPackagePropertySet.xml' path='doc/member[@name="IDataPackagePropertySet.get_Thumbnail"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Thumbnail([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySet*, IRandomAccessStreamReference**, int>)(lpVtbl[10]))((IDataPackagePropertySet*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataPackagePropertySet.xml' path='doc/member[@name="IDataPackagePropertySet.put_Thumbnail"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Thumbnail([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySet*, IRandomAccessStreamReference*, int>)(lpVtbl[11]))((IDataPackagePropertySet*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataPackagePropertySet.xml' path='doc/member[@name="IDataPackagePropertySet.get_FileTypes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_FileTypes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySet*, IVector<HSTRING>**, int>)(lpVtbl[12]))((IDataPackagePropertySet*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataPackagePropertySet.xml' path='doc/member[@name="IDataPackagePropertySet.get_ApplicationName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_ApplicationName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySet*, HSTRING*, int>)(lpVtbl[13]))((IDataPackagePropertySet*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataPackagePropertySet.xml' path='doc/member[@name="IDataPackagePropertySet.put_ApplicationName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_ApplicationName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySet*, HSTRING, int>)(lpVtbl[14]))((IDataPackagePropertySet*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataPackagePropertySet.xml' path='doc/member[@name="IDataPackagePropertySet.get_ApplicationListingUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_ApplicationListingUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySet*, IUriRuntimeClass**, int>)(lpVtbl[15]))((IDataPackagePropertySet*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataPackagePropertySet.xml' path='doc/member[@name="IDataPackagePropertySet.put_ApplicationListingUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_ApplicationListingUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySet*, IUriRuntimeClass*, int>)(lpVtbl[16]))((IDataPackagePropertySet*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Title(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Title(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_Description(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_Description(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_Thumbnail([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value);

        [VtblIndex(11)]
        HRESULT put_Thumbnail([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* value);

        [VtblIndex(12)]
        HRESULT get_FileTypes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);

        [VtblIndex(13)]
        HRESULT get_ApplicationName(HSTRING* value);

        [VtblIndex(14)]
        HRESULT put_ApplicationName(HSTRING value);

        [VtblIndex(15)]
        HRESULT get_ApplicationListingUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value);

        [VtblIndex(16)]
        HRESULT put_ApplicationListingUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Title;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Title;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Description;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Description;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference**, int> get_Thumbnail;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference*, int> put_Thumbnail;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_FileTypes;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ApplicationName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_ApplicationName;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass**, int> get_ApplicationListingUri;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, int> put_ApplicationListingUri;
    }
}
