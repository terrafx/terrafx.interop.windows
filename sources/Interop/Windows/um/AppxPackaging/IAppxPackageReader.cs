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
    public unsafe partial struct IAppxPackageReader
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxPackageReader*, Guid*, void**, int>)(lpVtbl[0]))((IAppxPackageReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxPackageReader*, uint>)(lpVtbl[1]))((IAppxPackageReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxPackageReader*, uint>)(lpVtbl[2]))((IAppxPackageReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBlockMap(IAppxBlockMapReader** blockMapReader)
        {
            return ((delegate* unmanaged<IAppxPackageReader*, IAppxBlockMapReader**, int>)(lpVtbl[3]))((IAppxPackageReader*)Unsafe.AsPointer(ref this), blockMapReader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFootprintFile(APPX_FOOTPRINT_FILE_TYPE type, IAppxFile** file)
        {
            return ((delegate* unmanaged<IAppxPackageReader*, APPX_FOOTPRINT_FILE_TYPE, IAppxFile**, int>)(lpVtbl[4]))((IAppxPackageReader*)Unsafe.AsPointer(ref this), type, file);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPayloadFile([NativeTypeName("LPCWSTR")] ushort* fileName, IAppxFile** file)
        {
            return ((delegate* unmanaged<IAppxPackageReader*, ushort*, IAppxFile**, int>)(lpVtbl[5]))((IAppxPackageReader*)Unsafe.AsPointer(ref this), fileName, file);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPayloadFiles(IAppxFilesEnumerator** filesEnumerator)
        {
            return ((delegate* unmanaged<IAppxPackageReader*, IAppxFilesEnumerator**, int>)(lpVtbl[6]))((IAppxPackageReader*)Unsafe.AsPointer(ref this), filesEnumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetManifest(IAppxManifestReader** manifestReader)
        {
            return ((delegate* unmanaged<IAppxPackageReader*, IAppxManifestReader**, int>)(lpVtbl[7]))((IAppxPackageReader*)Unsafe.AsPointer(ref this), manifestReader);
        }
    }
}
