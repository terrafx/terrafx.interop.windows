// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BB057577-0DB8-4E6A-87A7-1A8C9A505A0F")]
    [NativeTypeName("struct IVMRDeinterlaceControl : IUnknown")]
    public unsafe partial struct IVMRDeinterlaceControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IVMRDeinterlaceControl*, Guid*, void**, int>)(lpVtbl[0]))((IVMRDeinterlaceControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVMRDeinterlaceControl*, uint>)(lpVtbl[1]))((IVMRDeinterlaceControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVMRDeinterlaceControl*, uint>)(lpVtbl[2]))((IVMRDeinterlaceControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNumberOfDeinterlaceModes([NativeTypeName("VMRVideoDesc *")] VMRVideoDesc* lpVideoDescription, [NativeTypeName("LPDWORD")] uint* lpdwNumDeinterlaceModes, [NativeTypeName("LPGUID")] Guid* lpDeinterlaceModes)
        {
            return ((delegate* unmanaged<IVMRDeinterlaceControl*, VMRVideoDesc*, uint*, Guid*, int>)(lpVtbl[3]))((IVMRDeinterlaceControl*)Unsafe.AsPointer(ref this), lpVideoDescription, lpdwNumDeinterlaceModes, lpDeinterlaceModes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeinterlaceModeCaps([NativeTypeName("LPGUID")] Guid* lpDeinterlaceMode, [NativeTypeName("VMRVideoDesc *")] VMRVideoDesc* lpVideoDescription, [NativeTypeName("VMRDeinterlaceCaps *")] VMRDeinterlaceCaps* lpDeinterlaceCaps)
        {
            return ((delegate* unmanaged<IVMRDeinterlaceControl*, Guid*, VMRVideoDesc*, VMRDeinterlaceCaps*, int>)(lpVtbl[4]))((IVMRDeinterlaceControl*)Unsafe.AsPointer(ref this), lpDeinterlaceMode, lpVideoDescription, lpDeinterlaceCaps);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeinterlaceMode([NativeTypeName("DWORD")] uint dwStreamID, [NativeTypeName("LPGUID")] Guid* lpDeinterlaceMode)
        {
            return ((delegate* unmanaged<IVMRDeinterlaceControl*, uint, Guid*, int>)(lpVtbl[5]))((IVMRDeinterlaceControl*)Unsafe.AsPointer(ref this), dwStreamID, lpDeinterlaceMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDeinterlaceMode([NativeTypeName("DWORD")] uint dwStreamID, [NativeTypeName("LPGUID")] Guid* lpDeinterlaceMode)
        {
            return ((delegate* unmanaged<IVMRDeinterlaceControl*, uint, Guid*, int>)(lpVtbl[6]))((IVMRDeinterlaceControl*)Unsafe.AsPointer(ref this), dwStreamID, lpDeinterlaceMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeinterlacePrefs([NativeTypeName("LPDWORD")] uint* lpdwDeinterlacePrefs)
        {
            return ((delegate* unmanaged<IVMRDeinterlaceControl*, uint*, int>)(lpVtbl[7]))((IVMRDeinterlaceControl*)Unsafe.AsPointer(ref this), lpdwDeinterlacePrefs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDeinterlacePrefs([NativeTypeName("DWORD")] uint dwDeinterlacePrefs)
        {
            return ((delegate* unmanaged<IVMRDeinterlaceControl*, uint, int>)(lpVtbl[8]))((IVMRDeinterlaceControl*)Unsafe.AsPointer(ref this), dwDeinterlacePrefs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetActualDeinterlaceMode([NativeTypeName("DWORD")] uint dwStreamID, [NativeTypeName("LPGUID")] Guid* lpDeinterlaceMode)
        {
            return ((delegate* unmanaged<IVMRDeinterlaceControl*, uint, Guid*, int>)(lpVtbl[9]))((IVMRDeinterlaceControl*)Unsafe.AsPointer(ref this), dwStreamID, lpDeinterlaceMode);
        }
    }
}
