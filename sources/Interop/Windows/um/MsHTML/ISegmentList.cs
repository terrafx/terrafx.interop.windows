// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F605-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ISegmentList : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISegmentList
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISegmentList*, Guid*, void**, int>)(lpVtbl[0]))((ISegmentList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISegmentList*, uint>)(lpVtbl[1]))((ISegmentList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISegmentList*, uint>)(lpVtbl[2]))((ISegmentList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int CreateIterator(ISegmentListIterator** ppIIter)
        {
            return ((delegate* unmanaged<ISegmentList*, ISegmentListIterator**, int>)(lpVtbl[3]))((ISegmentList*)Unsafe.AsPointer(ref this), ppIIter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetType(SELECTION_TYPE* peType)
        {
            return ((delegate* unmanaged<ISegmentList*, SELECTION_TYPE*, int>)(lpVtbl[4]))((ISegmentList*)Unsafe.AsPointer(ref this), peType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int IsEmpty([NativeTypeName("BOOL *")] int* pfEmpty)
        {
            return ((delegate* unmanaged<ISegmentList*, int*, int>)(lpVtbl[5]))((ISegmentList*)Unsafe.AsPointer(ref this), pfEmpty);
        }
    }
}
