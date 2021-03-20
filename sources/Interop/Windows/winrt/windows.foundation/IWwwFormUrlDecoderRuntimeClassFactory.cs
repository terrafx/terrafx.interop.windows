// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5B8C6B3D-24AE-41B5-A1BF-F0C3D544845B")]
    [NativeTypeName("struct IWwwFormUrlDecoderRuntimeClassFactory : IInspectable")]
    public unsafe partial struct IWwwFormUrlDecoderRuntimeClassFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IWwwFormUrlDecoderRuntimeClassFactory*, Guid*, void**, int>)(lpVtbl[0]))((IWwwFormUrlDecoderRuntimeClassFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWwwFormUrlDecoderRuntimeClassFactory*, uint>)(lpVtbl[1]))((IWwwFormUrlDecoderRuntimeClassFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWwwFormUrlDecoderRuntimeClassFactory*, uint>)(lpVtbl[2]))((IWwwFormUrlDecoderRuntimeClassFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IWwwFormUrlDecoderRuntimeClassFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IWwwFormUrlDecoderRuntimeClassFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IWwwFormUrlDecoderRuntimeClassFactory*, IntPtr*, int>)(lpVtbl[4]))((IWwwFormUrlDecoderRuntimeClassFactory*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IWwwFormUrlDecoderRuntimeClassFactory*, TrustLevel*, int>)(lpVtbl[5]))((IWwwFormUrlDecoderRuntimeClassFactory*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateWwwFormUrlDecoder([NativeTypeName("HSTRING")] IntPtr query, [NativeTypeName("ABI::Windows::Foundation::IWwwFormUrlDecoderRuntimeClass **")] IWwwFormUrlDecoderRuntimeClass** instance)
        {
            return ((delegate* unmanaged<IWwwFormUrlDecoderRuntimeClassFactory*, IntPtr, IWwwFormUrlDecoderRuntimeClass**, int>)(lpVtbl[6]))((IWwwFormUrlDecoderRuntimeClassFactory*)Unsafe.AsPointer(ref this), query, instance);
        }
    }
}
