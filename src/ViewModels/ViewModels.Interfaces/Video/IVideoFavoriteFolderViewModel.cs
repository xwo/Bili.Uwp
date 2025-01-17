﻿// Copyright (c) Richasy. All rights reserved.

using System.Reactive;
using Bili.Models.Data.Video;
using ReactiveUI;

namespace Bili.ViewModels.Interfaces.Video
{
    /// <summary>
    /// 收藏夹视图模型的接口定义.
    /// </summary>
    public interface IVideoFavoriteFolderViewModel : IReactiveObject
    {
        /// <summary>
        /// 移除收藏夹命令.
        /// </summary>
        ReactiveCommand<Unit, Unit> RemoveCommand { get; }

        /// <summary>
        /// 显示收藏夹详情命令.
        /// </summary>
        ReactiveCommand<Unit, Unit> ShowDetailCommand { get; }

        /// <summary>
        /// 收藏夹信息.
        /// </summary>
        VideoFavoriteFolder Folder { get; }

        /// <summary>
        /// 是否由自己创建.
        /// </summary>
        bool IsMine { get; }

        /// <summary>
        /// 是否正在移除.
        /// </summary>
        bool IsRemoving { get; }

        /// <summary>
        /// 设置收藏夹信息.
        /// </summary>
        /// <param name="folder">收藏夹.</param>
        /// <param name="groupRef">收藏夹分组视图模型引用.</param>
        void SetFolder(VideoFavoriteFolder folder, IVideoFavoriteFolderGroupViewModel groupRef);
    }
}
