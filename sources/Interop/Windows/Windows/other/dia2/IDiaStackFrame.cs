// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("5EDBC96D-CDD6-4792-AFBE-CC89007D9610")]
    [NativeTypeName("struct IDiaStackFrame : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDiaStackFrame : IDiaStackFrame.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiaStackFrame*, Guid*, void**, int>)(lpVtbl[0]))((IDiaStackFrame*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiaStackFrame*, uint>)(lpVtbl[1]))((IDiaStackFrame*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiaStackFrame*, uint>)(lpVtbl[2]))((IDiaStackFrame*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT get_type([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaStackFrame*, uint*, int>)(lpVtbl[3]))((IDiaStackFrame*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT get_base([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
        {
            return ((delegate* unmanaged<IDiaStackFrame*, ulong*, int>)(lpVtbl[4]))((IDiaStackFrame*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT get_size([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaStackFrame*, uint*, int>)(lpVtbl[5]))((IDiaStackFrame*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT get_returnAddress([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
        {
            return ((delegate* unmanaged<IDiaStackFrame*, ulong*, int>)(lpVtbl[6]))((IDiaStackFrame*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_localsBase([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
        {
            return ((delegate* unmanaged<IDiaStackFrame*, ulong*, int>)(lpVtbl[7]))((IDiaStackFrame*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_lengthLocals([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaStackFrame*, uint*, int>)(lpVtbl[8]))((IDiaStackFrame*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_lengthParams([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaStackFrame*, uint*, int>)(lpVtbl[9]))((IDiaStackFrame*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_lengthProlog([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaStackFrame*, uint*, int>)(lpVtbl[10]))((IDiaStackFrame*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_lengthSavedRegisters([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaStackFrame*, uint*, int>)(lpVtbl[11]))((IDiaStackFrame*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_systemExceptionHandling(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaStackFrame*, BOOL*, int>)(lpVtbl[12]))((IDiaStackFrame*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_cplusplusExceptionHandling(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaStackFrame*, BOOL*, int>)(lpVtbl[13]))((IDiaStackFrame*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_functionStart(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaStackFrame*, BOOL*, int>)(lpVtbl[14]))((IDiaStackFrame*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT get_allocatesBasePointer(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaStackFrame*, BOOL*, int>)(lpVtbl[15]))((IDiaStackFrame*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_maxStack([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaStackFrame*, uint*, int>)(lpVtbl[16]))((IDiaStackFrame*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT get_registerValue([NativeTypeName("DWORD")] uint index, [NativeTypeName("ULONGLONG *")] ulong* pRetVal)
        {
            return ((delegate* unmanaged<IDiaStackFrame*, uint, ulong*, int>)(lpVtbl[17]))((IDiaStackFrame*)Unsafe.AsPointer(ref this), index, pRetVal);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT get_type([NativeTypeName("DWORD *")] uint* pRetVal);

            [VtblIndex(4)]
            HRESULT get_base([NativeTypeName("ULONGLONG *")] ulong* pRetVal);

            [VtblIndex(5)]
            HRESULT get_size([NativeTypeName("DWORD *")] uint* pRetVal);

            [VtblIndex(6)]
            HRESULT get_returnAddress([NativeTypeName("ULONGLONG *")] ulong* pRetVal);

            [VtblIndex(7)]
            HRESULT get_localsBase([NativeTypeName("ULONGLONG *")] ulong* pRetVal);

            [VtblIndex(8)]
            HRESULT get_lengthLocals([NativeTypeName("DWORD *")] uint* pRetVal);

            [VtblIndex(9)]
            HRESULT get_lengthParams([NativeTypeName("DWORD *")] uint* pRetVal);

            [VtblIndex(10)]
            HRESULT get_lengthProlog([NativeTypeName("DWORD *")] uint* pRetVal);

            [VtblIndex(11)]
            HRESULT get_lengthSavedRegisters([NativeTypeName("DWORD *")] uint* pRetVal);

            [VtblIndex(12)]
            HRESULT get_systemExceptionHandling(BOOL* pRetVal);

            [VtblIndex(13)]
            HRESULT get_cplusplusExceptionHandling(BOOL* pRetVal);

            [VtblIndex(14)]
            HRESULT get_functionStart(BOOL* pRetVal);

            [VtblIndex(15)]
            HRESULT get_allocatesBasePointer(BOOL* pRetVal);

            [VtblIndex(16)]
            HRESULT get_maxStack([NativeTypeName("DWORD *")] uint* pRetVal);

            [VtblIndex(17)]
            HRESULT get_registerValue([NativeTypeName("DWORD")] uint index, [NativeTypeName("ULONGLONG *")] ulong* pRetVal);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaStackFrame*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaStackFrame*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaStackFrame*, uint> Release;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaStackFrame*, uint*, int> get_type;

            [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaStackFrame*, ulong*, int> get_base;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaStackFrame*, uint*, int> get_size;

            [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaStackFrame*, ulong*, int> get_returnAddress;

            [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaStackFrame*, ulong*, int> get_localsBase;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaStackFrame*, uint*, int> get_lengthLocals;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaStackFrame*, uint*, int> get_lengthParams;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaStackFrame*, uint*, int> get_lengthProlog;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaStackFrame*, uint*, int> get_lengthSavedRegisters;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaStackFrame*, BOOL*, int> get_systemExceptionHandling;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaStackFrame*, BOOL*, int> get_cplusplusExceptionHandling;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaStackFrame*, BOOL*, int> get_functionStart;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaStackFrame*, BOOL*, int> get_allocatesBasePointer;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaStackFrame*, uint*, int> get_maxStack;

            [NativeTypeName("HRESULT (DWORD, ULONGLONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaStackFrame*, uint, ulong*, int> get_registerValue;
        }
    }
}
