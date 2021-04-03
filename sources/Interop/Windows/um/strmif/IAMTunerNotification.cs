// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("211A8760-03AC-11D1-8D13-00AA00BD8339")]
    [NativeTypeName("struct IAMTunerNotification : IUnknown")]
    public unsafe partial struct IAMTunerNotification
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAMTunerNotification*, Guid*, void**, int>)(lpVtbl[0]))((IAMTunerNotification*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMTunerNotification*, uint>)(lpVtbl[1]))((IAMTunerNotification*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMTunerNotification*, uint>)(lpVtbl[2]))((IAMTunerNotification*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnEvent(AMTunerEventType Event)
        {
            return ((delegate* unmanaged<IAMTunerNotification*, AMTunerEventType, int>)(lpVtbl[3]))((IAMTunerNotification*)Unsafe.AsPointer(ref this), Event);
        }
    }
}
