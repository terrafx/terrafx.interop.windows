// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDeviceInformation.xml' path='doc/member[@name="IDeviceInformation"]/*' />
[Guid("ABA0FB95-4398-489D-8E44-E6130927011F")]
[NativeTypeName("struct IDeviceInformation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDeviceInformation : IDeviceInformation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDeviceInformation));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformation*, Guid*, void**, int>)(lpVtbl[0]))((IDeviceInformation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformation*, uint>)(lpVtbl[1]))((IDeviceInformation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformation*, uint>)(lpVtbl[2]))((IDeviceInformation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformation*, uint*, Guid**, int>)(lpVtbl[3]))((IDeviceInformation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformation*, HSTRING*, int>)(lpVtbl[4]))((IDeviceInformation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformation*, TrustLevel*, int>)(lpVtbl[5]))((IDeviceInformation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDeviceInformation.xml' path='doc/member[@name="IDeviceInformation.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformation*, HSTRING*, int>)(lpVtbl[6]))((IDeviceInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDeviceInformation.xml' path='doc/member[@name="IDeviceInformation.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformation*, HSTRING*, int>)(lpVtbl[7]))((IDeviceInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDeviceInformation.xml' path='doc/member[@name="IDeviceInformation.get_IsEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformation*, byte*, int>)(lpVtbl[8]))((IDeviceInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDeviceInformation.xml' path='doc/member[@name="IDeviceInformation.get_IsDefault"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsDefault([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformation*, byte*, int>)(lpVtbl[9]))((IDeviceInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDeviceInformation.xml' path='doc/member[@name="IDeviceInformation.get_EnclosureLocation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_EnclosureLocation([NativeTypeName("ABI::Windows::Devices::Enumeration::IEnclosureLocation **")] IEnclosureLocation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformation*, IEnclosureLocation**, int>)(lpVtbl[10]))((IDeviceInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDeviceInformation.xml' path='doc/member[@name="IDeviceInformation.get_Properties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Properties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_IInspectable_t **")] IMapView<HSTRING, Pointer<IInspectable>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformation*, IMapView<HSTRING, Pointer<IInspectable>>**, int>)(lpVtbl[11]))((IDeviceInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDeviceInformation.xml' path='doc/member[@name="IDeviceInformation.Update"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Update([NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformationUpdate *")] IDeviceInformationUpdate* updateInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformation*, IDeviceInformationUpdate*, int>)(lpVtbl[12]))((IDeviceInformation*)Unsafe.AsPointer(ref this), updateInfo);
    }

    /// <include file='IDeviceInformation.xml' path='doc/member[@name="IDeviceInformation.GetThumbnailAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetThumbnailAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceThumbnail_t **")] IAsyncOperation<Pointer<IntPtr>>** asyncOp)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformation*, IAsyncOperation<Pointer<IntPtr>>**, int>)(lpVtbl[13]))((IDeviceInformation*)Unsafe.AsPointer(ref this), asyncOp);
    }

    /// <include file='IDeviceInformation.xml' path='doc/member[@name="IDeviceInformation.GetGlyphThumbnailAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetGlyphThumbnailAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceThumbnail_t **")] IAsyncOperation<Pointer<IntPtr>>** asyncOp)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformation*, IAsyncOperation<Pointer<IntPtr>>**, int>)(lpVtbl[14]))((IDeviceInformation*)Unsafe.AsPointer(ref this), asyncOp);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_IsEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_IsDefault([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT get_EnclosureLocation([NativeTypeName("ABI::Windows::Devices::Enumeration::IEnclosureLocation **")] IEnclosureLocation** value);

        [VtblIndex(11)]
        HRESULT get_Properties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_IInspectable_t **")] IMapView<HSTRING, Pointer<IInspectable>>** value);

        [VtblIndex(12)]
        HRESULT Update([NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformationUpdate *")] IDeviceInformationUpdate* updateInfo);

        [VtblIndex(13)]
        HRESULT GetThumbnailAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceThumbnail_t **")] IAsyncOperation<Pointer<IntPtr>>** asyncOp);

        [VtblIndex(14)]
        HRESULT GetGlyphThumbnailAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceThumbnail_t **")] IAsyncOperation<Pointer<IntPtr>>** asyncOp);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsDefault;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::IEnclosureLocation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEnclosureLocation**, int> get_EnclosureLocation;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_IInspectable_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMapView<HSTRING, Pointer<IInspectable>>**, int> get_Properties;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::IDeviceInformationUpdate *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeviceInformationUpdate*, int> Update;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceThumbnail_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IntPtr>>**, int> GetThumbnailAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceThumbnail_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IntPtr>>**, int> GetGlyphThumbnailAsync;
    }
}
