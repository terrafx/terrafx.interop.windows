// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("125E7431-F678-4E8E-B670-20A9B06C512D")]
    [NativeTypeName("struct IWwwFormUrlDecoderEntry : IInspectable")]
    public unsafe partial struct IWwwFormUrlDecoderEntry
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IWwwFormUrlDecoderEntry*, Guid*, void**, int>)(lpVtbl[0]))((IWwwFormUrlDecoderEntry*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWwwFormUrlDecoderEntry*, uint>)(lpVtbl[1]))((IWwwFormUrlDecoderEntry*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWwwFormUrlDecoderEntry*, uint>)(lpVtbl[2]))((IWwwFormUrlDecoderEntry*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IWwwFormUrlDecoderEntry*, uint*, Guid**, int>)(lpVtbl[3]))((IWwwFormUrlDecoderEntry*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IWwwFormUrlDecoderEntry*, IntPtr*, int>)(lpVtbl[4]))((IWwwFormUrlDecoderEntry*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IWwwFormUrlDecoderEntry*, TrustLevel*, int>)(lpVtbl[5]))((IWwwFormUrlDecoderEntry*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Name([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IWwwFormUrlDecoderEntry*, IntPtr*, int>)(lpVtbl[6]))((IWwwFormUrlDecoderEntry*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Value([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IWwwFormUrlDecoderEntry*, IntPtr*, int>)(lpVtbl[7]))((IWwwFormUrlDecoderEntry*)Unsafe.AsPointer(ref this), value);
        }
    }
}
