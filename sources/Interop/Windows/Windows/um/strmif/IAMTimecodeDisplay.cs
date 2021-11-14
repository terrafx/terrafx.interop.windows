// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("9B496CE2-811B-11CF-8C77-00AA006B6814")]
    [NativeTypeName("struct IAMTimecodeDisplay : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAMTimecodeDisplay : IAMTimecodeDisplay.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAMTimecodeDisplay*, Guid*, void**, int>)(lpVtbl[0]))((IAMTimecodeDisplay*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMTimecodeDisplay*, uint>)(lpVtbl[1]))((IAMTimecodeDisplay*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMTimecodeDisplay*, uint>)(lpVtbl[2]))((IAMTimecodeDisplay*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTCDisplayEnable([NativeTypeName("long *")] int* pState)
        {
            return ((delegate* unmanaged<IAMTimecodeDisplay*, int*, int>)(lpVtbl[3]))((IAMTimecodeDisplay*)Unsafe.AsPointer(ref this), pState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetTCDisplayEnable([NativeTypeName("long")] int State)
        {
            return ((delegate* unmanaged<IAMTimecodeDisplay*, int, int>)(lpVtbl[4]))((IAMTimecodeDisplay*)Unsafe.AsPointer(ref this), State);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetTCDisplay([NativeTypeName("long")] int Param, [NativeTypeName("long *")] int* pValue)
        {
            return ((delegate* unmanaged<IAMTimecodeDisplay*, int, int*, int>)(lpVtbl[5]))((IAMTimecodeDisplay*)Unsafe.AsPointer(ref this), Param, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetTCDisplay([NativeTypeName("long")] int Param, [NativeTypeName("long")] int Value)
        {
            return ((delegate* unmanaged<IAMTimecodeDisplay*, int, int, int>)(lpVtbl[6]))((IAMTimecodeDisplay*)Unsafe.AsPointer(ref this), Param, Value);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetTCDisplayEnable([NativeTypeName("long *")] int* pState);

            [VtblIndex(4)]
            HRESULT SetTCDisplayEnable([NativeTypeName("long")] int State);

            [VtblIndex(5)]
            HRESULT GetTCDisplay([NativeTypeName("long")] int Param, [NativeTypeName("long *")] int* pValue);

            [VtblIndex(6)]
            HRESULT SetTCDisplay([NativeTypeName("long")] int Param, [NativeTypeName("long")] int Value);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMTimecodeDisplay*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAMTimecodeDisplay*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAMTimecodeDisplay*, uint> Release;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMTimecodeDisplay*, int*, int> GetTCDisplayEnable;

            [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMTimecodeDisplay*, int, int> SetTCDisplayEnable;

            [NativeTypeName("HRESULT (long, long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMTimecodeDisplay*, int, int*, int> GetTCDisplay;

            [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMTimecodeDisplay*, int, int, int> SetTCDisplay;
        }
    }
}
