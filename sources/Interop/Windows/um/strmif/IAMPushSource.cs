// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F185FE76-E64E-11D2-B76E-00C04FB6BD3D")]
    [NativeTypeName("struct IAMPushSource : IAMLatency")]
    public unsafe partial struct IAMPushSource
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAMPushSource*, Guid*, void**, int>)(lpVtbl[0]))((IAMPushSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAMPushSource*, uint>)(lpVtbl[1]))((IAMPushSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAMPushSource*, uint>)(lpVtbl[2]))((IAMPushSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLatency([NativeTypeName("REFERENCE_TIME *")] long* prtLatency)
        {
            return ((delegate* stdcall<IAMPushSource*, long*, int>)(lpVtbl[3]))((IAMPushSource*)Unsafe.AsPointer(ref this), prtLatency);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPushSourceFlags([NativeTypeName("ULONG *")] uint* pFlags)
        {
            return ((delegate* stdcall<IAMPushSource*, uint*, int>)(lpVtbl[4]))((IAMPushSource*)Unsafe.AsPointer(ref this), pFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPushSourceFlags([NativeTypeName("ULONG")] uint Flags)
        {
            return ((delegate* stdcall<IAMPushSource*, uint, int>)(lpVtbl[5]))((IAMPushSource*)Unsafe.AsPointer(ref this), Flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetStreamOffset([NativeTypeName("REFERENCE_TIME")] long rtOffset)
        {
            return ((delegate* stdcall<IAMPushSource*, long, int>)(lpVtbl[6]))((IAMPushSource*)Unsafe.AsPointer(ref this), rtOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamOffset([NativeTypeName("REFERENCE_TIME *")] long* prtOffset)
        {
            return ((delegate* stdcall<IAMPushSource*, long*, int>)(lpVtbl[7]))((IAMPushSource*)Unsafe.AsPointer(ref this), prtOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMaxStreamOffset([NativeTypeName("REFERENCE_TIME *")] long* prtMaxOffset)
        {
            return ((delegate* stdcall<IAMPushSource*, long*, int>)(lpVtbl[8]))((IAMPushSource*)Unsafe.AsPointer(ref this), prtMaxOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMaxStreamOffset([NativeTypeName("REFERENCE_TIME")] long rtMaxOffset)
        {
            return ((delegate* stdcall<IAMPushSource*, long, int>)(lpVtbl[9]))((IAMPushSource*)Unsafe.AsPointer(ref this), rtMaxOffset);
        }
    }
}
