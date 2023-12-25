// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStreamSocketControl.xml' path='doc/member[@name="IStreamSocketControl"]/*' />
[Guid("FE25ADF1-92AB-4AF3-9992-0F4C85E36CC4")]
[NativeTypeName("struct IStreamSocketControl : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStreamSocketControl : IStreamSocketControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStreamSocketControl));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketControl*, Guid*, void**, int>)(lpVtbl[0]))((IStreamSocketControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketControl*, uint>)(lpVtbl[1]))((IStreamSocketControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketControl*, uint>)(lpVtbl[2]))((IStreamSocketControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketControl*, uint*, Guid**, int>)(lpVtbl[3]))((IStreamSocketControl*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketControl*, HSTRING*, int>)(lpVtbl[4]))((IStreamSocketControl*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketControl*, TrustLevel*, int>)(lpVtbl[5]))((IStreamSocketControl*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStreamSocketControl.xml' path='doc/member[@name="IStreamSocketControl.get_NoDelay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_NoDelay([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketControl*, byte*, int>)(lpVtbl[6]))((IStreamSocketControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamSocketControl.xml' path='doc/member[@name="IStreamSocketControl.put_NoDelay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_NoDelay([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketControl*, byte, int>)(lpVtbl[7]))((IStreamSocketControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamSocketControl.xml' path='doc/member[@name="IStreamSocketControl.get_KeepAlive"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_KeepAlive([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketControl*, byte*, int>)(lpVtbl[8]))((IStreamSocketControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamSocketControl.xml' path='doc/member[@name="IStreamSocketControl.put_KeepAlive"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_KeepAlive([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketControl*, byte, int>)(lpVtbl[9]))((IStreamSocketControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamSocketControl.xml' path='doc/member[@name="IStreamSocketControl.get_OutboundBufferSizeInBytes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_OutboundBufferSizeInBytes([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketControl*, uint*, int>)(lpVtbl[10]))((IStreamSocketControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamSocketControl.xml' path='doc/member[@name="IStreamSocketControl.put_OutboundBufferSizeInBytes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_OutboundBufferSizeInBytes([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketControl*, uint, int>)(lpVtbl[11]))((IStreamSocketControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamSocketControl.xml' path='doc/member[@name="IStreamSocketControl.get_QualityOfService"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_QualityOfService([NativeTypeName("ABI::Windows::Networking::Sockets::SocketQualityOfService *")] SocketQualityOfService* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketControl*, SocketQualityOfService*, int>)(lpVtbl[12]))((IStreamSocketControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamSocketControl.xml' path='doc/member[@name="IStreamSocketControl.put_QualityOfService"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_QualityOfService([NativeTypeName("ABI::Windows::Networking::Sockets::SocketQualityOfService")] SocketQualityOfService value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketControl*, SocketQualityOfService, int>)(lpVtbl[13]))((IStreamSocketControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamSocketControl.xml' path='doc/member[@name="IStreamSocketControl.get_OutboundUnicastHopLimit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_OutboundUnicastHopLimit(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketControl*, byte*, int>)(lpVtbl[14]))((IStreamSocketControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamSocketControl.xml' path='doc/member[@name="IStreamSocketControl.put_OutboundUnicastHopLimit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_OutboundUnicastHopLimit(byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketControl*, byte, int>)(lpVtbl[15]))((IStreamSocketControl*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_NoDelay([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_NoDelay([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_KeepAlive([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_KeepAlive([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_OutboundBufferSizeInBytes([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(11)]
        HRESULT put_OutboundBufferSizeInBytes([NativeTypeName("UINT32")] uint value);

        [VtblIndex(12)]
        HRESULT get_QualityOfService([NativeTypeName("ABI::Windows::Networking::Sockets::SocketQualityOfService *")] SocketQualityOfService* value);

        [VtblIndex(13)]
        HRESULT put_QualityOfService([NativeTypeName("ABI::Windows::Networking::Sockets::SocketQualityOfService")] SocketQualityOfService value);

        [VtblIndex(14)]
        HRESULT get_OutboundUnicastHopLimit(byte* value);

        [VtblIndex(15)]
        HRESULT put_OutboundUnicastHopLimit(byte value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_NoDelay;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_NoDelay;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_KeepAlive;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_KeepAlive;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_OutboundBufferSizeInBytes;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_OutboundBufferSizeInBytes;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Sockets::SocketQualityOfService *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SocketQualityOfService*, int> get_QualityOfService;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Sockets::SocketQualityOfService) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SocketQualityOfService, int> put_QualityOfService;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_OutboundUnicastHopLimit;

        [NativeTypeName("HRESULT (BYTE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_OutboundUnicastHopLimit;
    }
}
