// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStreamSocketInformation.xml' path='doc/member[@name="IStreamSocketInformation"]/*' />
[Guid("3B80AE30-5E68-4205-88F0-DC85D2E25DED")]
[NativeTypeName("struct IStreamSocketInformation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStreamSocketInformation : IStreamSocketInformation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStreamSocketInformation));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketInformation*, Guid*, void**, int>)(lpVtbl[0]))((IStreamSocketInformation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketInformation*, uint>)(lpVtbl[1]))((IStreamSocketInformation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketInformation*, uint>)(lpVtbl[2]))((IStreamSocketInformation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketInformation*, uint*, Guid**, int>)(lpVtbl[3]))((IStreamSocketInformation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketInformation*, HSTRING*, int>)(lpVtbl[4]))((IStreamSocketInformation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketInformation*, TrustLevel*, int>)(lpVtbl[5]))((IStreamSocketInformation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStreamSocketInformation.xml' path='doc/member[@name="IStreamSocketInformation.get_LocalAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_LocalAddress([NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketInformation*, IHostName**, int>)(lpVtbl[6]))((IStreamSocketInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamSocketInformation.xml' path='doc/member[@name="IStreamSocketInformation.get_LocalPort"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_LocalPort(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketInformation*, HSTRING*, int>)(lpVtbl[7]))((IStreamSocketInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamSocketInformation.xml' path='doc/member[@name="IStreamSocketInformation.get_RemoteHostName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_RemoteHostName([NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketInformation*, IHostName**, int>)(lpVtbl[8]))((IStreamSocketInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamSocketInformation.xml' path='doc/member[@name="IStreamSocketInformation.get_RemoteAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_RemoteAddress([NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketInformation*, IHostName**, int>)(lpVtbl[9]))((IStreamSocketInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamSocketInformation.xml' path='doc/member[@name="IStreamSocketInformation.get_RemoteServiceName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_RemoteServiceName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketInformation*, HSTRING*, int>)(lpVtbl[10]))((IStreamSocketInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamSocketInformation.xml' path='doc/member[@name="IStreamSocketInformation.get_RemotePort"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_RemotePort(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketInformation*, HSTRING*, int>)(lpVtbl[11]))((IStreamSocketInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamSocketInformation.xml' path='doc/member[@name="IStreamSocketInformation.get_RoundTripTimeStatistics"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_RoundTripTimeStatistics([NativeTypeName("ABI::Windows::Networking::Sockets::RoundTripTimeStatistics *")] RoundTripTimeStatistics* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketInformation*, RoundTripTimeStatistics*, int>)(lpVtbl[12]))((IStreamSocketInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamSocketInformation.xml' path='doc/member[@name="IStreamSocketInformation.get_BandwidthStatistics"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_BandwidthStatistics([NativeTypeName("ABI::Windows::Networking::Sockets::BandwidthStatistics *")] BandwidthStatistics* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketInformation*, BandwidthStatistics*, int>)(lpVtbl[13]))((IStreamSocketInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamSocketInformation.xml' path='doc/member[@name="IStreamSocketInformation.get_ProtectionLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_ProtectionLevel([NativeTypeName("ABI::Windows::Networking::Sockets::SocketProtectionLevel *")] SocketProtectionLevel* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketInformation*, SocketProtectionLevel*, int>)(lpVtbl[14]))((IStreamSocketInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamSocketInformation.xml' path='doc/member[@name="IStreamSocketInformation.get_SessionKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_SessionKey([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketInformation*, IBuffer**, int>)(lpVtbl[15]))((IStreamSocketInformation*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_LocalAddress([NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName** value);

        [VtblIndex(7)]
        HRESULT get_LocalPort(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_RemoteHostName([NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName** value);

        [VtblIndex(9)]
        HRESULT get_RemoteAddress([NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName** value);

        [VtblIndex(10)]
        HRESULT get_RemoteServiceName(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_RemotePort(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_RoundTripTimeStatistics([NativeTypeName("ABI::Windows::Networking::Sockets::RoundTripTimeStatistics *")] RoundTripTimeStatistics* value);

        [VtblIndex(13)]
        HRESULT get_BandwidthStatistics([NativeTypeName("ABI::Windows::Networking::Sockets::BandwidthStatistics *")] BandwidthStatistics* value);

        [VtblIndex(14)]
        HRESULT get_ProtectionLevel([NativeTypeName("ABI::Windows::Networking::Sockets::SocketProtectionLevel *")] SocketProtectionLevel* value);

        [VtblIndex(15)]
        HRESULT get_SessionKey([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, IHostName**, int> get_LocalAddress;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_LocalPort;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IHostName **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHostName**, int> get_RemoteHostName;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IHostName **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHostName**, int> get_RemoteAddress;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RemoteServiceName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RemotePort;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Sockets::RoundTripTimeStatistics *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, RoundTripTimeStatistics*, int> get_RoundTripTimeStatistics;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Sockets::BandwidthStatistics *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BandwidthStatistics*, int> get_BandwidthStatistics;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Sockets::SocketProtectionLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SocketProtectionLevel*, int> get_ProtectionLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer**, int> get_SessionKey;
    }
}
