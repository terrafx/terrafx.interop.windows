// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5EFEC991-BCA3-42D1-9EC2-E92D609EC22A")]
    [NativeTypeName("struct IAppxBlockMapReader : IUnknown")]
    public unsafe partial struct IAppxBlockMapReader
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxBlockMapReader*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBlockMapReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxBlockMapReader*, uint>)(lpVtbl[1]))((IAppxBlockMapReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxBlockMapReader*, uint>)(lpVtbl[2]))((IAppxBlockMapReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFile([NativeTypeName("LPCWSTR")] ushort* filename, IAppxBlockMapFile** file)
        {
            return ((delegate* unmanaged<IAppxBlockMapReader*, ushort*, IAppxBlockMapFile**, int>)(lpVtbl[3]))((IAppxBlockMapReader*)Unsafe.AsPointer(ref this), filename, file);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFiles(IAppxBlockMapFilesEnumerator** enumerator)
        {
            return ((delegate* unmanaged<IAppxBlockMapReader*, IAppxBlockMapFilesEnumerator**, int>)(lpVtbl[4]))((IAppxBlockMapReader*)Unsafe.AsPointer(ref this), enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetHashMethod(IUri** hashMethod)
        {
            return ((delegate* unmanaged<IAppxBlockMapReader*, IUri**, int>)(lpVtbl[5]))((IAppxBlockMapReader*)Unsafe.AsPointer(ref this), hashMethod);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStream(IStream** blockMapStream)
        {
            return ((delegate* unmanaged<IAppxBlockMapReader*, IStream**, int>)(lpVtbl[6]))((IAppxBlockMapReader*)Unsafe.AsPointer(ref this), blockMapStream);
        }
    }
}
