// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A868AF-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IDistributorNotify : IUnknown")]
    public unsafe partial struct IDistributorNotify
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDistributorNotify*, Guid*, void**, int>)(lpVtbl[0]))((IDistributorNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDistributorNotify*, uint>)(lpVtbl[1]))((IDistributorNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDistributorNotify*, uint>)(lpVtbl[2]))((IDistributorNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Stop()
        {
            return ((delegate* unmanaged[Stdcall]<IDistributorNotify*, int>)(lpVtbl[3]))((IDistributorNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Pause()
        {
            return ((delegate* unmanaged[Stdcall]<IDistributorNotify*, int>)(lpVtbl[4]))((IDistributorNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Run([NativeTypeName("REFERENCE_TIME")] long tStart)
        {
            return ((delegate* unmanaged[Stdcall]<IDistributorNotify*, long, int>)(lpVtbl[5]))((IDistributorNotify*)Unsafe.AsPointer(ref this), tStart);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSyncSource([NativeTypeName("IReferenceClock *")] IReferenceClock* pClock)
        {
            return ((delegate* unmanaged[Stdcall]<IDistributorNotify*, IReferenceClock*, int>)(lpVtbl[6]))((IDistributorNotify*)Unsafe.AsPointer(ref this), pClock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NotifyGraphChange()
        {
            return ((delegate* unmanaged[Stdcall]<IDistributorNotify*, int>)(lpVtbl[7]))((IDistributorNotify*)Unsafe.AsPointer(ref this));
        }
    }
}
