// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("97EC2EA4-0E42-4937-97AC-9D6D328824E1")]
    [NativeTypeName("struct IMFShutdown : IUnknown")]
    public unsafe partial struct IMFShutdown
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFShutdown*, Guid*, void**, int>)(lpVtbl[0]))((IMFShutdown*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFShutdown*, uint>)(lpVtbl[1]))((IMFShutdown*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFShutdown*, uint>)(lpVtbl[2]))((IMFShutdown*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Shutdown()
        {
            return ((delegate* unmanaged<IMFShutdown*, int>)(lpVtbl[3]))((IMFShutdown*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetShutdownStatus(MFSHUTDOWN_STATUS* pStatus)
        {
            return ((delegate* unmanaged<IMFShutdown*, MFSHUTDOWN_STATUS*, int>)(lpVtbl[4]))((IMFShutdown*)Unsafe.AsPointer(ref this), pStatus);
        }
    }
}
