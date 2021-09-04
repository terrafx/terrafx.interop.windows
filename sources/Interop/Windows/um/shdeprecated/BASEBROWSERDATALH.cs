// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct BASEBROWSERDATALH
    {
        [NativeTypeName("HWND")]
        public IntPtr _hwnd;

        public ITravelLog* _ptl;

        public IHlinkFrame* _phlf;

        public IWebBrowser2* _pautoWB2;

        public IExpDispSupport* _pautoEDS;

        public IShellService* _pautoSS;

        public int _eSecureLockIcon;

        public uint _bitfield;

        [NativeTypeName("UINT : 1")]
        public uint _fCreatingViewWindow
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return _bitfield & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
            }
        }

        [NativeTypeName("UINT")]
        public uint _uActivateState;

        [NativeTypeName("LPCITEMIDLIST")]
        public ITEMIDLIST* _pidlViewState;

        public IOleCommandTarget* _pctView;

        [NativeTypeName("LPITEMIDLIST")]
        public ITEMIDLIST* _pidlCur;

        public IShellView* _psv;

        public IShellFolder* _psf;

        [NativeTypeName("HWND")]
        public IntPtr _hwndView;

        [NativeTypeName("LPWSTR")]
        public ushort* _pszTitleCur;

        [NativeTypeName("LPITEMIDLIST")]
        public ITEMIDLIST* _pidlPending;

        public IShellView* _psvPending;

        public IShellFolder* _psfPending;

        [NativeTypeName("HWND")]
        public IntPtr _hwndViewPending;

        [NativeTypeName("LPWSTR")]
        public ushort* _pszTitlePending;

        [NativeTypeName("BOOL")]
        public int _fIsViewMSHTML;

        [NativeTypeName("BOOL")]
        public int _fPrivacyImpacted;

        [NativeTypeName("CLSID")]
        public Guid _clsidView;

        [NativeTypeName("CLSID")]
        public Guid _clsidViewPending;

        [NativeTypeName("HWND")]
        public IntPtr _hwndFrame;

        [NativeTypeName("LONG")]
        public int _lPhishingFilterStatus;
    }
}
