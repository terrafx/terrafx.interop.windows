// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D646097F-6EF7-5746-8BA8-8FF2206E6F3B")]
    [NativeTypeName("struct IGestureRecognizer2 : IInspectable")]
    public unsafe partial struct IGestureRecognizer2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IGestureRecognizer2*, Guid*, void**, int>)(lpVtbl[0]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGestureRecognizer2*, uint>)(lpVtbl[1]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGestureRecognizer2*, uint>)(lpVtbl[2]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IGestureRecognizer2*, uint*, Guid**, int>)(lpVtbl[3]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IGestureRecognizer2*, IntPtr*, int>)(lpVtbl[4]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IGestureRecognizer2*, TrustLevel*, int>)(lpVtbl[5]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_TapMinContactCount([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IGestureRecognizer2*, uint*, int>)(lpVtbl[6]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_TapMinContactCount([NativeTypeName("UINT32")] uint value)
        {
            return ((delegate* unmanaged<IGestureRecognizer2*, uint, int>)(lpVtbl[7]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_TapMaxContactCount([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IGestureRecognizer2*, uint*, int>)(lpVtbl[8]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_TapMaxContactCount([NativeTypeName("UINT32")] uint value)
        {
            return ((delegate* unmanaged<IGestureRecognizer2*, uint, int>)(lpVtbl[9]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_HoldMinContactCount([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IGestureRecognizer2*, uint*, int>)(lpVtbl[10]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_HoldMinContactCount([NativeTypeName("UINT32")] uint value)
        {
            return ((delegate* unmanaged<IGestureRecognizer2*, uint, int>)(lpVtbl[11]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_HoldMaxContactCount([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IGestureRecognizer2*, uint*, int>)(lpVtbl[12]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_HoldMaxContactCount([NativeTypeName("UINT32")] uint value)
        {
            return ((delegate* unmanaged<IGestureRecognizer2*, uint, int>)(lpVtbl[13]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_HoldRadius([NativeTypeName("FLOAT *")] float* value)
        {
            return ((delegate* unmanaged<IGestureRecognizer2*, float*, int>)(lpVtbl[14]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_HoldRadius([NativeTypeName("FLOAT")] float value)
        {
            return ((delegate* unmanaged<IGestureRecognizer2*, float, int>)(lpVtbl[15]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_HoldStartDelay([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
        {
            return ((delegate* unmanaged<IGestureRecognizer2*, TimeSpan*, int>)(lpVtbl[16]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_HoldStartDelay([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
        {
            return ((delegate* unmanaged<IGestureRecognizer2*, TimeSpan, int>)(lpVtbl[17]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_TranslationMinContactCount([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IGestureRecognizer2*, uint*, int>)(lpVtbl[18]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_TranslationMinContactCount([NativeTypeName("UINT32")] uint value)
        {
            return ((delegate* unmanaged<IGestureRecognizer2*, uint, int>)(lpVtbl[19]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_TranslationMaxContactCount([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IGestureRecognizer2*, uint*, int>)(lpVtbl[20]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_TranslationMaxContactCount([NativeTypeName("UINT32")] uint value)
        {
            return ((delegate* unmanaged<IGestureRecognizer2*, uint, int>)(lpVtbl[21]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), value);
        }
    }
}
