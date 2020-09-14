// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A03CD5F0-3045-11CF-8C44-00AA006B6814")]
    [NativeTypeName("struct IAMExtTransport : IUnknown")]
    public unsafe partial struct IAMExtTransport
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAMExtTransport*, Guid*, void**, int>)(lpVtbl[0]))((IAMExtTransport*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMExtTransport*, uint>)(lpVtbl[1]))((IAMExtTransport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMExtTransport*, uint>)(lpVtbl[2]))((IAMExtTransport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCapability([NativeTypeName("long")] int Capability, [NativeTypeName("long *")] int* pValue, [NativeTypeName("double *")] double* pdblValue)
        {
            return ((delegate* unmanaged<IAMExtTransport*, int, int*, double*, int>)(lpVtbl[3]))((IAMExtTransport*)Unsafe.AsPointer(ref this), Capability, pValue, pdblValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_MediaState([NativeTypeName("long")] int State)
        {
            return ((delegate* unmanaged<IAMExtTransport*, int, int>)(lpVtbl[4]))((IAMExtTransport*)Unsafe.AsPointer(ref this), State);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MediaState([NativeTypeName("long *")] int* pState)
        {
            return ((delegate* unmanaged<IAMExtTransport*, int*, int>)(lpVtbl[5]))((IAMExtTransport*)Unsafe.AsPointer(ref this), pState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_LocalControl([NativeTypeName("long")] int State)
        {
            return ((delegate* unmanaged<IAMExtTransport*, int, int>)(lpVtbl[6]))((IAMExtTransport*)Unsafe.AsPointer(ref this), State);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LocalControl([NativeTypeName("long *")] int* pState)
        {
            return ((delegate* unmanaged<IAMExtTransport*, int*, int>)(lpVtbl[7]))((IAMExtTransport*)Unsafe.AsPointer(ref this), pState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStatus([NativeTypeName("long")] int StatusItem, [NativeTypeName("long *")] int* pValue)
        {
            return ((delegate* unmanaged<IAMExtTransport*, int, int*, int>)(lpVtbl[8]))((IAMExtTransport*)Unsafe.AsPointer(ref this), StatusItem, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTransportBasicParameters([NativeTypeName("long")] int Param, [NativeTypeName("long *")] int* pValue, [NativeTypeName("LPOLESTR *")] ushort** ppszData)
        {
            return ((delegate* unmanaged<IAMExtTransport*, int, int*, ushort**, int>)(lpVtbl[9]))((IAMExtTransport*)Unsafe.AsPointer(ref this), Param, pValue, ppszData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTransportBasicParameters([NativeTypeName("long")] int Param, [NativeTypeName("long")] int Value, [NativeTypeName("LPCOLESTR")] ushort* pszData)
        {
            return ((delegate* unmanaged<IAMExtTransport*, int, int, ushort*, int>)(lpVtbl[10]))((IAMExtTransport*)Unsafe.AsPointer(ref this), Param, Value, pszData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTransportVideoParameters([NativeTypeName("long")] int Param, [NativeTypeName("long *")] int* pValue)
        {
            return ((delegate* unmanaged<IAMExtTransport*, int, int*, int>)(lpVtbl[11]))((IAMExtTransport*)Unsafe.AsPointer(ref this), Param, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTransportVideoParameters([NativeTypeName("long")] int Param, [NativeTypeName("long")] int Value)
        {
            return ((delegate* unmanaged<IAMExtTransport*, int, int, int>)(lpVtbl[12]))((IAMExtTransport*)Unsafe.AsPointer(ref this), Param, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTransportAudioParameters([NativeTypeName("long")] int Param, [NativeTypeName("long *")] int* pValue)
        {
            return ((delegate* unmanaged<IAMExtTransport*, int, int*, int>)(lpVtbl[13]))((IAMExtTransport*)Unsafe.AsPointer(ref this), Param, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTransportAudioParameters([NativeTypeName("long")] int Param, [NativeTypeName("long")] int Value)
        {
            return ((delegate* unmanaged<IAMExtTransport*, int, int, int>)(lpVtbl[14]))((IAMExtTransport*)Unsafe.AsPointer(ref this), Param, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Mode([NativeTypeName("long")] int Mode)
        {
            return ((delegate* unmanaged<IAMExtTransport*, int, int>)(lpVtbl[15]))((IAMExtTransport*)Unsafe.AsPointer(ref this), Mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Mode([NativeTypeName("long *")] int* pMode)
        {
            return ((delegate* unmanaged<IAMExtTransport*, int*, int>)(lpVtbl[16]))((IAMExtTransport*)Unsafe.AsPointer(ref this), pMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Rate(double dblRate)
        {
            return ((delegate* unmanaged<IAMExtTransport*, double, int>)(lpVtbl[17]))((IAMExtTransport*)Unsafe.AsPointer(ref this), dblRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Rate([NativeTypeName("double *")] double* pdblRate)
        {
            return ((delegate* unmanaged<IAMExtTransport*, double*, int>)(lpVtbl[18]))((IAMExtTransport*)Unsafe.AsPointer(ref this), pdblRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetChase([NativeTypeName("long *")] int* pEnabled, [NativeTypeName("long *")] int* pOffset, [NativeTypeName("HEVENT *")] nuint* phEvent)
        {
            return ((delegate* unmanaged<IAMExtTransport*, int*, int*, nuint*, int>)(lpVtbl[19]))((IAMExtTransport*)Unsafe.AsPointer(ref this), pEnabled, pOffset, phEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetChase([NativeTypeName("long")] int Enable, [NativeTypeName("long")] int Offset, [NativeTypeName("HEVENT")] nuint hEvent)
        {
            return ((delegate* unmanaged<IAMExtTransport*, int, int, nuint, int>)(lpVtbl[20]))((IAMExtTransport*)Unsafe.AsPointer(ref this), Enable, Offset, hEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBump([NativeTypeName("long *")] int* pSpeed, [NativeTypeName("long *")] int* pDuration)
        {
            return ((delegate* unmanaged<IAMExtTransport*, int*, int*, int>)(lpVtbl[21]))((IAMExtTransport*)Unsafe.AsPointer(ref this), pSpeed, pDuration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBump([NativeTypeName("long")] int Speed, [NativeTypeName("long")] int Duration)
        {
            return ((delegate* unmanaged<IAMExtTransport*, int, int, int>)(lpVtbl[22]))((IAMExtTransport*)Unsafe.AsPointer(ref this), Speed, Duration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AntiClogControl([NativeTypeName("long *")] int* pEnabled)
        {
            return ((delegate* unmanaged<IAMExtTransport*, int*, int>)(lpVtbl[23]))((IAMExtTransport*)Unsafe.AsPointer(ref this), pEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_AntiClogControl([NativeTypeName("long")] int Enable)
        {
            return ((delegate* unmanaged<IAMExtTransport*, int, int>)(lpVtbl[24]))((IAMExtTransport*)Unsafe.AsPointer(ref this), Enable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEditPropertySet([NativeTypeName("long")] int EditID, [NativeTypeName("long *")] int* pState)
        {
            return ((delegate* unmanaged<IAMExtTransport*, int, int*, int>)(lpVtbl[25]))((IAMExtTransport*)Unsafe.AsPointer(ref this), EditID, pState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetEditPropertySet([NativeTypeName("long *")] int* pEditID, [NativeTypeName("long")] int State)
        {
            return ((delegate* unmanaged<IAMExtTransport*, int*, int, int>)(lpVtbl[26]))((IAMExtTransport*)Unsafe.AsPointer(ref this), pEditID, State);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEditProperty([NativeTypeName("long")] int EditID, [NativeTypeName("long")] int Param, [NativeTypeName("long *")] int* pValue)
        {
            return ((delegate* unmanaged<IAMExtTransport*, int, int, int*, int>)(lpVtbl[27]))((IAMExtTransport*)Unsafe.AsPointer(ref this), EditID, Param, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetEditProperty([NativeTypeName("long")] int EditID, [NativeTypeName("long")] int Param, [NativeTypeName("long")] int Value)
        {
            return ((delegate* unmanaged<IAMExtTransport*, int, int, int, int>)(lpVtbl[28]))((IAMExtTransport*)Unsafe.AsPointer(ref this), EditID, Param, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_EditStart([NativeTypeName("long *")] int* pValue)
        {
            return ((delegate* unmanaged<IAMExtTransport*, int*, int>)(lpVtbl[29]))((IAMExtTransport*)Unsafe.AsPointer(ref this), pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_EditStart([NativeTypeName("long")] int Value)
        {
            return ((delegate* unmanaged<IAMExtTransport*, int, int>)(lpVtbl[30]))((IAMExtTransport*)Unsafe.AsPointer(ref this), Value);
        }
    }
}
