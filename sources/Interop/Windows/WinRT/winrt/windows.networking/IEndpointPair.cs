// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEndpointPair.xml' path='doc/member[@name="IEndpointPair"]/*' />
[Guid("33A0AA36-F8FA-4B30-B856-76517C3BD06D")]
[NativeTypeName("struct IEndpointPair : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEndpointPair : IEndpointPair.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IEndpointPair);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEndpointPair*, Guid*, void**, int>)(lpVtbl[0]))((IEndpointPair*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEndpointPair*, uint>)(lpVtbl[1]))((IEndpointPair*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEndpointPair*, uint>)(lpVtbl[2]))((IEndpointPair*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEndpointPair*, uint*, Guid**, int>)(lpVtbl[3]))((IEndpointPair*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEndpointPair*, HSTRING*, int>)(lpVtbl[4]))((IEndpointPair*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEndpointPair*, TrustLevel*, int>)(lpVtbl[5]))((IEndpointPair*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEndpointPair.xml' path='doc/member[@name="IEndpointPair.get_LocalHostName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_LocalHostName([NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEndpointPair*, IHostName**, int>)(lpVtbl[6]))((IEndpointPair*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEndpointPair.xml' path='doc/member[@name="IEndpointPair.put_LocalHostName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_LocalHostName([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEndpointPair*, IHostName*, int>)(lpVtbl[7]))((IEndpointPair*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEndpointPair.xml' path='doc/member[@name="IEndpointPair.get_LocalServiceName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_LocalServiceName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEndpointPair*, HSTRING*, int>)(lpVtbl[8]))((IEndpointPair*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEndpointPair.xml' path='doc/member[@name="IEndpointPair.put_LocalServiceName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_LocalServiceName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEndpointPair*, HSTRING, int>)(lpVtbl[9]))((IEndpointPair*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEndpointPair.xml' path='doc/member[@name="IEndpointPair.get_RemoteHostName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_RemoteHostName([NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEndpointPair*, IHostName**, int>)(lpVtbl[10]))((IEndpointPair*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEndpointPair.xml' path='doc/member[@name="IEndpointPair.put_RemoteHostName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_RemoteHostName([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEndpointPair*, IHostName*, int>)(lpVtbl[11]))((IEndpointPair*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEndpointPair.xml' path='doc/member[@name="IEndpointPair.get_RemoteServiceName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_RemoteServiceName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEndpointPair*, HSTRING*, int>)(lpVtbl[12]))((IEndpointPair*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEndpointPair.xml' path='doc/member[@name="IEndpointPair.put_RemoteServiceName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_RemoteServiceName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEndpointPair*, HSTRING, int>)(lpVtbl[13]))((IEndpointPair*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_LocalHostName([NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName** value);

        [VtblIndex(7)]
        HRESULT put_LocalHostName([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* value);

        [VtblIndex(8)]
        HRESULT get_LocalServiceName(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_LocalServiceName(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_RemoteHostName([NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName** value);

        [VtblIndex(11)]
        HRESULT put_RemoteHostName([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* value);

        [VtblIndex(12)]
        HRESULT get_RemoteServiceName(HSTRING* value);

        [VtblIndex(13)]
        HRESULT put_RemoteServiceName(HSTRING value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IHostName **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHostName**, int> get_LocalHostName;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IHostName *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHostName*, int> put_LocalHostName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_LocalServiceName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_LocalServiceName;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IHostName **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHostName**, int> get_RemoteHostName;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IHostName *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHostName*, int> put_RemoteHostName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RemoteServiceName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_RemoteServiceName;
    }
}
