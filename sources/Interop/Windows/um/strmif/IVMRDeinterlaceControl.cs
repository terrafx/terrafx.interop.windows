// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BB057577-0DB8-4E6A-87A7-1A8C9A505A0F")]
    [NativeTypeName("struct IVMRDeinterlaceControl : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IVMRDeinterlaceControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IVMRDeinterlaceControl*, Guid*, void**, int>)(lpVtbl[0]))((IVMRDeinterlaceControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVMRDeinterlaceControl*, uint>)(lpVtbl[1]))((IVMRDeinterlaceControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVMRDeinterlaceControl*, uint>)(lpVtbl[2]))((IVMRDeinterlaceControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetNumberOfDeinterlaceModes(VMRVideoDesc* lpVideoDescription, [NativeTypeName("LPDWORD")] uint* lpdwNumDeinterlaceModes, [NativeTypeName("LPGUID")] Guid* lpDeinterlaceModes)
        {
            return ((delegate* unmanaged<IVMRDeinterlaceControl*, VMRVideoDesc*, uint*, Guid*, int>)(lpVtbl[3]))((IVMRDeinterlaceControl*)Unsafe.AsPointer(ref this), lpVideoDescription, lpdwNumDeinterlaceModes, lpDeinterlaceModes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetDeinterlaceModeCaps([NativeTypeName("LPGUID")] Guid* lpDeinterlaceMode, VMRVideoDesc* lpVideoDescription, VMRDeinterlaceCaps* lpDeinterlaceCaps)
        {
            return ((delegate* unmanaged<IVMRDeinterlaceControl*, Guid*, VMRVideoDesc*, VMRDeinterlaceCaps*, int>)(lpVtbl[4]))((IVMRDeinterlaceControl*)Unsafe.AsPointer(ref this), lpDeinterlaceMode, lpVideoDescription, lpDeinterlaceCaps);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetDeinterlaceMode([NativeTypeName("DWORD")] uint dwStreamID, [NativeTypeName("LPGUID")] Guid* lpDeinterlaceMode)
        {
            return ((delegate* unmanaged<IVMRDeinterlaceControl*, uint, Guid*, int>)(lpVtbl[5]))((IVMRDeinterlaceControl*)Unsafe.AsPointer(ref this), dwStreamID, lpDeinterlaceMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetDeinterlaceMode([NativeTypeName("DWORD")] uint dwStreamID, [NativeTypeName("LPGUID")] Guid* lpDeinterlaceMode)
        {
            return ((delegate* unmanaged<IVMRDeinterlaceControl*, uint, Guid*, int>)(lpVtbl[6]))((IVMRDeinterlaceControl*)Unsafe.AsPointer(ref this), dwStreamID, lpDeinterlaceMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetDeinterlacePrefs([NativeTypeName("LPDWORD")] uint* lpdwDeinterlacePrefs)
        {
            return ((delegate* unmanaged<IVMRDeinterlaceControl*, uint*, int>)(lpVtbl[7]))((IVMRDeinterlaceControl*)Unsafe.AsPointer(ref this), lpdwDeinterlacePrefs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetDeinterlacePrefs([NativeTypeName("DWORD")] uint dwDeinterlacePrefs)
        {
            return ((delegate* unmanaged<IVMRDeinterlaceControl*, uint, int>)(lpVtbl[8]))((IVMRDeinterlaceControl*)Unsafe.AsPointer(ref this), dwDeinterlacePrefs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetActualDeinterlaceMode([NativeTypeName("DWORD")] uint dwStreamID, [NativeTypeName("LPGUID")] Guid* lpDeinterlaceMode)
        {
            return ((delegate* unmanaged<IVMRDeinterlaceControl*, uint, Guid*, int>)(lpVtbl[9]))((IVMRDeinterlaceControl*)Unsafe.AsPointer(ref this), dwStreamID, lpDeinterlaceMode);
        }
    }
}
