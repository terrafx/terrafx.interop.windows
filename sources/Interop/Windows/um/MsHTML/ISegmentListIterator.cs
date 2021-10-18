// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F692-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ISegmentListIterator : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISegmentListIterator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISegmentListIterator*, Guid*, void**, int>)(lpVtbl[0]))((ISegmentListIterator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISegmentListIterator*, uint>)(lpVtbl[1]))((ISegmentListIterator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISegmentListIterator*, uint>)(lpVtbl[2]))((ISegmentListIterator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Current(ISegment** ppISegment)
        {
            return ((delegate* unmanaged<ISegmentListIterator*, ISegment**, int>)(lpVtbl[3]))((ISegmentListIterator*)Unsafe.AsPointer(ref this), ppISegment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int First()
        {
            return ((delegate* unmanaged<ISegmentListIterator*, int>)(lpVtbl[4]))((ISegmentListIterator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int IsDone()
        {
            return ((delegate* unmanaged<ISegmentListIterator*, int>)(lpVtbl[5]))((ISegmentListIterator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Advance()
        {
            return ((delegate* unmanaged<ISegmentListIterator*, int>)(lpVtbl[6]))((ISegmentListIterator*)Unsafe.AsPointer(ref this));
        }
    }
}
