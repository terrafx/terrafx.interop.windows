// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/Windows.ApplicationModel.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F0E24AB0-DD09-42E1-B0BC-E0E131F78D7E")]
    [NativeTypeName("struct ICoreApplicationUnhandledError : IInspectable")]
    public unsafe partial struct ICoreApplicationUnhandledError
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICoreApplicationUnhandledError*, Guid*, void**, int>)(lpVtbl[0]))((ICoreApplicationUnhandledError*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICoreApplicationUnhandledError*, uint>)(lpVtbl[1]))((ICoreApplicationUnhandledError*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICoreApplicationUnhandledError*, uint>)(lpVtbl[2]))((ICoreApplicationUnhandledError*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICoreApplicationUnhandledError*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreApplicationUnhandledError*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICoreApplicationUnhandledError*, IntPtr*, int>)(lpVtbl[4]))((ICoreApplicationUnhandledError*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICoreApplicationUnhandledError*, TrustLevel*, int>)(lpVtbl[5]))((ICoreApplicationUnhandledError*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_UnhandledErrorDetected([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_Windows__CApplicationModel__CCore__CUnhandledErrorDetectedEventArgs_t *")] IEventHandler<IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<ICoreApplicationUnhandledError*, IEventHandler<IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[6]))((ICoreApplicationUnhandledError*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_UnhandledErrorDetected(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<ICoreApplicationUnhandledError*, EventRegistrationToken, int>)(lpVtbl[7]))((ICoreApplicationUnhandledError*)Unsafe.AsPointer(ref this), token);
        }
    }
}
