// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F007EEAF-9831-411C-9847-917CDC62D1FE")]
    [NativeTypeName("struct IAppxFilesEnumerator : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxFilesEnumerator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxFilesEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAppxFilesEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxFilesEnumerator*, uint>)(lpVtbl[1]))((IAppxFilesEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxFilesEnumerator*, uint>)(lpVtbl[2]))((IAppxFilesEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrent(IAppxFile** file)
        {
            return ((delegate* unmanaged<IAppxFilesEnumerator*, IAppxFile**, int>)(lpVtbl[3]))((IAppxFilesEnumerator*)Unsafe.AsPointer(ref this), file);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetHasCurrent(BOOL* hasCurrent)
        {
            return ((delegate* unmanaged<IAppxFilesEnumerator*, BOOL*, int>)(lpVtbl[4]))((IAppxFilesEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int MoveNext(BOOL* hasNext)
        {
            return ((delegate* unmanaged<IAppxFilesEnumerator*, BOOL*, int>)(lpVtbl[5]))((IAppxFilesEnumerator*)Unsafe.AsPointer(ref this), hasNext);
        }
    }
}
