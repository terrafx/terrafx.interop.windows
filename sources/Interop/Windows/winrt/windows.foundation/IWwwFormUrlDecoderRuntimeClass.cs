// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D45A0451-F225-4542-9296-0E1DF5D254DF")]
    [NativeTypeName("struct IWwwFormUrlDecoderRuntimeClass : IInspectable")]
    public unsafe partial struct IWwwFormUrlDecoderRuntimeClass
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IWwwFormUrlDecoderRuntimeClass*, Guid*, void**, int>)(lpVtbl[0]))((IWwwFormUrlDecoderRuntimeClass*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWwwFormUrlDecoderRuntimeClass*, uint>)(lpVtbl[1]))((IWwwFormUrlDecoderRuntimeClass*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWwwFormUrlDecoderRuntimeClass*, uint>)(lpVtbl[2]))((IWwwFormUrlDecoderRuntimeClass*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IWwwFormUrlDecoderRuntimeClass*, uint*, Guid**, int>)(lpVtbl[3]))((IWwwFormUrlDecoderRuntimeClass*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IWwwFormUrlDecoderRuntimeClass*, IntPtr*, int>)(lpVtbl[4]))((IWwwFormUrlDecoderRuntimeClass*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IWwwFormUrlDecoderRuntimeClass*, TrustLevel*, int>)(lpVtbl[5]))((IWwwFormUrlDecoderRuntimeClass*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFirstValueByName([NativeTypeName("HSTRING")] IntPtr name, [NativeTypeName("HSTRING *")] IntPtr* phstrValue)
        {
            return ((delegate* unmanaged<IWwwFormUrlDecoderRuntimeClass*, IntPtr, IntPtr*, int>)(lpVtbl[6]))((IWwwFormUrlDecoderRuntimeClass*)Unsafe.AsPointer(ref this), name, phstrValue);
        }
    }
}
