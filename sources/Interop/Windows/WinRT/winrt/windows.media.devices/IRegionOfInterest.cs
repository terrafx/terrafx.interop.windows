// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRegionOfInterest.xml' path='doc/member[@name="IRegionOfInterest"]/*' />
[Guid("E5ECC834-CE66-4E05-A78F-CF391A5EC2D1")]
[NativeTypeName("struct IRegionOfInterest : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRegionOfInterest : IRegionOfInterest.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IRegionOfInterest);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionOfInterest*, Guid*, void**, int>)(lpVtbl[0]))((IRegionOfInterest*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionOfInterest*, uint>)(lpVtbl[1]))((IRegionOfInterest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionOfInterest*, uint>)(lpVtbl[2]))((IRegionOfInterest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionOfInterest*, uint*, Guid**, int>)(lpVtbl[3]))((IRegionOfInterest*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionOfInterest*, HSTRING*, int>)(lpVtbl[4]))((IRegionOfInterest*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionOfInterest*, TrustLevel*, int>)(lpVtbl[5]))((IRegionOfInterest*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRegionOfInterest.xml' path='doc/member[@name="IRegionOfInterest.get_AutoFocusEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AutoFocusEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionOfInterest*, byte*, int>)(lpVtbl[6]))((IRegionOfInterest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRegionOfInterest.xml' path='doc/member[@name="IRegionOfInterest.put_AutoFocusEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_AutoFocusEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionOfInterest*, byte, int>)(lpVtbl[7]))((IRegionOfInterest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRegionOfInterest.xml' path='doc/member[@name="IRegionOfInterest.get_AutoWhiteBalanceEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AutoWhiteBalanceEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionOfInterest*, byte*, int>)(lpVtbl[8]))((IRegionOfInterest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRegionOfInterest.xml' path='doc/member[@name="IRegionOfInterest.put_AutoWhiteBalanceEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_AutoWhiteBalanceEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionOfInterest*, byte, int>)(lpVtbl[9]))((IRegionOfInterest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRegionOfInterest.xml' path='doc/member[@name="IRegionOfInterest.get_AutoExposureEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_AutoExposureEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionOfInterest*, byte*, int>)(lpVtbl[10]))((IRegionOfInterest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRegionOfInterest.xml' path='doc/member[@name="IRegionOfInterest.put_AutoExposureEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_AutoExposureEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionOfInterest*, byte, int>)(lpVtbl[11]))((IRegionOfInterest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRegionOfInterest.xml' path='doc/member[@name="IRegionOfInterest.get_Bounds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Bounds([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionOfInterest*, Rect*, int>)(lpVtbl[12]))((IRegionOfInterest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRegionOfInterest.xml' path='doc/member[@name="IRegionOfInterest.put_Bounds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Bounds([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionOfInterest*, Rect, int>)(lpVtbl[13]))((IRegionOfInterest*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AutoFocusEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_AutoFocusEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_AutoWhiteBalanceEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_AutoWhiteBalanceEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_AutoExposureEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT put_AutoExposureEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(12)]
        HRESULT get_Bounds([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value);

        [VtblIndex(13)]
        HRESULT put_Bounds([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AutoFocusEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_AutoFocusEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AutoWhiteBalanceEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_AutoWhiteBalanceEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AutoExposureEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_AutoExposureEnabled;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Rect*, int> get_Bounds;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Rect, int> put_Bounds;
    }
}
