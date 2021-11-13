// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/TextStor.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("0FEB7E34-5A60-4356-8EF7-ABDEC2FF7CF8")]
    [NativeTypeName("struct IAnchor : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAnchor : IAnchor.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAnchor*, Guid*, void**, int>)(lpVtbl[0]))((IAnchor*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAnchor*, uint>)(lpVtbl[1]))((IAnchor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAnchor*, uint>)(lpVtbl[2]))((IAnchor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetGravity(TsGravity gravity)
        {
            return ((delegate* unmanaged<IAnchor*, TsGravity, int>)(lpVtbl[3]))((IAnchor*)Unsafe.AsPointer(ref this), gravity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetGravity(TsGravity* pgravity)
        {
            return ((delegate* unmanaged<IAnchor*, TsGravity*, int>)(lpVtbl[4]))((IAnchor*)Unsafe.AsPointer(ref this), pgravity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT IsEqual(IAnchor* paWith, BOOL* pfEqual)
        {
            return ((delegate* unmanaged<IAnchor*, IAnchor*, BOOL*, int>)(lpVtbl[5]))((IAnchor*)Unsafe.AsPointer(ref this), paWith, pfEqual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Compare(IAnchor* paWith, [NativeTypeName("LONG *")] int* plResult)
        {
            return ((delegate* unmanaged<IAnchor*, IAnchor*, int*, int>)(lpVtbl[6]))((IAnchor*)Unsafe.AsPointer(ref this), paWith, plResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT Shift([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LONG")] int cchReq, [NativeTypeName("LONG *")] int* pcch, IAnchor* paHaltAnchor)
        {
            return ((delegate* unmanaged<IAnchor*, uint, int, int*, IAnchor*, int>)(lpVtbl[7]))((IAnchor*)Unsafe.AsPointer(ref this), dwFlags, cchReq, pcch, paHaltAnchor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT ShiftTo(IAnchor* paSite)
        {
            return ((delegate* unmanaged<IAnchor*, IAnchor*, int>)(lpVtbl[8]))((IAnchor*)Unsafe.AsPointer(ref this), paSite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT ShiftRegion([NativeTypeName("DWORD")] uint dwFlags, TsShiftDir dir, BOOL* pfNoRegion)
        {
            return ((delegate* unmanaged<IAnchor*, uint, TsShiftDir, BOOL*, int>)(lpVtbl[9]))((IAnchor*)Unsafe.AsPointer(ref this), dwFlags, dir, pfNoRegion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetChangeHistoryMask([NativeTypeName("DWORD")] uint dwMask)
        {
            return ((delegate* unmanaged<IAnchor*, uint, int>)(lpVtbl[10]))((IAnchor*)Unsafe.AsPointer(ref this), dwMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetChangeHistory([NativeTypeName("DWORD *")] uint* pdwHistory)
        {
            return ((delegate* unmanaged<IAnchor*, uint*, int>)(lpVtbl[11]))((IAnchor*)Unsafe.AsPointer(ref this), pdwHistory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT ClearChangeHistory()
        {
            return ((delegate* unmanaged<IAnchor*, int>)(lpVtbl[12]))((IAnchor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT Clone(IAnchor** ppaClone)
        {
            return ((delegate* unmanaged<IAnchor*, IAnchor**, int>)(lpVtbl[13]))((IAnchor*)Unsafe.AsPointer(ref this), ppaClone);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetGravity(TsGravity gravity);

            [VtblIndex(4)]
            HRESULT GetGravity(TsGravity* pgravity);

            [VtblIndex(5)]
            HRESULT IsEqual(IAnchor* paWith, BOOL* pfEqual);

            [VtblIndex(6)]
            HRESULT Compare(IAnchor* paWith, [NativeTypeName("LONG *")] int* plResult);

            [VtblIndex(7)]
            HRESULT Shift([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LONG")] int cchReq, [NativeTypeName("LONG *")] int* pcch, IAnchor* paHaltAnchor);

            [VtblIndex(8)]
            HRESULT ShiftTo(IAnchor* paSite);

            [VtblIndex(9)]
            HRESULT ShiftRegion([NativeTypeName("DWORD")] uint dwFlags, TsShiftDir dir, BOOL* pfNoRegion);

            [VtblIndex(10)]
            HRESULT SetChangeHistoryMask([NativeTypeName("DWORD")] uint dwMask);

            [VtblIndex(11)]
            HRESULT GetChangeHistory([NativeTypeName("DWORD *")] uint* pdwHistory);

            [VtblIndex(12)]
            HRESULT ClearChangeHistory();

            [VtblIndex(13)]
            HRESULT Clone(IAnchor** ppaClone);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAnchor*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAnchor*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAnchor*, uint> Release;

            [NativeTypeName("HRESULT (TsGravity) __attribute__((stdcall))")]
            public delegate* unmanaged<IAnchor*, TsGravity, int> SetGravity;

            [NativeTypeName("HRESULT (TsGravity *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAnchor*, TsGravity*, int> GetGravity;

            [NativeTypeName("HRESULT (IAnchor *, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAnchor*, IAnchor*, BOOL*, int> IsEqual;

            [NativeTypeName("HRESULT (IAnchor *, LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAnchor*, IAnchor*, int*, int> Compare;

            [NativeTypeName("HRESULT (DWORD, LONG, LONG *, IAnchor *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAnchor*, uint, int, int*, IAnchor*, int> Shift;

            [NativeTypeName("HRESULT (IAnchor *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAnchor*, IAnchor*, int> ShiftTo;

            [NativeTypeName("HRESULT (DWORD, TsShiftDir, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAnchor*, uint, TsShiftDir, BOOL*, int> ShiftRegion;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IAnchor*, uint, int> SetChangeHistoryMask;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAnchor*, uint*, int> GetChangeHistory;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IAnchor*, int> ClearChangeHistory;

            [NativeTypeName("HRESULT (IAnchor **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAnchor*, IAnchor**, int> Clone;
        }
    }
}
