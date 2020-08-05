// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.media.core.interop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7BD67CF8-BF7D-43E6-AF8D-B170EE0C0110")]
    [NativeTypeName("struct IAudioFrameNativeFactory : IInspectable")]
    public unsafe partial struct IAudioFrameNativeFactory
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAudioFrameNativeFactory*, Guid*, void**, int>)(lpVtbl[0]))((IAudioFrameNativeFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAudioFrameNativeFactory*, uint>)(lpVtbl[1]))((IAudioFrameNativeFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAudioFrameNativeFactory*, uint>)(lpVtbl[2]))((IAudioFrameNativeFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* stdcall<IAudioFrameNativeFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioFrameNativeFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* stdcall<IAudioFrameNativeFactory*, IntPtr*, int>)(lpVtbl[4]))((IAudioFrameNativeFactory*)Unsafe.AsPointer(ref this), className);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* stdcall<IAudioFrameNativeFactory*, TrustLevel*, int>)(lpVtbl[5]))((IAudioFrameNativeFactory*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFromMFSample([NativeTypeName("IMFSample *")] IMFSample* data, [NativeTypeName("BOOL")] int forceReadOnly, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv)
        {
            return ((delegate* stdcall<IAudioFrameNativeFactory*, IMFSample*, int, Guid*, void**, int>)(lpVtbl[6]))((IAudioFrameNativeFactory*)Unsafe.AsPointer(ref this), data, forceReadOnly, riid, ppv);
        }
    }
}
