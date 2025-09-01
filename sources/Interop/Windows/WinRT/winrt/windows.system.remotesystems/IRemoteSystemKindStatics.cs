// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRemoteSystemKindStatics.xml' path='doc/member[@name="IRemoteSystemKindStatics"]/*' />
[Guid("F6317633-AB14-41D0-9553-796AADB882DB")]
[NativeTypeName("struct IRemoteSystemKindStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRemoteSystemKindStatics : IRemoteSystemKindStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IRemoteSystemKindStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemKindStatics*, Guid*, void**, int>)(lpVtbl[0]))((IRemoteSystemKindStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemKindStatics*, uint>)(lpVtbl[1]))((IRemoteSystemKindStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemKindStatics*, uint>)(lpVtbl[2]))((IRemoteSystemKindStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemKindStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IRemoteSystemKindStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemKindStatics*, HSTRING*, int>)(lpVtbl[4]))((IRemoteSystemKindStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemKindStatics*, TrustLevel*, int>)(lpVtbl[5]))((IRemoteSystemKindStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRemoteSystemKindStatics.xml' path='doc/member[@name="IRemoteSystemKindStatics.get_Phone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Phone(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemKindStatics*, HSTRING*, int>)(lpVtbl[6]))((IRemoteSystemKindStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRemoteSystemKindStatics.xml' path='doc/member[@name="IRemoteSystemKindStatics.get_Hub"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Hub(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemKindStatics*, HSTRING*, int>)(lpVtbl[7]))((IRemoteSystemKindStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRemoteSystemKindStatics.xml' path='doc/member[@name="IRemoteSystemKindStatics.get_Holographic"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Holographic(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemKindStatics*, HSTRING*, int>)(lpVtbl[8]))((IRemoteSystemKindStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRemoteSystemKindStatics.xml' path='doc/member[@name="IRemoteSystemKindStatics.get_Desktop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Desktop(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemKindStatics*, HSTRING*, int>)(lpVtbl[9]))((IRemoteSystemKindStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRemoteSystemKindStatics.xml' path='doc/member[@name="IRemoteSystemKindStatics.get_Xbox"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Xbox(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemKindStatics*, HSTRING*, int>)(lpVtbl[10]))((IRemoteSystemKindStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Phone(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Hub(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Holographic(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_Desktop(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_Xbox(HSTRING* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Phone;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Hub;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Holographic;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Desktop;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Xbox;
    }
}
