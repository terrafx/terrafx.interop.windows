// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wpframework.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='IProtocolManager.xml' path='doc/member[@name="IProtocolManager"]/*' />
[NativeTypeName("struct IProtocolManager : IWpfReferencedObject")]
[NativeInheritance("IWpfReferencedObject")]
public unsafe partial struct IProtocolManager : IProtocolManager.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IWpfReferencedObject.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IProtocolManager*, uint>)(lpVtbl[0]))((IProtocolManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IWpfReferencedObject.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IProtocolManager*, uint>)(lpVtbl[1]))((IProtocolManager*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IProtocolManager.xml' path='doc/member[@name="IProtocolManager.GetPmInterface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT GetPmInterface(PM_INTERFACE_ID_ENUM PmInterfaceId, [NativeTypeName("PVOID *")] void** ppInterface)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtocolManager*, PM_INTERFACE_ID_ENUM, void**, int>)(lpVtbl[2]))((IProtocolManager*)Unsafe.AsPointer(ref this), PmInterfaceId, ppInterface);
    }

    /// <include file='IProtocolManager.xml' path='doc/member[@name="IProtocolManager.GetCustomInterface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCustomInterface([NativeTypeName("DWORD")] uint InterfaceId, [NativeTypeName("PVOID *")] void** ppInterface)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtocolManager*, uint, void**, int>)(lpVtbl[3]))((IProtocolManager*)Unsafe.AsPointer(ref this), InterfaceId, ppInterface);
    }

    /// <include file='IProtocolManager.xml' path='doc/member[@name="IProtocolManager.Shutdown"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Shutdown(BOOL fImmediate)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtocolManager*, BOOL, int>)(lpVtbl[4]))((IProtocolManager*)Unsafe.AsPointer(ref this), fImmediate);
    }

    public interface Interface : IWpfReferencedObject.Interface
    {
        [VtblIndex(2)]
        HRESULT GetPmInterface(PM_INTERFACE_ID_ENUM PmInterfaceId, [NativeTypeName("PVOID *")] void** ppInterface);

        [VtblIndex(3)]
        HRESULT GetCustomInterface([NativeTypeName("DWORD")] uint InterfaceId, [NativeTypeName("PVOID *")] void** ppInterface);

        [VtblIndex(4)]
        HRESULT Shutdown(BOOL fImmediate);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (PM_INTERFACE_ID_ENUM, PVOID *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PM_INTERFACE_ID_ENUM, void**, int> GetPmInterface;

        [NativeTypeName("HRESULT (DWORD, PVOID *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, void**, int> GetCustomInterface;

        [NativeTypeName("HRESULT (BOOL)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL, int> Shutdown;
    }
}
