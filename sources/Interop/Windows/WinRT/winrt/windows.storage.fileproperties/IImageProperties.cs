// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.fileproperties.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IImageProperties.xml' path='doc/member[@name="IImageProperties"]/*' />
[Guid("523C9424-FCFF-4275-AFEE-ECDB9AB47973")]
[NativeTypeName("struct IImageProperties : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IImageProperties : IImageProperties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IImageProperties));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageProperties*, Guid*, void**, int>)(lpVtbl[0]))((IImageProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IImageProperties*, uint>)(lpVtbl[1]))((IImageProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IImageProperties*, uint>)(lpVtbl[2]))((IImageProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageProperties*, uint*, Guid**, int>)(lpVtbl[3]))((IImageProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageProperties*, HSTRING*, int>)(lpVtbl[4]))((IImageProperties*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageProperties*, TrustLevel*, int>)(lpVtbl[5]))((IImageProperties*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IImageProperties.xml' path='doc/member[@name="IImageProperties.get_Rating"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Rating([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageProperties*, uint*, int>)(lpVtbl[6]))((IImageProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IImageProperties.xml' path='doc/member[@name="IImageProperties.put_Rating"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Rating([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageProperties*, uint, int>)(lpVtbl[7]))((IImageProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IImageProperties.xml' path='doc/member[@name="IImageProperties.get_Keywords"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Keywords([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageProperties*, IVector<HSTRING>**, int>)(lpVtbl[8]))((IImageProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IImageProperties.xml' path='doc/member[@name="IImageProperties.get_DateTaken"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_DateTaken([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageProperties*, WinRTDateTime*, int>)(lpVtbl[9]))((IImageProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IImageProperties.xml' path='doc/member[@name="IImageProperties.put_DateTaken"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_DateTaken([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageProperties*, WinRTDateTime, int>)(lpVtbl[10]))((IImageProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IImageProperties.xml' path='doc/member[@name="IImageProperties.get_Width"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Width([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageProperties*, uint*, int>)(lpVtbl[11]))((IImageProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IImageProperties.xml' path='doc/member[@name="IImageProperties.get_Height"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Height([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageProperties*, uint*, int>)(lpVtbl[12]))((IImageProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IImageProperties.xml' path='doc/member[@name="IImageProperties.get_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Title(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageProperties*, HSTRING*, int>)(lpVtbl[13]))((IImageProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IImageProperties.xml' path='doc/member[@name="IImageProperties.put_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_Title(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageProperties*, HSTRING, int>)(lpVtbl[14]))((IImageProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IImageProperties.xml' path='doc/member[@name="IImageProperties.get_Latitude"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Latitude([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageProperties*, IReference<double>**, int>)(lpVtbl[15]))((IImageProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IImageProperties.xml' path='doc/member[@name="IImageProperties.get_Longitude"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Longitude([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageProperties*, IReference<double>**, int>)(lpVtbl[16]))((IImageProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IImageProperties.xml' path='doc/member[@name="IImageProperties.get_CameraManufacturer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_CameraManufacturer(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageProperties*, HSTRING*, int>)(lpVtbl[17]))((IImageProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IImageProperties.xml' path='doc/member[@name="IImageProperties.put_CameraManufacturer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_CameraManufacturer(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageProperties*, HSTRING, int>)(lpVtbl[18]))((IImageProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IImageProperties.xml' path='doc/member[@name="IImageProperties.get_CameraModel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_CameraModel(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageProperties*, HSTRING*, int>)(lpVtbl[19]))((IImageProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IImageProperties.xml' path='doc/member[@name="IImageProperties.put_CameraModel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_CameraModel(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageProperties*, HSTRING, int>)(lpVtbl[20]))((IImageProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IImageProperties.xml' path='doc/member[@name="IImageProperties.get_Orientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_Orientation([NativeTypeName("ABI::Windows::Storage::FileProperties::PhotoOrientation *")] PhotoOrientation* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageProperties*, PhotoOrientation*, int>)(lpVtbl[21]))((IImageProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IImageProperties.xml' path='doc/member[@name="IImageProperties.get_PeopleNames"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_PeopleNames([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageProperties*, IVectorView<HSTRING>**, int>)(lpVtbl[22]))((IImageProperties*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Rating([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT put_Rating([NativeTypeName("UINT32")] uint value);

        [VtblIndex(8)]
        HRESULT get_Keywords([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);

        [VtblIndex(9)]
        HRESULT get_DateTaken([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);

        [VtblIndex(10)]
        HRESULT put_DateTaken([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value);

        [VtblIndex(11)]
        HRESULT get_Width([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(12)]
        HRESULT get_Height([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(13)]
        HRESULT get_Title(HSTRING* value);

        [VtblIndex(14)]
        HRESULT put_Title(HSTRING value);

        [VtblIndex(15)]
        HRESULT get_Latitude([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value);

        [VtblIndex(16)]
        HRESULT get_Longitude([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value);

        [VtblIndex(17)]
        HRESULT get_CameraManufacturer(HSTRING* value);

        [VtblIndex(18)]
        HRESULT put_CameraManufacturer(HSTRING value);

        [VtblIndex(19)]
        HRESULT get_CameraModel(HSTRING* value);

        [VtblIndex(20)]
        HRESULT put_CameraModel(HSTRING value);

        [VtblIndex(21)]
        HRESULT get_Orientation([NativeTypeName("ABI::Windows::Storage::FileProperties::PhotoOrientation *")] PhotoOrientation* value);

        [VtblIndex(22)]
        HRESULT get_PeopleNames([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** value);
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Rating;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_Rating;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_Keywords;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_DateTaken;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime, int> put_DateTaken;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Width;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Height;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Title;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Title;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_double_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<double>**, int> get_Latitude;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_double_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<double>**, int> get_Longitude;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CameraManufacturer;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_CameraManufacturer;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CameraModel;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_CameraModel;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::FileProperties::PhotoOrientation *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhotoOrientation*, int> get_Orientation;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<HSTRING>**, int> get_PeopleNames;
    }
}
