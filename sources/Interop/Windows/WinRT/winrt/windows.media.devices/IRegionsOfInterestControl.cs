// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRegionsOfInterestControl.xml' path='doc/member[@name="IRegionsOfInterestControl"]/*' />
[Guid("C323F527-AB0B-4558-8B5B-DF5693DB0378")]
[NativeTypeName("struct IRegionsOfInterestControl : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRegionsOfInterestControl : IRegionsOfInterestControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRegionsOfInterestControl));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionsOfInterestControl*, Guid*, void**, int>)(lpVtbl[0]))((IRegionsOfInterestControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionsOfInterestControl*, uint>)(lpVtbl[1]))((IRegionsOfInterestControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionsOfInterestControl*, uint>)(lpVtbl[2]))((IRegionsOfInterestControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionsOfInterestControl*, uint*, Guid**, int>)(lpVtbl[3]))((IRegionsOfInterestControl*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionsOfInterestControl*, HSTRING*, int>)(lpVtbl[4]))((IRegionsOfInterestControl*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionsOfInterestControl*, TrustLevel*, int>)(lpVtbl[5]))((IRegionsOfInterestControl*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRegionsOfInterestControl.xml' path='doc/member[@name="IRegionsOfInterestControl.get_MaxRegions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MaxRegions([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionsOfInterestControl*, uint*, int>)(lpVtbl[6]))((IRegionsOfInterestControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRegionsOfInterestControl.xml' path='doc/member[@name="IRegionsOfInterestControl.SetRegionsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetRegionsAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CMedia__CDevices__CRegionOfInterest_t *")] IIterable<Pointer<IRegionOfInterest>>* regions, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionsOfInterestControl*, IIterable<Pointer<IRegionOfInterest>>*, IAsyncAction**, int>)(lpVtbl[7]))((IRegionsOfInterestControl*)Unsafe.AsPointer(ref this), regions, asyncInfo);
    }

    /// <include file='IRegionsOfInterestControl.xml' path='doc/member[@name="IRegionsOfInterestControl.SetRegionsWithLockAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetRegionsWithLockAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CMedia__CDevices__CRegionOfInterest_t *")] IIterable<Pointer<IRegionOfInterest>>* regions, [NativeTypeName("boolean")] byte lockValues, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionsOfInterestControl*, IIterable<Pointer<IRegionOfInterest>>*, byte, IAsyncAction**, int>)(lpVtbl[8]))((IRegionsOfInterestControl*)Unsafe.AsPointer(ref this), regions, lockValues, asyncInfo);
    }

    /// <include file='IRegionsOfInterestControl.xml' path='doc/member[@name="IRegionsOfInterestControl.ClearRegionsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ClearRegionsAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionsOfInterestControl*, IAsyncAction**, int>)(lpVtbl[9]))((IRegionsOfInterestControl*)Unsafe.AsPointer(ref this), asyncInfo);
    }

    /// <include file='IRegionsOfInterestControl.xml' path='doc/member[@name="IRegionsOfInterestControl.get_AutoFocusSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_AutoFocusSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionsOfInterestControl*, byte*, int>)(lpVtbl[10]))((IRegionsOfInterestControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRegionsOfInterestControl.xml' path='doc/member[@name="IRegionsOfInterestControl.get_AutoWhiteBalanceSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_AutoWhiteBalanceSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionsOfInterestControl*, byte*, int>)(lpVtbl[11]))((IRegionsOfInterestControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRegionsOfInterestControl.xml' path='doc/member[@name="IRegionsOfInterestControl.get_AutoExposureSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_AutoExposureSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionsOfInterestControl*, byte*, int>)(lpVtbl[12]))((IRegionsOfInterestControl*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MaxRegions([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT SetRegionsAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CMedia__CDevices__CRegionOfInterest_t *")] IIterable<Pointer<IRegionOfInterest>>* regions, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);

        [VtblIndex(8)]
        HRESULT SetRegionsWithLockAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CMedia__CDevices__CRegionOfInterest_t *")] IIterable<Pointer<IRegionOfInterest>>* regions, [NativeTypeName("boolean")] byte lockValues, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);

        [VtblIndex(9)]
        HRESULT ClearRegionsAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);

        [VtblIndex(10)]
        HRESULT get_AutoFocusSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT get_AutoWhiteBalanceSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(12)]
        HRESULT get_AutoExposureSupported([NativeTypeName("boolean *")] byte* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_MaxRegions;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CMedia__CDevices__CRegionOfInterest_t *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IRegionOfInterest>>*, IAsyncAction**, int> SetRegionsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CMedia__CDevices__CRegionOfInterest_t *, boolean, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IRegionOfInterest>>*, byte, IAsyncAction**, int> SetRegionsWithLockAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> ClearRegionsAsync;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AutoFocusSupported;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AutoWhiteBalanceSupported;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AutoExposureSupported;
    }
}
