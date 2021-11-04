// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("19666FB4-BABE-4C55-BC03-0A074DA37E2A")]
    [NativeTypeName("struct IMFSourceBufferAppendMode : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFSourceBufferAppendMode
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSourceBufferAppendMode*, Guid*, void**, int>)(lpVtbl[0]))((IMFSourceBufferAppendMode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSourceBufferAppendMode*, uint>)(lpVtbl[1]))((IMFSourceBufferAppendMode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSourceBufferAppendMode*, uint>)(lpVtbl[2]))((IMFSourceBufferAppendMode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public MF_MSE_APPEND_MODE GetAppendMode()
        {
            return ((delegate* unmanaged<IMFSourceBufferAppendMode*, MF_MSE_APPEND_MODE>)(lpVtbl[3]))((IMFSourceBufferAppendMode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetAppendMode(MF_MSE_APPEND_MODE mode)
        {
            return ((delegate* unmanaged<IMFSourceBufferAppendMode*, MF_MSE_APPEND_MODE, int>)(lpVtbl[4]))((IMFSourceBufferAppendMode*)Unsafe.AsPointer(ref this), mode);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSourceBufferAppendMode*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSourceBufferAppendMode*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSourceBufferAppendMode*, uint> Release;

            [NativeTypeName("MF_MSE_APPEND_MODE () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSourceBufferAppendMode*, MF_MSE_APPEND_MODE> GetAppendMode;

            [NativeTypeName("HRESULT (MF_MSE_APPEND_MODE) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSourceBufferAppendMode*, MF_MSE_APPEND_MODE, int> SetAppendMode;
        }
    }
}
