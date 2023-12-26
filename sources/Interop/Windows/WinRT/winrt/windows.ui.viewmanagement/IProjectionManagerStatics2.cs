// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IProjectionManagerStatics2.xml' path='doc/member[@name="IProjectionManagerStatics2"]/*' />
[Guid("F33D2F43-2749-4CDE-B977-C0C41E7415D1")]
[NativeTypeName("struct IProjectionManagerStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProjectionManagerStatics2 : IProjectionManagerStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProjectionManagerStatics2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IProjectionManagerStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IProjectionManagerStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IProjectionManagerStatics2*, uint>)(lpVtbl[1]))((IProjectionManagerStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IProjectionManagerStatics2*, uint>)(lpVtbl[2]))((IProjectionManagerStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IProjectionManagerStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IProjectionManagerStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IProjectionManagerStatics2*, HSTRING*, int>)(lpVtbl[4]))((IProjectionManagerStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IProjectionManagerStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IProjectionManagerStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IProjectionManagerStatics2.xml' path='doc/member[@name="IProjectionManagerStatics2.StartProjectingWithDeviceInfoAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT StartProjectingWithDeviceInfoAsync([NativeTypeName("INT32")] int projectionViewId, [NativeTypeName("INT32")] int anchorViewId, [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation *")] IDeviceInformation* displayDeviceInfo, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IProjectionManagerStatics2*, int, int, IDeviceInformation*, IAsyncAction**, int>)(lpVtbl[6]))((IProjectionManagerStatics2*)Unsafe.AsPointer(ref this), projectionViewId, anchorViewId, displayDeviceInfo, operation);
    }

    /// <include file='IProjectionManagerStatics2.xml' path='doc/member[@name="IProjectionManagerStatics2.RequestStartProjectingAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RequestStartProjectingAsync([NativeTypeName("INT32")] int projectionViewId, [NativeTypeName("INT32")] int anchorViewId, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IProjectionManagerStatics2*, int, int, Rect, IAsyncOperation<bool>**, int>)(lpVtbl[7]))((IProjectionManagerStatics2*)Unsafe.AsPointer(ref this), projectionViewId, anchorViewId, selection, operation);
    }

    /// <include file='IProjectionManagerStatics2.xml' path='doc/member[@name="IProjectionManagerStatics2.RequestStartProjectingWithPlacementAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RequestStartProjectingWithPlacementAsync([NativeTypeName("INT32")] int projectionViewId, [NativeTypeName("INT32")] int anchorViewId, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement prefferedPlacement, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IProjectionManagerStatics2*, int, int, Rect, Placement, IAsyncOperation<bool>**, int>)(lpVtbl[8]))((IProjectionManagerStatics2*)Unsafe.AsPointer(ref this), projectionViewId, anchorViewId, selection, prefferedPlacement, operation);
    }

    /// <include file='IProjectionManagerStatics2.xml' path='doc/member[@name="IProjectionManagerStatics2.GetDeviceSelector"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDeviceSelector(HSTRING* selector)
    {
        return ((delegate* unmanaged[MemberFunction]<IProjectionManagerStatics2*, HSTRING*, int>)(lpVtbl[9]))((IProjectionManagerStatics2*)Unsafe.AsPointer(ref this), selector);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT StartProjectingWithDeviceInfoAsync([NativeTypeName("INT32")] int projectionViewId, [NativeTypeName("INT32")] int anchorViewId, [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation *")] IDeviceInformation* displayDeviceInfo, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(7)]
        HRESULT RequestStartProjectingAsync([NativeTypeName("INT32")] int projectionViewId, [NativeTypeName("INT32")] int anchorViewId, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);

        [VtblIndex(8)]
        HRESULT RequestStartProjectingWithPlacementAsync([NativeTypeName("INT32")] int projectionViewId, [NativeTypeName("INT32")] int anchorViewId, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement prefferedPlacement, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);

        [VtblIndex(9)]
        HRESULT GetDeviceSelector(HSTRING* selector);
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

        [NativeTypeName("HRESULT (INT32, INT32, ABI::Windows::Devices::Enumeration::IDeviceInformation *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int, IDeviceInformation*, IAsyncAction**, int> StartProjectingWithDeviceInfoAsync;

        [NativeTypeName("HRESULT (INT32, INT32, ABI::Windows::Foundation::Rect, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int, Rect, IAsyncOperation<bool>**, int> RequestStartProjectingAsync;

        [NativeTypeName("HRESULT (INT32, INT32, ABI::Windows::Foundation::Rect, ABI::Windows::UI::Popups::Placement, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int, Rect, Placement, IAsyncOperation<bool>**, int> RequestStartProjectingWithPlacementAsync;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetDeviceSelector;
    }
}
