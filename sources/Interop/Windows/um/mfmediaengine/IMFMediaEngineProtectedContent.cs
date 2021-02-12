// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9F8021E8-9C8C-487E-BB5C-79AA4779938C")]
    [NativeTypeName("struct IMFMediaEngineProtectedContent : IUnknown")]
    public unsafe partial struct IMFMediaEngineProtectedContent
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMediaEngineProtectedContent*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineProtectedContent*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMediaEngineProtectedContent*, uint>)(lpVtbl[1]))((IMFMediaEngineProtectedContent*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMediaEngineProtectedContent*, uint>)(lpVtbl[2]))((IMFMediaEngineProtectedContent*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShareResources([NativeTypeName("IUnknown *")] IUnknown* pUnkDeviceContext)
        {
            return ((delegate* unmanaged<IMFMediaEngineProtectedContent*, IUnknown*, int>)(lpVtbl[3]))((IMFMediaEngineProtectedContent*)Unsafe.AsPointer(ref this), pUnkDeviceContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRequiredProtections([NativeTypeName("DWORD *")] uint* pFrameProtectionFlags)
        {
            return ((delegate* unmanaged<IMFMediaEngineProtectedContent*, uint*, int>)(lpVtbl[4]))((IMFMediaEngineProtectedContent*)Unsafe.AsPointer(ref this), pFrameProtectionFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOPMWindow([NativeTypeName("HWND")] IntPtr hwnd)
        {
            return ((delegate* unmanaged<IMFMediaEngineProtectedContent*, IntPtr, int>)(lpVtbl[5]))((IMFMediaEngineProtectedContent*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TransferVideoFrame([NativeTypeName("IUnknown *")] IUnknown* pDstSurf, [NativeTypeName("const MFVideoNormalizedRect *")] MFVideoNormalizedRect* pSrc, [NativeTypeName("const RECT *")] RECT* pDst, [NativeTypeName("const MFARGB *")] MFARGB* pBorderClr, [NativeTypeName("DWORD *")] uint* pFrameProtectionFlags)
        {
            return ((delegate* unmanaged<IMFMediaEngineProtectedContent*, IUnknown*, MFVideoNormalizedRect*, RECT*, MFARGB*, uint*, int>)(lpVtbl[6]))((IMFMediaEngineProtectedContent*)Unsafe.AsPointer(ref this), pDstSurf, pSrc, pDst, pBorderClr, pFrameProtectionFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetContentProtectionManager([NativeTypeName("IMFContentProtectionManager *")] IMFContentProtectionManager* pCPM)
        {
            return ((delegate* unmanaged<IMFMediaEngineProtectedContent*, IMFContentProtectionManager*, int>)(lpVtbl[7]))((IMFMediaEngineProtectedContent*)Unsafe.AsPointer(ref this), pCPM);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetApplicationCertificate([NativeTypeName("const BYTE *")] byte* pbBlob, [NativeTypeName("DWORD")] uint cbBlob)
        {
            return ((delegate* unmanaged<IMFMediaEngineProtectedContent*, byte*, uint, int>)(lpVtbl[8]))((IMFMediaEngineProtectedContent*)Unsafe.AsPointer(ref this), pbBlob, cbBlob);
        }
    }
}
