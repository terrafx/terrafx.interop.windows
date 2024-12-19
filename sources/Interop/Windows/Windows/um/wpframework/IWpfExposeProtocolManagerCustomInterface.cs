// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wpframework.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='IWpfExposeProtocolManagerCustomInterface.xml' path='doc/member[@name="IWpfExposeProtocolManagerCustomInterface"]/*' />
[NativeTypeName("struct IWpfExposeProtocolManagerCustomInterface : IWpfReferencedObject")]
[NativeInheritance("IWpfReferencedObject")]
public unsafe partial struct IWpfExposeProtocolManagerCustomInterface : IWpfExposeProtocolManagerCustomInterface.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IWpfReferencedObject.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWpfExposeProtocolManagerCustomInterface*, uint>)(lpVtbl[0]))((IWpfExposeProtocolManagerCustomInterface*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IWpfReferencedObject.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWpfExposeProtocolManagerCustomInterface*, uint>)(lpVtbl[1]))((IWpfExposeProtocolManagerCustomInterface*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWpfExposeProtocolManagerCustomInterface.xml' path='doc/member[@name="IWpfExposeProtocolManagerCustomInterface.LoadProtocolManagerAndGetCustomInterface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT LoadProtocolManagerAndGetCustomInterface([NativeTypeName("PCWSTR")] char* pProtocolManagerDll, [NativeTypeName("PCWSTR")] char* pProtocolManagerDllInitFunction, [NativeTypeName("DWORD")] uint dwCustomInterfaceId, [NativeTypeName("PVOID *")] void** ppCustomInterface)
    {
        return ((delegate* unmanaged[MemberFunction]<IWpfExposeProtocolManagerCustomInterface*, char*, char*, uint, void**, int>)(lpVtbl[2]))((IWpfExposeProtocolManagerCustomInterface*)Unsafe.AsPointer(ref this), pProtocolManagerDll, pProtocolManagerDllInitFunction, dwCustomInterfaceId, ppCustomInterface);
    }

    public interface Interface : IWpfReferencedObject.Interface
    {
        [VtblIndex(2)]
        HRESULT LoadProtocolManagerAndGetCustomInterface([NativeTypeName("PCWSTR")] char* pProtocolManagerDll, [NativeTypeName("PCWSTR")] char* pProtocolManagerDllInitFunction, [NativeTypeName("DWORD")] uint dwCustomInterfaceId, [NativeTypeName("PVOID *")] void** ppCustomInterface);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (PCWSTR, PCWSTR, DWORD, PVOID *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, uint, void**, int> LoadProtocolManagerAndGetCustomInterface;
    }
}
