// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DD75B8C0-BA76-43B0-AE0F-68656A1DC5C8")]
    [NativeTypeName("struct IAppxBundleReader : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxBundleReader
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxBundleReader*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBundleReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxBundleReader*, uint>)(lpVtbl[1]))((IAppxBundleReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxBundleReader*, uint>)(lpVtbl[2]))((IAppxBundleReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetFootprintFile(APPX_BUNDLE_FOOTPRINT_FILE_TYPE fileType, IAppxFile** footprintFile)
        {
            return ((delegate* unmanaged<IAppxBundleReader*, APPX_BUNDLE_FOOTPRINT_FILE_TYPE, IAppxFile**, int>)(lpVtbl[3]))((IAppxBundleReader*)Unsafe.AsPointer(ref this), fileType, footprintFile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetBlockMap(IAppxBlockMapReader** blockMapReader)
        {
            return ((delegate* unmanaged<IAppxBundleReader*, IAppxBlockMapReader**, int>)(lpVtbl[4]))((IAppxBundleReader*)Unsafe.AsPointer(ref this), blockMapReader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetManifest(IAppxBundleManifestReader** manifestReader)
        {
            return ((delegate* unmanaged<IAppxBundleReader*, IAppxBundleManifestReader**, int>)(lpVtbl[5]))((IAppxBundleReader*)Unsafe.AsPointer(ref this), manifestReader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetPayloadPackages(IAppxFilesEnumerator** payloadPackages)
        {
            return ((delegate* unmanaged<IAppxBundleReader*, IAppxFilesEnumerator**, int>)(lpVtbl[6]))((IAppxBundleReader*)Unsafe.AsPointer(ref this), payloadPackages);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetPayloadPackage([NativeTypeName("LPCWSTR")] ushort* fileName, IAppxFile** payloadPackage)
        {
            return ((delegate* unmanaged<IAppxBundleReader*, ushort*, IAppxFile**, int>)(lpVtbl[7]))((IAppxBundleReader*)Unsafe.AsPointer(ref this), fileName, payloadPackage);
        }
    }
}
