// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3264E477-16D1-4D63-823E-7D2984696634")]
    [NativeTypeName("struct IAppxContentGroupsEnumerator : IUnknown")]
    public unsafe partial struct IAppxContentGroupsEnumerator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxContentGroupsEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAppxContentGroupsEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxContentGroupsEnumerator*, uint>)(lpVtbl[1]))((IAppxContentGroupsEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxContentGroupsEnumerator*, uint>)(lpVtbl[2]))((IAppxContentGroupsEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrent(IAppxContentGroup** stream)
        {
            return ((delegate* unmanaged<IAppxContentGroupsEnumerator*, IAppxContentGroup**, int>)(lpVtbl[3]))((IAppxContentGroupsEnumerator*)Unsafe.AsPointer(ref this), stream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetHasCurrent([NativeTypeName("BOOL *")] int* hasCurrent)
        {
            return ((delegate* unmanaged<IAppxContentGroupsEnumerator*, int*, int>)(lpVtbl[4]))((IAppxContentGroupsEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MoveNext([NativeTypeName("BOOL *")] int* hasNext)
        {
            return ((delegate* unmanaged<IAppxContentGroupsEnumerator*, int*, int>)(lpVtbl[5]))((IAppxContentGroupsEnumerator*)Unsafe.AsPointer(ref this), hasNext);
        }
    }
}
