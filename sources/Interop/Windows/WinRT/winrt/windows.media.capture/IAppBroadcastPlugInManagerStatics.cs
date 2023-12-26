// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppBroadcastPlugInManagerStatics.xml' path='doc/member[@name="IAppBroadcastPlugInManagerStatics"]/*' />
[Guid("F2645C20-5C76-4CDC-9364-82FE9EB6534D")]
[NativeTypeName("struct IAppBroadcastPlugInManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppBroadcastPlugInManagerStatics : IAppBroadcastPlugInManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppBroadcastPlugInManagerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPlugInManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IAppBroadcastPlugInManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPlugInManagerStatics*, uint>)(lpVtbl[1]))((IAppBroadcastPlugInManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPlugInManagerStatics*, uint>)(lpVtbl[2]))((IAppBroadcastPlugInManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPlugInManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IAppBroadcastPlugInManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPlugInManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((IAppBroadcastPlugInManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPlugInManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IAppBroadcastPlugInManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppBroadcastPlugInManagerStatics.xml' path='doc/member[@name="IAppBroadcastPlugInManagerStatics.GetDefault"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDefault([NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastPlugInManager **")] IAppBroadcastPlugInManager** ppInstance)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPlugInManagerStatics*, IAppBroadcastPlugInManager**, int>)(lpVtbl[6]))((IAppBroadcastPlugInManagerStatics*)Unsafe.AsPointer(ref this), ppInstance);
    }

    /// <include file='IAppBroadcastPlugInManagerStatics.xml' path='doc/member[@name="IAppBroadcastPlugInManagerStatics.GetForUser"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetForUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastPlugInManager **")] IAppBroadcastPlugInManager** ppInstance)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPlugInManagerStatics*, IUser*, IAppBroadcastPlugInManager**, int>)(lpVtbl[7]))((IAppBroadcastPlugInManagerStatics*)Unsafe.AsPointer(ref this), user, ppInstance);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDefault([NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastPlugInManager **")] IAppBroadcastPlugInManager** ppInstance);

        [VtblIndex(7)]
        HRESULT GetForUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastPlugInManager **")] IAppBroadcastPlugInManager** ppInstance);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::IAppBroadcastPlugInManager **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppBroadcastPlugInManager**, int> GetDefault;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *, ABI::Windows::Media::Capture::IAppBroadcastPlugInManager **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, IAppBroadcastPlugInManager**, int> GetForUser;
    }
}
