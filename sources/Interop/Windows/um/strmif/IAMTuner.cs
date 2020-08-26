// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("211A8761-03AC-11D1-8D13-00AA00BD8339")]
    [NativeTypeName("struct IAMTuner : IUnknown")]
    public unsafe partial struct IAMTuner
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAMTuner*, Guid*, void**, int>)(lpVtbl[0]))((IAMTuner*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAMTuner*, uint>)(lpVtbl[1]))((IAMTuner*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAMTuner*, uint>)(lpVtbl[2]))((IAMTuner*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Channel([NativeTypeName("long")] int lChannel, [NativeTypeName("long")] int lVideoSubChannel, [NativeTypeName("long")] int lAudioSubChannel)
        {
            return ((delegate* stdcall<IAMTuner*, int, int, int, int>)(lpVtbl[3]))((IAMTuner*)Unsafe.AsPointer(ref this), lChannel, lVideoSubChannel, lAudioSubChannel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Channel([NativeTypeName("long *")] int* plChannel, [NativeTypeName("long *")] int* plVideoSubChannel, [NativeTypeName("long *")] int* plAudioSubChannel)
        {
            return ((delegate* stdcall<IAMTuner*, int*, int*, int*, int>)(lpVtbl[4]))((IAMTuner*)Unsafe.AsPointer(ref this), plChannel, plVideoSubChannel, plAudioSubChannel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ChannelMinMax([NativeTypeName("long *")] int* lChannelMin, [NativeTypeName("long *")] int* lChannelMax)
        {
            return ((delegate* stdcall<IAMTuner*, int*, int*, int>)(lpVtbl[5]))((IAMTuner*)Unsafe.AsPointer(ref this), lChannelMin, lChannelMax);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_CountryCode([NativeTypeName("long")] int lCountryCode)
        {
            return ((delegate* stdcall<IAMTuner*, int, int>)(lpVtbl[6]))((IAMTuner*)Unsafe.AsPointer(ref this), lCountryCode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CountryCode([NativeTypeName("long *")] int* plCountryCode)
        {
            return ((delegate* stdcall<IAMTuner*, int*, int>)(lpVtbl[7]))((IAMTuner*)Unsafe.AsPointer(ref this), plCountryCode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_TuningSpace([NativeTypeName("long")] int lTuningSpace)
        {
            return ((delegate* stdcall<IAMTuner*, int, int>)(lpVtbl[8]))((IAMTuner*)Unsafe.AsPointer(ref this), lTuningSpace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_TuningSpace([NativeTypeName("long *")] int* plTuningSpace)
        {
            return ((delegate* stdcall<IAMTuner*, int*, int>)(lpVtbl[9]))((IAMTuner*)Unsafe.AsPointer(ref this), plTuningSpace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Logon([NativeTypeName("HANDLE")] IntPtr hCurrentUser)
        {
            return ((delegate* stdcall<IAMTuner*, IntPtr, int>)(lpVtbl[10]))((IAMTuner*)Unsafe.AsPointer(ref this), hCurrentUser);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Logout()
        {
            return ((delegate* stdcall<IAMTuner*, int>)(lpVtbl[11]))((IAMTuner*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SignalPresent([NativeTypeName("long *")] int* plSignalStrength)
        {
            return ((delegate* stdcall<IAMTuner*, int*, int>)(lpVtbl[12]))((IAMTuner*)Unsafe.AsPointer(ref this), plSignalStrength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Mode(AMTunerModeType lMode)
        {
            return ((delegate* stdcall<IAMTuner*, AMTunerModeType, int>)(lpVtbl[13]))((IAMTuner*)Unsafe.AsPointer(ref this), lMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Mode([NativeTypeName("AMTunerModeType *")] AMTunerModeType* plMode)
        {
            return ((delegate* stdcall<IAMTuner*, AMTunerModeType*, int>)(lpVtbl[14]))((IAMTuner*)Unsafe.AsPointer(ref this), plMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAvailableModes([NativeTypeName("long *")] int* plModes)
        {
            return ((delegate* stdcall<IAMTuner*, int*, int>)(lpVtbl[15]))((IAMTuner*)Unsafe.AsPointer(ref this), plModes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterNotificationCallBack([NativeTypeName("IAMTunerNotification *")] IAMTunerNotification* pNotify, [NativeTypeName("long")] int lEvents)
        {
            return ((delegate* stdcall<IAMTuner*, IAMTunerNotification*, int, int>)(lpVtbl[16]))((IAMTuner*)Unsafe.AsPointer(ref this), pNotify, lEvents);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnRegisterNotificationCallBack([NativeTypeName("IAMTunerNotification *")] IAMTunerNotification* pNotify)
        {
            return ((delegate* stdcall<IAMTuner*, IAMTunerNotification*, int>)(lpVtbl[17]))((IAMTuner*)Unsafe.AsPointer(ref this), pNotify);
        }
    }
}
