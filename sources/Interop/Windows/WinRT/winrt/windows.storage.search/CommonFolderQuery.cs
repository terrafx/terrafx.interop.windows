// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CommonFolderQuery.xml' path='doc/member[@name="CommonFolderQuery"]/*' />
public enum CommonFolderQuery
{
    /// <include file='CommonFolderQuery.xml' path='doc/member[@name="CommonFolderQuery.CommonFolderQuery_DefaultQuery"]/*' />
    CommonFolderQuery_DefaultQuery = 0,

    /// <include file='CommonFolderQuery.xml' path='doc/member[@name="CommonFolderQuery.CommonFolderQuery_GroupByYear"]/*' />
    CommonFolderQuery_GroupByYear = 100,

    /// <include file='CommonFolderQuery.xml' path='doc/member[@name="CommonFolderQuery.CommonFolderQuery_GroupByMonth"]/*' />
    CommonFolderQuery_GroupByMonth = 101,

    /// <include file='CommonFolderQuery.xml' path='doc/member[@name="CommonFolderQuery.CommonFolderQuery_GroupByArtist"]/*' />
    CommonFolderQuery_GroupByArtist = 102,

    /// <include file='CommonFolderQuery.xml' path='doc/member[@name="CommonFolderQuery.CommonFolderQuery_GroupByAlbum"]/*' />
    CommonFolderQuery_GroupByAlbum = 103,

    /// <include file='CommonFolderQuery.xml' path='doc/member[@name="CommonFolderQuery.CommonFolderQuery_GroupByAlbumArtist"]/*' />
    CommonFolderQuery_GroupByAlbumArtist = 104,

    /// <include file='CommonFolderQuery.xml' path='doc/member[@name="CommonFolderQuery.CommonFolderQuery_GroupByComposer"]/*' />
    CommonFolderQuery_GroupByComposer = 105,

    /// <include file='CommonFolderQuery.xml' path='doc/member[@name="CommonFolderQuery.CommonFolderQuery_GroupByGenre"]/*' />
    CommonFolderQuery_GroupByGenre = 106,

    /// <include file='CommonFolderQuery.xml' path='doc/member[@name="CommonFolderQuery.CommonFolderQuery_GroupByPublishedYear"]/*' />
    CommonFolderQuery_GroupByPublishedYear = 107,

    /// <include file='CommonFolderQuery.xml' path='doc/member[@name="CommonFolderQuery.CommonFolderQuery_GroupByRating"]/*' />
    CommonFolderQuery_GroupByRating = 108,

    /// <include file='CommonFolderQuery.xml' path='doc/member[@name="CommonFolderQuery.CommonFolderQuery_GroupByTag"]/*' />
    CommonFolderQuery_GroupByTag = 109,

    /// <include file='CommonFolderQuery.xml' path='doc/member[@name="CommonFolderQuery.CommonFolderQuery_GroupByAuthor"]/*' />
    CommonFolderQuery_GroupByAuthor = 110,

    /// <include file='CommonFolderQuery.xml' path='doc/member[@name="CommonFolderQuery.CommonFolderQuery_GroupByType"]/*' />
    CommonFolderQuery_GroupByType = 111,
}
