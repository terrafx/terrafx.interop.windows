// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("83EC1C30-23D1-11D1-99E6-00A0C9560266")]
    [NativeTypeName("struct IAMTVAudio : IUnknown")]
    public unsafe partial struct IAMTVAudio
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAMTVAudio*, Guid*, void**, int>)(lpVtbl[0]))((IAMTVAudio*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMTVAudio*, uint>)(lpVtbl[1]))((IAMTVAudio*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMTVAudio*, uint>)(lpVtbl[2]))((IAMTVAudio*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetHardwareSupportedTVAudioModes([NativeTypeName("long *")] int* plModes)
        {
            return ((delegate* unmanaged<IAMTVAudio*, int*, int>)(lpVtbl[3]))((IAMTVAudio*)Unsafe.AsPointer(ref this), plModes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAvailableTVAudioModes([NativeTypeName("long *")] int* plModes)
        {
            return ((delegate* unmanaged<IAMTVAudio*, int*, int>)(lpVtbl[4]))((IAMTVAudio*)Unsafe.AsPointer(ref this), plModes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_TVAudioMode([NativeTypeName("long *")] int* plMode)
        {
            return ((delegate* unmanaged<IAMTVAudio*, int*, int>)(lpVtbl[5]))((IAMTVAudio*)Unsafe.AsPointer(ref this), plMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_TVAudioMode([NativeTypeName("long")] int lMode)
        {
            return ((delegate* unmanaged<IAMTVAudio*, int, int>)(lpVtbl[6]))((IAMTVAudio*)Unsafe.AsPointer(ref this), lMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterNotificationCallBack([NativeTypeName("IAMTunerNotification *")] IAMTunerNotification* pNotify, [NativeTypeName("long")] int lEvents)
        {
            return ((delegate* unmanaged<IAMTVAudio*, IAMTunerNotification*, int, int>)(lpVtbl[7]))((IAMTVAudio*)Unsafe.AsPointer(ref this), pNotify, lEvents);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnRegisterNotificationCallBack([NativeTypeName("IAMTunerNotification *")] IAMTunerNotification* pNotify)
        {
            return ((delegate* unmanaged<IAMTVAudio*, IAMTunerNotification*, int>)(lpVtbl[8]))((IAMTVAudio*)Unsafe.AsPointer(ref this), pNotify);
        }
    }
}
