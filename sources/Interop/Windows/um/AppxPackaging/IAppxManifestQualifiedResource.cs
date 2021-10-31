// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3B53A497-3C5C-48D1-9EA3-BB7EAC8CD7D4")]
    [NativeTypeName("struct IAppxManifestQualifiedResource : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxManifestQualifiedResource
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestQualifiedResource*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestQualifiedResource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestQualifiedResource*, uint>)(lpVtbl[1]))((IAppxManifestQualifiedResource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestQualifiedResource*, uint>)(lpVtbl[2]))((IAppxManifestQualifiedResource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetLanguage([NativeTypeName("LPWSTR *")] ushort** language)
        {
            return ((delegate* unmanaged<IAppxManifestQualifiedResource*, ushort**, int>)(lpVtbl[3]))((IAppxManifestQualifiedResource*)Unsafe.AsPointer(ref this), language);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetScale([NativeTypeName("UINT32 *")] uint* scale)
        {
            return ((delegate* unmanaged<IAppxManifestQualifiedResource*, uint*, int>)(lpVtbl[4]))((IAppxManifestQualifiedResource*)Unsafe.AsPointer(ref this), scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetDXFeatureLevel(DX_FEATURE_LEVEL* dxFeatureLevel)
        {
            return ((delegate* unmanaged<IAppxManifestQualifiedResource*, DX_FEATURE_LEVEL*, int>)(lpVtbl[5]))((IAppxManifestQualifiedResource*)Unsafe.AsPointer(ref this), dxFeatureLevel);
        }
    }
}
