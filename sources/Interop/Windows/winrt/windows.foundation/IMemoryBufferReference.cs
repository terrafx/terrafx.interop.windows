// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FBC4DD29-245B-11E4-AF98-689423260CF8")]
    [NativeTypeName("struct IMemoryBufferReference : IInspectable")]
    public unsafe partial struct IMemoryBufferReference
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMemoryBufferReference*, Guid*, void**, int>)(lpVtbl[0]))((IMemoryBufferReference*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMemoryBufferReference*, uint>)(lpVtbl[1]))((IMemoryBufferReference*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMemoryBufferReference*, uint>)(lpVtbl[2]))((IMemoryBufferReference*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IMemoryBufferReference*, uint*, Guid**, int>)(lpVtbl[3]))((IMemoryBufferReference*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IMemoryBufferReference*, IntPtr*, int>)(lpVtbl[4]))((IMemoryBufferReference*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IMemoryBufferReference*, TrustLevel*, int>)(lpVtbl[5]))((IMemoryBufferReference*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Capacity([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IMemoryBufferReference*, uint*, int>)(lpVtbl[6]))((IMemoryBufferReference*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_Closed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CFoundation__CIMemoryBufferReference_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* cookie)
        {
            return ((delegate* unmanaged<IMemoryBufferReference*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[7]))((IMemoryBufferReference*)Unsafe.AsPointer(ref this), handler, cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_Closed(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<IMemoryBufferReference*, EventRegistrationToken, int>)(lpVtbl[8]))((IMemoryBufferReference*)Unsafe.AsPointer(ref this), cookie);
        }
    }
}
