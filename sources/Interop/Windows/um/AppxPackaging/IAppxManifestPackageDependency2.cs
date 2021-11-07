// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows8.0")]
    [Guid("DDA0B713-F3FF-49D3-898A-2786780C5D98")]
    [NativeTypeName("struct IAppxManifestPackageDependency2 : IAppxManifestPackageDependency")]
    [NativeInheritance("IAppxManifestPackageDependency")]
    public unsafe partial struct IAppxManifestPackageDependency2 : IAppxManifestPackageDependency2.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestPackageDependency2*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestPackageDependency2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestPackageDependency2*, uint>)(lpVtbl[1]))((IAppxManifestPackageDependency2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestPackageDependency2*, uint>)(lpVtbl[2]))((IAppxManifestPackageDependency2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** name)
        {
            return ((delegate* unmanaged<IAppxManifestPackageDependency2*, ushort**, int>)(lpVtbl[3]))((IAppxManifestPackageDependency2*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetPublisher([NativeTypeName("LPWSTR *")] ushort** publisher)
        {
            return ((delegate* unmanaged<IAppxManifestPackageDependency2*, ushort**, int>)(lpVtbl[4]))((IAppxManifestPackageDependency2*)Unsafe.AsPointer(ref this), publisher);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetMinVersion([NativeTypeName("UINT64 *")] ulong* minVersion)
        {
            return ((delegate* unmanaged<IAppxManifestPackageDependency2*, ulong*, int>)(lpVtbl[5]))((IAppxManifestPackageDependency2*)Unsafe.AsPointer(ref this), minVersion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetMaxMajorVersionTested([NativeTypeName("UINT16 *")] ushort* maxMajorVersionTested)
        {
            return ((delegate* unmanaged<IAppxManifestPackageDependency2*, ushort*, int>)(lpVtbl[6]))((IAppxManifestPackageDependency2*)Unsafe.AsPointer(ref this), maxMajorVersionTested);
        }

        public interface Interface : IAppxManifestPackageDependency.Interface
        {
            [VtblIndex(6)]
            HRESULT GetMaxMajorVersionTested([NativeTypeName("UINT16 *")] ushort* maxMajorVersionTested);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxManifestPackageDependency2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxManifestPackageDependency2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxManifestPackageDependency2*, uint> Release;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxManifestPackageDependency2*, ushort**, int> GetName;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxManifestPackageDependency2*, ushort**, int> GetPublisher;

            [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxManifestPackageDependency2*, ulong*, int> GetMinVersion;

            [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxManifestPackageDependency2*, ushort*, int> GetMaxMajorVersionTested;
        }
    }
}
