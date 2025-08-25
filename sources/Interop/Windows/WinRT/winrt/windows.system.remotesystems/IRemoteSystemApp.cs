// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRemoteSystemApp.xml' path='doc/member[@name="IRemoteSystemApp"]/*' />
[Guid("80E5BCBD-D54D-41B1-9B16-6810A871ED4F")]
[NativeTypeName("struct IRemoteSystemApp : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRemoteSystemApp : IRemoteSystemApp.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IRemoteSystemApp);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemApp*, Guid*, void**, int>)(lpVtbl[0]))((IRemoteSystemApp*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemApp*, uint>)(lpVtbl[1]))((IRemoteSystemApp*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemApp*, uint>)(lpVtbl[2]))((IRemoteSystemApp*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemApp*, uint*, Guid**, int>)(lpVtbl[3]))((IRemoteSystemApp*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemApp*, HSTRING*, int>)(lpVtbl[4]))((IRemoteSystemApp*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemApp*, TrustLevel*, int>)(lpVtbl[5]))((IRemoteSystemApp*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRemoteSystemApp.xml' path='doc/member[@name="IRemoteSystemApp.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemApp*, HSTRING*, int>)(lpVtbl[6]))((IRemoteSystemApp*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRemoteSystemApp.xml' path='doc/member[@name="IRemoteSystemApp.get_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemApp*, HSTRING*, int>)(lpVtbl[7]))((IRemoteSystemApp*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRemoteSystemApp.xml' path='doc/member[@name="IRemoteSystemApp.get_IsAvailableByProximity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsAvailableByProximity([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemApp*, byte*, int>)(lpVtbl[8]))((IRemoteSystemApp*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRemoteSystemApp.xml' path='doc/member[@name="IRemoteSystemApp.get_IsAvailableBySpatialProximity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsAvailableBySpatialProximity([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemApp*, byte*, int>)(lpVtbl[9]))((IRemoteSystemApp*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRemoteSystemApp.xml' path='doc/member[@name="IRemoteSystemApp.get_Attributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Attributes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t **")] IMapView<HSTRING, HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemApp*, IMapView<HSTRING, HSTRING>**, int>)(lpVtbl[10]))((IRemoteSystemApp*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_IsAvailableByProximity([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_IsAvailableBySpatialProximity([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT get_Attributes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t **")] IMapView<HSTRING, HSTRING>** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsAvailableByProximity;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsAvailableBySpatialProximity;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMapView<HSTRING, HSTRING>**, int> get_Attributes;
    }
}
