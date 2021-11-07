// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B5C49650-99BC-481C-9A34-3D53A4106708")]
    [NativeTypeName("struct IAppxPackageReader : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxPackageReader : IAppxPackageReader.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxPackageReader*, Guid*, void**, int>)(lpVtbl[0]))((IAppxPackageReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxPackageReader*, uint>)(lpVtbl[1]))((IAppxPackageReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxPackageReader*, uint>)(lpVtbl[2]))((IAppxPackageReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetBlockMap(IAppxBlockMapReader** blockMapReader)
        {
            return ((delegate* unmanaged<IAppxPackageReader*, IAppxBlockMapReader**, int>)(lpVtbl[3]))((IAppxPackageReader*)Unsafe.AsPointer(ref this), blockMapReader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetFootprintFile(APPX_FOOTPRINT_FILE_TYPE type, IAppxFile** file)
        {
            return ((delegate* unmanaged<IAppxPackageReader*, APPX_FOOTPRINT_FILE_TYPE, IAppxFile**, int>)(lpVtbl[4]))((IAppxPackageReader*)Unsafe.AsPointer(ref this), type, file);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetPayloadFile([NativeTypeName("LPCWSTR")] ushort* fileName, IAppxFile** file)
        {
            return ((delegate* unmanaged<IAppxPackageReader*, ushort*, IAppxFile**, int>)(lpVtbl[5]))((IAppxPackageReader*)Unsafe.AsPointer(ref this), fileName, file);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetPayloadFiles(IAppxFilesEnumerator** filesEnumerator)
        {
            return ((delegate* unmanaged<IAppxPackageReader*, IAppxFilesEnumerator**, int>)(lpVtbl[6]))((IAppxPackageReader*)Unsafe.AsPointer(ref this), filesEnumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetManifest(IAppxManifestReader** manifestReader)
        {
            return ((delegate* unmanaged<IAppxPackageReader*, IAppxManifestReader**, int>)(lpVtbl[7]))((IAppxPackageReader*)Unsafe.AsPointer(ref this), manifestReader);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetBlockMap(IAppxBlockMapReader** blockMapReader);

            [VtblIndex(4)]
            HRESULT GetFootprintFile(APPX_FOOTPRINT_FILE_TYPE type, IAppxFile** file);

            [VtblIndex(5)]
            HRESULT GetPayloadFile([NativeTypeName("LPCWSTR")] ushort* fileName, IAppxFile** file);

            [VtblIndex(6)]
            HRESULT GetPayloadFiles(IAppxFilesEnumerator** filesEnumerator);

            [VtblIndex(7)]
            HRESULT GetManifest(IAppxManifestReader** manifestReader);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxPackageReader*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxPackageReader*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxPackageReader*, uint> Release;

            [NativeTypeName("HRESULT (IAppxBlockMapReader **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxPackageReader*, IAppxBlockMapReader**, int> GetBlockMap;

            [NativeTypeName("HRESULT (APPX_FOOTPRINT_FILE_TYPE, IAppxFile **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxPackageReader*, APPX_FOOTPRINT_FILE_TYPE, IAppxFile**, int> GetFootprintFile;

            [NativeTypeName("HRESULT (LPCWSTR, IAppxFile **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxPackageReader*, ushort*, IAppxFile**, int> GetPayloadFile;

            [NativeTypeName("HRESULT (IAppxFilesEnumerator **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxPackageReader*, IAppxFilesEnumerator**, int> GetPayloadFiles;

            [NativeTypeName("HRESULT (IAppxManifestReader **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxPackageReader*, IAppxManifestReader**, int> GetManifest;
        }
    }
}
