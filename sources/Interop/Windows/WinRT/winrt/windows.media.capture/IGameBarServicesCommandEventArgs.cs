// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGameBarServicesCommandEventArgs.xml' path='doc/member[@name="IGameBarServicesCommandEventArgs"]/*' />
[Guid("A74226B2-F176-4FCF-8FBB-CF698B2EB8E0")]
[NativeTypeName("struct IGameBarServicesCommandEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGameBarServicesCommandEventArgs : IGameBarServicesCommandEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGameBarServicesCommandEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServicesCommandEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IGameBarServicesCommandEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServicesCommandEventArgs*, uint>)(lpVtbl[1]))((IGameBarServicesCommandEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServicesCommandEventArgs*, uint>)(lpVtbl[2]))((IGameBarServicesCommandEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServicesCommandEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IGameBarServicesCommandEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServicesCommandEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IGameBarServicesCommandEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServicesCommandEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IGameBarServicesCommandEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGameBarServicesCommandEventArgs.xml' path='doc/member[@name="IGameBarServicesCommandEventArgs.get_Command"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Command([NativeTypeName("ABI::Windows::Media::Capture::GameBarCommand *")] GameBarCommand* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServicesCommandEventArgs*, GameBarCommand*, int>)(lpVtbl[6]))((IGameBarServicesCommandEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGameBarServicesCommandEventArgs.xml' path='doc/member[@name="IGameBarServicesCommandEventArgs.get_Origin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Origin([NativeTypeName("ABI::Windows::Media::Capture::GameBarCommandOrigin *")] GameBarCommandOrigin* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServicesCommandEventArgs*, GameBarCommandOrigin*, int>)(lpVtbl[7]))((IGameBarServicesCommandEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Command([NativeTypeName("ABI::Windows::Media::Capture::GameBarCommand *")] GameBarCommand* value);

        [VtblIndex(7)]
        HRESULT get_Origin([NativeTypeName("ABI::Windows::Media::Capture::GameBarCommandOrigin *")] GameBarCommandOrigin* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::GameBarCommand *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GameBarCommand*, int> get_Command;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::GameBarCommandOrigin *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GameBarCommandOrigin*, int> get_Origin;
    }
}
