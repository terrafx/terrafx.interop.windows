// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("211A8765-03AC-11D1-8D13-00AA00BD8339")]
    [NativeTypeName("struct IBPCSatelliteTuner : IAMTuner")]
    public unsafe partial struct IBPCSatelliteTuner
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IBPCSatelliteTuner*, Guid*, void**, int>)(lpVtbl[0]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IBPCSatelliteTuner*, uint>)(lpVtbl[1]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IBPCSatelliteTuner*, uint>)(lpVtbl[2]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Channel([NativeTypeName("long")] int lChannel, [NativeTypeName("long")] int lVideoSubChannel, [NativeTypeName("long")] int lAudioSubChannel)
        {
            return ((delegate* unmanaged[Stdcall]<IBPCSatelliteTuner*, int, int, int, int>)(lpVtbl[3]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this), lChannel, lVideoSubChannel, lAudioSubChannel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Channel([NativeTypeName("long *")] int* plChannel, [NativeTypeName("long *")] int* plVideoSubChannel, [NativeTypeName("long *")] int* plAudioSubChannel)
        {
            return ((delegate* unmanaged[Stdcall]<IBPCSatelliteTuner*, int*, int*, int*, int>)(lpVtbl[4]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this), plChannel, plVideoSubChannel, plAudioSubChannel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ChannelMinMax([NativeTypeName("long *")] int* lChannelMin, [NativeTypeName("long *")] int* lChannelMax)
        {
            return ((delegate* unmanaged[Stdcall]<IBPCSatelliteTuner*, int*, int*, int>)(lpVtbl[5]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this), lChannelMin, lChannelMax);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_CountryCode([NativeTypeName("long")] int lCountryCode)
        {
            return ((delegate* unmanaged[Stdcall]<IBPCSatelliteTuner*, int, int>)(lpVtbl[6]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this), lCountryCode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CountryCode([NativeTypeName("long *")] int* plCountryCode)
        {
            return ((delegate* unmanaged[Stdcall]<IBPCSatelliteTuner*, int*, int>)(lpVtbl[7]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this), plCountryCode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_TuningSpace([NativeTypeName("long")] int lTuningSpace)
        {
            return ((delegate* unmanaged[Stdcall]<IBPCSatelliteTuner*, int, int>)(lpVtbl[8]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this), lTuningSpace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_TuningSpace([NativeTypeName("long *")] int* plTuningSpace)
        {
            return ((delegate* unmanaged[Stdcall]<IBPCSatelliteTuner*, int*, int>)(lpVtbl[9]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this), plTuningSpace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Logon([NativeTypeName("HANDLE")] IntPtr hCurrentUser)
        {
            return ((delegate* unmanaged[Stdcall]<IBPCSatelliteTuner*, IntPtr, int>)(lpVtbl[10]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this), hCurrentUser);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Logout()
        {
            return ((delegate* unmanaged[Stdcall]<IBPCSatelliteTuner*, int>)(lpVtbl[11]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SignalPresent([NativeTypeName("long *")] int* plSignalStrength)
        {
            return ((delegate* unmanaged[Stdcall]<IBPCSatelliteTuner*, int*, int>)(lpVtbl[12]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this), plSignalStrength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Mode(AMTunerModeType lMode)
        {
            return ((delegate* unmanaged[Stdcall]<IBPCSatelliteTuner*, AMTunerModeType, int>)(lpVtbl[13]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this), lMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Mode([NativeTypeName("AMTunerModeType *")] AMTunerModeType* plMode)
        {
            return ((delegate* unmanaged[Stdcall]<IBPCSatelliteTuner*, AMTunerModeType*, int>)(lpVtbl[14]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this), plMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAvailableModes([NativeTypeName("long *")] int* plModes)
        {
            return ((delegate* unmanaged[Stdcall]<IBPCSatelliteTuner*, int*, int>)(lpVtbl[15]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this), plModes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterNotificationCallBack([NativeTypeName("IAMTunerNotification *")] IAMTunerNotification* pNotify, [NativeTypeName("long")] int lEvents)
        {
            return ((delegate* unmanaged[Stdcall]<IBPCSatelliteTuner*, IAMTunerNotification*, int, int>)(lpVtbl[16]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this), pNotify, lEvents);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnRegisterNotificationCallBack([NativeTypeName("IAMTunerNotification *")] IAMTunerNotification* pNotify)
        {
            return ((delegate* unmanaged[Stdcall]<IBPCSatelliteTuner*, IAMTunerNotification*, int>)(lpVtbl[17]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this), pNotify);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DefaultSubChannelTypes([NativeTypeName("long *")] int* plDefaultVideoType, [NativeTypeName("long *")] int* plDefaultAudioType)
        {
            return ((delegate* unmanaged[Stdcall]<IBPCSatelliteTuner*, int*, int*, int>)(lpVtbl[18]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this), plDefaultVideoType, plDefaultAudioType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_DefaultSubChannelTypes([NativeTypeName("long")] int lDefaultVideoType, [NativeTypeName("long")] int lDefaultAudioType)
        {
            return ((delegate* unmanaged[Stdcall]<IBPCSatelliteTuner*, int, int, int>)(lpVtbl[19]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this), lDefaultVideoType, lDefaultAudioType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsTapingPermitted()
        {
            return ((delegate* unmanaged[Stdcall]<IBPCSatelliteTuner*, int>)(lpVtbl[20]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this));
        }
    }
}
