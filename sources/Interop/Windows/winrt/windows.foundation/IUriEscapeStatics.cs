// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C1D432BA-C824-4452-A7FD-512BC3BBE9A1")]
    [NativeTypeName("struct IUriEscapeStatics : IInspectable")]
    public unsafe partial struct IUriEscapeStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IUriEscapeStatics*, Guid*, void**, int>)(lpVtbl[0]))((IUriEscapeStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUriEscapeStatics*, uint>)(lpVtbl[1]))((IUriEscapeStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUriEscapeStatics*, uint>)(lpVtbl[2]))((IUriEscapeStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IUriEscapeStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IUriEscapeStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IUriEscapeStatics*, IntPtr*, int>)(lpVtbl[4]))((IUriEscapeStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IUriEscapeStatics*, TrustLevel*, int>)(lpVtbl[5]))((IUriEscapeStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnescapeComponent([NativeTypeName("HSTRING")] IntPtr toUnescape, [NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUriEscapeStatics*, IntPtr, IntPtr*, int>)(lpVtbl[6]))((IUriEscapeStatics*)Unsafe.AsPointer(ref this), toUnescape, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EscapeComponent([NativeTypeName("HSTRING")] IntPtr toEscape, [NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUriEscapeStatics*, IntPtr, IntPtr*, int>)(lpVtbl[7]))((IUriEscapeStatics*)Unsafe.AsPointer(ref this), toEscape, value);
        }
    }
}
