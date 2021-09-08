// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("71C6E74C-0F28-11D8-A82A-00065B84435C")]
    [NativeTypeName("struct ITfInputProcessorProfileMgr : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfInputProcessorProfileMgr
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfileMgr*, Guid*, void**, int>)(lpVtbl[0]))((ITfInputProcessorProfileMgr*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfInputProcessorProfileMgr*, uint>)(lpVtbl[1]))((ITfInputProcessorProfileMgr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfInputProcessorProfileMgr*, uint>)(lpVtbl[2]))((ITfInputProcessorProfileMgr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int ActivateProfile([NativeTypeName("DWORD")] uint dwProfileType, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("const GUID &")] Guid* guidProfile, [NativeTypeName("HKL")] IntPtr hkl, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfileMgr*, uint, ushort, Guid*, Guid*, IntPtr, uint, int>)(lpVtbl[3]))((ITfInputProcessorProfileMgr*)Unsafe.AsPointer(ref this), dwProfileType, langid, clsid, guidProfile, hkl, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int DeactivateProfile([NativeTypeName("DWORD")] uint dwProfileType, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("const GUID &")] Guid* guidProfile, [NativeTypeName("HKL")] IntPtr hkl, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfileMgr*, uint, ushort, Guid*, Guid*, IntPtr, uint, int>)(lpVtbl[4]))((ITfInputProcessorProfileMgr*)Unsafe.AsPointer(ref this), dwProfileType, langid, clsid, guidProfile, hkl, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetProfile([NativeTypeName("DWORD")] uint dwProfileType, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("const GUID &")] Guid* guidProfile, [NativeTypeName("HKL")] IntPtr hkl, TF_INPUTPROCESSORPROFILE* pProfile)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfileMgr*, uint, ushort, Guid*, Guid*, IntPtr, TF_INPUTPROCESSORPROFILE*, int>)(lpVtbl[5]))((ITfInputProcessorProfileMgr*)Unsafe.AsPointer(ref this), dwProfileType, langid, clsid, guidProfile, hkl, pProfile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int EnumProfiles([NativeTypeName("LANGID")] ushort langid, IEnumTfInputProcessorProfiles** ppEnum)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfileMgr*, ushort, IEnumTfInputProcessorProfiles**, int>)(lpVtbl[6]))((ITfInputProcessorProfileMgr*)Unsafe.AsPointer(ref this), langid, ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int ReleaseInputProcessor([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfileMgr*, Guid*, uint, int>)(lpVtbl[7]))((ITfInputProcessorProfileMgr*)Unsafe.AsPointer(ref this), rclsid, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterProfile([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile, [NativeTypeName("const WCHAR *")] ushort* pchDesc, [NativeTypeName("ULONG")] uint cchDesc, [NativeTypeName("const WCHAR *")] ushort* pchIconFile, [NativeTypeName("ULONG")] uint cchFile, [NativeTypeName("ULONG")] uint uIconIndex, [NativeTypeName("HKL")] IntPtr hklsubstitute, [NativeTypeName("DWORD")] uint dwPreferredLayout, [NativeTypeName("BOOL")] int bEnabledByDefault, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfileMgr*, Guid*, ushort, Guid*, ushort*, uint, ushort*, uint, uint, IntPtr, uint, int, uint, int>)(lpVtbl[8]))((ITfInputProcessorProfileMgr*)Unsafe.AsPointer(ref this), rclsid, langid, guidProfile, pchDesc, cchDesc, pchIconFile, cchFile, uIconIndex, hklsubstitute, dwPreferredLayout, bEnabledByDefault, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterProfile([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfileMgr*, Guid*, ushort, Guid*, uint, int>)(lpVtbl[9]))((ITfInputProcessorProfileMgr*)Unsafe.AsPointer(ref this), rclsid, langid, guidProfile, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int GetActiveProfile([NativeTypeName("const GUID &")] Guid* catid, TF_INPUTPROCESSORPROFILE* pProfile)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfileMgr*, Guid*, TF_INPUTPROCESSORPROFILE*, int>)(lpVtbl[10]))((ITfInputProcessorProfileMgr*)Unsafe.AsPointer(ref this), catid, pProfile);
        }
    }
}
