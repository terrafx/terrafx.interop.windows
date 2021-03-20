// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BC6A8519-18EE-4043-9839-4FC584D60A14")]
    [NativeTypeName("struct IEdgeGestureStatics : IInspectable")]
    public unsafe partial struct IEdgeGestureStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IEdgeGestureStatics*, Guid*, void**, int>)(lpVtbl[0]))((IEdgeGestureStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEdgeGestureStatics*, uint>)(lpVtbl[1]))((IEdgeGestureStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEdgeGestureStatics*, uint>)(lpVtbl[2]))((IEdgeGestureStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IEdgeGestureStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IEdgeGestureStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IEdgeGestureStatics*, IntPtr*, int>)(lpVtbl[4]))((IEdgeGestureStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IEdgeGestureStatics*, TrustLevel*, int>)(lpVtbl[5]))((IEdgeGestureStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetForCurrentView([NativeTypeName("ABI::Windows::UI::Input::IEdgeGesture **")] IEdgeGesture** current)
        {
            return ((delegate* unmanaged<IEdgeGestureStatics*, IEdgeGesture**, int>)(lpVtbl[6]))((IEdgeGestureStatics*)Unsafe.AsPointer(ref this), current);
        }
    }
}
