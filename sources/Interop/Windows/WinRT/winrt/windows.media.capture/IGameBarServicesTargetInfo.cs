// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGameBarServicesTargetInfo.xml' path='doc/member[@name="IGameBarServicesTargetInfo"]/*' />
[Guid("B4202F92-1611-4E05-B6EF-DFD737AE33B0")]
[NativeTypeName("struct IGameBarServicesTargetInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGameBarServicesTargetInfo : IGameBarServicesTargetInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IGameBarServicesTargetInfo);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServicesTargetInfo*, Guid*, void**, int>)(lpVtbl[0]))((IGameBarServicesTargetInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServicesTargetInfo*, uint>)(lpVtbl[1]))((IGameBarServicesTargetInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServicesTargetInfo*, uint>)(lpVtbl[2]))((IGameBarServicesTargetInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServicesTargetInfo*, uint*, Guid**, int>)(lpVtbl[3]))((IGameBarServicesTargetInfo*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServicesTargetInfo*, HSTRING*, int>)(lpVtbl[4]))((IGameBarServicesTargetInfo*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServicesTargetInfo*, TrustLevel*, int>)(lpVtbl[5]))((IGameBarServicesTargetInfo*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGameBarServicesTargetInfo.xml' path='doc/member[@name="IGameBarServicesTargetInfo.get_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServicesTargetInfo*, HSTRING*, int>)(lpVtbl[6]))((IGameBarServicesTargetInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGameBarServicesTargetInfo.xml' path='doc/member[@name="IGameBarServicesTargetInfo.get_AppId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AppId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServicesTargetInfo*, HSTRING*, int>)(lpVtbl[7]))((IGameBarServicesTargetInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGameBarServicesTargetInfo.xml' path='doc/member[@name="IGameBarServicesTargetInfo.get_TitleId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_TitleId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServicesTargetInfo*, HSTRING*, int>)(lpVtbl[8]))((IGameBarServicesTargetInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGameBarServicesTargetInfo.xml' path='doc/member[@name="IGameBarServicesTargetInfo.get_DisplayMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_DisplayMode([NativeTypeName("ABI::Windows::Media::Capture::GameBarServicesDisplayMode *")] GameBarServicesDisplayMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServicesTargetInfo*, GameBarServicesDisplayMode*, int>)(lpVtbl[9]))((IGameBarServicesTargetInfo*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_AppId(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_TitleId(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_DisplayMode([NativeTypeName("ABI::Windows::Media::Capture::GameBarServicesDisplayMode *")] GameBarServicesDisplayMode* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AppId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_TitleId;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::GameBarServicesDisplayMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GameBarServicesDisplayMode*, int> get_DisplayMode;
    }
}
