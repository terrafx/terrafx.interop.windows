// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGeolocatorStatics2.xml' path='doc/member[@name="IGeolocatorStatics2"]/*' />
[Guid("993011A2-FA1C-4631-A71D-0DBEB1250D9C")]
[NativeTypeName("struct IGeolocatorStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGeolocatorStatics2 : IGeolocatorStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGeolocatorStatics2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocatorStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IGeolocatorStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocatorStatics2*, uint>)(lpVtbl[1]))((IGeolocatorStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocatorStatics2*, uint>)(lpVtbl[2]))((IGeolocatorStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocatorStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IGeolocatorStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocatorStatics2*, HSTRING*, int>)(lpVtbl[4]))((IGeolocatorStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocatorStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IGeolocatorStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGeolocatorStatics2.xml' path='doc/member[@name="IGeolocatorStatics2.get_IsDefaultGeopositionRecommended"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsDefaultGeopositionRecommended([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocatorStatics2*, byte*, int>)(lpVtbl[6]))((IGeolocatorStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGeolocatorStatics2.xml' path='doc/member[@name="IGeolocatorStatics2.put_DefaultGeoposition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_DefaultGeoposition([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CGeolocation__CBasicGeoposition_t *")] IReference<BasicGeoposition>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocatorStatics2*, IReference<BasicGeoposition>*, int>)(lpVtbl[7]))((IGeolocatorStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGeolocatorStatics2.xml' path='doc/member[@name="IGeolocatorStatics2.get_DefaultGeoposition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DefaultGeoposition([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CGeolocation__CBasicGeoposition_t **")] IReference<BasicGeoposition>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeolocatorStatics2*, IReference<BasicGeoposition>**, int>)(lpVtbl[8]))((IGeolocatorStatics2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsDefaultGeopositionRecommended([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_DefaultGeoposition([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CGeolocation__CBasicGeoposition_t *")] IReference<BasicGeoposition>* value);

        [VtblIndex(8)]
        HRESULT get_DefaultGeoposition([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CGeolocation__CBasicGeoposition_t **")] IReference<BasicGeoposition>** value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsDefaultGeopositionRecommended;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CGeolocation__CBasicGeoposition_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<BasicGeoposition>*, int> put_DefaultGeoposition;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CGeolocation__CBasicGeoposition_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<BasicGeoposition>**, int> get_DefaultGeoposition;
    }
}
