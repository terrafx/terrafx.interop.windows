// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6B2CCB44-6F01-560C-97AD-FC7F32EC581F")]
    [NativeTypeName("struct IUserChangedEventArgs2 : IInspectable")]
    public unsafe partial struct IUserChangedEventArgs2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IUserChangedEventArgs2*, Guid*, void**, int>)(lpVtbl[0]))((IUserChangedEventArgs2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUserChangedEventArgs2*, uint>)(lpVtbl[1]))((IUserChangedEventArgs2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUserChangedEventArgs2*, uint>)(lpVtbl[2]))((IUserChangedEventArgs2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IUserChangedEventArgs2*, uint*, Guid**, int>)(lpVtbl[3]))((IUserChangedEventArgs2*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IUserChangedEventArgs2*, IntPtr*, int>)(lpVtbl[4]))((IUserChangedEventArgs2*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IUserChangedEventArgs2*, TrustLevel*, int>)(lpVtbl[5]))((IUserChangedEventArgs2*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ChangedPropertyKinds([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSystem__CUserWatcherUpdateKind_t **")] IVectorView<UserWatcherUpdateKind>** value)
        {
            return ((delegate* unmanaged<IUserChangedEventArgs2*, IVectorView<UserWatcherUpdateKind>**, int>)(lpVtbl[6]))((IUserChangedEventArgs2*)Unsafe.AsPointer(ref this), value);
        }
    }
}
