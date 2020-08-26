// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.media.core.interop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("69E3693E-8E1E-4E63-AC4C-7FDC21D9731D")]
    [NativeTypeName("struct IVideoFrameNativeFactory : IInspectable")]
    public unsafe partial struct IVideoFrameNativeFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IVideoFrameNativeFactory*, Guid*, void**, int>)(lpVtbl[0]))((IVideoFrameNativeFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IVideoFrameNativeFactory*, uint>)(lpVtbl[1]))((IVideoFrameNativeFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IVideoFrameNativeFactory*, uint>)(lpVtbl[2]))((IVideoFrameNativeFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* stdcall<IVideoFrameNativeFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IVideoFrameNativeFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* stdcall<IVideoFrameNativeFactory*, IntPtr*, int>)(lpVtbl[4]))((IVideoFrameNativeFactory*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* stdcall<IVideoFrameNativeFactory*, TrustLevel*, int>)(lpVtbl[5]))((IVideoFrameNativeFactory*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFromMFSample([NativeTypeName("IMFSample *")] IMFSample* data, [NativeTypeName("const GUID &")] Guid* subtype, [NativeTypeName("UINT32")] uint width, [NativeTypeName("UINT32")] uint height, [NativeTypeName("BOOL")] int forceReadOnly, [NativeTypeName("const MFVideoArea *")] MFVideoArea* minDisplayAperture, [NativeTypeName("IMFDXGIDeviceManager *")] IMFDXGIDeviceManager* device, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv)
        {
            return ((delegate* stdcall<IVideoFrameNativeFactory*, IMFSample*, Guid*, uint, uint, int, MFVideoArea*, IMFDXGIDeviceManager*, Guid*, void**, int>)(lpVtbl[6]))((IVideoFrameNativeFactory*)Unsafe.AsPointer(ref this), data, subtype, width, height, forceReadOnly, minDisplayAperture, device, riid, ppv);
        }
    }
}
