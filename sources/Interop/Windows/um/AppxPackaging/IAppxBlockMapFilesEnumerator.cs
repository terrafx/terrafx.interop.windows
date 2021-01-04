// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("02B856A2-4262-4070-BACB-1A8CBBC42305")]
    [NativeTypeName("struct IAppxBlockMapFilesEnumerator : IUnknown")]
    public unsafe partial struct IAppxBlockMapFilesEnumerator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxBlockMapFilesEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBlockMapFilesEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxBlockMapFilesEnumerator*, uint>)(lpVtbl[1]))((IAppxBlockMapFilesEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxBlockMapFilesEnumerator*, uint>)(lpVtbl[2]))((IAppxBlockMapFilesEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrent([NativeTypeName("IAppxBlockMapFile **")] IAppxBlockMapFile** file)
        {
            return ((delegate* unmanaged<IAppxBlockMapFilesEnumerator*, IAppxBlockMapFile**, int>)(lpVtbl[3]))((IAppxBlockMapFilesEnumerator*)Unsafe.AsPointer(ref this), file);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetHasCurrent([NativeTypeName("BOOL *")] int* hasCurrent)
        {
            return ((delegate* unmanaged<IAppxBlockMapFilesEnumerator*, int*, int>)(lpVtbl[4]))((IAppxBlockMapFilesEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MoveNext([NativeTypeName("BOOL *")] int* hasCurrent)
        {
            return ((delegate* unmanaged<IAppxBlockMapFilesEnumerator*, int*, int>)(lpVtbl[5]))((IAppxBlockMapFilesEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
        }
    }
}
