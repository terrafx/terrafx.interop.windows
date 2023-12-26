// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISetVersionRequest.xml' path='doc/member[@name="ISetVersionRequest"]/*' />
[Guid("B9C76B9B-1056-4E69-8330-162619956F9B")]
[NativeTypeName("struct ISetVersionRequest : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISetVersionRequest : ISetVersionRequest.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISetVersionRequest));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISetVersionRequest*, Guid*, void**, int>)(lpVtbl[0]))((ISetVersionRequest*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISetVersionRequest*, uint>)(lpVtbl[1]))((ISetVersionRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISetVersionRequest*, uint>)(lpVtbl[2]))((ISetVersionRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISetVersionRequest*, uint*, Guid**, int>)(lpVtbl[3]))((ISetVersionRequest*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISetVersionRequest*, HSTRING*, int>)(lpVtbl[4]))((ISetVersionRequest*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISetVersionRequest*, TrustLevel*, int>)(lpVtbl[5]))((ISetVersionRequest*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISetVersionRequest.xml' path='doc/member[@name="ISetVersionRequest.get_CurrentVersion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CurrentVersion([NativeTypeName("UINT32 *")] uint* currentVersion)
    {
        return ((delegate* unmanaged[MemberFunction]<ISetVersionRequest*, uint*, int>)(lpVtbl[6]))((ISetVersionRequest*)Unsafe.AsPointer(ref this), currentVersion);
    }

    /// <include file='ISetVersionRequest.xml' path='doc/member[@name="ISetVersionRequest.get_DesiredVersion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DesiredVersion([NativeTypeName("UINT32 *")] uint* desiredVersion)
    {
        return ((delegate* unmanaged[MemberFunction]<ISetVersionRequest*, uint*, int>)(lpVtbl[7]))((ISetVersionRequest*)Unsafe.AsPointer(ref this), desiredVersion);
    }

    /// <include file='ISetVersionRequest.xml' path='doc/member[@name="ISetVersionRequest.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::Storage::ISetVersionDeferral **")] ISetVersionDeferral** deferral)
    {
        return ((delegate* unmanaged[MemberFunction]<ISetVersionRequest*, ISetVersionDeferral**, int>)(lpVtbl[8]))((ISetVersionRequest*)Unsafe.AsPointer(ref this), deferral);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CurrentVersion([NativeTypeName("UINT32 *")] uint* currentVersion);

        [VtblIndex(7)]
        HRESULT get_DesiredVersion([NativeTypeName("UINT32 *")] uint* desiredVersion);

        [VtblIndex(8)]
        HRESULT GetDeferral([NativeTypeName("ABI::Windows::Storage::ISetVersionDeferral **")] ISetVersionDeferral** deferral);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_CurrentVersion;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_DesiredVersion;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::ISetVersionDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISetVersionDeferral**, int> GetDeferral;
    }
}
