// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("1AC56374-6198-4D6B-92E4-749D5AB8A895")]
[NativeTypeName("struct IAppxManifestPackageDependency3 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxManifestPackageDependency3 : IAppxManifestPackageDependency3.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxManifestPackageDependency3*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestPackageDependency3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxManifestPackageDependency3*, uint>)(lpVtbl[1]))((IAppxManifestPackageDependency3*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxManifestPackageDependency3*, uint>)(lpVtbl[2]))((IAppxManifestPackageDependency3*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIsOptional(BOOL* isOptional)
    {
        return ((delegate* unmanaged<IAppxManifestPackageDependency3*, BOOL*, int>)(lpVtbl[3]))((IAppxManifestPackageDependency3*)Unsafe.AsPointer(ref this), isOptional);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetIsOptional(BOOL* isOptional);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetIsOptional;
    }
}
