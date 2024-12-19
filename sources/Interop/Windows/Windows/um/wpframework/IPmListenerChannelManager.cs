// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wpframework.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='IPmListenerChannelManager.xml' path='doc/member[@name="IPmListenerChannelManager"]/*' />
[NativeTypeName("struct IPmListenerChannelManager : IWpfReferencedObject")]
[NativeInheritance("IWpfReferencedObject")]
public unsafe partial struct IPmListenerChannelManager : IPmListenerChannelManager.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IWpfReferencedObject.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPmListenerChannelManager*, uint>)(lpVtbl[0]))((IPmListenerChannelManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IWpfReferencedObject.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPmListenerChannelManager*, uint>)(lpVtbl[1]))((IPmListenerChannelManager*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPmListenerChannelManager.xml' path='doc/member[@name="IPmListenerChannelManager.StartListenerChannel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT StartListenerChannel([NativeTypeName("PCWSTR")] char* protocolId, IWpfListenerChannelCallback* pListenerChannelCallback)
    {
        return ((delegate* unmanaged[MemberFunction]<IPmListenerChannelManager*, char*, IWpfListenerChannelCallback*, int>)(lpVtbl[2]))((IPmListenerChannelManager*)Unsafe.AsPointer(ref this), protocolId, pListenerChannelCallback);
    }

    /// <include file='IPmListenerChannelManager.xml' path='doc/member[@name="IPmListenerChannelManager.StopListenerChannel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT StopListenerChannel([NativeTypeName("PCWSTR")] char* protocolId, IWpfListenerChannelCallback* pListenerChannelCallback, BOOL fImmediate)
    {
        return ((delegate* unmanaged[MemberFunction]<IPmListenerChannelManager*, char*, IWpfListenerChannelCallback*, BOOL, int>)(lpVtbl[3]))((IPmListenerChannelManager*)Unsafe.AsPointer(ref this), protocolId, pListenerChannelCallback, fImmediate);
    }

    public interface Interface : IWpfReferencedObject.Interface
    {
        [VtblIndex(2)]
        HRESULT StartListenerChannel([NativeTypeName("PCWSTR")] char* protocolId, IWpfListenerChannelCallback* pListenerChannelCallback);

        [VtblIndex(3)]
        HRESULT StopListenerChannel([NativeTypeName("PCWSTR")] char* protocolId, IWpfListenerChannelCallback* pListenerChannelCallback, BOOL fImmediate);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (PCWSTR, IWpfListenerChannelCallback *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, IWpfListenerChannelCallback*, int> StartListenerChannel;

        [NativeTypeName("HRESULT (PCWSTR, IWpfListenerChannelCallback *, BOOL)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, IWpfListenerChannelCallback*, BOOL, int> StopListenerChannel;
    }
}
