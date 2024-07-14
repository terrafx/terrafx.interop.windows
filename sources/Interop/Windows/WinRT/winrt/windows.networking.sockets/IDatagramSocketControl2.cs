// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDatagramSocketControl2.xml' path='doc/member[@name="IDatagramSocketControl2"]/*' />
[Guid("33EAD5C2-979C-4415-82A1-3CFAF646C192")]
[NativeTypeName("struct IDatagramSocketControl2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDatagramSocketControl2 : IDatagramSocketControl2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDatagramSocketControl2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketControl2*, Guid*, void**, int>)(lpVtbl[0]))((IDatagramSocketControl2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketControl2*, uint>)(lpVtbl[1]))((IDatagramSocketControl2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketControl2*, uint>)(lpVtbl[2]))((IDatagramSocketControl2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketControl2*, uint*, Guid**, int>)(lpVtbl[3]))((IDatagramSocketControl2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketControl2*, HSTRING*, int>)(lpVtbl[4]))((IDatagramSocketControl2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketControl2*, TrustLevel*, int>)(lpVtbl[5]))((IDatagramSocketControl2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDatagramSocketControl2.xml' path='doc/member[@name="IDatagramSocketControl2.get_InboundBufferSizeInBytes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_InboundBufferSizeInBytes([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketControl2*, uint*, int>)(lpVtbl[6]))((IDatagramSocketControl2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDatagramSocketControl2.xml' path='doc/member[@name="IDatagramSocketControl2.put_InboundBufferSizeInBytes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_InboundBufferSizeInBytes([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketControl2*, uint, int>)(lpVtbl[7]))((IDatagramSocketControl2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDatagramSocketControl2.xml' path='doc/member[@name="IDatagramSocketControl2.get_DontFragment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DontFragment([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketControl2*, byte*, int>)(lpVtbl[8]))((IDatagramSocketControl2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDatagramSocketControl2.xml' path='doc/member[@name="IDatagramSocketControl2.put_DontFragment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_DontFragment([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketControl2*, byte, int>)(lpVtbl[9]))((IDatagramSocketControl2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_InboundBufferSizeInBytes([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT put_InboundBufferSizeInBytes([NativeTypeName("UINT32")] uint value);

        [VtblIndex(8)]
        HRESULT get_DontFragment([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_DontFragment([NativeTypeName("boolean")] byte value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_InboundBufferSizeInBytes;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_InboundBufferSizeInBytes;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_DontFragment;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_DontFragment;
    }
}
