// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDatagramSocketMessageReceivedEventArgs.xml' path='doc/member[@name="IDatagramSocketMessageReceivedEventArgs"]/*' />
[Guid("9E2DDCA2-1712-4CE4-B179-8C652C6D107E")]
[NativeTypeName("struct IDatagramSocketMessageReceivedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDatagramSocketMessageReceivedEventArgs : IDatagramSocketMessageReceivedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDatagramSocketMessageReceivedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketMessageReceivedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IDatagramSocketMessageReceivedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketMessageReceivedEventArgs*, uint>)(lpVtbl[1]))((IDatagramSocketMessageReceivedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketMessageReceivedEventArgs*, uint>)(lpVtbl[2]))((IDatagramSocketMessageReceivedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketMessageReceivedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IDatagramSocketMessageReceivedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketMessageReceivedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IDatagramSocketMessageReceivedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketMessageReceivedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IDatagramSocketMessageReceivedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDatagramSocketMessageReceivedEventArgs.xml' path='doc/member[@name="IDatagramSocketMessageReceivedEventArgs.get_RemoteAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_RemoteAddress([NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketMessageReceivedEventArgs*, IHostName**, int>)(lpVtbl[6]))((IDatagramSocketMessageReceivedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDatagramSocketMessageReceivedEventArgs.xml' path='doc/member[@name="IDatagramSocketMessageReceivedEventArgs.get_RemotePort"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_RemotePort(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketMessageReceivedEventArgs*, HSTRING*, int>)(lpVtbl[7]))((IDatagramSocketMessageReceivedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDatagramSocketMessageReceivedEventArgs.xml' path='doc/member[@name="IDatagramSocketMessageReceivedEventArgs.get_LocalAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_LocalAddress([NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketMessageReceivedEventArgs*, IHostName**, int>)(lpVtbl[8]))((IDatagramSocketMessageReceivedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDatagramSocketMessageReceivedEventArgs.xml' path='doc/member[@name="IDatagramSocketMessageReceivedEventArgs.GetDataReader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDataReader([NativeTypeName("ABI::Windows::Storage::Streams::IDataReader **")] IDataReader** dataReader)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketMessageReceivedEventArgs*, IDataReader**, int>)(lpVtbl[9]))((IDatagramSocketMessageReceivedEventArgs*)Unsafe.AsPointer(ref this), dataReader);
    }

    /// <include file='IDatagramSocketMessageReceivedEventArgs.xml' path='doc/member[@name="IDatagramSocketMessageReceivedEventArgs.GetDataStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDataStream([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")] IInputStream** inputStream)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketMessageReceivedEventArgs*, IInputStream**, int>)(lpVtbl[10]))((IDatagramSocketMessageReceivedEventArgs*)Unsafe.AsPointer(ref this), inputStream);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_RemoteAddress([NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName** value);

        [VtblIndex(7)]
        HRESULT get_RemotePort(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_LocalAddress([NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName** value);

        [VtblIndex(9)]
        HRESULT GetDataReader([NativeTypeName("ABI::Windows::Storage::Streams::IDataReader **")] IDataReader** dataReader);

        [VtblIndex(10)]
        HRESULT GetDataStream([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")] IInputStream** inputStream);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, IHostName**, int> get_RemoteAddress;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RemotePort;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IHostName **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHostName**, int> get_LocalAddress;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IDataReader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDataReader**, int> GetDataReader;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IInputStream **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInputStream**, int> GetDataStream;
    }
}
