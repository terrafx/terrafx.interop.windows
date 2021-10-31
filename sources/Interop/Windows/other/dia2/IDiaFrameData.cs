// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A39184B7-6A36-42DE-8EEC-7DF9F3F59F33")]
    [NativeTypeName("struct IDiaFrameData : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDiaFrameData
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiaFrameData*, Guid*, void**, int>)(lpVtbl[0]))((IDiaFrameData*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiaFrameData*, uint>)(lpVtbl[1]))((IDiaFrameData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiaFrameData*, uint>)(lpVtbl[2]))((IDiaFrameData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int get_addressSection([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaFrameData*, uint*, int>)(lpVtbl[3]))((IDiaFrameData*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int get_addressOffset([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaFrameData*, uint*, int>)(lpVtbl[4]))((IDiaFrameData*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int get_relativeVirtualAddress([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaFrameData*, uint*, int>)(lpVtbl[5]))((IDiaFrameData*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int get_virtualAddress([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
        {
            return ((delegate* unmanaged<IDiaFrameData*, ulong*, int>)(lpVtbl[6]))((IDiaFrameData*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_lengthBlock([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaFrameData*, uint*, int>)(lpVtbl[7]))((IDiaFrameData*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_lengthLocals([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaFrameData*, uint*, int>)(lpVtbl[8]))((IDiaFrameData*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int get_lengthParams([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaFrameData*, uint*, int>)(lpVtbl[9]))((IDiaFrameData*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_maxStack([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaFrameData*, uint*, int>)(lpVtbl[10]))((IDiaFrameData*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_lengthProlog([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaFrameData*, uint*, int>)(lpVtbl[11]))((IDiaFrameData*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_lengthSavedRegisters([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaFrameData*, uint*, int>)(lpVtbl[12]))((IDiaFrameData*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_program([NativeTypeName("BSTR *")] ushort** pRetVal)
        {
            return ((delegate* unmanaged<IDiaFrameData*, ushort**, int>)(lpVtbl[13]))((IDiaFrameData*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_systemExceptionHandling(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaFrameData*, BOOL*, int>)(lpVtbl[14]))((IDiaFrameData*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_cplusplusExceptionHandling(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaFrameData*, BOOL*, int>)(lpVtbl[15]))((IDiaFrameData*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_functionStart(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaFrameData*, BOOL*, int>)(lpVtbl[16]))((IDiaFrameData*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_allocatesBasePointer(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaFrameData*, BOOL*, int>)(lpVtbl[17]))((IDiaFrameData*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_type([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaFrameData*, uint*, int>)(lpVtbl[18]))((IDiaFrameData*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_functionParent(IDiaFrameData** pRetVal)
        {
            return ((delegate* unmanaged<IDiaFrameData*, IDiaFrameData**, int>)(lpVtbl[19]))((IDiaFrameData*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int execute(IDiaStackWalkFrame* frame)
        {
            return ((delegate* unmanaged<IDiaFrameData*, IDiaStackWalkFrame*, int>)(lpVtbl[20]))((IDiaFrameData*)Unsafe.AsPointer(ref this), frame);
        }
    }
}
