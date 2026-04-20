// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.datatransfer.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITransferTargetWatcherStatics.xml' path='doc/member[@name="ITransferTargetWatcherStatics"]/*' />
[Guid("A24B3528-DB4E-5BDD-9D30-DCB192C701F5")]
[NativeTypeName("struct ITransferTargetWatcherStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITransferTargetWatcherStatics : ITransferTargetWatcherStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ITransferTargetWatcherStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetWatcherStatics*, Guid*, void**, int>)(lpVtbl[0]))((ITransferTargetWatcherStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetWatcherStatics*, uint>)(lpVtbl[1]))((ITransferTargetWatcherStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetWatcherStatics*, uint>)(lpVtbl[2]))((ITransferTargetWatcherStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetWatcherStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ITransferTargetWatcherStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetWatcherStatics*, HSTRING*, int>)(lpVtbl[4]))((ITransferTargetWatcherStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetWatcherStatics*, TrustLevel*, int>)(lpVtbl[5]))((ITransferTargetWatcherStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITransferTargetWatcherStatics.xml' path='doc/member[@name="ITransferTargetWatcherStatics.IsSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsSupported([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackageView *")] IDataPackageView* dataPackage, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferTargetWatcherStatics*, IDataPackageView*, byte*, int>)(lpVtbl[6]))((ITransferTargetWatcherStatics*)Unsafe.AsPointer(ref this), dataPackage, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT IsSupported([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackageView *")] IDataPackageView* dataPackage, [NativeTypeName("boolean *")] byte* result);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::DataTransfer::IDataPackageView *, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDataPackageView*, byte*, int> IsSupported;
    }
}
