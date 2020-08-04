// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.media.core.interop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("20BE1E2E-930F-4746-9335-3C332F255093")]
    public unsafe partial struct IAudioFrameNative
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAudioFrameNative*, Guid*, void**, int>)(lpVtbl[0]))((IAudioFrameNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAudioFrameNative*, uint>)(lpVtbl[1]))((IAudioFrameNative*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAudioFrameNative*, uint>)(lpVtbl[2]))((IAudioFrameNative*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* stdcall<IAudioFrameNative*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioFrameNative*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* stdcall<IAudioFrameNative*, IntPtr*, int>)(lpVtbl[4]))((IAudioFrameNative*)Unsafe.AsPointer(ref this), className);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* stdcall<IAudioFrameNative*, TrustLevel*, int>)(lpVtbl[5]))((IAudioFrameNative*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetData([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv)
        {
            return ((delegate* stdcall<IAudioFrameNative*, Guid*, void**, int>)(lpVtbl[6]))((IAudioFrameNative*)Unsafe.AsPointer(ref this), riid, ppv);
        }
    }
}
