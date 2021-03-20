// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("ED32A372-F3C8-4FAA-9CFB-470148DA3888")]
    [NativeTypeName("struct IDeferralCompletedHandler : IUnknown")]
    public unsafe partial struct IDeferralCompletedHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDeferralCompletedHandler*, Guid*, void**, int>)(lpVtbl[0]))((IDeferralCompletedHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDeferralCompletedHandler*, uint>)(lpVtbl[1]))((IDeferralCompletedHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDeferralCompletedHandler*, uint>)(lpVtbl[2]))((IDeferralCompletedHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke()
        {
            return ((delegate* unmanaged<IDeferralCompletedHandler*, int>)(lpVtbl[3]))((IDeferralCompletedHandler*)Unsafe.AsPointer(ref this));
        }
    }
}
