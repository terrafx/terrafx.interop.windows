// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.datatransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IShareTargetInfo.xml' path='doc/member[@name="IShareTargetInfo"]/*' />
[Guid("385BE607-C6E8-4114-B294-28F3BB6F9904")]
[NativeTypeName("struct IShareTargetInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IShareTargetInfo : IShareTargetInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShareTargetInfo));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareTargetInfo*, Guid*, void**, int>)(lpVtbl[0]))((IShareTargetInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IShareTargetInfo*, uint>)(lpVtbl[1]))((IShareTargetInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IShareTargetInfo*, uint>)(lpVtbl[2]))((IShareTargetInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareTargetInfo*, uint*, Guid**, int>)(lpVtbl[3]))((IShareTargetInfo*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareTargetInfo*, HSTRING*, int>)(lpVtbl[4]))((IShareTargetInfo*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareTargetInfo*, TrustLevel*, int>)(lpVtbl[5]))((IShareTargetInfo*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IShareTargetInfo.xml' path='doc/member[@name="IShareTargetInfo.get_AppUserModelId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AppUserModelId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareTargetInfo*, HSTRING*, int>)(lpVtbl[6]))((IShareTargetInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IShareTargetInfo.xml' path='doc/member[@name="IShareTargetInfo.get_ShareProvider"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ShareProvider([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IShareProvider **")] IShareProvider** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareTargetInfo*, IShareProvider**, int>)(lpVtbl[7]))((IShareTargetInfo*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AppUserModelId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_ShareProvider([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IShareProvider **")] IShareProvider** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AppUserModelId;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::DataTransfer::IShareProvider **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IShareProvider**, int> get_ShareProvider;
    }
}
