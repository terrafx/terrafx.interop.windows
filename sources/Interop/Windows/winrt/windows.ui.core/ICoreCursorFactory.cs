// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F6359621-A79D-4ED3-8C32-A9EF9D6B76A4")]
    [NativeTypeName("struct ICoreCursorFactory : IInspectable")]
    public unsafe partial struct ICoreCursorFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICoreCursorFactory*, Guid*, void**, int>)(lpVtbl[0]))((ICoreCursorFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICoreCursorFactory*, uint>)(lpVtbl[1]))((ICoreCursorFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICoreCursorFactory*, uint>)(lpVtbl[2]))((ICoreCursorFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICoreCursorFactory*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreCursorFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICoreCursorFactory*, IntPtr*, int>)(lpVtbl[4]))((ICoreCursorFactory*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICoreCursorFactory*, TrustLevel*, int>)(lpVtbl[5]))((ICoreCursorFactory*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCursor([NativeTypeName("ABI::Windows::UI::Core::CoreCursorType")] CoreCursorType type, [NativeTypeName("UINT32")] uint id, [NativeTypeName("ABI::Windows::UI::Core::ICoreCursor **")] ICoreCursor** cursor)
        {
            return ((delegate* unmanaged<ICoreCursorFactory*, CoreCursorType, uint, ICoreCursor**, int>)(lpVtbl[6]))((ICoreCursorFactory*)Unsafe.AsPointer(ref this), type, id, cursor);
        }
    }
}
