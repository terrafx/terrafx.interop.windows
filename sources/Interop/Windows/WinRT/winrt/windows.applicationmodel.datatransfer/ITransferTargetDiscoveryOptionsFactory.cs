// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.datatransfer.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITransferTargetDiscoveryOptionsFactory.xml' path='doc/member[@name="ITransferTargetDiscoveryOptionsFactory"]/*' />
[Guid("EC4B7FFC-CBC6-5E12-8E9B-D5E892F2C6F8")]
[NativeTypeName("struct ITransferTargetDiscoveryOptionsFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITransferTargetDiscoveryOptionsFactory : ITransferTargetDiscoveryOptionsFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ITransferTargetDiscoveryOptionsFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetDiscoveryOptionsFactory*, Guid*, void**, int>)(lpVtbl[0]))((ITransferTargetDiscoveryOptionsFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetDiscoveryOptionsFactory*, uint>)(lpVtbl[1]))((ITransferTargetDiscoveryOptionsFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetDiscoveryOptionsFactory*, uint>)(lpVtbl[2]))((ITransferTargetDiscoveryOptionsFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetDiscoveryOptionsFactory*, uint*, Guid**, int>)(lpVtbl[3]))((ITransferTargetDiscoveryOptionsFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetDiscoveryOptionsFactory*, HSTRING*, int>)(lpVtbl[4]))((ITransferTargetDiscoveryOptionsFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetDiscoveryOptionsFactory*, TrustLevel*, int>)(lpVtbl[5]))((ITransferTargetDiscoveryOptionsFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITransferTargetDiscoveryOptionsFactory.xml' path='doc/member[@name="ITransferTargetDiscoveryOptionsFactory.CreateInstance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateInstance([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackageView *")] IDataPackageView* dataPackage, [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::ITransferTargetDiscoveryOptions **")] ITransferTargetDiscoveryOptions** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetDiscoveryOptionsFactory*, IDataPackageView*, ITransferTargetDiscoveryOptions**, int>)(lpVtbl[6]))((ITransferTargetDiscoveryOptionsFactory*)Unsafe.AsPointer(ref this), dataPackage, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateInstance([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackageView *")] IDataPackageView* dataPackage, [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::ITransferTargetDiscoveryOptions **")] ITransferTargetDiscoveryOptions** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::DataTransfer::IDataPackageView *, ABI::Windows::ApplicationModel::DataTransfer::ITransferTargetDiscoveryOptions **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDataPackageView*, ITransferTargetDiscoveryOptions**, int> CreateInstance;
    }
}
