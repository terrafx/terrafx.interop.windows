// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1C1A17B0-BED0-415D-974B-DC6696131599")]
    public unsafe partial struct IVMRMixerControl
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IVMRMixerControl*, Guid*, void**, int>)(lpVtbl[0]))((IVMRMixerControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IVMRMixerControl*, uint>)(lpVtbl[1]))((IVMRMixerControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IVMRMixerControl*, uint>)(lpVtbl[2]))((IVMRMixerControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAlpha([NativeTypeName("DWORD")] uint dwStreamID, float Alpha)
        {
            return ((delegate* stdcall<IVMRMixerControl*, uint, float, int>)(lpVtbl[3]))((IVMRMixerControl*)Unsafe.AsPointer(ref this), dwStreamID, Alpha);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAlpha([NativeTypeName("DWORD")] uint dwStreamID, [NativeTypeName("float *")] float* pAlpha)
        {
            return ((delegate* stdcall<IVMRMixerControl*, uint, float*, int>)(lpVtbl[4]))((IVMRMixerControl*)Unsafe.AsPointer(ref this), dwStreamID, pAlpha);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetZOrder([NativeTypeName("DWORD")] uint dwStreamID, [NativeTypeName("DWORD")] uint dwZ)
        {
            return ((delegate* stdcall<IVMRMixerControl*, uint, uint, int>)(lpVtbl[5]))((IVMRMixerControl*)Unsafe.AsPointer(ref this), dwStreamID, dwZ);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetZOrder([NativeTypeName("DWORD")] uint dwStreamID, [NativeTypeName("DWORD *")] uint* pZ)
        {
            return ((delegate* stdcall<IVMRMixerControl*, uint, uint*, int>)(lpVtbl[6]))((IVMRMixerControl*)Unsafe.AsPointer(ref this), dwStreamID, pZ);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOutputRect([NativeTypeName("DWORD")] uint dwStreamID, [NativeTypeName("const NORMALIZEDRECT *")] NORMALIZEDRECT* pRect)
        {
            return ((delegate* stdcall<IVMRMixerControl*, uint, NORMALIZEDRECT*, int>)(lpVtbl[7]))((IVMRMixerControl*)Unsafe.AsPointer(ref this), dwStreamID, pRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOutputRect([NativeTypeName("DWORD")] uint dwStreamID, [NativeTypeName("NORMALIZEDRECT *")] NORMALIZEDRECT* pRect)
        {
            return ((delegate* stdcall<IVMRMixerControl*, uint, NORMALIZEDRECT*, int>)(lpVtbl[8]))((IVMRMixerControl*)Unsafe.AsPointer(ref this), dwStreamID, pRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBackgroundClr([NativeTypeName("COLORREF")] uint ClrBkg)
        {
            return ((delegate* stdcall<IVMRMixerControl*, uint, int>)(lpVtbl[9]))((IVMRMixerControl*)Unsafe.AsPointer(ref this), ClrBkg);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBackgroundClr([NativeTypeName("COLORREF *")] uint* lpClrBkg)
        {
            return ((delegate* stdcall<IVMRMixerControl*, uint*, int>)(lpVtbl[10]))((IVMRMixerControl*)Unsafe.AsPointer(ref this), lpClrBkg);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMixingPrefs([NativeTypeName("DWORD")] uint dwMixerPrefs)
        {
            return ((delegate* stdcall<IVMRMixerControl*, uint, int>)(lpVtbl[11]))((IVMRMixerControl*)Unsafe.AsPointer(ref this), dwMixerPrefs);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMixingPrefs([NativeTypeName("DWORD *")] uint* pdwMixerPrefs)
        {
            return ((delegate* stdcall<IVMRMixerControl*, uint*, int>)(lpVtbl[12]))((IVMRMixerControl*)Unsafe.AsPointer(ref this), pdwMixerPrefs);
        }
    }
}
