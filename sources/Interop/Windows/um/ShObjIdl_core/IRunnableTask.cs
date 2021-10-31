// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("85788D00-6807-11D0-B810-00C04FD706EC")]
    [NativeTypeName("struct IRunnableTask : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IRunnableTask
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IRunnableTask*, Guid*, void**, int>)(lpVtbl[0]))((IRunnableTask*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRunnableTask*, uint>)(lpVtbl[1]))((IRunnableTask*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRunnableTask*, uint>)(lpVtbl[2]))((IRunnableTask*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Run()
        {
            return ((delegate* unmanaged<IRunnableTask*, int>)(lpVtbl[3]))((IRunnableTask*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Kill(BOOL bWait)
        {
            return ((delegate* unmanaged<IRunnableTask*, BOOL, int>)(lpVtbl[4]))((IRunnableTask*)Unsafe.AsPointer(ref this), bWait);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Suspend()
        {
            return ((delegate* unmanaged<IRunnableTask*, int>)(lpVtbl[5]))((IRunnableTask*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Resume()
        {
            return ((delegate* unmanaged<IRunnableTask*, int>)(lpVtbl[6]))((IRunnableTask*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("ULONG")]
        public uint IsRunning()
        {
            return ((delegate* unmanaged<IRunnableTask*, uint>)(lpVtbl[7]))((IRunnableTask*)Unsafe.AsPointer(ref this));
        }
    }
}
