// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("C6E13380-30AC-11D0-A18C-00A0C9118956")]
    [NativeTypeName("struct IAMCrossbar : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAMCrossbar : IAMCrossbar.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAMCrossbar*, Guid*, void**, int>)(lpVtbl[0]))((IAMCrossbar*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMCrossbar*, uint>)(lpVtbl[1]))((IAMCrossbar*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMCrossbar*, uint>)(lpVtbl[2]))((IAMCrossbar*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT get_PinCounts([NativeTypeName("long *")] int* OutputPinCount, [NativeTypeName("long *")] int* InputPinCount)
        {
            return ((delegate* unmanaged<IAMCrossbar*, int*, int*, int>)(lpVtbl[3]))((IAMCrossbar*)Unsafe.AsPointer(ref this), OutputPinCount, InputPinCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT CanRoute([NativeTypeName("long")] int OutputPinIndex, [NativeTypeName("long")] int InputPinIndex)
        {
            return ((delegate* unmanaged<IAMCrossbar*, int, int, int>)(lpVtbl[4]))((IAMCrossbar*)Unsafe.AsPointer(ref this), OutputPinIndex, InputPinIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Route([NativeTypeName("long")] int OutputPinIndex, [NativeTypeName("long")] int InputPinIndex)
        {
            return ((delegate* unmanaged<IAMCrossbar*, int, int, int>)(lpVtbl[5]))((IAMCrossbar*)Unsafe.AsPointer(ref this), OutputPinIndex, InputPinIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT get_IsRoutedTo([NativeTypeName("long")] int OutputPinIndex, [NativeTypeName("long *")] int* InputPinIndex)
        {
            return ((delegate* unmanaged<IAMCrossbar*, int, int*, int>)(lpVtbl[6]))((IAMCrossbar*)Unsafe.AsPointer(ref this), OutputPinIndex, InputPinIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_CrossbarPinInfo(BOOL IsInputPin, [NativeTypeName("long")] int PinIndex, [NativeTypeName("long *")] int* PinIndexRelated, [NativeTypeName("long *")] int* PhysicalType)
        {
            return ((delegate* unmanaged<IAMCrossbar*, BOOL, int, int*, int*, int>)(lpVtbl[7]))((IAMCrossbar*)Unsafe.AsPointer(ref this), IsInputPin, PinIndex, PinIndexRelated, PhysicalType);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT get_PinCounts([NativeTypeName("long *")] int* OutputPinCount, [NativeTypeName("long *")] int* InputPinCount);

            [VtblIndex(4)]
            HRESULT CanRoute([NativeTypeName("long")] int OutputPinIndex, [NativeTypeName("long")] int InputPinIndex);

            [VtblIndex(5)]
            HRESULT Route([NativeTypeName("long")] int OutputPinIndex, [NativeTypeName("long")] int InputPinIndex);

            [VtblIndex(6)]
            HRESULT get_IsRoutedTo([NativeTypeName("long")] int OutputPinIndex, [NativeTypeName("long *")] int* InputPinIndex);

            [VtblIndex(7)]
            HRESULT get_CrossbarPinInfo(BOOL IsInputPin, [NativeTypeName("long")] int PinIndex, [NativeTypeName("long *")] int* PinIndexRelated, [NativeTypeName("long *")] int* PhysicalType);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMCrossbar*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAMCrossbar*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAMCrossbar*, uint> Release;

            [NativeTypeName("HRESULT (long *, long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMCrossbar*, int*, int*, int> get_PinCounts;

            [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMCrossbar*, int, int, int> CanRoute;

            [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMCrossbar*, int, int, int> Route;

            [NativeTypeName("HRESULT (long, long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMCrossbar*, int, int*, int> get_IsRoutedTo;

            [NativeTypeName("HRESULT (BOOL, long, long *, long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMCrossbar*, BOOL, int, int*, int*, int> get_CrossbarPinInfo;
        }
    }
}
