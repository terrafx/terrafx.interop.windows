// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1A09A2FD-7440-44EB-8C84-848205A6A1CC")]
    [NativeTypeName("struct IAppxContentGroupFilesEnumerator : IUnknown")]
    public unsafe partial struct IAppxContentGroupFilesEnumerator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxContentGroupFilesEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAppxContentGroupFilesEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxContentGroupFilesEnumerator*, uint>)(lpVtbl[1]))((IAppxContentGroupFilesEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxContentGroupFilesEnumerator*, uint>)(lpVtbl[2]))((IAppxContentGroupFilesEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrent([NativeTypeName("LPWSTR *")] ushort** file)
        {
            return ((delegate* unmanaged<IAppxContentGroupFilesEnumerator*, ushort**, int>)(lpVtbl[3]))((IAppxContentGroupFilesEnumerator*)Unsafe.AsPointer(ref this), file);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetHasCurrent([NativeTypeName("BOOL *")] int* hasCurrent)
        {
            return ((delegate* unmanaged<IAppxContentGroupFilesEnumerator*, int*, int>)(lpVtbl[4]))((IAppxContentGroupFilesEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MoveNext([NativeTypeName("BOOL *")] int* hasNext)
        {
            return ((delegate* unmanaged<IAppxContentGroupFilesEnumerator*, int*, int>)(lpVtbl[5]))((IAppxContentGroupFilesEnumerator*)Unsafe.AsPointer(ref this), hasNext);
        }
    }
}
