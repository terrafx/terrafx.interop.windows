// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1B25DA6E-8AA6-41E9-8251-4165F5985F49")]
    [NativeTypeName("struct ILauncherUIOptions : IInspectable")]
    public unsafe partial struct ILauncherUIOptions
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ILauncherUIOptions*, Guid*, void**, int>)(lpVtbl[0]))((ILauncherUIOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ILauncherUIOptions*, uint>)(lpVtbl[1]))((ILauncherUIOptions*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ILauncherUIOptions*, uint>)(lpVtbl[2]))((ILauncherUIOptions*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ILauncherUIOptions*, uint*, Guid**, int>)(lpVtbl[3]))((ILauncherUIOptions*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ILauncherUIOptions*, IntPtr*, int>)(lpVtbl[4]))((ILauncherUIOptions*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ILauncherUIOptions*, TrustLevel*, int>)(lpVtbl[5]))((ILauncherUIOptions*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_InvocationPoint([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CPoint_t **")] IReference<Point>** value)
        {
            return ((delegate* unmanaged<ILauncherUIOptions*, IReference<Point>**, int>)(lpVtbl[6]))((ILauncherUIOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_InvocationPoint([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CPoint_t *")] IReference<Point>* value)
        {
            return ((delegate* unmanaged<ILauncherUIOptions*, IReference<Point>*, int>)(lpVtbl[7]))((ILauncherUIOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SelectionRect([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CRect_t **")] IReference<Rect>** value)
        {
            return ((delegate* unmanaged<ILauncherUIOptions*, IReference<Rect>**, int>)(lpVtbl[8]))((ILauncherUIOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_SelectionRect([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CRect_t *")] IReference<Rect>* value)
        {
            return ((delegate* unmanaged<ILauncherUIOptions*, IReference<Rect>*, int>)(lpVtbl[9]))((ILauncherUIOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PreferredPlacement([NativeTypeName("ABI::Windows::UI::Popups::Placement *")] Placement* value)
        {
            return ((delegate* unmanaged<ILauncherUIOptions*, Placement*, int>)(lpVtbl[10]))((ILauncherUIOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_PreferredPlacement([NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement value)
        {
            return ((delegate* unmanaged<ILauncherUIOptions*, Placement, int>)(lpVtbl[11]))((ILauncherUIOptions*)Unsafe.AsPointer(ref this), value);
        }
    }
}
