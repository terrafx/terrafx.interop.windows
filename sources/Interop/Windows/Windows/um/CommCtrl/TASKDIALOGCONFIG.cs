// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct TASKDIALOGCONFIG
{
    public uint cbSize;

    public HWND hwndParent;

    public HINSTANCE hInstance;

    [NativeTypeName("TASKDIALOG_FLAGS")]
    public int dwFlags;

    [NativeTypeName("TASKDIALOG_COMMON_BUTTON_FLAGS")]
    public int dwCommonButtons;

    [NativeTypeName("PCWSTR")]
    public ushort* pszWindowTitle;

    [NativeTypeName("_TASKDIALOGCONFIG::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/CommCtrl.h:7735:5)")]
    public _Anonymous1_e__Union Anonymous1;

    [NativeTypeName("PCWSTR")]
    public ushort* pszMainInstruction;

    [NativeTypeName("PCWSTR")]
    public ushort* pszContent;

    public uint cButtons;

    [NativeTypeName("const TASKDIALOG_BUTTON *")]
    public TASKDIALOG_BUTTON* pButtons;

    public int nDefaultButton;

    public uint cRadioButtons;

    [NativeTypeName("const TASKDIALOG_BUTTON *")]
    public TASKDIALOG_BUTTON* pRadioButtons;

    public int nDefaultRadioButton;

    [NativeTypeName("PCWSTR")]
    public ushort* pszVerificationText;

    [NativeTypeName("PCWSTR")]
    public ushort* pszExpandedInformation;

    [NativeTypeName("PCWSTR")]
    public ushort* pszExpandedControlText;

    [NativeTypeName("PCWSTR")]
    public ushort* pszCollapsedControlText;

    [NativeTypeName("_TASKDIALOGCONFIG::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/CommCtrl.h:7752:5)")]
    public _Anonymous2_e__Union Anonymous2;

    [NativeTypeName("PCWSTR")]
    public ushort* pszFooter;

    [NativeTypeName("PFTASKDIALOGCALLBACK")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint, HRESULT> pfCallback;

    [NativeTypeName("LONG_PTR")]
    public nint lpCallbackData;

    public uint cxWidth;

    public ref HICON hMainIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous1.hMainIcon;
        }
    }

    public ref ushort* pszMainIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous1.pszMainIcon;
        }
    }

    public ref HICON hFooterIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous2.hFooterIcon;
        }
    }

    public ref ushort* pszFooterIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous2.pszFooterIcon;
        }
    }

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public unsafe partial struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        public HICON hMainIcon;

        [FieldOffset(0)]
        [NativeTypeName("PCWSTR")]
        public ushort* pszMainIcon;
    }

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public unsafe partial struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        public HICON hFooterIcon;

        [FieldOffset(0)]
        [NativeTypeName("PCWSTR")]
        public ushort* pszFooterIcon;
    }
}
