// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wpframework.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='IWorkerProcessFramework.xml' path='doc/member[@name="IWorkerProcessFramework"]/*' />
[NativeTypeName("struct IWorkerProcessFramework : IWpfReferencedObject")]
[NativeInheritance("IWpfReferencedObject")]
public unsafe partial struct IWorkerProcessFramework : IWorkerProcessFramework.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IWpfReferencedObject.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWorkerProcessFramework*, uint>)(lpVtbl[0]))((IWorkerProcessFramework*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IWpfReferencedObject.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWorkerProcessFramework*, uint>)(lpVtbl[1]))((IWorkerProcessFramework*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWorkerProcessFramework.xml' path='doc/member[@name="IWorkerProcessFramework.GetWpfInterface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT GetWpfInterface(WPF_INTERFACE_ID_ENUM WpfInterfaceId, [NativeTypeName("PVOID *")] void** ppInterface)
    {
        return ((delegate* unmanaged[MemberFunction]<IWorkerProcessFramework*, WPF_INTERFACE_ID_ENUM, void**, int>)(lpVtbl[2]))((IWorkerProcessFramework*)Unsafe.AsPointer(ref this), WpfInterfaceId, ppInterface);
    }

    /// <include file='IWorkerProcessFramework.xml' path='doc/member[@name="IWorkerProcessFramework.GetCustomInterface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCustomInterface([NativeTypeName("DWORD")] uint InterfaceId, [NativeTypeName("PVOID *")] void** ppInterface)
    {
        return ((delegate* unmanaged[MemberFunction]<IWorkerProcessFramework*, uint, void**, int>)(lpVtbl[3]))((IWorkerProcessFramework*)Unsafe.AsPointer(ref this), InterfaceId, ppInterface);
    }

    /// <include file='IWorkerProcessFramework.xml' path='doc/member[@name="IWorkerProcessFramework.GetInterfaceVersion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetInterfaceVersion([NativeTypeName("PDWORD")] uint* pdwMajorVersion, [NativeTypeName("PDWORD")] uint* pdwMinorVersion)
    {
        return ((delegate* unmanaged[MemberFunction]<IWorkerProcessFramework*, uint*, uint*, int>)(lpVtbl[4]))((IWorkerProcessFramework*)Unsafe.AsPointer(ref this), pdwMajorVersion, pdwMinorVersion);
    }

    public interface Interface : IWpfReferencedObject.Interface
    {
        [VtblIndex(2)]
        HRESULT GetWpfInterface(WPF_INTERFACE_ID_ENUM WpfInterfaceId, [NativeTypeName("PVOID *")] void** ppInterface);

        [VtblIndex(3)]
        HRESULT GetCustomInterface([NativeTypeName("DWORD")] uint InterfaceId, [NativeTypeName("PVOID *")] void** ppInterface);

        [VtblIndex(4)]
        HRESULT GetInterfaceVersion([NativeTypeName("PDWORD")] uint* pdwMajorVersion, [NativeTypeName("PDWORD")] uint* pdwMinorVersion);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (WPF_INTERFACE_ID_ENUM, PVOID *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WPF_INTERFACE_ID_ENUM, void**, int> GetWpfInterface;

        [NativeTypeName("HRESULT (DWORD, PVOID *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, void**, int> GetCustomInterface;

        [NativeTypeName("HRESULT (PDWORD, PDWORD)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, int> GetInterfaceVersion;
    }
}
