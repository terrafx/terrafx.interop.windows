// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.datatransfer.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITransferTargetDiscoveryOptions.xml' path='doc/member[@name="ITransferTargetDiscoveryOptions"]/*' />
[Guid("712FE3B5-644F-5F6B-97B6-3A3400999ED7")]
[NativeTypeName("struct ITransferTargetDiscoveryOptions : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITransferTargetDiscoveryOptions : ITransferTargetDiscoveryOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ITransferTargetDiscoveryOptions);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetDiscoveryOptions*, Guid*, void**, int>)(lpVtbl[0]))((ITransferTargetDiscoveryOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetDiscoveryOptions*, uint>)(lpVtbl[1]))((ITransferTargetDiscoveryOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetDiscoveryOptions*, uint>)(lpVtbl[2]))((ITransferTargetDiscoveryOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetDiscoveryOptions*, uint*, Guid**, int>)(lpVtbl[3]))((ITransferTargetDiscoveryOptions*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetDiscoveryOptions*, HSTRING*, int>)(lpVtbl[4]))((ITransferTargetDiscoveryOptions*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetDiscoveryOptions*, TrustLevel*, int>)(lpVtbl[5]))((ITransferTargetDiscoveryOptions*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITransferTargetDiscoveryOptions.xml' path='doc/member[@name="ITransferTargetDiscoveryOptions.get_DataPackage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DataPackage([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackageView **")] IDataPackageView** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetDiscoveryOptions*, IDataPackageView**, int>)(lpVtbl[6]))((ITransferTargetDiscoveryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITransferTargetDiscoveryOptions.xml' path='doc/member[@name="ITransferTargetDiscoveryOptions.get_MaxAppTargets"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MaxAppTargets([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetDiscoveryOptions*, int*, int>)(lpVtbl[7]))((ITransferTargetDiscoveryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITransferTargetDiscoveryOptions.xml' path='doc/member[@name="ITransferTargetDiscoveryOptions.put_MaxAppTargets"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_MaxAppTargets([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetDiscoveryOptions*, int, int>)(lpVtbl[8]))((ITransferTargetDiscoveryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITransferTargetDiscoveryOptions.xml' path='doc/member[@name="ITransferTargetDiscoveryOptions.get_AllowedTargetAppIds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_AllowedTargetAppIds([NativeTypeName("UINT32 *")] uint* valueLength, HSTRING** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetDiscoveryOptions*, uint*, HSTRING**, int>)(lpVtbl[9]))((ITransferTargetDiscoveryOptions*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='ITransferTargetDiscoveryOptions.xml' path='doc/member[@name="ITransferTargetDiscoveryOptions.put_AllowedTargetAppIds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_AllowedTargetAppIds([NativeTypeName("UINT32")] uint valueLength, HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetDiscoveryOptions*, uint, HSTRING*, int>)(lpVtbl[10]))((ITransferTargetDiscoveryOptions*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DataPackage([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackageView **")] IDataPackageView** value);

        [VtblIndex(7)]
        HRESULT get_MaxAppTargets([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(8)]
        HRESULT put_MaxAppTargets([NativeTypeName("INT32")] int value);

        [VtblIndex(9)]
        HRESULT get_AllowedTargetAppIds([NativeTypeName("UINT32 *")] uint* valueLength, HSTRING** value);

        [VtblIndex(10)]
        HRESULT put_AllowedTargetAppIds([NativeTypeName("UINT32")] uint valueLength, HSTRING* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::DataTransfer::IDataPackageView **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDataPackageView**, int> get_DataPackage;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MaxAppTargets;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_MaxAppTargets;

        [NativeTypeName("HRESULT (UINT32 *, HSTRING **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, HSTRING**, int> get_AllowedTargetAppIds;

        [NativeTypeName("HRESULT (UINT32, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, HSTRING*, int> put_AllowedTargetAppIds;
    }
}
