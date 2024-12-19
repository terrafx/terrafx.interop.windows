// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wpframework.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='IWpfApplicationInfoUtil.xml' path='doc/member[@name="IWpfApplicationInfoUtil"]/*' />
[NativeTypeName("struct IWpfApplicationInfoUtil : IWpfReferencedObject")]
[NativeInheritance("IWpfReferencedObject")]
public unsafe partial struct IWpfApplicationInfoUtil : IWpfApplicationInfoUtil.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IWpfReferencedObject.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWpfApplicationInfoUtil*, uint>)(lpVtbl[0]))((IWpfApplicationInfoUtil*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IWpfReferencedObject.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWpfApplicationInfoUtil*, uint>)(lpVtbl[1]))((IWpfApplicationInfoUtil*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWpfApplicationInfoUtil.xml' path='doc/member[@name="IWpfApplicationInfoUtil.GetApplicationPropertiesFromAppId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT GetApplicationPropertiesFromAppId([NativeTypeName("PCWSTR")] char* pszAppId, [NativeTypeName("PWSTR")] char* pszVirtualPath, [NativeTypeName("DWORD *")] uint* pcchVirtualPath, [NativeTypeName("DWORD *")] uint* pdwSiteId)
    {
        return ((delegate* unmanaged[MemberFunction]<IWpfApplicationInfoUtil*, char*, char*, uint*, uint*, int>)(lpVtbl[2]))((IWpfApplicationInfoUtil*)Unsafe.AsPointer(ref this), pszAppId, pszVirtualPath, pcchVirtualPath, pdwSiteId);
    }

    public interface Interface : IWpfReferencedObject.Interface
    {
        [VtblIndex(2)]
        HRESULT GetApplicationPropertiesFromAppId([NativeTypeName("PCWSTR")] char* pszAppId, [NativeTypeName("PWSTR")] char* pszVirtualPath, [NativeTypeName("DWORD *")] uint* pcchVirtualPath, [NativeTypeName("DWORD *")] uint* pdwSiteId);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (PCWSTR, PWSTR, DWORD *, DWORD *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, uint*, uint*, int> GetApplicationPropertiesFromAppId;
    }
}
